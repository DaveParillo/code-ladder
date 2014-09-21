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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CodeLadder))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.tabCode = New System.Windows.Forms.TabPage()
        Me.txtCodeBin = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.pagePuzzle = New System.Windows.Forms.TabPage()
        Me.txtCode = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtTalk = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnEval = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnTextBigger = New System.Windows.Forms.Button()
        Me.btnTextSmaller = New System.Windows.Forms.Button()
        Me.tabCode.SuspendLayout()
        CType(Me.txtCodeBin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagePuzzle.SuspendLayout()
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(538, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Score:"
        '
        'lblScore
        '
        Me.lblScore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(599, 24)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(35, 17)
        Me.lblScore.TabIndex = 22
        Me.lblScore.Text = "999"
        '
        'tabCode
        '
        Me.tabCode.Controls.Add(Me.txtCodeBin)
        Me.tabCode.Location = New System.Drawing.Point(4, 25)
        Me.tabCode.Name = "tabCode"
        Me.tabCode.Size = New System.Drawing.Size(678, 466)
        Me.tabCode.TabIndex = 2
        Me.tabCode.Text = "My Code Bin"
        Me.tabCode.UseVisualStyleBackColor = True
        '
        'txtCodeBin
        '
        Me.txtCodeBin.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.txtCodeBin.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.txtCodeBin.BackBrush = Nothing
        Me.txtCodeBin.CharHeight = 16
        Me.txtCodeBin.CharWidth = 9
        Me.txtCodeBin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodeBin.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.txtCodeBin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCodeBin.Font = New System.Drawing.Font("Consolas", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodeBin.IsReplaceMode = False
        Me.txtCodeBin.Language = FastColoredTextBoxNS.Language.VB
        Me.txtCodeBin.Location = New System.Drawing.Point(0, 0)
        Me.txtCodeBin.Name = "txtCodeBin"
        Me.txtCodeBin.Paddings = New System.Windows.Forms.Padding(0)
        Me.txtCodeBin.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCodeBin.Size = New System.Drawing.Size(678, 466)
        Me.txtCodeBin.TabIndex = 2
        Me.txtCodeBin.Zoom = 100
        '
        'pagePuzzle
        '
        Me.pagePuzzle.Controls.Add(Me.txtCode)
        Me.pagePuzzle.Controls.Add(Me.txtDescription)
        Me.pagePuzzle.Controls.Add(Me.txtTalk)
        Me.pagePuzzle.Controls.Add(Me.Label3)
        Me.pagePuzzle.Controls.Add(Me.lblTitle)
        Me.pagePuzzle.Location = New System.Drawing.Point(4, 25)
        Me.pagePuzzle.Name = "pagePuzzle"
        Me.pagePuzzle.Padding = New System.Windows.Forms.Padding(3)
        Me.pagePuzzle.Size = New System.Drawing.Size(678, 466)
        Me.pagePuzzle.TabIndex = 0
        Me.pagePuzzle.Text = "Puzzles"
        Me.pagePuzzle.UseVisualStyleBackColor = True
        '
        'txtCode
        '
        Me.txtCode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCode.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.txtCode.AutoIndentCharsPatterns = "" & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*[\w\.\(\)]+\s*(?<range>=)\s*(?<range>.+)" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtCode.AutoScrollMinSize = New System.Drawing.Size(27, 14)
        Me.txtCode.BackBrush = Nothing
        Me.txtCode.CharHeight = 14
        Me.txtCode.CharWidth = 8
        Me.txtCode.CommentPrefix = "'"
        Me.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCode.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.txtCode.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.IsReplaceMode = False
        Me.txtCode.Language = FastColoredTextBoxNS.Language.VB
        Me.txtCode.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.txtCode.Location = New System.Drawing.Point(6, 95)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Paddings = New System.Windows.Forms.Padding(0)
        Me.txtCode.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.txtCode.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCode.Size = New System.Drawing.Size(666, 194)
        Me.txtCode.TabIndex = 21
        Me.txtCode.Zoom = 100
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(6, 6)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(669, 66)
        Me.txtDescription.TabIndex = 20
        '
        'txtTalk
        '
        Me.txtTalk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTalk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTalk.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTalk.Location = New System.Drawing.Point(6, 314)
        Me.txtTalk.Multiline = True
        Me.txtTalk.Name = "txtTalk"
        Me.txtTalk.ReadOnly = True
        Me.txtTalk.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTalk.Size = New System.Drawing.Size(666, 142)
        Me.txtTalk.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 75)
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
        Me.lblTitle.Location = New System.Drawing.Point(8, 292)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(62, 17)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Results"
        '
        'btnEval
        '
        Me.btnEval.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEval.Location = New System.Drawing.Point(74, 27)
        Me.btnEval.Name = "btnEval"
        Me.btnEval.Size = New System.Drawing.Size(90, 30)
        Me.btnEval.TabIndex = 1
        Me.btnEval.Text = "Evaluate!"
        Me.ToolTip1.SetToolTip(Me.btnEval, "Compile and evaluate your code")
        Me.btnEval.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnNext.Location = New System.Drawing.Point(170, 27)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(25, 30)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "4"
        Me.ToolTip1.SetToolTip(Me.btnNext, "Advance to the next problem")
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'tabMain
        '
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.Controls.Add(Me.pagePuzzle)
        Me.tabMain.Controls.Add(Me.tabCode)
        Me.tabMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMain.Location = New System.Drawing.Point(12, 63)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(686, 495)
        Me.tabMain.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(640, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "of"
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(668, 24)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(35, 17)
        Me.lblTotal.TabIndex = 25
        Me.lblTotal.Text = "999"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(709, 24)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.NewGameToolStripMenuItem.Text = "&New Game"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreferencesToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'PreferencesToolStripMenuItem
        '
        Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
        Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.PreferencesToolStripMenuItem.Text = "&Preferences"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistoryToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.HistoryToolStripMenuItem.Text = "History"
        '
        'btnPrev
        '
        Me.btnPrev.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnPrev.Location = New System.Drawing.Point(43, 27)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(25, 30)
        Me.btnPrev.TabIndex = 6
        Me.btnPrev.Text = "3"
        Me.ToolTip1.SetToolTip(Me.btnPrev, "Go back to the previous problem")
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnFirst.Location = New System.Drawing.Point(12, 27)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(30, 30)
        Me.btnFirst.TabIndex = 7
        Me.btnFirst.Text = "9"
        Me.ToolTip1.SetToolTip(Me.btnFirst, "Rewind to the first problem")
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnLast.Location = New System.Drawing.Point(196, 27)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(30, 30)
        Me.btnLast.TabIndex = 3
        Me.btnLast.Text = ":"
        Me.ToolTip1.SetToolTip(Me.btnLast, "Skip to the last problem")
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnTextBigger
        '
        Me.btnTextBigger.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTextBigger.Location = New System.Drawing.Point(246, 27)
        Me.btnTextBigger.Name = "btnTextBigger"
        Me.btnTextBigger.Size = New System.Drawing.Size(30, 30)
        Me.btnTextBigger.TabIndex = 19
        Me.btnTextBigger.Tag = "+1"
        Me.btnTextBigger.Text = "A"
        Me.btnTextBigger.UseVisualStyleBackColor = True
        '
        'btnTextSmaller
        '
        Me.btnTextSmaller.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTextSmaller.Location = New System.Drawing.Point(281, 27)
        Me.btnTextSmaller.Name = "btnTextSmaller"
        Me.btnTextSmaller.Size = New System.Drawing.Size(30, 30)
        Me.btnTextSmaller.TabIndex = 20
        Me.btnTextSmaller.Tag = "-1"
        Me.btnTextSmaller.Text = "A"
        Me.btnTextSmaller.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTextSmaller.UseVisualStyleBackColor = True
        '
        'CodeLadder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 570)
        Me.Controls.Add(Me.btnTextSmaller)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnTextBigger)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnEval)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(500, 39)
        Me.Name = "CodeLadder"
        Me.Text = "Code Ladder"
        Me.tabCode.ResumeLayout(False)
        CType(Me.txtCodeBin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagePuzzle.ResumeLayout(False)
        Me.pagePuzzle.PerformLayout()
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents tabCode As System.Windows.Forms.TabPage
    Friend WithEvents txtCodeBin As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents pagePuzzle As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnEval As System.Windows.Forms.Button
    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreferencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnTextBigger As System.Windows.Forms.Button
    Friend WithEvents btnTextSmaller As System.Windows.Forms.Button
    Friend WithEvents txtTalk As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
