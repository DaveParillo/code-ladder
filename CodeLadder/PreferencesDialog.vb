Imports System.Windows.Forms

Public Class PreferencesDialog
    Friend Enum LANG As Integer
        VISUAL_BASIC
        C_SHARP
    End Enum

    Private _language As LANG
    Private _langNew As LANG
    Private _name As String
    Private Const MIN_NAME_LENGTH As Integer = 5

    Friend ReadOnly Property Language As LANG
        Get
            Return _language
        End Get
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        If LanguageChanged() Then
            _language = _langNew
        End If
        If txtName.Text.Length >= MIN_NAME_LENGTH Then
            _name = txtName.Text
            Me.Close()
        Else
            MessageBox.Show("Please enter at least " & MIN_NAME_LENGTH & " characters for your name.", _
                            "Not enough letters in Name")
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        If _language = LANG.VISUAL_BASIC Then
            radVisualBasic.Checked = True
        Else
            radCSharp.Checked = True
        End If
        txtName.Text = _name
        Me.Close()
    End Sub

    Private Sub VB_CheckedChanged() Handles radVisualBasic.CheckedChanged
        If radVisualBasic.Checked Then
            _langNew = LANG.VISUAL_BASIC
        End If

    End Sub
    Private Sub CSharp_CheckedChanged() Handles radCSharp.CheckedChanged
        If radCSharp.Checked Then
            _langNew = LANG.C_SHARP
        End If
    End Sub

    Private Function LanguageChanged() As Boolean
        Return Not (_langNew = _language)
    End Function

End Class
