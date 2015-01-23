Imports Microsoft.VisualBasic
Imports System.Text

''' <summary>
''' Compiles and assembles the code written by users in the Coding TextBox
''' </summary>
Public Class CompilerVisualBasic : Inherits Compiler

    Private _Provider As Microsoft.VisualBasic.VBCodeProvider
    Private _Code As StringBuilder
    Shadows disposed As Boolean = False

    Public Sub New()
        MyBase.New()
        _Provider = New VBCodeProvider
        _Code = New StringBuilder

        'References/Parameters.
        MyBase.CompilerParameters.ReferencedAssemblies.Add("System.Drawing.dll")
        MyBase.CompilerParameters.ReferencedAssemblies.Add("System.Windows.Forms.dll")
        MyBase.CompilerParameters.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")

        'Compiles in memory.
        MyBase.CompilerParameters.GenerateInMemory = True
    End Sub

    ''' <summary>
    ''' Returns the CodeProvider
    ''' </summary>
    ''' <returns>VBCodeProvider Reference</returns>
    ''' <remarks>This property must be implemented by classes derived from Compiler</remarks>
    Protected Friend Overrides ReadOnly Property Provider() As Object
        Get
            ClassDisposed()
            Return _Provider
        End Get
    End Property

    ''' <summary>
    ''' Defines standard code included before anything else when code is passed to the compiler.
    ''' </summary>
    ''' <returns>The stock header code</returns>
    Public Function HeaderCode() As String
        Dim s As New StringBuilder
        s.AppendLine("Option Strict On")
        s.AppendLine("Imports System.Windows.Forms")
        s.AppendLine("Imports System.Drawing")
        s.AppendLine("Imports Microsoft.VisualBasic")
        s.AppendLine("Imports Microsoft.VisualBasic.Constants")
        s.AppendLine("Imports Microsoft.VisualBasic.Information")
        s.AppendLine("Imports Microsoft.VisualBasic.Strings")
        s.AppendLine("Imports System.Random")
        s.AppendLine("Imports Microsoft.VisualBasic.VBMath")
        s.AppendLine("Namespace GeneratedNamespace")
        s.AppendLine("Class GeneratedMainClass")

        Return s.ToString
    End Function

    ''' <summary>
    ''' Defines standard code included after everything else when code is passed to the compiler.
    ''' </summary>
    ''' <returns>The stock footer code</returns>
    Public Function FooterCode() As String
        Dim s As New StringBuilder
        s.AppendLine("End Class")
        s.Append("End Namespace")
        Return s.ToString
    End Function

    ''' <summary>
    ''' Allows the game to insert the user entered code into the generated code template
    ''' </summary>
    ''' <value>The code supplied by the user / game.</value>
    ''' <returns>The entire set of code passed to the compiler</returns>
    Public Overrides Property Code As String
        Get
            Return _Code.ToString
        End Get
        Set(ByVal value As String)
            _Code.Append(value)
        End Set
    End Property


#Region "IDisposable Methods"
    Protected Overridable Overloads Sub Dispose(ByVal isDisposing As Boolean)
        If Not Me.disposed Then
            If isDisposing Then
                MyBase.Dispose(isDisposing)
                If _Provider IsNot Nothing Then
                    _Provider.Dispose()
                End If
            End If
            _Code = Nothing
        End If
        Me.disposed = True
    End Sub

#End Region


End Class
