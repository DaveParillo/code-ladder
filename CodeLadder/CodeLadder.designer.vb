﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.tabCodeBin = New System.Windows.Forms.TabPage()
        Me.txtCodeBin = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.tabPuzzle = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtTalk = New System.Windows.Forms.TextBox()
        Me.grpFooter = New System.Windows.Forms.GroupBox()
        Me.txtFooter = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCode = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.grpHeader = New System.Windows.Forms.GroupBox()
        Me.txtHeader = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.linkHelp = New System.Windows.Forms.LinkLabel()
        Me.chkShowAllCode = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEval = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabAllCode = New System.Windows.Forms.TabPage()
        Me.txtAllCode = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsingCodeLadderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutCodeLadderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnTextBigger = New System.Windows.Forms.Button()
        Me.btnTextSmaller = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tabCodeBin.SuspendLayout()
        CType(Me.txtCodeBin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPuzzle.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.grpFooter.SuspendLayout()
        CType(Me.txtFooter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpHeader.SuspendLayout()
        CType(Me.txtHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.tabAllCode.SuspendLayout()
        CType(Me.txtAllCode, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'tabCodeBin
        '
        Me.tabCodeBin.Controls.Add(Me.txtCodeBin)
        Me.tabCodeBin.Location = New System.Drawing.Point(4, 25)
        Me.tabCodeBin.Name = "tabCodeBin"
        Me.tabCodeBin.Size = New System.Drawing.Size(678, 582)
        Me.tabCodeBin.TabIndex = 2
        Me.tabCodeBin.Text = "My Code Bin"
        Me.tabCodeBin.UseVisualStyleBackColor = True
        '
        'txtCodeBin
        '
        Me.txtCodeBin.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.txtCodeBin.AutoIndentCharsPatterns = "" & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*[\w\.\(\)]+\s*(?<range>=)\s*(?<range>.+)" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtCodeBin.AutoScrollMinSize = New System.Drawing.Size(2, 16)
        Me.txtCodeBin.BackBrush = Nothing
        Me.txtCodeBin.CharHeight = 16
        Me.txtCodeBin.CharWidth = 8
        Me.txtCodeBin.CommentPrefix = "'"
        Me.txtCodeBin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodeBin.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.txtCodeBin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCodeBin.Font = New System.Drawing.Font("Consolas", 10.75!)
        Me.txtCodeBin.IsReplaceMode = False
        Me.txtCodeBin.Language = FastColoredTextBoxNS.Language.VB
        Me.txtCodeBin.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.txtCodeBin.Location = New System.Drawing.Point(0, 0)
        Me.txtCodeBin.Name = "txtCodeBin"
        Me.txtCodeBin.Paddings = New System.Windows.Forms.Padding(0)
        Me.txtCodeBin.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.txtCodeBin.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCodeBin.Size = New System.Drawing.Size(678, 582)
        Me.txtCodeBin.TabIndex = 2
        Me.txtCodeBin.Zoom = 100
        '
        'tabPuzzle
        '
        Me.tabPuzzle.Controls.Add(Me.TableLayoutPanel1)
        Me.tabPuzzle.Location = New System.Drawing.Point(4, 25)
        Me.tabPuzzle.Name = "tabPuzzle"
        Me.tabPuzzle.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPuzzle.Size = New System.Drawing.Size(678, 582)
        Me.tabPuzzle.TabIndex = 0
        Me.tabPuzzle.Text = "Puzzles"
        Me.tabPuzzle.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtDescription, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox4, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.grpFooter, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.grpHeader, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(672, 576)
        Me.TableLayoutPanel1.TabIndex = 24
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(3, 3)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(666, 66)
        Me.txtDescription.TabIndex = 25
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtTalk)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(3, 450)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(666, 123)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Results"
        '
        'txtTalk
        '
        Me.txtTalk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTalk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTalk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTalk.Location = New System.Drawing.Point(3, 19)
        Me.txtTalk.Multiline = True
        Me.txtTalk.Name = "txtTalk"
        Me.txtTalk.ReadOnly = True
        Me.txtTalk.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTalk.Size = New System.Drawing.Size(660, 101)
        Me.txtTalk.TabIndex = 20
        '
        'grpFooter
        '
        Me.grpFooter.Controls.Add(Me.txtFooter)
        Me.grpFooter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpFooter.Location = New System.Drawing.Point(3, 370)
        Me.grpFooter.Name = "grpFooter"
        Me.grpFooter.Size = New System.Drawing.Size(666, 74)
        Me.grpFooter.TabIndex = 7
        Me.grpFooter.TabStop = False
        Me.grpFooter.Text = "Footer"
        Me.grpFooter.Visible = False
        '
        'txtFooter
        '
        Me.txtFooter.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.txtFooter.AutoIndentCharsPatterns = "" & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*[\w\.\(\)]+\s*(?<range>=)\s*(?<range>.+)" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtFooter.AutoScrollMinSize = New System.Drawing.Size(2, 15)
        Me.txtFooter.BackBrush = Nothing
        Me.txtFooter.BackColor = System.Drawing.SystemColors.Control
        Me.txtFooter.CharHeight = 15
        Me.txtFooter.CharWidth = 7
        Me.txtFooter.CommentPrefix = "'"
        Me.txtFooter.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFooter.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.txtFooter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFooter.Font = New System.Drawing.Font("Consolas", 9.75!)
        Me.txtFooter.IsReplaceMode = False
        Me.txtFooter.Language = FastColoredTextBoxNS.Language.VB
        Me.txtFooter.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.txtFooter.Location = New System.Drawing.Point(3, 19)
        Me.txtFooter.Name = "txtFooter"
        Me.txtFooter.Paddings = New System.Windows.Forms.Padding(0)
        Me.txtFooter.ReadOnly = True
        Me.txtFooter.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.txtFooter.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFooter.Size = New System.Drawing.Size(660, 52)
        Me.txtFooter.TabIndex = 25
        Me.txtFooter.Zoom = 100
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCode)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(666, 186)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Your Code"
        '
        'txtCode
        '
        Me.txtCode.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.txtCode.AutoIndentCharsPatterns = "" & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*[\w\.\(\)]+\s*(?<range>=)\s*(?<range>.+)" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtCode.AutoScrollMinSize = New System.Drawing.Size(25, 15)
        Me.txtCode.BackBrush = Nothing
        Me.txtCode.CharHeight = 15
        Me.txtCode.CharWidth = 7
        Me.txtCode.CommentPrefix = "'"
        Me.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCode.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.txtCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCode.Font = New System.Drawing.Font("Consolas", 9.75!)
        Me.txtCode.IsReplaceMode = False
        Me.txtCode.Language = FastColoredTextBoxNS.Language.VB
        Me.txtCode.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.txtCode.Location = New System.Drawing.Point(3, 19)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Paddings = New System.Windows.Forms.Padding(0)
        Me.txtCode.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.txtCode.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCode.Size = New System.Drawing.Size(660, 164)
        Me.txtCode.TabIndex = 24
        Me.txtCode.Zoom = 100
        '
        'grpHeader
        '
        Me.grpHeader.Controls.Add(Me.txtHeader)
        Me.grpHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHeader.Location = New System.Drawing.Point(3, 108)
        Me.grpHeader.Name = "grpHeader"
        Me.grpHeader.Size = New System.Drawing.Size(666, 64)
        Me.grpHeader.TabIndex = 5
        Me.grpHeader.TabStop = False
        Me.grpHeader.Text = "Header"
        Me.grpHeader.Visible = False
        '
        'txtHeader
        '
        Me.txtHeader.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.txtHeader.AutoIndentCharsPatterns = "" & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*[\w\.\(\)]+\s*(?<range>=)\s*(?<range>.+)" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtHeader.AutoScrollMinSize = New System.Drawing.Size(25, 15)
        Me.txtHeader.BackBrush = Nothing
        Me.txtHeader.BackColor = System.Drawing.SystemColors.Control
        Me.txtHeader.CharHeight = 15
        Me.txtHeader.CharWidth = 7
        Me.txtHeader.CommentPrefix = "'"
        Me.txtHeader.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHeader.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.txtHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtHeader.Font = New System.Drawing.Font("Consolas", 9.75!)
        Me.txtHeader.IsReplaceMode = False
        Me.txtHeader.Language = FastColoredTextBoxNS.Language.VB
        Me.txtHeader.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.txtHeader.Location = New System.Drawing.Point(3, 19)
        Me.txtHeader.Name = "txtHeader"
        Me.txtHeader.Paddings = New System.Windows.Forms.Padding(0)
        Me.txtHeader.ReadOnly = True
        Me.txtHeader.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.txtHeader.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHeader.Size = New System.Drawing.Size(660, 42)
        Me.txtHeader.TabIndex = 25
        Me.txtHeader.Zoom = 100
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.linkHelp)
        Me.Panel1.Controls.Add(Me.chkShowAllCode)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(666, 27)
        Me.Panel1.TabIndex = 9
        '
        'linkHelp
        '
        Me.linkHelp.AutoSize = True
        Me.linkHelp.Location = New System.Drawing.Point(493, 4)
        Me.linkHelp.Name = "linkHelp"
        Me.linkHelp.Size = New System.Drawing.Size(147, 17)
        Me.linkHelp.TabIndex = 27
        Me.linkHelp.TabStop = True
        Me.linkHelp.Text = "Question specific help"
        Me.ToolTip1.SetToolTip(Me.linkHelp, "Opens a new web page")
        '
        'chkShowAllCode
        '
        Me.chkShowAllCode.AutoSize = True
        Me.chkShowAllCode.Location = New System.Drawing.Point(74, 3)
        Me.chkShowAllCode.Name = "chkShowAllCode"
        Me.chkShowAllCode.Size = New System.Drawing.Size(80, 21)
        Me.chkShowAllCode.TabIndex = 12
        Me.chkShowAllCode.Text = "Show All"
        Me.chkShowAllCode.UseVisualStyleBackColor = True
        Me.chkShowAllCode.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Code"
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
        Me.tabMain.Controls.Add(Me.tabPuzzle)
        Me.tabMain.Controls.Add(Me.tabCodeBin)
        Me.tabMain.Controls.Add(Me.tabAllCode)
        Me.tabMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMain.Location = New System.Drawing.Point(12, 63)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(686, 611)
        Me.tabMain.TabIndex = 5
        '
        'tabAllCode
        '
        Me.tabAllCode.Controls.Add(Me.txtAllCode)
        Me.tabAllCode.Location = New System.Drawing.Point(4, 25)
        Me.tabAllCode.Name = "tabAllCode"
        Me.tabAllCode.Size = New System.Drawing.Size(678, 582)
        Me.tabAllCode.TabIndex = 3
        Me.tabAllCode.Text = "All Code"
        Me.tabAllCode.UseVisualStyleBackColor = True
        '
        'txtAllCode
        '
        Me.txtAllCode.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.txtAllCode.AutoIndentCharsPatterns = "" & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*[\w\.\(\)]+\s*(?<range>=)\s*(?<range>.+)" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtAllCode.AutoScrollMinSize = New System.Drawing.Size(2, 16)
        Me.txtAllCode.BackBrush = Nothing
        Me.txtAllCode.CharHeight = 16
        Me.txtAllCode.CharWidth = 8
        Me.txtAllCode.CommentPrefix = "'"
        Me.txtAllCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAllCode.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.txtAllCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAllCode.Font = New System.Drawing.Font("Consolas", 10.75!)
        Me.txtAllCode.IsReplaceMode = False
        Me.txtAllCode.Language = FastColoredTextBoxNS.Language.VB
        Me.txtAllCode.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.txtAllCode.Location = New System.Drawing.Point(0, 0)
        Me.txtAllCode.Name = "txtAllCode"
        Me.txtAllCode.Paddings = New System.Windows.Forms.Padding(0)
        Me.txtAllCode.ReadOnly = True
        Me.txtAllCode.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.txtAllCode.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAllCode.Size = New System.Drawing.Size(678, 582)
        Me.txtAllCode.TabIndex = 3
        Me.txtAllCode.Zoom = 100
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
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "&New Lab"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsingCodeLadderToolStripMenuItem, Me.AboutCodeLadderToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'UsingCodeLadderToolStripMenuItem
        '
        Me.UsingCodeLadderToolStripMenuItem.Name = "UsingCodeLadderToolStripMenuItem"
        Me.UsingCodeLadderToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.UsingCodeLadderToolStripMenuItem.Text = "&Open Help"
        '
        'AboutCodeLadderToolStripMenuItem
        '
        Me.AboutCodeLadderToolStripMenuItem.Name = "AboutCodeLadderToolStripMenuItem"
        Me.AboutCodeLadderToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.AboutCodeLadderToolStripMenuItem.Text = "&About Code Ladder"
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
        Me.ToolTip1.SetToolTip(Me.btnTextBigger, "Make Text bigger")
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
        Me.ToolTip1.SetToolTip(Me.btnTextSmaller, "Make text smaller")
        Me.btnTextSmaller.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(709, 24)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CodeLadder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 686)
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
        Me.tabCodeBin.ResumeLayout(False)
        CType(Me.txtCodeBin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPuzzle.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.grpFooter.ResumeLayout(False)
        CType(Me.txtFooter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpHeader.ResumeLayout(False)
        CType(Me.txtHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tabMain.ResumeLayout(False)
        Me.tabAllCode.ResumeLayout(False)
        CType(Me.txtAllCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents tabCodeBin As System.Windows.Forms.TabPage
    Friend WithEvents txtCodeBin As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents tabPuzzle As System.Windows.Forms.TabPage
    Friend WithEvents btnEval As System.Windows.Forms.Button
    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTalk As System.Windows.Forms.TextBox
    Friend WithEvents grpFooter As System.Windows.Forms.GroupBox
    Friend WithEvents txtFooter As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCode As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents grpHeader As System.Windows.Forms.GroupBox
    Friend WithEvents txtHeader As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents chkShowAllCode As System.Windows.Forms.CheckBox
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsingCodeLadderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutCodeLadderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabAllCode As System.Windows.Forms.TabPage
    Friend WithEvents txtAllCode As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents linkHelp As System.Windows.Forms.LinkLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
End Class
