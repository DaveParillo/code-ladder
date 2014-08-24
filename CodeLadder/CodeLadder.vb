Imports System.IO

''' <summary>
''' The main game controller
''' </summary>
Public Class CodeLadder
    Private Const GAME_NAME As String = "Code Ladder"

    Private _prefs As New PreferencesDialog
    Private _game As GameDAL
    Private _state As GameState


#Region "Event Handlers"

    ''' <summary>
    ''' Starts the code evaluation process
    ''' </summary>
    Private Sub btnEval_Click() Handles btnEval.Click
        Dim actual As Object
        Dim isAnswerOK As Boolean
        Dim c As Object

        If _prefs.Language = PreferencesDialog.LANG.C_SHARP Then
            c = New CompilerCSharp
        Else
            c = New CompilerVisualBasic
        End If
        txtTalk.Text = String.Empty

        c.Code = Me.txtCode.Text
        For Each r As Results In _game.Expected
            actual = c.Eval(_game.EntryPoint, r.Parameters)
            If c.Errors.HasErrors Then
                txtTalk.Text = "Compiler errors: " & vbNewLine
                txtTalk.Text = c.WriteErrors()
            Else
                isAnswerOK = Evaluate(actual, r)
                _state.History = Me.txtCode.Text
                ' Stop evaluating on the first unexpected result
                If Not isAnswerOK Then
                    ShowYouFailed(actual, r)
                    Exit For
                End If
            End If
        Next
        If isAnswerOK Then
            ShowYouPassed()
            _state.SaveGame()
        End If

        txtTalk.Refresh()

    End Sub

    ''' <summary>
    ''' Event Handler to increase / decrease font size of the 'functional' elements of the UI:
    '''  - The text boxes and the line numbering label.
    ''' </summary>
    ''' <param name="sender">One of the controls used to change font size</param>
    ''' <param name="e">Not used</param>
    Private Sub ChangeTextSize_Click(sender As Object, e As EventArgs) Handles btnTextBigger.Click, btnTextSmaller.Click
        Dim amt As Single = Val(sender.Tag)

        ChangeFontSizeOf(txtCode, amt)
        ChangeFontSizeOf(txtTalk, amt)
        ChangeFontSizeOf(txtDescription, amt)
        ChangeFontSizeOf(lblLineNumbers, amt)
        ChangeFontSizeOf(txtCodeBin, amt)
    End Sub

#Region "Puzzle Navigation Button Event handlers"

    ''' <summary>
    ''' Load the next puzzle in the ladder
    ''' </summary>
    Private Sub btnNext_Click() Handles btnNext.Click
        If _game.NextPuzzle() Then
            WriteNewPuzzle()
        Else
            MessageBox.Show("Congratulations!" & vbNewLine & vbNewLine _
                            & "If you have solved all the problems, excellent job!" & vbNewLine _
                            & "If your score is less than " & _game.Count & ", now would be a good time" & vbNewLine _
                            & "to try again on any of your unsolved problems." & vbNewLine & vbNewLine _
                            & "Don't forget to upload the saved 'dat' file to blackboard!" & vbNewLine _
                            & "Do NOT upload the Code Ladder 'exe' file. I can't grade that." _
                            , "You made it to the end!")
        End If
        UpdateTalkText()

    End Sub

    ''' <summary>
    ''' Load the previous puzzle in the ladder
    ''' </summary>
    Private Sub btnPrev_Click() Handles btnPrev.Click
        If _game.PreviousPuzzle() Then
            WriteNewPuzzle()
        Else
            MessageBox.Show("Can't navigate before the first puzzle set.", "You're at the beginning")
        End If
        UpdateTalkText()
    End Sub

    Private Sub btnFirst_Click() Handles btnFirst.Click
        If _game.FirstPuzzle() Then
            WriteNewPuzzle()
        End If
        UpdateTalkText()
    End Sub

    Private Sub btnLast_Click() Handles btnLast.Click
        If _game.LastPuzzle() Then
            WriteNewPuzzle()
        End If
        UpdateTalkText()
    End Sub


