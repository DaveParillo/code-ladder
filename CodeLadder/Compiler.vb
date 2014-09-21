Imports System
Imports System.Text
Imports System.IO
Imports System.Reflection
Imports System.CodeDom.Compiler

''' <summary>
''' Compiles and assembles the code written by users in the Coding TextBox
''' </summary>
''' <remarks>CodeProvider is currently hard-coded to VBCodeProvider,
''' but this could be extended in the future.
''' </remarks>
Public MustInherit Class Compiler
    Implements IDisposable

    Protected disposed As Boolean = False   '  For IDisposable to detect redundant calls
    Private _CompilerErrors As CompilerErrorCollection

    Private _CompilerParams As New System.CodeDom.Compiler.CompilerParameters()
    Private _Code As StringBuilder
    Private _CommandText As String
    Private _Results As System.CodeDom.Compiler.CompilerResults

    Private _Instance As Object

    Protected Friend MustOverride ReadOnly Property Provider() As Object

    ''' <summary>
    ''' Allows the game to insert the user entered code into the generated code template
    ''' </summary>
    ''' <value>The code supplied by the user / game.</value>
    ''' <returns>The entire set of code passed to the compiler</returns>
    Public MustOverride Property Code As String

    Public Sub New()
        MyBase.New()
        _CompilerErrors = New CompilerErrorCollection
        _CompilerParams = New System.CodeDom.Compiler.CompilerParameters()

        'References/Parameters.
        _CompilerParams.ReferencedAssemblies.Clear()
        _CompilerParams.ReferencedAssemblies.Add("System.dll")

        'Compiles in memory.
        _CompilerParams.GenerateInMemory = True
    End Sub

    Public Overridable Property Errors As CompilerErrorCollection
        Get
            Return _CompilerErrors
        End Get
        Set(ByVal value As CompilerErrorCollection)
            _CompilerErrors = value
        End Set
    End Property

    Public Overridable Function WriteErrors() As String
        Dim e As CompilerError
        Dim sb As New StringBuilder
        For Each e In _CompilerErrors
            sb.AppendLine("Line:    " & e.Line - 6)
            sb.AppendLine("Text:    " & e.ErrorText)
            sb.AppendLine(String.Empty)

        Next
        Return sb.ToString
    End Function
    Public Overridable Property Command As String
        Get
            Return _CommandText
        End Get
        Set(ByVal value As String)
            _CommandText = Trim(value)
        End Set
    End Property


    Protected Friend Overridable ReadOnly Property CompilerParameters() As CompilerParameters
        Get
            Return _CompilerParams
        End Get
    End Property


    ''' <summary>
    ''' The Compile stage.
    ''' </summary>
    ''' <returns>True if Assembly was successful</returns>
    ''' <remarks>The results of compilation errors are promoted to the UI</remarks>
    Protected Friend Overridable Function Compile() As Boolean
        Dim retVal As Boolean = False
        ClassDisposed()
        Try
            If "CSharpCodeProvider" = TypeName(Provider) Then
                _CompilerParams.GenerateExecutable = True
            End If
            _Results = Provider.CompileAssemblyFromSource(Me.CompilerParameters, Me.Code.ToString)

            If _Results.Errors.HasErrors Then
                Me._CompilerErrors = _Results.Errors
            Else
                retVal = True
            End If
        Catch ex As Exception
            MessageBox.Show("Program Compiler Error!" _
                                & vbNewLine & vbNewLine _
                                & ex.Message)
        End Try
        Return retVal
    End Function

    ''' <summary>
    ''' The Assembly stage.
    ''' </summary>
    ''' <returns>True if Assembly was successful</returns>
    Protected Friend Overridable Function Link() As Boolean
        Dim retVal As Boolean = False
        Dim assy As System.Reflection.Assembly
        ClassDisposed()
        Try
            assy = _Results.CompiledAssembly
            _Instance = assy.CreateInstance("GeneratedNamespace.GeneratedMainClass")
            If _Instance Is Nothing Then
                MessageBox.Show("Can't load generated class...")
            Else
                retVal = True
            End If
        Catch ex As Exception
            MessageBox.Show("Program Assembly failure" _
                                & vbNewLine & vbNewLine _
                                & ex.Message)
        End Try

        Return retVal
    End Function

    ''' <summary>
    ''' Called by the game to evaluate the users code
    ''' </summary>
    ''' <param name="StartMethod">The function in the program to invoke</param>
    ''' <param name="Parameters">An array of parameters passed to StartMethod</param>
    ''' <returns>The return value from the called function</returns>
    Public Overridable Function Eval(ByVal StartMethod As String, ByVal Parameters() As Object) As Object
        Dim oType As Type
        Dim oInfo As MethodInfo
        Dim oRetVal As Object

        oRetVal = Nothing
        ClassDisposed()
        If Me.Compile() AndAlso Me.Link() Then
            ''Excute assembled code
            Try
                oType = _Instance.GetType
                If "CSharpCodeProvider" = TypeName(Provider) Then
                    oInfo = oType.GetMethod(StartMethod, BindingFlags.Static Or BindingFlags.NonPublic)
                Else
                    oInfo = oType.GetMethod(StartMethod)
                End If
                oRetVal = oInfo.Invoke(_Instance, Parameters)
            Catch ex As Exception
                MessageBox.Show("Program Runtime failure" _
                                & vbNewLine & vbNewLine _
                                & ex.Message)
            End Try
        Else
            'No output from comiler or assembler
        End If
        Return oRetVal
    End Function

#Region "IDisposable Support"

    ' IDisposable
    Protected Overridable Sub Dispose(isDisposing As Boolean)
        If Not Me.disposed Then
            If isDisposing Then
                ' All the managed resources are in subclasses
            End If
            _CompilerErrors = Nothing
            _CompilerParams = Nothing
            _Code = Nothing
            _CommandText = Nothing
            _Results = Nothing
            _Instance = Nothing
        End If
        Me.disposed = True
    End Sub

    ' Note: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    Protected Overrides Sub Finalize()
        Dispose(False)
        MyBase.Finalize()
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

    Public Sub ClassDisposed()
        If Me.disposed Then
            Throw New ObjectDisposedException(Me.GetType().ToString, "This object has been disposed.")
        End If
    End Sub


#End Region

End Class
