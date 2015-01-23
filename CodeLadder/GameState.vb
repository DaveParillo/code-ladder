Imports System.IO
Imports System.Runtime.Serialization
Imports System.Text


''' <summary>
''' Saves and Restores key game state data
''' </summary>
''' <remarks>Allows you to pick up from where you left off.
''' Currently only a default save file is used.
''' </remarks>
Public Class GameState
    Private Const SAVE_FILE_DEFAULT As String = "DefaultSavedGame.dat"

    <Serializable()> Private Structure _StateInfo
        Dim score As Integer                      ' Current total score
        Dim name As String                        ' Student name from the preferences dialog
        Dim solved As List(Of Integer)            ' A list of Solved puzzle ID's
        Dim location As Integer                   ' Current location in the list of problems
        Dim codeBin As String                     ' compilation of all code the user has saved
        Dim history As String                     ' timestamped snapshots of preferences and 'Evaluate!' changes 
    End Structure

    Private _state As _StateInfo
    Private _history As New StringBuilder
    'Private pFileName As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, pFileDefault)
    Private _FileName As String

    Public Sub New(Optional ByVal FileName As String = SAVE_FILE_DEFAULT)
        MyBase.New()
        _FileName = FileName
        LoadGame()
    End Sub

    ''' <summary>
    ''' Saves the current game data
    ''' </summary>
    Public Sub SaveGame()
        Dim formatter As New Formatters.Binary.BinaryFormatter
        Dim ms As New MemoryStream
        _state.history = _history.ToString
        formatter.Serialize(ms, _state)
        My.Computer.FileSystem.WriteAllBytes(_FileName, ms.GetBuffer, False)
    End Sub

    ''' <summary>
    ''' Loads the current game data, if possible
    ''' </summary>
    Public Sub LoadGame()
        If File.Exists(_FileName) Then
            Dim formatter As New Formatters.Binary.BinaryFormatter
            Dim bytes As Byte() = My.Computer.FileSystem.ReadAllBytes(_FileName)
            Dim sl As New List(Of String)

            _state = DirectCast(formatter.Deserialize(New MemoryStream(bytes)), _StateInfo)
            _history.Clear()
            _history.Append(_state.history)
        Else
            _state.score = 0
            _state.name = String.Empty
            _state.solved = New List(Of Integer)
            _state.location = 0
            _state.codeBin = String.Empty
            _state.history = String.Empty
        End If

    End Sub

#Region "Class Proprties"
    ''' <summary>
    ''' Total score. Essentially a progress indicator.
    ''' </summary>
    ''' <value>The new score</value>
    ''' <returns>The score</returns>
    Public Property Score() As Integer
        Get
            Return _state.score
        End Get
        Set(ByVal value As Integer)
            _state.score = value
        End Set
    End Property


    ''' <summary>
    ''' The last puzzle actually completed is saved
    ''' </summary>
    Public Property Location() As Integer
        Get
            Return _state.location
        End Get
        Set(ByVal value As Integer)
            _state.location = value
        End Set
    End Property

    ''' <summary>
    ''' The 'code bin' represents the valid code the user has previously supplied as answers to problems.
    ''' </summary>
    ''' <value>The text from the game code bin TextBox</value>
    ''' <returns>The saved code bin contents</returns>
    Public Property CodeBin() As String
        Get
            Return _state.codeBin
        End Get
        Set(ByVal value As String)
            _state.codeBin = value
        End Set
    End Property

    ''' <summary>
    ''' The 'history' represents the incorrect code the user has previously supplied as answers to problems and other important items to archive
    ''' </summary>
    ''' <value>The text to save</value>
    ''' <returns>The saved history contents</returns>
    ''' <remarks>Each history item is time stamped.
    '''          The history is not normally visible to regular users</remarks>
    Public Property History() As String
        Get
            Return _history.ToString
        End Get
        Set(ByVal value As String)
            _history.AppendLine(Now().ToString & vbTab & value)
        End Set
    End Property

    ''' <summary>
    ''' The 'solved' property represents a list of all puzzles the user has already solved correctly.
    ''' </summary>
    ''' <returns>A list of puzzle ID's</returns>
    Public ReadOnly Property Solved() As List(Of Integer)
        Get
            Return _state.solved
        End Get
    End Property

    ''' <summary>
    ''' Check if a particular puzzle is in the list of already solved problems
    ''' </summary>
    ''' <param name="PuzzleID">The puzzle to search for</param>
    ''' <value></value>
    ''' <returns>True if PuzzleID is in the list of solved problems</returns>
    Public ReadOnly Property IsSolved(ByVal PuzzleID As Integer) As Boolean
        Get
            Return _state.solved.Contains(PuzzleID)
        End Get
    End Property

    ''' <summary>
    ''' Property representing the user name.
    ''' </summary>
    ''' <value>The users name</value>
    ''' <returns>The users name</returns>
    Public Property Name() As String
        Get
            If IsNothing(_state.name) Then
                Return String.Empty
            Else
                Return _state.name
            End If
        End Get
        Set(ByVal value As String)
            _state.name = value
            Me.History = "Name set to " & value
        End Set
    End Property

    ''' <summary>
    ''' Returns the current save file name.
    ''' </summary>
    ''' <returns>The save file location</returns>
    Public ReadOnly Property FileName() As String
        Get
            Return _FileName
        End Get

    End Property

#End Region

    ''' <summary>
    ''' Delete the saved game file and initialize state info.
    ''' </summary>
    Sub Delete()
        If File.Exists(_FileName) Then
            File.Delete(_FileName)
        End If
        Me.LoadGame()

    End Sub

    ''' <summary>
    ''' Adds a puzzle ID to the list of solved puzzles
    ''' </summary>
    ''' <param name="puzzleID">The ID of the puzzle to add</param>
    Sub AddSolvedPuzzle(ByVal puzzleID As Integer)
        If Not _state.solved.Contains(puzzleID) Then
            _state.solved.Add(puzzleID)
        End If
    End Sub


End Class
