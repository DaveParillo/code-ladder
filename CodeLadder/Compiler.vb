Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.IO
Imports System.Reflection
Imports System.CodeDom.Compiler

''' <summary>
''' Compiles and assembles the code written by users in the Codeing TextBox
''' </summary>
''' <remarks>CodeProvider is currently hard-coded to VBCodeProvider,
''' but this could be extended in the future.
''' </remarks>
Public Class Compiler
    Private pCompilerErrors As CompilerErrorCollection

    Private pProvider As Microsoft.VisualBasic.VBCodeProvider
    Private pCompilerParams As New System.CodeDom.Compiler.CompilerParameters()
    Private pCodeText As StringBuilder
    Private pCommandText As String
    Private pResults As System.CodeDom.Compiler.CompilerResults
    Private pLinked As System.Reflection.Assembly
    Private pInstance As Object


    Public Sub New()
        MyBase.New()
        pCompilerErrors = New CompilerErrorCollection
        pProvider = New VBCodeProvider
        pCompilerParams = New System.CodeDom.Compiler.CompilerParameters()
        pCodeText = New StringBuilder

        'References/Parameters.
        pCompilerParams.ReferencedAssemblies.Clear()
        pCompilerParams.ReferencedAssemblies.Add("System.dll")
        pCompilerParams.ReferencedAssemblies.Add("System.Drawing.dll")
        pCompilerParams.ReferencedAssemblies.Add("System.Windows.Forms.dll")
        pCompilerParams.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")

        'Compiles in memory.
        pCompilerParams.GenerateInMemory = True
    End Sub

    Public Property Errors As CompilerErrorCollection
        Get
            Return pCompilerErrors
        End Get
        Set(ByVal value As CompilerErrorCollection)
            pCompilerErrors = value
        End Set
    End Property

    Public Function WriteErrors() As String
        Dim e As CompilerError
        Dim sb As New StringBuilder
        For Each e In pCompilerErrors
            sb.AppendLine("Line:    " & e.Line - 6)
            sb.AppendLine("Text:    " & e.ErrorText)
            sb.AppendLine(String.Empty)

        Next
        Return sb.ToString
    End Function
    Public Property Command As String
        Get
            Return pCommandText
        End Get
        Set(ByVal value As String)
            pCommandText = Trim(value)
        End Set
    End Property

    ''' <summary>
    ''' Allows the game to insert the user entered code into the generated code template
    ''' </summary>
    ''' <value>The code supplied by the user / game.</value>
    ''' <returns>The entire set of code passed to the compiler</returns>
    Public Property Text As String
        Get
            Return pCodeText.ToString
        End Get
        Set(ByVal value As String)
            pCodeText.AppendLine("Option Strict On")
            pCodeText.AppendLine("Imports System.Windows.Forms")
            pCodeText.AppendLine("Imports System.Drawing")
            pCodeText.AppendLine("Imports Microsoft.VisualBasic.Constants")
            pCodeText.AppendLine("Imports Microsoft.VisualBasic.Information")
            pCodeText.AppendLine("Imports Microsoft.VisualBasic.Strings")
            pCodeText.AppendLine("Imports System.Random")
            pCodeText.AppendLine("Imports Microsoft.VisualBasic.VBMath")
            pCodeText.AppendLine("Namespace GeneratedNamespace")
            pCodeText.AppendLine("Class GeneratedMainClass")

            pCodeText.AppendLine(value)

            pCodeText.AppendLine("End Class")
            pCodeText.AppendLine("End Namespace")
        End Set
    End Property

    ''' <summary>
    ''' The Compile stage.
    ''' </summary>
    ''' <returns>True if Assembly was successful</returns>
    ''' <remarks>The results of compilation errors are promoted to the UI</remarks>
    Private Function Compile() As Boolean
        Dim retVal As Boolean = True
        Try
            pResults = pProvider.CompileAssemblyFromSource(pCompilerParams, pCodeText.ToString)

            If pResults.Errors.HasErrors Then
                Me.pCompilerErrors = pResults.Errors
                retVal = False
            End If
        Catch ex As Exception
            MessageBox.Show("Compiler Error attempting to Compile!" _
                                & vbNewLine & vbNewLine _
                                & ex.Message)
            Stop
        End Try
        Return retVal
    End Function

    ''' <summary>
    ''' The Assembly stage.
    ''' </summary>
    ''' <returns>True if Assembly was successful</returns>
    Private Function Link() As Boolean
        Dim retVal As Boolean = True
        pLinked = pResults.CompiledAssembly

        pInstance = pLinked.CreateInstance("GeneratedNamespace.GeneratedMainClass")
        If pInstance Is Nothing Then
            MessageBox.Show("Can't load generated class...")
            retVal = False
        End If
        Return retVal
    End Function

    ''' <summary>
    ''' Called by the game to evaluate the users code
    ''' </summary>
    ''' <param name="StartMethod">The function in the program to invoke</param>
    ''' <param name="Parameters">An array of parameters passed to StartMethod</param>
    ''' <returns>The return value from the called function</returns>
    Public Function Eval(ByVal StartMethod As String, ByVal Parameters() As Object) As Object
        Dim oType As Type
        Dim oInfo As MethodInfo
        Dim oRetVal As Object

        oRetVal = Nothing
        If Me.Compile() AndAlso Me.Link() Then
            ''Excute assembled code
            Try
                oType = pInstance.GetType
                oInfo = oType.GetMethod(StartMethod)
                oRetVal = oInfo.Invoke(pInstance, Parameters)
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

End Class
