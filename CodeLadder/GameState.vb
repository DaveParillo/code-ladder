Imports System.IO


''' <summary>
''' Saves and Restores key game state data
''' </summary>
''' <remarks>Allows you to pick up from where you left off.
''' Currently only a default save file is used.
''' </remarks>
Public Class GameState
    Private Const SAVE_FILE_DEFAULT As String = "DefaultSavedGame.dat"

    Private _Score As Integer
    Private _Puzzle As Integer
    Private _CodeBin As String

    'Private pFileName As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, pFileDefault)
    Private _FileName As String = SAVE_FILE_DEFAULT

    Public Sub New()
        MyBase.New()
        LoadGame()
    End Sub

    ''' <summary>
    ''' Saves the current game data
    ''' </summary>
    Public Sub SaveGame()
        Using writer As BinaryWriter = New BinaryWriter(File.Open(_FileName, IO.FileMode.Create))
            writer.Write(_Score)
            writer.Write(_Puzzle)
            writer.Write(_CodeBin)
        End Using
    End Sub

    ''' <summary>
    ''' Loads the current game data, if possible
    ''' </summary>
    Public Sub LoadGame()
        If File.Exists(_FileName) Then
            Using reader As BinaryReader = New BinaryReader(File.Open(_FileName, IO.FileMode.Open))
                _Score = reader.ReadInt32()
                _Puzzle = reader.ReadInt32()
                _CodeBin = reader.ReadString()
            End Using
        Else
            _Score = 0
            _Puzzle = 0
            _CodeBin = String.Empty
        End If
    End Sub

#Region "Class Proprties"
    Public Property Score() As Integer
        Get
            Return _Score
        End Get
        Set(ByVal value As Integer)
            _Score = value
        End Set
    End Property

    ''' <summary>
    ''' The last puzzle actually completed is saved
    ''' </summary>
    Public Property PuzzleId() As Integer
        Get
            Return _Puzzle
        End Get
        Set(ByVal value As Integer)
            _Puzzle = value
        End Set
    End Property

    ''' <summary>
    ''' The 'code bin' represents the valid code the user has previously supplied as answers to problems.
    ''' </summary>
    ''' <value>The text from the game code bin TextBox</value>
    ''' <returns>The saved code bin contents</returns>
    Public Property CodeBin() As String
        Get
            Return _CodeBin
        End Get
        Set(ByVal value As String)
            _CodeBin = value
        End Set
    End Property

#End Region

    Sub Delete()
        If File.Exists(_FileName) Then
            File.Delete(_FileName)
        End If
    End Sub


End Class
