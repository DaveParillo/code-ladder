Imports Microsoft.VisualBasic
Imports System.Text

''' <summary>
''' Compiles and assembles the code written by users in the Coding TextBox
''' </summary>
''' <remarks>CodeProvider is currently hard-coded to VBCodeProvider,
''' but this could be extended in the future.
''' </remarks>
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
    ''' Allows the game to insert the user entered code into the generated code template
    ''' </summary>
    ''' <value>The code supplied by the user / game.</value>
    ''' <returns>The entire set of code passed to the compiler</returns>
    Public Overrides Property Code As String
        Get
            Return _Code.ToString
        End Get
        Set(ByVal value As String)
            _Code.AppendLine("Option Strict On")
            _Code.AppendLine("Imports System.Windows.Forms")
            _Code.AppendLine("Imports System.Drawing")
            _Code.AppendLine("Imports Microsoft.VisualBasic")
            _Code.AppendLine("Imports Microsoft.VisualBasic.Constants")
            _Code.AppendLine("Imports Microsoft.VisualBasic.Information")
            _Code.AppendLine("Imports Microsoft.VisualBasic.Strings")
            _Code.AppendLine("Imports System.Random")
            _Code.AppendLine("Imports Microsoft.VisualBasic.VBMath")
            _Code.AppendLine("Namespace GeneratedNamespace")
            _Code.AppendLine("Class GeneratedMainClass")

            _Code.AppendLine(value)

            _Code.AppendLine("End Class")
            _Code.AppendLine("End Namespace")
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