#End Region

    ''' <summary>
    ''' Actions to take on Application Start
    ''' </summary>
    Private Sub CodeLadder_Load() Handles MyBase.Load
        _state = LoadLatestWeek()

        _game = New GameDAL(_prefs.Language, _prefs.Difficulty)

        lblScore.Text = _state.Score.ToString
        If Len(_state.Name) > 0 Then
            _prefs.txtName.Text = _state.Name
        End If
        Me.Text = GAME_NAME & ", " & GetPrefix() & ": " & _prefs.txtName.Text
        _game.LoadGame(_state.Location)
        txtCodeBin.Text = _state.CodeBin
        lblTotal.Text = _game.Count.ToString

        WriteNewPuzzle()

        txtTalk.Text = String.Empty

    End Sub
#Region "Toolstrip Menu Items"

    ''' <summary>
    ''' Edit preferences and update game with selections
    ''' </summary>
    Private Sub PreferencesToolStripMenuItem_Click() Handles PreferencesToolStripMenuItem.Click
        Dim l As PreferencesDialog.LANG
        l = _prefs.Language
        _prefs.ShowDialog()
        If _prefs.DialogResult = DialogResult.OK Then
            If l <> _prefs.Language Then
                _state.Delete()
            End If
            _state.Name = _prefs.txtName.Text
            _state.SaveGame()
            CodeLadder_Load()
        End If
    End Sub

    ''' <summary>
    ''' Save feedback for nervous users
    ''' </summary>
    Private Sub SaveToolStripMenuItem_Click() Handles SaveToolStripMenuItem.Click
        _state.SaveGame()
        MessageBox.Show("FIle Saved to " & _state.FileName & ".", "File saved OK")
    End Sub

    ''' <summary>
    ''' Restart from the beginning
    ''' </summary>
    Private Sub NewGameToolStripMenuItem_Click() Handles NewGameToolStripMenuItem.Click
        If vbYes = MessageBox.Show("Restart?" & vbNewLine & vbNewLine & _
                                   "This will delete your " _
                                   & _prefs.cboLevel.SelectedItem  _
                                   & " saved results and restart from problem #1.", "Are you sure?", _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            _state.Delete()
            _state.History = "User initiated new game."
            CodeLadder_Load()
        End If
    End Sub

    ''' <summary>
    ''' Exit the application
    ''' </summary>
    Private Sub ExitToolStripMenuItem_Click() Handles ExitToolStripMenuItem.Click
        _state.History = "Exit."
        Me.Close()
    End Sub

    ''' <summary>
    ''' Display the saved game state history
    ''' </summary>
    Private Sub HistoryToolStripMenuItem_Click() Handles HistoryToolStripMenuItem.Click
        Dim h As New History
        h.UpdateHistory(_state.History)
        h.ShowDialog()
    End Sub

#End Region

#End Region

#Region "Utility Functions"

    ''' <summary>
    '''   Get the currently selected Difficulty Level in a filename safe way.
    ''' </summary>
    Private Function GetPrefix() As String
        Return Replace(_prefs.cboLevel.SelectedItem, " ", "_")
    End Function



    ''' <summary>
    ''' Show the user where they went wrong.
    ''' Show the expected results given a set of inputs
    ''' </summary>
    ''' <param name="Expected">The expected results for a given set of inputs</param>
    Private Sub ShowExpected(ByVal Expected As Results)
        txtTalk.Text &= "Expected "
        If Not Expected.ObjectProperty Is Nothing AndAlso Expected.ObjectProperty.Length > 0 Then
            txtTalk.Text &= "the '" & Expected.ObjectProperty & "' property to have a value of '" & Expected.Value & "'" & vbNewLine
        ElseIf Not Expected.Parameters Is Nothing AndAlso Expected.Parameters.Length > 0 Then
            txtTalk.Text &= "given parameters: "
            For i As Integer = 0 To Expected.Parameters.Length - 1
                txtTalk.Text &= Expected.Parameters(i) & ", "
            Next
            txtTalk.Text &= " a value of '" & Expected.Value & "'" & vbNewLine
        Else
            txtTalk.Text &= "'" & Expected.Value & "'" & vbNewLine
        End If
    End Sub
    ''' <summary>
    ''' Let the user know they rock.
    ''' </summary>
    Private Sub ShowYouPassed()
        txtTalk.Text = "You passed the challenge!" & vbNewLine

        ' Update the score, if unsolved
        If Not _state.Solved.Contains(_game.Location) Then
            _state.Score += 1
            lblScore.Text = _state.Score.ToString
            _state.AddSolvedPuzzle(_game.Location)
        End If

        'update current location
        _state.Location = _game.Location

        ' Update the code bin
        txtCodeBin.Text &= "' Answer to problem #" & _game.Location.ToString & vbNewLine
        txtCodeBin.Text &= txtCode.Text & vbNewLine
        _state.CodeBin = txtCodeBin.Text
    End Sub

    ''' <summary>
    ''' Let the user know they need to try again.
    ''' </summary>
    Private Sub ShowYouFailed(ByVal Actual As Object, ByVal Expected As Results)
        If Not Actual Is Nothing Then
            txtTalk.Text = "Your code returned '" & Actual.ToString & "'" & vbNewLine
        End If
        ShowExpected(Expected)
    End Sub

    ''' <summary>
    ''' Evaluate the users code using a set of expected results
    ''' </summary>
    ''' <param name="Actual">What their code generate as output</param>
    ''' <param name="Expected">What their code should have generated, given an (optional) set of inputs</param>
    ''' <returns>True, if the actual results match expectations</returns>
    ''' <remarks>Is still relatively limitied in what it can evaluate</remarks>
    Private Function Evaluate(ByVal Actual As Object, ByVal Expected As Results) As Boolean
        Dim isAnswerOK As Boolean = False

        If Actual Is Nothing Then
            txtTalk.Text = "Your code returned nothing" & vbNewLine
        Else
            Select Case Actual.GetType
                Case GetType(Boolean)
                    Dim i As Boolean
                    isAnswerOK = (Boolean.TryParse(Actual.ToString, i) AndAlso CBool(Expected.Value) = i)
                Case GetType(Char)
                    Dim i As Char
                    isAnswerOK = (Char.TryParse(Actual.ToString, i) AndAlso CChar(Expected.Value) = i)
                Case GetType(Date)
                    Dim i As Date
                    isAnswerOK = (Date.TryParse(Actual.ToString, i) AndAlso CDate(Expected.Value) = i)
                Case GetType(Decimal)
                    Dim i As Decimal
                    isAnswerOK = (Decimal.TryParse(Actual.ToString, i) AndAlso CDec(Expected.Value) = i)
                Case GetType(DialogResult)
                    Dim i As DialogResult
                    isAnswerOK = [Enum].TryParse(Expected.Value, i) AndAlso (Actual = i)
                Case GetType(Double)
                    Dim i As Double
                    isAnswerOK = (Double.TryParse(Actual.ToString, i) AndAlso CDbl(Expected.Value) = i)
                Case GetType(Integer)
                    Dim i As Integer
                    isAnswerOK = (Integer.TryParse(Actual.ToString, i) AndAlso CInt(Expected.Value) = i)
                Case GetType(Long)
                    Dim i As Long
                    isAnswerOK = (Long.TryParse(Actual.ToString, i) AndAlso CLng(Expected.Value) = i)
                Case GetType(Short)
                    Dim i As Short
                    isAnswerOK = (Short.TryParse(Actual.ToString, i) AndAlso CShort(Expected.Value) = i)
                Case GetType(Single)
                    Dim i As Single
                    isAnswerOK = (Single.TryParse(Actual.ToString, i) AndAlso CSng(Expected.Value) = i)

                Case GetType(String)
                    isAnswerOK = (Expected.Value = Actual)

                Case GetType(Label), GetType(TextBox), _
                     GetType(Button), GetType(Form), _
                     GetType(CheckBox), GetType(RadioButton), GetType(ListBox)
                    isAnswerOK = EvaluateControlProperty(Actual, Expected)
                Case Else
                    MsgBox("Need to add another Type handler - I can't process the " _
                       & Actual.GetType.ToString & " data type.", MsgBoxStyle.OkOnly, _
                       "Problem in function CodeLadder::Evaluate")
            End Select
        End If

        Return isAnswerOK
    End Function

    ''' <summary>
    ''' Evaluate VB Objects returned from the users code using a set of expected results
    ''' </summary>
    ''' <param name="Actual">User Object</param>
    ''' <param name="Expected">The expected property and value pair</param>
    ''' <returns>True, if the actual results match expectations</returns>
    ''' <remarks>Is still relatively limitied in what it can evaluate</remarks>
    Private Function EvaluateControlProperty(ByVal Actual As Object, ByVal Expected As Results) As Boolean
        Dim isAnswerOK As Boolean = False
        Select Case Expected.ObjectProperty
            Case "AutoSize"
                isAnswerOK = (Expected.Value = Actual.AutoSize)
            Case "Checked"
                isAnswerOK = (Expected.Value = Actual.Checked)
            Case "Font.Size"
                isAnswerOK = (Expected.Value = Actual.Font.Size)
            Case "ForeColor"
                isAnswerOK = (Expected.Value = Actual.ForeColor.ToString)
            Case "Items.Count"
                isAnswerOK = (Expected.Value = Actual.Items.Count)
            Case "Name"
                isAnswerOK = (Expected.Value = Actual.Name)
            Case "Size"
                isAnswerOK = (Expected.Value = Actual.Size)
            Case "Tag"
                isAnswerOK = (Expected.Value = Actual.Tag)
            Case "Text"
                isAnswerOK = (Expected.Value = Actual.Text)
            Case "TextAlign"
                isAnswerOK = (Expected.Value = Actual.TextAlign.ToString)
            Case "Visible"
                isAnswerOK = (Expected.Value = Actual.Visible)
            Case Else
                MsgBox("Need to add another Control Property handler - I don't grok the " _
                       & Expected.ObjectProperty & " property.", MsgBoxStyle.OkOnly, _
                       "Problem in function CodeLadder::EvaluateControlProperty")
        End Select
        Return isAnswerOK
    End Function

    ' Erase the Talk text box or let the user know they have already solved this one.
    Private Sub UpdateTalkText()
        If _state.Solved.Contains(_game.Location) Then
            txtTalk.Text = "You solved this already."
        Else
            txtTalk.Text = String.Empty
        End If
    End Sub

    ' Update all the controls that display puzzle specific information
    Private Sub WriteNewPuzzle()
        pagePuzzle.Text = "Problem #" & _game.Location
        txtDescription.Text = _game.PuzzleDescription
        _state.History = "Move to problem #" & _game.Location
        txtCode.Text = _game.PuzzleCode
    End Sub


    ''' <summary>
    ''' Change the font size of the provided control
    ''' </summary>
    ''' <param name="ctrl">The Control whose text property is to be changed</param>
    ''' <param name="Amount">The number of em size in points (plus or minus) to change font size by</param>
    ''' <remarks>Amount is relative.  It will be added to or subtracted from the current font size</remarks>
    Private Sub ChangeFontSizeOf(ctrl As Control, Amount As Single)
        Const minSize As Single = 4.0F

        ctrl.Font = New Font(ctrl.Font.FontFamily, _
                             Math.Max(minSize, ctrl.Font.Size + Amount), _
                             ctrl.Font.Style)
    End Sub


#End Region

    Private Function LoadLatestWeek() As GameState
        Dim s As GameState
        Dim prefix As String

        Const postfix As String = "SavedGame.dat"
        If _prefs.cboLevel.SelectedIndex > -1 Then
            s = New GameState(GetPrefix() & "SavedGame.dat")
        Else
            For i As Integer = _prefs.cboLevel.Items.Count - 1 To 0 Step -1
                prefix = Replace(_prefs.cboLevel.Items(i), " ", "_")
                If File.Exists(prefix & postfix) Then
                    s = New GameState(prefix & postfix)
                    _prefs.Difficulty = i
                    Exit For
                End If
            Next
            If s Is Nothing Then
                prefix = Replace(_prefs.cboLevel.Items(0), " ", "_")
                s = New GameState(prefix & postfix)
                _prefs.Difficulty = 0
            End If
        End If


        Return s
    End Function

End Class
