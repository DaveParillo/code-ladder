Imports System.IO


''' <summary>
''' Saves and Restores key game state data
''' </summary>
''' <remarks>Allows you to pick up from where you left off.
''' Currently only a default save file is used.
''' </remarks>
Public Class GameState
    Private Const SAVE_FILE_DEFAULT As String = "DefaultSavedGame.dat"

    Private pScore As Integer
    Private pPuzzle As Integer
    Private pCodeBin As String

    'Private pFileName As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, pFileDefault)
    Private pFileName As String = SAVE_FILE_DEFAULT

    Public Sub New()
        MyBase.New()
        LoadGame()
    End Sub

    ''' <summary>
    ''' Saves the current game data
    ''' </summary>
    Public Sub SaveGame()
        Using writer As BinaryWriter = New BinaryWriter(File.Open(pFileName, IO.FileMode.Create))
            writer.Write(pScore)
            writer.Write(pPuzzle)
            writer.Write(pCodeBin)
        End Using
    End Sub

    ''' <summary>
    ''' Loads the current game data, if possible
    ''' </summary>
    Public Sub LoadGame()
        If File.Exists(pFileName) Then
            Using reader As BinaryReader = New BinaryReader(File.Open(pFileName, IO.FileMode.Open))
                pScore = reader.ReadInt32()
                pPuzzle = reader.ReadInt32()
                pCodeBin = reader.ReadString()
            End Using
        Else
            pScore = 0
            pPuzzle = 0
            pCodeBin = String.Empty
        End If
    End Sub

#Region "Class Proprties"
    Public Property Score() As Integer
        Get
            Return pScore
        End Get
        Set(ByVal value As Integer)
            pScore = value
        End Set
    End Property

    ''' <summary>
    ''' The last puzzle actually completed is saved
    ''' </summary>
    Public Property PuzzleId() As Integer
        Get
            Return pPuzzle
        End Get
        Set(ByVal value As Integer)
            pPuzzle = value
        End Set
    End Property

    ''' <summary>
    ''' The 'code bin' represents the valid code the user has previously supplied as answers to problems.
    ''' </summary>
    ''' <value>The text from the game code bin TextBox</value>
    ''' <returns>The saved code bin contents</returns>
    Public Property CodeBin() As String
        Get
            Return pCodeBin
        End Get
        Set(ByVal value As String)
            pCodeBin = value
        End Set
    End Property

#End Region


End Class
