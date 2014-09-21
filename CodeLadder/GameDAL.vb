Imports System.Xml
Imports System.Reflection


''' <summary>
''' A data access layer for the game puzzles and expected results
''' </summary>
Friend Class GameDAL
    Private _Doc As XmlDocument
    Private _Location As Integer
    Private _Puzzle As XmlNode
    Private _Code As XmlNode
    Private _Results As XmlNode
    Private _Expected As Collection
    Private _EntryPoint As String


#Region "Constructors"

    ''' <summary>
    ''' Load the Game file of the provided language
    ''' </summary>
    Friend Sub New(ByVal InitialLanguage As PreferencesDialog.LANG, ByVal InitialLevel As PreferencesDialog.LEVEL)
        _Doc = New XmlDocument
        If InitialLanguage = PreferencesDialog.LANG.VISUAL_BASIC Then
            Select Case InitialLevel
                Case PreferencesDialog.LEVEL.LEVEL_1
                    _Doc.LoadXml(My.Resources.Week1VisualBasic)
                Case PreferencesDialog.LEVEL.LEVEL_2
                    _Doc.LoadXml(My.Resources.Week2VisualBasic)
                Case PreferencesDialog.LEVEL.LEVEL_3
                    _Doc.LoadXml(My.Resources.Week3VisualBasic)
                Case PreferencesDialog.LEVEL.LEVEL_4
                    _Doc.LoadXml(My.Resources.Week4VisualBasic)
                Case PreferencesDialog.LEVEL.LEVEL_5
                    _Doc.LoadXml(My.Resources.Week5VisualBasic)
                Case Else
                    _Doc.LoadXml(My.Resources.Week1VisualBasic)
            End Select

        Else
            _Doc.LoadXml(My.Resources.CSharp)
        End If
    End Sub

#End Region

