
''' <summary>
''' The main game controller
''' </summary>
Public Class CodeLadder

    Private game As New GameDAL
    Private state As New GameState


#Region "Event Handlers"

    ''' <summary>
    ''' Starts the code evaluation process
    ''' </summary>
    Private Sub btnEval_Click() Handles btnEval.Click
        Dim actual As Object
        Dim c As New Compiler
        Dim isAnswerOK As Boolean

        c.Text = Me.txtCode.Text
        For Each r As Results In game.Expected
            actual = c.Eval(game.EntryPoint, r.Parameters)
            If c.Errors.HasErrors Then
                lblTalk.Text = "Compiler errors: " & vbNewLine
                lblTalk.Text = c.WriteErrors()
            Else
                isAnswerOK = Evaluate(actual, r)
                ' Stop evaluating on the first unexpected result
                If Not isAnswerOK Then
                    ShowYouFailed(actual, r)
                    Exit For
                End If
            End If
        Next
        If isAnswerOK Then
            ShowYouPassed()
            state.SaveGame()
        End If

        lblTalk.Refresh()

    End Sub
    ''' <summary>
    ''' Load the next puzzle in the ladder
    ''' </summary>
    Private Sub btnNext_Click() Handles btnNext.Click
        If game.NextPuzzle() Then
            lblDescription.Text = "Problem #" & game.PuzzleId _
                                & ": " & game.PuzzleDescription

            txtCode.Text = game.PuzzleCode
        Else
            MessageBox.Show("You made it though every level!")
            txtCode.Clear()
            lblDescription.Text = String.Empty
        End If
        lblTalk.Text = String.Empty
    End Sub

    ''' <summary>
    ''' Actions to take on Application Start
    ''' </summary>
    Private Sub CodeLadder_Load() Handles MyBase.Load
        lblScore.Text = state.Score.ToString
        game.LoadGame(state.PuzzleId)
        txtCodeBin.Text = state.CodeBin

        lblDescription.Text = "Problem #" & game.PuzzleId _
                                & ": " & game.PuzzleDescription
        lblTalk.Text = String.Empty
        txtCode.Text = game.PuzzleCode

    End Sub


    ''' <summary>
    ''' Exit the application
    ''' </summary>
    Private Sub btnClose_Click() Handles btnClose.Click
        Me.Close()
    End Sub
#End Region


#Region "Utility Functions"
    ''' <summary>
    ''' Show the user where they went wrong.
    ''' Show the expected results given a set of inputs
    ''' </summary>
    ''' <param name="Expected">The expected results for a given set of inputs</param>
    Private Sub ShowExpected(ByVal Expected As Results)
        Dim foo As New Button
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
        ' Update the score
        state.Score += 1
        lblScore.Text = state.Score.ToString

        'update puzzle id
        state.PuzzleId = game.PuzzleId

        ' Update the code bin
        txtCodeBin.Text &= txtCode.Text
        state.CodeBin = txtCodeBin.Text
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