﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.1008
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("CodeLadder.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;GameML xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot; 
        '''  xsi:noNamespaceSchemaLocation=&quot;GameML.xsd&quot;
        '''  version=&quot;1&quot;&gt;
        '''  &lt;game name=&quot;CodeLadder&quot;&gt;
        '''    &lt;language&gt;CSharp&lt;/language&gt;
        '''    &lt;start&gt;1&lt;/start&gt;
        '''  &lt;/game&gt;
        '''
        '''   &lt;!--
        '''   CSharp Level 1
        '''   --&gt;
        '''  &lt;puzzle id=&quot;1&quot; level=&quot;1&quot;&gt;
        '''    &lt;description&gt;Fix the variable declaration in this broken function.&lt;/description&gt;
        '''    &lt;code entryPoint=&quot;Main&quot;&gt;
        '''      static int Main()
        '''      {
        '''        int p1 = 3,
        '''        return p1;
        '''      }
        '''      &lt;/code&gt;
        '''    &lt;resul [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property CSharp() As String
            Get
                Return ResourceManager.GetString("CSharp", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        '''&lt;xs:schema xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot; elementFormDefault=&quot;qualified&quot;&gt;
        '''  &lt;xs:element name=&quot;GameML&quot;&gt;
        '''    &lt;xs:complexType&gt;
        '''      &lt;xs:sequence&gt;
        '''        &lt;xs:element ref=&quot;game&quot;/&gt;
        '''        &lt;xs:element maxOccurs=&quot;unbounded&quot; ref=&quot;puzzle&quot;/&gt;
        '''      &lt;/xs:sequence&gt;
        '''      &lt;xs:attribute name=&quot;version&quot; use=&quot;required&quot; type=&quot;xs:integer&quot;/&gt;
        '''    &lt;/xs:complexType&gt;
        '''  &lt;/xs:element&gt;
        '''  &lt;xs:element name=&quot;game&quot;&gt;
        '''    &lt;xs:complexType&gt;
        '''      &lt;xs:sequence&gt;
        '''        &lt;xs:element ref=&quot;lang [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property GameML() As String
            Get
                Return ResourceManager.GetString("GameML", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;GameML xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot; 
        '''  xsi:noNamespaceSchemaLocation=&quot;GameML.xsd&quot;
        '''  version=&quot;1&quot;&gt;
        '''  &lt;game name=&quot;CodeLadder&quot;&gt;
        '''    &lt;start&gt;1&lt;/start&gt;   
        '''  &lt;/game&gt;
        '''
        '''   &lt;!--
        '''   VB Chapter 1
        '''   --&gt;
        '''  &lt;puzzle id=&quot;1&quot; level=&quot;1&quot;&gt;
        '''    &lt;description&gt;Fix the variable declaration in this broken function.&lt;/description&gt;
        '''    &lt;code&gt;
        '''      Public Function Puzzle() As Integer
        '''        Dim *intStrange As Integer = 3
        '''        Return *intStrange
        '''      End Function
        '''    &lt;/code&gt;
        '''    &lt;results&gt;
        ''' [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property VisualBasic() As String
            Get
                Return ResourceManager.GetString("VisualBasic", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
