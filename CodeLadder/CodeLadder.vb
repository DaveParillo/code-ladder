
''' <summary>
''' The main game controller
''' </summary>
Public Class CodeLadder
    Private Const GAME_NAME As String = "Code Ladder"
    Private _prefs As New PreferencesDialog
    Private _game As GameDAL
    Private _state As New GameState


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

        c.Code = Me.txtCode.Text
        For Each r As Results In _game.Expected
            actual = c.Eval(_game.EntryPoint, r.Parameters)
            If c.Errors.HasErrors Then
                lblTalk.Text = "Compiler errors: " & vbNewLine
                lblTalk.Text = c.WriteErrors()
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

        lblTalk.Refresh()

    End Sub

#Region "Puzzle Navigation Button Event handlers"

    ''' <summary>
    ''' Load the next puzzle in the ladder
    ''' </summary>
    Private Sub btnNext_Click() Handles btnNext.Click
        If _game.NextPuzzle() Then
            lblDescription.Text = "Problem #" & _game.PuzzleId _
                                & ": " & _game.PuzzleDescription
            _state.History = "Move to puzzle #" & _game.PuzzleId
            txtCode.Text = _game.PuzzleCode
        Else
            MessageBox.Show("You made it to the end!")
        End If
        UpdateTalkText()

    End Sub

    ''' <summary>
    ''' Load the previous puzzle in the ladder
    ''' </summary>
    Private Sub btnPrev_Click() Handles btnPrev.Click
        If _game.PreviousPuzzle() Then
            lblDescription.Text = "Problem #" & _game.PuzzleId _
                                & ": " & _game.PuzzleDescription
            _state.History = "Move to puzzle #" & _game.PuzzleId
            txtCode.Text = _game.PuzzleCode
        Else
            MessageBox.Show("Can't navigate before the first puzzle set.")
        End If
        UpdateTalkText()
    End Sub

    Private Sub btnFirst_Click() Handles btnFirst.Click
        If _game.FirstPuzzle() Then
            lblDescription.Text = "Problem #" & _game.PuzzleId _
                                & ": " & _game.PuzzleDescription
            _state.History = "Move to puzzle #" & _game.PuzzleId
            txtCode.Text = _game.PuzzleCode
        End If
        UpdateTalkText()
    End Sub

    Private Sub btnLast_Click() Handles btnLast.Click
        If _game.LastPuzzle() Then
            lblDescription.Text = "Problem #" & _game.PuzzleId _
                                & ": " & _game.PuzzleDescription
            _state.History = "Move to puzzle #" & _game.PuzzleId
            txtCode.Text = _game.PuzzleCode
        End If
        UpdateTalkText()
    End Sub

    ' Let the user know they have already solved this one.
    Private Sub UpdateTalkText()
        If _state.Solved.Contains(_game.PuzzleId) Then
            lblTalk.Text = "You solved this already."
        Else
            lblTalk.Text = String.Empty
        End If
    End Sub
#End Region

    ''' <summary>
    ''' Actions to take on Application Start
    ''' </summary>
    Private Sub CodeLadder_Load() Handles MyBase.Load
        _game = New GameDAL(_prefs.Language)
        lblScore.Text = _state.Score.ToString
        _prefs.txtName.Text = _state.Name
        Me.Text = GAME_NAME & ": " & _state.Name
        _game.LoadGame(_state.PuzzleId)
        txtCodeBin.Text = _state.CodeBin
        lblTotal.Text = _game.Count.ToString
        lblDescription.Text = "Problem #" & _game.PuzzleId _
                                & ": " & _game.PuzzleDescription
        lblTalk.Text = String.Empty
        txtCode.Text = _game.PuzzleCode

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
            CodeLadder_Load()
            _state.SaveGame()
        End If
    End Sub

    ''' <summary>
    ''' Restart from the beginning
    ''' </summary>
    Private Sub NewGameToolStripMenuItem_Click() Handles NewGameToolStripMenuItem.Click
        If vbYes = MessageBox.Show("Restart?" & vbNewLine & vbNewLine & _
                                   "This will delete your saved results and restart from the beginning.", "Are you sure?", _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            _state.Delete()
            CodeLadder_Load()
        End If
    End Sub

    ''' <summary>
    ''' Exit the application
    ''' </summary>
    Private Sub ExitToolStripMenuItem_Click() Handles ExitToolStripMenuItem.Click
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
    ''' Show the user where they went wrong.
    ''' Show the expected results given a set of inputs
    ''' </summary>
    ''' <param name="Expected">The expected results for a given set of inputs</param>
    Private Sub ShowExpected(ByVal Expected As Results)
        lblTalk.Text &= "Expected:" & vbNewLine
        If Not Expected.ObjectProperty Is Nothing AndAlso Expected.ObjectProperty.Length > 0 Then
            lblTalk.Text &= "Property: " & Expected.ObjectProperty & ", Value: " & Expected.Value & vbNewLine
        ElseIf Not Expected.Parameters Is Nothing AndAlso Expected.Parameters.Length > 0 Then
            lblTalk.Text &= "With parameters: "
            For i As Integer = 0 To Expected.Parameters.Length - 1
                lblTalk.Text &= Expected.Parameters(i) & ", "
            Next
            lblTalk.Text &= " Value: " & Expected.Value & vbNewLine
        Else
            lblTalk.Text &= "Value: " & Expected.Value & vbNewLine
        End If
    End Sub
    ''' <summary>
    ''' Let the user know they rock.
    ''' </summary>
    Private Sub ShowYouPassed()
        lblTalk.Text = "You passed the challenge!" & vbNewLine
        ' Update the score, if unsolved
        If Not _state.Solved.Contains(_game.PuzzleId) Then
            _state.Score += 1
            lblScore.Text = _state.Score.ToString
            _state.AddSolvedPuzzle(_game.PuzzleId)
        End If

        'update puzzle id
        _state.PuzzleId = _game.PuzzleId

        ' Update the code bin
        txtCodeBin.Text &= txtCode.Text
        _state.CodeBin = txtCodeBin.Text
    End Sub

    ''' <summary>
    ''' Let the user know they need to try again.
    ''' </summary>
    Private Sub ShowYouFailed(ByVal Actual As Object, ByVal Expected As Results)
        If Not Actual Is Nothing Then
            lblTalk.Text = "Your code returned: " & vbNewLine
            lblTalk.Text &= Actual.ToString & vbNewLine
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
            lblTalk.Text = "Your code returned nothing" & vbNewLine
        Else
            Select Case Actual.GetType
                Case GetType(String)
                    isAnswerOK = (Expected.Value = Actual)
                Case GetType(Boolean)
                    Dim i As Boolean
                    isAnswerOK = (Boolean.TryParse(Actual.ToString, i) AndAlso CBool(Expected.Value) = i)
                Case GetType(Integer)
                    Dim i As Integer
                    isAnswerOK = (Integer.TryParse(Actual.ToString, i) AndAlso CInt(Expected.Value) = i)
                Case GetType(Long)
                    Dim i As Long
                    isAnswerOK = (Long.TryParse(Actual.ToString, i) AndAlso CLng(Expected.Value) = i)
                Case GetType(Date)
                    Dim i As Date
                    isAnswerOK = (Date.TryParse(Actual.ToString, i) AndAlso CDate(Expected.Value) = i)
                Case GetType(Decimal)
                    Dim i As Double
                    isAnswerOK = (Decimal.TryParse(Actual.ToString, i) AndAlso CDec(Expected.Value) = i)
                Case GetType(Double)
                    Dim i As Double
                    isAnswerOK = (Double.TryParse(Actual.ToString, i) AndAlso CDbl(Expected.Value) = i)
                Case GetType(Label), GetType(TextBox), _
                     GetType(Button), GetType(Form), _
                     GetType(CheckBox), GetType(RadioButton)
                    isAnswerOK = EvaluateControlProperty(Actual, Expected)
                Case Else
                    MsgBox("Need to add another Type handler - I can't process the " _
                                   & Actual.GetType.ToString & " data type.")
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
            Case "Checked"
                isAnswerOK = (Expected.Value = Actual.Checked)
            Case "Text"
                isAnswerOK = (Expected.Value = Actual.Text)
            Case "Tag"
                isAnswerOK = (Expected.Value = Actual.Tag)
            Case "Visible"
                isAnswerOK = (Expected.Value = Actual.Visible)
            Case "Name"
                isAnswerOK = (Expected.Value = Actual.Name)
            Case "Font.Size"
                isAnswerOK = (Expected.Value = Actual.Font.Size)
            Case "ForeColor"
                isAnswerOK = (Expected.Value = Actual.ForeColor.ToString)
            Case "Size"
                isAnswerOK = (Expected.Value = Actual.Size)
            Case "AutoSize"
                isAnswerOK = (Expected.Value = Actual.AutoSize)
            Case "TextAlign"
                isAnswerOK = (Expected.Value = Actual.TextAlign.ToString)
            Case Else
                MsgBox("Need to add another Control Property handler - I don't grok the " _
                       & Expected.ObjectProperty & " property.")
        End Select
        Return isAnswerOK
    End Function

#End Region

End Class
