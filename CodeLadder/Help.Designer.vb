<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.webHelp = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'webHelp
        '
        Me.webHelp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webHelp.Location = New System.Drawing.Point(0, 0)
        Me.webHelp.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webHelp.Name = "webHelp"
        Me.webHelp.Size = New System.Drawing.Size(654, 572)
        Me.webHelp.TabIndex = 0
        Me.webHelp.Url = New System.Uri("https://code.google.com/p/code-ladder/wiki/HelpOverview", System.UriKind.Absolute)
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 572)
        Me.Controls.Add(Me.webHelp)
        Me.Name = "Help"
        Me.Text = "Help"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents webHelp As System.Windows.Forms.WebBrowser
End Class
