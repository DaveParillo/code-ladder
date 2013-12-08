Imports System.Xml
Imports System.Reflection


''' <summary>
''' A data access layer for the game puzzles and expected results
''' </summary>
Public Class GameDAL
    Private pDoc As XmlDocument
    Private plevel As Integer
    Private pPuzzle As XmlNode
    Private pCode As XmlNode
    Private pResults As XmlNode
    Private pExpected As Collection
    Private pEntryPoint As String


#Region "Constructors"
    ''' <summary>
    ''' Load the Game file on instance creation
    ''' </summary>
    Public Sub New()

        pDoc = New XmlDocument

        pDoc.LoadXml(My.Resources.CodeLadder)
        plevel = 1


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

        e = pResults.ChildNodes.GetEnumerator
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
        pExpected = c
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
    Public Sub LoadGame(Optional ByVal StartId As Integer = 0)
        If StartId > 0 Then
            pPuzzle = pDoc.SelectSingleNode("//puzzle[@id='" _
                                                  & StartId.ToString & "']")
            Me.NextPuzzle()
        Else
            LoadNewGame()
        End If
        If pPuzzle Is Nothing Then
            MsgBox("Problem starting game", vbOKOnly + vbCritical)
        End If
    End Sub

    Private Sub LoadNewGame()
        Dim e As IEnumerator

        e = pDoc.FirstChild.ChildNodes.Item(0).GetEnumerator
        While e.MoveNext()
            If IsNodeName("start", e) Then
                pPuzzle = pDoc.SelectSingleNode("//puzzle[@id='" _
                                                  & e.Current.InnerText & "']")
                Me.CollectResults()
            End If

        End While
    End Sub

    Private Sub CollectResults()
        Dim e As IEnumerator
        e = pPuzzle.ChildNodes.GetEnumerator
        While e.MoveNext()
            If IsNodeName("results", e) Then
                pResults = e.Current
            End If
        End While
        Me.SetExpected()
    End Sub


    ' Skip over any puzzle siblings not of type puzzle (i.e. comments)

    Public Function NextPuzzle() As Boolean
        Do
            If Not pPuzzle.NextSibling Is Nothing Then
                pPuzzle = pPuzzle.NextSibling
            End If
        Loop Until pPuzzle.Name = "puzzle"

        If pPuzzle IsNot Nothing Then
            'pPuzzle = pPuzzle.NextSibling
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

#End Region

#Region "Class Proprties"


    Public ReadOnly Property PuzzleId() As Integer
        Get
            Dim i As Integer
            If Integer.TryParse(pPuzzle.Attributes.GetNamedItem("id").Value, i) Then
                Return i
            Else
                MessageBox.Show("No puzzle with ID = " & pPuzzle.Attributes.GetNamedItem("id").Value)
            End If
            Return 0
        End Get
    End Property

    ''' <summary>
    ''' Create a string describing the current puzzle
    ''' </summary>
    Public ReadOnly Property PuzzleDescription() As String
        Get
            Dim e As IEnumerator
            Dim desc As String = String.Empty

            e = pPuzzle.ChildNodes.GetEnumerator
            While e.MoveNext()
                If IsNodeName("description", e) Then
                    desc += e.Current.InnerText & vbNewLine & vbNewLine
                End If
            End While

            Return desc
        End Get
    End Property


    Public ReadOnly Property PuzzleCode() As String
        Get
            Dim e As IEnumerator
            Dim code As String = String.Empty

            e = pPuzzle.ChildNodes.GetEnumerator
            While e.MoveNext()
                If IsNodeName("code", e) Then
                    code = e.Current.InnerText & vbNewLine & vbNewLine
                    pCode = e.Current
                End If
            End While
            Return code.Replace("      ", "")
        End Get
    End Property

    Public ReadOnly Property EntryPoint() As String
        Get
            If pCode.Attributes.GetNamedItem("entryPoint") Is Nothing Then
                Return "Puzzle"
            Else
                Return pCode.Attributes.GetNamedItem("entryPoint").Value
            End If

        End Get
    End Property

    Public ReadOnly Property Expected() As Collection
        Get
            Return pExpected
        End Get
    End Property

#End Region



End Class