#Region "Utility Functions"

    ''' <summary>
    ''' Fills the Expected property (a Results object) with the expected results for the current puzzle
    ''' </summary>
    Private Sub SetExpected()
        Dim e As IEnumerator
        Dim c As New Collection
        Dim r As Results

        e = _Results.ChildNodes.GetEnumerator
        While e.MoveNext()
            If IsNodeName("expected", e) Then
                Dim i As Integer
                i = e.Current.ChildNodes.Count
                If i > 0 Then
                    ' Get Strongly typed parameters
                    Dim f As IEnumerator = e.Current.ChildNodes.GetEnumerator
                    r = New Results(i)
                    i = 0
                    While f.MoveNext
                        TryConvert(f.Current.Attributes.GetNamedItem("value").Value, _
                                   f.Current.Attributes.GetNamedItem("type").Value, r.Parameters(i))
                        i += 1
                    End While

                Else
                    r = New Results
                    If e.Current.Attributes.GetNamedItem("parameters") IsNot Nothing Then
                        r.Parameters = e.Current.Attributes.GetNamedItem("parameters").Value.ToString.Split(",")
                    End If
                End If

                r.Value = e.Current.Attributes.GetNamedItem("value").Value

                If e.Current.Attributes.GetNamedItem("property") IsNot Nothing Then
                    r.ObjectProperty = e.Current.Attributes.GetNamedItem("property").Value
                End If

                c.Add(r)
                r = Nothing
            End If
        End While
        _Expected = c
    End Sub

    Private Function TryConvert(ByVal Value As String, ByVal Type As String, ByRef ObjectReference As Object) As Boolean
        Dim retVal As Boolean = True

        Select Case Type
            Case "Boolean"
                ObjectReference = Convert.ToBoolean(Value)
            Case "Byte"
                ObjectReference = Convert.ToByte(Value)
            Case "Char"
                ObjectReference = Convert.ToChar(Value)
            Case "Date", "DateTime"
                ObjectReference = Convert.ToDateTime(Value)
            Case "Decimal"
                ObjectReference = Convert.ToDecimal(Value)
            Case "Double"
                ObjectReference = Convert.ToDouble(Value)
            Case "Integer"
                ObjectReference = Convert.ToInt32(Value)
            Case "Long"
                ObjectReference = Convert.ToInt64(Value)
            Case "Object"
                ' Do nothing
            Case "Short"
                ObjectReference = Convert.ToInt16(Value)
            Case "Single"
                ObjectReference = Convert.ToSingle(Value)
            Case "String"
                ObjectReference = Convert.ToString(Value)
            Case Else
                MessageBox.Show("No handler for parameter type " & Type)
                retVal = False
        End Select
        Return retVal
    End Function

    ''' <summary>
    ''' Used to initialize a new game.
    ''' Reads in default or saved data from the "game" element
    ''' </summary>
    Public Sub LoadGame(Optional ByVal WhichPuzzle As Integer = 0)
        If WhichPuzzle > 0 Then
            _Puzzle = _Doc.SelectSingleNode("/GameML/puzzle[position()=" _
                                                  & WhichPuzzle.ToString & "]")
            If Not _Puzzle Is Nothing Then
                _Location = Val(WhichPuzzle)
                Me.NextPuzzle()
            End If
        Else
            LoadNewGame()
        End If
        If _Puzzle Is Nothing Then
            MsgBox("Problem starting game", vbOKOnly + vbCritical)
        End If
    End Sub

    ''' <summary>
    ''' Start a new game at the id identified by the game/start tag or go to the first puzzle.
    ''' </summary>
    Private Sub LoadNewGame()
        Dim e As IEnumerator

        e = _Doc.FirstChild.ChildNodes.Item(0).GetEnumerator
        While e.MoveNext()
            If IsNodeName("start", e) Then
                _Location = Val(e.Current.InnerText)
                _Puzzle = _Doc.SelectSingleNode("/GameML/puzzle[position()=" _
                                                  & e.Current.InnerText & "]")
            End If
        End While
        If _Puzzle Is Nothing Then
            If Not Me.FirstPuzzle() Then
                MessageBox.Show("Error starting game!")
            End If
        Else
            Me.CollectResults()
        End If
    End Sub

    ''' <summary>
    ''' Process the expected values in the current puzzle XML
    ''' </summary>
    Private Sub CollectResults()
        Dim e As IEnumerator
        e = _Puzzle.ChildNodes.GetEnumerator
        While e.MoveNext()
            If IsNodeName("results", e) Then
                _Results = e.Current
            End If
        End While
        Me.SetExpected()
    End Sub

    ''' <summary>
    ''' Jump to the first puzzle
    ''' </summary>
    ''' <returns>True is we found the first puzzle</returns>
    Public Function FirstPuzzle() As Boolean
        _Puzzle = _Doc.SelectSingleNode("(//puzzle)[1]")
        If _Puzzle IsNot Nothing Then
            _Location = 1
            Me.CollectResults()
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Jump to the last puzzle
    ''' </summary>
    ''' <returns>True is we found the last puzzle</returns>
    Public Function LastPuzzle() As Boolean
        _Puzzle = _Doc.SelectSingleNode("//puzzle[last()]")
        If _Puzzle IsNot Nothing Then
            _Location = Me.Count
            Me.CollectResults()
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Jump to the next puzzle, skiping over any puzzle siblings not of type puzzle (i.e. comments)
    ''' </summary>
    ''' <returns>True is we found a next puzzle</returns>
    Public Function NextPuzzle() As Boolean
        Dim id As Integer = Location
        Dim pTmp As System.Xml.XmlNode

        If _Puzzle Is Nothing Then
            Return False
        End If
        pTmp = _Puzzle
        Do
            If Not pTmp.NextSibling Is Nothing Then
                pTmp = pTmp.NextSibling
            End If
        Loop Until pTmp.Name = "puzzle" Or pTmp.NextSibling Is Nothing

        If pTmp.Name = "puzzle" AndAlso Not pTmp.Equals(_Puzzle) Then
            _Puzzle = pTmp
            _Location += 1
            Me.CollectResults()
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Jump to the previous puzzle, skiping over any puzzle siblings not of type puzzle (i.e. comments)
    ''' </summary>
    ''' <returns>True is we found a previous puzzle</returns>
    Public Function PreviousPuzzle() As Boolean
        Dim id As Integer = Location
        Dim pTmp As System.Xml.XmlNode

        If _Puzzle Is Nothing Then
            Return False
        End If
        pTmp = _Puzzle
        Do
            If Not pTmp.PreviousSibling Is Nothing Then
                pTmp = pTmp.PreviousSibling
            End If
        Loop Until pTmp.Name = "puzzle" Or pTmp.PreviousSibling Is Nothing

        If pTmp.Name = "puzzle" AndAlso Not pTmp.Equals(_Puzzle) Then
            _Puzzle = pTmp
            _Location -= 1
            Me.CollectResults()
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Checks if the current node name matches a string
    ''' </summary>
    ''' <param name="Name">The XMLNode name of interest</param>
    ''' <param name="e">The XMLNode enumerator</param>
    ''' <returns>True if the name matches the name of the current enumerator location</returns>
    ''' <remarks>Used when walking along DOM snippets so that we operate only on nodes of interest</remarks>
    Private Function IsNodeName(ByVal Name As String, ByVal e As IEnumerator) As Boolean
        Return (Name = e.Current.Name)
    End Function

    ''' <summary>
    ''' Counts the number of puzzles in the game XML document
    ''' </summary>
    ''' <returns>The number of 'puzzle' elements found</returns>
    Function Count() As Integer
        Dim e As IEnumerator
        Dim i As Integer = 0

        e = _Doc.DocumentElement.GetEnumerator
        While e.MoveNext()
            If IsNodeName("puzzle", e) Then
                i += 1
            End If
        End While
        Return i
    End Function
