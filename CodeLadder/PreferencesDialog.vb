Imports System.Windows.Forms
Imports System.IO

Public Class PreferencesDialog
    Friend Enum LANG As Integer
        VISUAL_BASIC
        C_SHARP
    End Enum

    Friend Enum LEVEL As Integer
        LEVEL_1
        LEVEL_2
        LEVEL_3
        LEVEL_4
        LEVEL_5
    End Enum

    Private _language As LANG
    Private _langNew As LANG
    Private _name As String
    Private _level As LEVEL
    Private _levelNew As LEVEL

    Friend Const MIN_NAME_LENGTH As Integer = 4

    Friend ReadOnly Property Language As LANG
        Get
            Return _language
        End Get
    End Property


    Friend Property UserName As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
            txtName.Text = value
        End Set
    End Property


    Friend Property Difficulty As LEVEL
        Get
            If cboLevel.SelectedIndex < 0 Then
                cboLevel.SelectedIndex = _level
            End If
            Return _level
        End Get
        Set(value As LEVEL)
            _level = value
            cboLevel.SelectedIndex = _level
        End Set
    End Property

    Private Sub OK_Button_Click() Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        If LanguageChanged() Then
            _language = _langNew
        End If
        _level = cboLevel.SelectedIndex
        If txtName.Text.Length >= MIN_NAME_LENGTH Then
            _name = txtName.Text
            Me.Close()
        Else
            MessageBox.Show("Please enter at least " & MIN_NAME_LENGTH & " characters for your name.", _
                            "Not enough letters in Name")
        End If

    End Sub

    Private Sub Cancel_Button_Click() Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        If _language = LANG.VISUAL_BASIC Then
            radVisualBasic.Checked = True
        Else
            radCSharp.Checked = True
        End If
        cboLevel.SelectedIndex = _level
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

    ''' <summary>
    ''' Determine if the user has selected a new Code Ladder Language
    ''' </summary>
    ''' <returns>True if the language selection has changed</returns>
    ''' <remarks></remarks>
    Private Function LanguageChanged() As Boolean
        Return Not (_langNew = _language)
    End Function


    ''' <summary>
    '''   Get the currently selected Difficulty Level in a filename safe way.
    ''' </summary>
    Friend Function GetDifficultyText() As String
        Return Replace(cboLevel.SelectedItem, " ", "_")
    End Function


    ''' <summary>
    ''' Builds a new state object, either by opening an existing file or by creating a new level 1 game.
    ''' 
    ''' Searches for old files in decending difficulty level - most to least, so that most recently
    ''' opened levels are tried first.
    ''' </summary>
    ''' <returns>A new GameState object</returns>
    ''' <remarks></remarks>
    Friend Function LoadLatestWeek() As GameState
        Dim s As GameState
        Dim prefix As String
        s = Nothing

        Const postfix As String = "SavedGame.dat"
        If cboLevel.SelectedIndex > -1 Then
            s = New GameState(GetDifficultyText() & "SavedGame.dat")
        Else
            For i As Integer = cboLevel.Items.Count - 1 To 0 Step -1
                prefix = Replace(cboLevel.Items(i), " ", "_")
                If File.Exists(prefix & postfix) Then
                    s = New GameState(prefix & postfix)
                    Difficulty = i
                    Exit For
                End If
            Next
            If s Is Nothing Then
                prefix = Replace(cboLevel.Items(0), " ", "_")
                s = New GameState(prefix & postfix)
                Difficulty = 0
            End If
        End If


        Return s
    End Function
End Class
