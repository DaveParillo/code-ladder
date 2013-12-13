Imports Microsoft.CSharp
Imports System.Text


''' <summary>
''' Compiles and assembles the code written by users in the Coding TextBox
''' </summary>
''' <remarks>CodeProvider is currently hard-coded to VBCodeProvider,
''' but this could be extended in the future.
''' </remarks>
Public Class CompilerCSharp : Inherits Compiler

    Private _Provider As Microsoft.CSharp.CSharpCodeProvider
    Private _Code As StringBuilder

    Public Sub New()
        MyBase.New()
        _Provider = New CSharpCodeProvider
        _Code = New StringBuilder

        'References/Parameters.
        MyBase.CompilerParameters.ReferencedAssemblies.Add("Microsoft.CSharp.dll")

    End Sub

    ''' <summary>
    ''' Returns the CodeProvider
    ''' </summary>
    ''' <returns>VBCodeProvider Reference</returns>
    ''' <remarks>This property must be implemented by classes derived from Compiler</remarks>
    Protected Friend Overrides ReadOnly Property Provider() As Object
        Get
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
            _Code.AppendLine("namespace GeneratedNamespace")
            _Code.AppendLine("{")
            _Code.AppendLine("using System;")
            _Code.AppendLine("class GeneratedMainClass")
            _Code.AppendLine("{")

            _Code.AppendLine(value)

            _Code.AppendLine("} // End Class")
            _Code.AppendLine("} // End Namespace")
        End Set
    End Property


End Class
