<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CodeLadder
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.tabCode = New System.Windows.Forms.TabPage()
        Me.txtCodeBin = New System.Windows.Forms.TextBox()
        Me.tabLand = New System.Windows.Forms.TabPage()
        Me.btnEval = New System.Windows.Forms.Button()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblTalk = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.tabCode.SuspendLayout()
        Me.tabLand.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(12, 568)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(132, 33)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(631, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Score:"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(693, 9)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(87, 17)
        Me.lblScore.TabIndex = 22
        Me.lblScore.Text = "TotalScore"
        '
        'tabCode
        '
        Me.tabCode.Controls.Add(Me.txtCodeBin)
        Me.tabCode.Location = New System.Drawing.Point(4, 22)
        Me.tabCode.Name = "tabCode"
        Me.tabCode.Size = New System.Drawing.Size(765, 507)
        Me.tabCode.TabIndex = 2
        Me.tabCode.Text = "My Code Bin"
        Me.tabCode.UseVisualStyleBackColor = True
        '
        'txtCodeBin
        '
        Me.txtCodeBin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodeBin.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodeBin.Location = New System.Drawing.Point(12, 12)
        Me.txtCodeBin.Multiline = True
        Me.txtCodeBin.Name = "txtCodeBin"
        Me.txtCodeBin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCodeBin.Size = New System.Drawing.Size(746, 373)
        Me.txtCodeBin.TabIndex = 2
        '
        'tabLand
        '
        Me.tabLand.Controls.Add(Me.btnEval)
        Me.tabLand.Controls.Add(Me.lblDescription)
        Me.tabLand.Controls.Add(Me.txtCode)
        Me.tabLand.Controls.Add(Me.lblTalk)
        Me.tabLand.Controls.Add(Me.Label3)
        Me.tabLand.Controls.Add(Me.lblTitle)
        Me.tabLand.Location = New System.Drawing.Point(4, 22)
        Me.tabLand.Name = "tabLand"
        Me.tabLand.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLand.Size = New System.Drawing.Size(765, 507)
        Me.tabLand.TabIndex = 0
        Me.tabLand.Text = "Puzzles"
        Me.tabLand.UseVisualStyleBackColor = True
        '
        'btnEval
        '
        Me.btnEval.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEval.Location = New System.Drawing.Point(663, 25)
        Me.btnEval.Name = "btnEval"
        Me.btnEval.Size = New System.Drawing.Size(90, 25)
        Me.btnEval.TabIndex = 15
        Me.btnEval.Text = "Evaluate!"
        Me.btnEval.UseVisualStyleBackColor = True
        '
        'lblDescription
        '
        Me.lblDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(10, 3)
        Me.lblDescription.MaximumSize = New System.Drawing.Size(740, 35)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(49, 35)
        Me.lblDescription.TabIndex = 16
        Me.lblDescription.Text = "Hello" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "There!"
        '
        'txtCode
        '
        Me.txtCode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCode.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(13, 56)
        Me.txtCode.Multiline = True
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCode.Size = New System.Drawing.Size(740, 274)
        Me.txtCode.TabIndex = 5
        '
        'lblTalk
        '
        Me.lblTalk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTalk.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTalk.Location = New System.Drawing.Point(13, 350)
        Me.lblTalk.Name = "lblTalk"
        Me.lblTalk.Size = New System.Drawing.Size(736, 154)
        Me.lblTalk.TabIndex = 11
        Me.lblTalk.Text = "Hello"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Code"
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(10, 333)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(62, 17)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Results"
        '
        'tabMain
        '
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.Controls.Add(Me.tabLand)
        Me.tabMain.Controls.Add(Me.tabCode)
        Me.tabMain.Location = New System.Drawing.Point(12, 29)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(773, 533)
        Me.tabMain.TabIndex = 0
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNext.Location = New System.Drawing.Point(648, 568)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(132, 33)
        Me.btnNext.TabIndex = 23
        Me.btnNext.Text = "Next Challenge"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'CodeLadder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 613)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.tabMain)
        Me.Name = "CodeLadder"
        Me.Text = "Code Ladder"
        Me.tabCode.ResumeLayout(False)
        Me.tabCode.PerformLayout()
        Me.tabLand.ResumeLayout(False)
        Me.tabLand.PerformLayout()
        Me.tabMain.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents tabCode As System.Windows.Forms.TabPage
    Friend WithEvents txtCodeBin As System.Windows.Forms.TextBox
    Friend WithEvents tabLand As System.Windows.Forms.TabPage
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lblTalk As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnEval As System.Windows.Forms.Button
    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
End Class