#End Region

#Region "Class Proprties"


    Public ReadOnly Property Location() As Integer
        Get
            Return _Location
        End Get
    End Property

    ''' <summary>
    ''' Create a string describing the current puzzle
    ''' </summary>
    Public ReadOnly Property PuzzleDescription() As String
        Get
            Dim e As IEnumerator
            Dim desc As String = String.Empty

            e = _Puzzle.ChildNodes.GetEnumerator
            While e.MoveNext()
                If IsNodeName("description", e) Then
                    desc &= e.Current.InnerText
                End If
            End While
            desc = Replace(Replace(desc, vbNewLine, String.Empty), "  ", String.Empty)
            Return desc
        End Get
    End Property

    ''' <summary>
    ''' Grab all the puzzle code from the XML node
    ''' </summary>
    ''' <returns>The code</returns>
    Public ReadOnly Property PuzzleCode() As String
        Get
            Dim e As IEnumerator
            Dim code As String = String.Empty

            e = _Puzzle.ChildNodes.GetEnumerator
            While e.MoveNext()
                If IsNodeName("code", e) Then
                    code = Replace(e.Current.InnerText, vbNewLine, String.Empty, 1, 1)
                    _Code = e.Current
                End If
            End While
            'In general we want our code to preservve whitespace, but we want to get rid of
            ' the first bunch of spaces on each line.
            code = Replace(code, "      ", String.Empty, 1, 1)           ' The very first line in the code block doesn't start w/ CRLF
            code = Replace(code, vbNewLine & "      ", vbNewLine, 1)  ' All the rest do
            Return code
        End Get
    End Property

    ''' <summary>
    ''' The 'Entry Point' is the method in the compiled code where execution begins.
    ''' In C#, this must be Main, but in VB, could be user or system generated code.
    ''' </summary>
    ''' <returns>The method name</returns>
    Public ReadOnly Property EntryPoint() As String
        Get
            If _Code.Attributes.GetNamedItem("entryPoint") Is Nothing Then
                Return "Puzzle"
            Else
                Return _Code.Attributes.GetNamedItem("entryPoint").Value
            End If

        End Get
    End Property
    ''' <summary>
    ''' The collection of expected values and their Types
    ''' </summary>
    ''' <returns>A collection of the expected results.</returns>
    ''' <remarks>See the Results class for details.  
    ''' This property is set in the private procedure SetExpected</remarks>
    Public ReadOnly Property Expected() As Collection
        Get
            Return _Expected
        End Get
    End Property

#End Region





End Class
