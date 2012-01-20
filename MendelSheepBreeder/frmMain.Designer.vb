<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tblMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tblParents = New System.Windows.Forms.TableLayoutPanel()
        Me.pctParent2 = New System.Windows.Forms.PictureBox()
        Me.pctParent1 = New System.Windows.Forms.PictureBox()
        Me.pnlParentsGenomeP2 = New System.Windows.Forms.Panel()
        Me.tblParentsGenomeP2 = New System.Windows.Forms.TableLayoutPanel()
        Me.nmrParentsGenome2Hue2 = New System.Windows.Forms.NumericUpDown()
        Me.nmrParentsGenome2Hue1 = New System.Windows.Forms.NumericUpDown()
        Me.nmrParentsGenome2Lightness2 = New System.Windows.Forms.NumericUpDown()
        Me.nmrParentsGenome2Lightness1 = New System.Windows.Forms.NumericUpDown()
        Me.nmrParentsGenome2Colourness2 = New System.Windows.Forms.NumericUpDown()
        Me.nmrParentsGenome2Colourness1 = New System.Windows.Forms.NumericUpDown()
        Me.nmrParentsGenome2Naturalness2 = New System.Windows.Forms.NumericUpDown()
        Me.lblParentsGenomeP2Naturalness = New System.Windows.Forms.Label()
        Me.lblParentsGenomeP2Colourness = New System.Windows.Forms.Label()
        Me.lblParentsGenomeP2Lightness = New System.Windows.Forms.Label()
        Me.lblParentsGenomeP2Hue = New System.Windows.Forms.Label()
        Me.nmrParentsGenome2Naturalness1 = New System.Windows.Forms.NumericUpDown()
        Me.pnlParentsGenomeP1 = New System.Windows.Forms.Panel()
        Me.tblParentsGenomeP1 = New System.Windows.Forms.TableLayoutPanel()
        Me.nmrParentsGenome1Lightness2 = New System.Windows.Forms.NumericUpDown()
        Me.nmrParentsGenome1Lightness1 = New System.Windows.Forms.NumericUpDown()
        Me.nmrParentsGenome1Hue2 = New System.Windows.Forms.NumericUpDown()
        Me.nmrParentsGenome1Hue1 = New System.Windows.Forms.NumericUpDown()
        Me.lblParentsGenomeP1Naturalness = New System.Windows.Forms.Label()
        Me.lblParentsGenomeP1Colourness = New System.Windows.Forms.Label()
        Me.lblParentsGenomeP1Lightness = New System.Windows.Forms.Label()
        Me.lblParentsGenomeP1Hue = New System.Windows.Forms.Label()
        Me.nmrParentsGenome1Colourness1 = New System.Windows.Forms.NumericUpDown()
        Me.nmrParentsGenome1Naturalness1 = New System.Windows.Forms.NumericUpDown()
        Me.nmrParentsGenome1Naturalness2 = New System.Windows.Forms.NumericUpDown()
        Me.nmrParentsGenome1Colourness2 = New System.Windows.Forms.NumericUpDown()
        Me.flwChildrenOutput = New System.Windows.Forms.FlowLayoutPanel()
        Me.tblMain.SuspendLayout()
        Me.tblParents.SuspendLayout()
        CType(Me.pctParent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctParent1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlParentsGenomeP2.SuspendLayout()
        Me.tblParentsGenomeP2.SuspendLayout()
        CType(Me.nmrParentsGenome2Hue2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrParentsGenome2Hue1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrParentsGenome2Lightness2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrParentsGenome2Lightness1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrParentsGenome2Colourness2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrParentsGenome2Colourness1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrParentsGenome2Naturalness2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrParentsGenome2Naturalness1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlParentsGenomeP1.SuspendLayout()
        Me.tblParentsGenomeP1.SuspendLayout()
        CType(Me.nmrParentsGenome1Lightness2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrParentsGenome1Lightness1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrParentsGenome1Hue2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrParentsGenome1Hue1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrParentsGenome1Colourness1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrParentsGenome1Naturalness1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrParentsGenome1Naturalness2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrParentsGenome1Colourness2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblMain
        '
        Me.tblMain.ColumnCount = 2
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.51282!))
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.48718!))
        Me.tblMain.Controls.Add(Me.tblParents, 0, 0)
        Me.tblMain.Controls.Add(Me.flwChildrenOutput, 0, 1)
        Me.tblMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblMain.Location = New System.Drawing.Point(0, 0)
        Me.tblMain.Name = "tblMain"
        Me.tblMain.RowCount = 2
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblMain.Size = New System.Drawing.Size(936, 568)
        Me.tblMain.TabIndex = 0
        '
        'tblParents
        '
        Me.tblParents.ColumnCount = 2
        Me.tblParents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblParents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblParents.Controls.Add(Me.pctParent2, 1, 0)
        Me.tblParents.Controls.Add(Me.pctParent1, 0, 0)
        Me.tblParents.Controls.Add(Me.pnlParentsGenomeP2, 1, 1)
        Me.tblParents.Controls.Add(Me.pnlParentsGenomeP1, 0, 1)
        Me.tblParents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblParents.Location = New System.Drawing.Point(3, 3)
        Me.tblParents.Name = "tblParents"
        Me.tblParents.RowCount = 2
        Me.tblParents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.15108!))
        Me.tblParents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.84892!))
        Me.tblParents.Size = New System.Drawing.Size(653, 278)
        Me.tblParents.TabIndex = 0
        '
        'pctParent2
        '
        Me.pctParent2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pctParent2.Location = New System.Drawing.Point(329, 3)
        Me.pctParent2.Name = "pctParent2"
        Me.pctParent2.Size = New System.Drawing.Size(321, 164)
        Me.pctParent2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctParent2.TabIndex = 4
        Me.pctParent2.TabStop = False
        '
        'pctParent1
        '
        Me.pctParent1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pctParent1.Location = New System.Drawing.Point(3, 3)
        Me.pctParent1.Name = "pctParent1"
        Me.pctParent1.Size = New System.Drawing.Size(320, 164)
        Me.pctParent1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctParent1.TabIndex = 1
        Me.pctParent1.TabStop = False
        '
        'pnlParentsGenomeP2
        '
        Me.pnlParentsGenomeP2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlParentsGenomeP2.Controls.Add(Me.tblParentsGenomeP2)
        Me.pnlParentsGenomeP2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlParentsGenomeP2.Location = New System.Drawing.Point(329, 173)
        Me.pnlParentsGenomeP2.Name = "pnlParentsGenomeP2"
        Me.pnlParentsGenomeP2.Size = New System.Drawing.Size(321, 102)
        Me.pnlParentsGenomeP2.TabIndex = 2
        '
        'tblParentsGenomeP2
        '
        Me.tblParentsGenomeP2.ColumnCount = 4
        Me.tblParentsGenomeP2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblParentsGenomeP2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblParentsGenomeP2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblParentsGenomeP2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblParentsGenomeP2.Controls.Add(Me.nmrParentsGenome2Hue2, 3, 3)
        Me.tblParentsGenomeP2.Controls.Add(Me.nmrParentsGenome2Hue1, 2, 3)
        Me.tblParentsGenomeP2.Controls.Add(Me.nmrParentsGenome2Lightness2, 1, 3)
        Me.tblParentsGenomeP2.Controls.Add(Me.nmrParentsGenome2Lightness1, 0, 3)
        Me.tblParentsGenomeP2.Controls.Add(Me.nmrParentsGenome2Colourness2, 3, 1)
        Me.tblParentsGenomeP2.Controls.Add(Me.nmrParentsGenome2Colourness1, 2, 1)
        Me.tblParentsGenomeP2.Controls.Add(Me.nmrParentsGenome2Naturalness2, 1, 1)
        Me.tblParentsGenomeP2.Controls.Add(Me.lblParentsGenomeP2Naturalness, 0, 0)
        Me.tblParentsGenomeP2.Controls.Add(Me.lblParentsGenomeP2Colourness, 2, 0)
        Me.tblParentsGenomeP2.Controls.Add(Me.lblParentsGenomeP2Lightness, 0, 2)
        Me.tblParentsGenomeP2.Controls.Add(Me.lblParentsGenomeP2Hue, 2, 2)
        Me.tblParentsGenomeP2.Controls.Add(Me.nmrParentsGenome2Naturalness1, 0, 1)
        Me.tblParentsGenomeP2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblParentsGenomeP2.Location = New System.Drawing.Point(0, 0)
        Me.tblParentsGenomeP2.Name = "tblParentsGenomeP2"
        Me.tblParentsGenomeP2.RowCount = 4
        Me.tblParentsGenomeP2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblParentsGenomeP2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblParentsGenomeP2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblParentsGenomeP2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblParentsGenomeP2.Size = New System.Drawing.Size(319, 100)
        Me.tblParentsGenomeP2.TabIndex = 1
        '
        'nmrParentsGenome2Hue2
        '
        Me.nmrParentsGenome2Hue2.Location = New System.Drawing.Point(240, 73)
        Me.nmrParentsGenome2Hue2.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmrParentsGenome2Hue2.Name = "nmrParentsGenome2Hue2"
        Me.nmrParentsGenome2Hue2.Size = New System.Drawing.Size(49, 20)
        Me.nmrParentsGenome2Hue2.TabIndex = 12
        '
        'nmrParentsGenome2Hue1
        '
        Me.nmrParentsGenome2Hue1.Location = New System.Drawing.Point(161, 73)
        Me.nmrParentsGenome2Hue1.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmrParentsGenome2Hue1.Name = "nmrParentsGenome2Hue1"
        Me.nmrParentsGenome2Hue1.Size = New System.Drawing.Size(49, 20)
        Me.nmrParentsGenome2Hue1.TabIndex = 11
        '
        'nmrParentsGenome2Lightness2
        '
        Me.nmrParentsGenome2Lightness2.Location = New System.Drawing.Point(82, 73)
        Me.nmrParentsGenome2Lightness2.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmrParentsGenome2Lightness2.Name = "nmrParentsGenome2Lightness2"
        Me.nmrParentsGenome2Lightness2.Size = New System.Drawing.Size(49, 20)
        Me.nmrParentsGenome2Lightness2.TabIndex = 10
        '
        'nmrParentsGenome2Lightness1
        '
        Me.nmrParentsGenome2Lightness1.Location = New System.Drawing.Point(3, 73)
        Me.nmrParentsGenome2Lightness1.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmrParentsGenome2Lightness1.Name = "nmrParentsGenome2Lightness1"
        Me.nmrParentsGenome2Lightness1.Size = New System.Drawing.Size(49, 20)
        Me.nmrParentsGenome2Lightness1.TabIndex = 9
        '
        'nmrParentsGenome2Colourness2
        '
        Me.nmrParentsGenome2Colourness2.Location = New System.Drawing.Point(240, 23)
        Me.nmrParentsGenome2Colourness2.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmrParentsGenome2Colourness2.Name = "nmrParentsGenome2Colourness2"
        Me.nmrParentsGenome2Colourness2.Size = New System.Drawing.Size(49, 20)
        Me.nmrParentsGenome2Colourness2.TabIndex = 8
        '
        'nmrParentsGenome2Colourness1
        '
        Me.nmrParentsGenome2Colourness1.Location = New System.Drawing.Point(161, 23)
        Me.nmrParentsGenome2Colourness1.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmrParentsGenome2Colourness1.Name = "nmrParentsGenome2Colourness1"
        Me.nmrParentsGenome2Colourness1.Size = New System.Drawing.Size(49, 20)
        Me.nmrParentsGenome2Colourness1.TabIndex = 7
        '
        'nmrParentsGenome2Naturalness2
        '
        Me.nmrParentsGenome2Naturalness2.Location = New System.Drawing.Point(82, 23)
        Me.nmrParentsGenome2Naturalness2.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmrParentsGenome2Naturalness2.Name = "nmrParentsGenome2Naturalness2"
        Me.nmrParentsGenome2Naturalness2.Size = New System.Drawing.Size(49, 20)
        Me.nmrParentsGenome2Naturalness2.TabIndex = 6
        '
        'lblParentsGenomeP2Naturalness
        '
        Me.lblParentsGenomeP2Naturalness.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblParentsGenomeP2Naturalness.AutoSize = True
        Me.tblParentsGenomeP2.SetColumnSpan(Me.lblParentsGenomeP2Naturalness, 2)
        Me.lblParentsGenomeP2Naturalness.Location = New System.Drawing.Point(47, 7)
        Me.lblParentsGenomeP2Naturalness.Name = "lblParentsGenomeP2Naturalness"
        Me.lblParentsGenomeP2Naturalness.Size = New System.Drawing.Size(63, 13)
        Me.lblParentsGenomeP2Naturalness.TabIndex = 1
        Me.lblParentsGenomeP2Naturalness.Text = "Naturalness"
        '
        'lblParentsGenomeP2Colourness
        '
        Me.lblParentsGenomeP2Colourness.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblParentsGenomeP2Colourness.AutoSize = True
        Me.tblParentsGenomeP2.SetColumnSpan(Me.lblParentsGenomeP2Colourness, 2)
        Me.lblParentsGenomeP2Colourness.Location = New System.Drawing.Point(209, 7)
        Me.lblParentsGenomeP2Colourness.Name = "lblParentsGenomeP2Colourness"
        Me.lblParentsGenomeP2Colourness.Size = New System.Drawing.Size(59, 13)
        Me.lblParentsGenomeP2Colourness.TabIndex = 2
        Me.lblParentsGenomeP2Colourness.Text = "Colourness"
        '
        'lblParentsGenomeP2Lightness
        '
        Me.lblParentsGenomeP2Lightness.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblParentsGenomeP2Lightness.AutoSize = True
        Me.tblParentsGenomeP2.SetColumnSpan(Me.lblParentsGenomeP2Lightness, 2)
        Me.lblParentsGenomeP2Lightness.Location = New System.Drawing.Point(53, 57)
        Me.lblParentsGenomeP2Lightness.Name = "lblParentsGenomeP2Lightness"
        Me.lblParentsGenomeP2Lightness.Size = New System.Drawing.Size(52, 13)
        Me.lblParentsGenomeP2Lightness.TabIndex = 3
        Me.lblParentsGenomeP2Lightness.Text = "Lightness"
        '
        'lblParentsGenomeP2Hue
        '
        Me.lblParentsGenomeP2Hue.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblParentsGenomeP2Hue.AutoSize = True
        Me.tblParentsGenomeP2.SetColumnSpan(Me.lblParentsGenomeP2Hue, 2)
        Me.lblParentsGenomeP2Hue.Location = New System.Drawing.Point(225, 57)
        Me.lblParentsGenomeP2Hue.Name = "lblParentsGenomeP2Hue"
        Me.lblParentsGenomeP2Hue.Size = New System.Drawing.Size(27, 13)
        Me.lblParentsGenomeP2Hue.TabIndex = 4
        Me.lblParentsGenomeP2Hue.Text = "Hue"
        '
        'nmrParentsGenome2Naturalness1
        '
        Me.nmrParentsGenome2Naturalness1.Location = New System.Drawing.Point(3, 23)
        Me.nmrParentsGenome2Naturalness1.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmrParentsGenome2Naturalness1.Name = "nmrParentsGenome2Naturalness1"
        Me.nmrParentsGenome2Naturalness1.Size = New System.Drawing.Size(49, 20)
        Me.nmrParentsGenome2Naturalness1.TabIndex = 5
        '
        'pnlParentsGenomeP1
        '
        Me.pnlParentsGenomeP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlParentsGenomeP1.Controls.Add(Me.tblParentsGenomeP1)
        Me.pnlParentsGenomeP1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlParentsGenomeP1.Location = New System.Drawing.Point(3, 173)
        Me.pnlParentsGenomeP1.Name = "pnlParentsGenomeP1"
        Me.pnlParentsGenomeP1.Size = New System.Drawing.Size(320, 102)
        Me.pnlParentsGenomeP1.TabIndex = 3
        '
        'tblParentsGenomeP1
        '
        Me.tblParentsGenomeP1.ColumnCount = 4
        Me.tblParentsGenomeP1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblParentsGenomeP1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblParentsGenomeP1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblParentsGenomeP1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblParentsGenomeP1.Controls.Add(Me.nmrParentsGenome1Lightness2, 0, 3)
        Me.tblParentsGenomeP1.Controls.Add(Me.nmrParentsGenome1Lightness1, 0, 3)
        Me.tblParentsGenomeP1.Controls.Add(Me.nmrParentsGenome1Hue2, 0, 3)
        Me.tblParentsGenomeP1.Controls.Add(Me.nmrParentsGenome1Hue1, 0, 3)
        Me.tblParentsGenomeP1.Controls.Add(Me.lblParentsGenomeP1Naturalness, 0, 0)
        Me.tblParentsGenomeP1.Controls.Add(Me.lblParentsGenomeP1Colourness, 2, 0)
        Me.tblParentsGenomeP1.Controls.Add(Me.lblParentsGenomeP1Lightness, 0, 2)
        Me.tblParentsGenomeP1.Controls.Add(Me.lblParentsGenomeP1Hue, 2, 2)
        Me.tblParentsGenomeP1.Controls.Add(Me.nmrParentsGenome1Colourness1, 2, 1)
        Me.tblParentsGenomeP1.Controls.Add(Me.nmrParentsGenome1Naturalness1, 0, 1)
        Me.tblParentsGenomeP1.Controls.Add(Me.nmrParentsGenome1Naturalness2, 1, 1)
        Me.tblParentsGenomeP1.Controls.Add(Me.nmrParentsGenome1Colourness2, 3, 1)
        Me.tblParentsGenomeP1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblParentsGenomeP1.Location = New System.Drawing.Point(0, 0)
        Me.tblParentsGenomeP1.Name = "tblParentsGenomeP1"
        Me.tblParentsGenomeP1.RowCount = 4
        Me.tblParentsGenomeP1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblParentsGenomeP1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblParentsGenomeP1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblParentsGenomeP1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblParentsGenomeP1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblParentsGenomeP1.Size = New System.Drawing.Size(318, 100)
        Me.tblParentsGenomeP1.TabIndex = 0
        '
        'nmrParentsGenome1Lightness2
        '
        Me.nmrParentsGenome1Lightness2.Location = New System.Drawing.Point(82, 73)
        Me.nmrParentsGenome1Lightness2.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmrParentsGenome1Lightness2.Name = "nmrParentsGenome1Lightness2"
        Me.nmrParentsGenome1Lightness2.Size = New System.Drawing.Size(49, 20)
        Me.nmrParentsGenome1Lightness2.TabIndex = 14
        '
        'nmrParentsGenome1Lightness1
        '
        Me.nmrParentsGenome1Lightness1.Location = New System.Drawing.Point(3, 73)
        Me.nmrParentsGenome1Lightness1.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmrParentsGenome1Lightness1.Name = "nmrParentsGenome1Lightness1"
        Me.nmrParentsGenome1Lightness1.Size = New System.Drawing.Size(49, 20)
        Me.nmrParentsGenome1Lightness1.TabIndex = 13
        '
        'nmrParentsGenome1Hue2
        '
        Me.nmrParentsGenome1Hue2.Location = New System.Drawing.Point(240, 73)
        Me.nmrParentsGenome1Hue2.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmrParentsGenome1Hue2.Name = "nmrParentsGenome1Hue2"
        Me.nmrParentsGenome1Hue2.Size = New System.Drawing.Size(49, 20)
        Me.nmrParentsGenome1Hue2.TabIndex = 12
        '
        'nmrParentsGenome1Hue1
        '
        Me.nmrParentsGenome1Hue1.Location = New System.Drawing.Point(161, 73)
        Me.nmrParentsGenome1Hue1.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmrParentsGenome1Hue1.Name = "nmrParentsGenome1Hue1"
        Me.nmrParentsGenome1Hue1.Size = New System.Drawing.Size(49, 20)
        Me.nmrParentsGenome1Hue1.TabIndex = 10
        '
        'lblParentsGenomeP1Naturalness
        '
        Me.lblParentsGenomeP1Naturalness.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblParentsGenomeP1Naturalness.AutoSize = True
        Me.tblParentsGenomeP1.SetColumnSpan(Me.lblParentsGenomeP1Naturalness, 2)
        Me.lblParentsGenomeP1Naturalness.Location = New System.Drawing.Point(47, 7)
        Me.lblParentsGenomeP1Naturalness.Name = "lblParentsGenomeP1Naturalness"
        Me.lblParentsGenomeP1Naturalness.Size = New System.Drawing.Size(63, 13)
        Me.lblParentsGenomeP1Naturalness.TabIndex = 1
        Me.lblParentsGenomeP1Naturalness.Text = "Naturalness"
        '
        'lblParentsGenomeP1Colourness
        '
        Me.lblParentsGenomeP1Colourness.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblParentsGenomeP1Colourness.AutoSize = True
        Me.tblParentsGenomeP1.SetColumnSpan(Me.lblParentsGenomeP1Colourness, 2)
        Me.lblParentsGenomeP1Colourness.Location = New System.Drawing.Point(208, 7)
        Me.lblParentsGenomeP1Colourness.Name = "lblParentsGenomeP1Colourness"
        Me.lblParentsGenomeP1Colourness.Size = New System.Drawing.Size(59, 13)
        Me.lblParentsGenomeP1Colourness.TabIndex = 2
        Me.lblParentsGenomeP1Colourness.Text = "Colourness"
        '
        'lblParentsGenomeP1Lightness
        '
        Me.lblParentsGenomeP1Lightness.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblParentsGenomeP1Lightness.AutoSize = True
        Me.tblParentsGenomeP1.SetColumnSpan(Me.lblParentsGenomeP1Lightness, 2)
        Me.lblParentsGenomeP1Lightness.Location = New System.Drawing.Point(53, 57)
        Me.lblParentsGenomeP1Lightness.Name = "lblParentsGenomeP1Lightness"
        Me.lblParentsGenomeP1Lightness.Size = New System.Drawing.Size(52, 13)
        Me.lblParentsGenomeP1Lightness.TabIndex = 3
        Me.lblParentsGenomeP1Lightness.Text = "Lightness"
        '
        'lblParentsGenomeP1Hue
        '
        Me.lblParentsGenomeP1Hue.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblParentsGenomeP1Hue.AutoSize = True
        Me.tblParentsGenomeP1.SetColumnSpan(Me.lblParentsGenomeP1Hue, 2)
        Me.lblParentsGenomeP1Hue.Location = New System.Drawing.Point(224, 57)
        Me.lblParentsGenomeP1Hue.Name = "lblParentsGenomeP1Hue"
        Me.lblParentsGenomeP1Hue.Size = New System.Drawing.Size(27, 13)
        Me.lblParentsGenomeP1Hue.TabIndex = 4
        Me.lblParentsGenomeP1Hue.Text = "Hue"
        '
        'nmrParentsGenome1Colourness1
        '
        Me.nmrParentsGenome1Colourness1.Location = New System.Drawing.Point(161, 23)
        Me.nmrParentsGenome1Colourness1.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmrParentsGenome1Colourness1.Name = "nmrParentsGenome1Colourness1"
        Me.nmrParentsGenome1Colourness1.Size = New System.Drawing.Size(49, 20)
        Me.nmrParentsGenome1Colourness1.TabIndex = 9
        '
        'nmrParentsGenome1Naturalness1
        '
        Me.nmrParentsGenome1Naturalness1.Location = New System.Drawing.Point(3, 23)
        Me.nmrParentsGenome1Naturalness1.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmrParentsGenome1Naturalness1.Name = "nmrParentsGenome1Naturalness1"
        Me.nmrParentsGenome1Naturalness1.Size = New System.Drawing.Size(49, 20)
        Me.nmrParentsGenome1Naturalness1.TabIndex = 6
        '
        'nmrParentsGenome1Naturalness2
        '
        Me.nmrParentsGenome1Naturalness2.Location = New System.Drawing.Point(82, 23)
        Me.nmrParentsGenome1Naturalness2.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmrParentsGenome1Naturalness2.Name = "nmrParentsGenome1Naturalness2"
        Me.nmrParentsGenome1Naturalness2.Size = New System.Drawing.Size(49, 20)
        Me.nmrParentsGenome1Naturalness2.TabIndex = 11
        '
        'nmrParentsGenome1Colourness2
        '
        Me.nmrParentsGenome1Colourness2.Location = New System.Drawing.Point(240, 23)
        Me.nmrParentsGenome1Colourness2.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmrParentsGenome1Colourness2.Name = "nmrParentsGenome1Colourness2"
        Me.nmrParentsGenome1Colourness2.Size = New System.Drawing.Size(49, 20)
        Me.nmrParentsGenome1Colourness2.TabIndex = 8
        '
        'flwChildrenOutput
        '
        Me.flwChildrenOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flwChildrenOutput.Location = New System.Drawing.Point(3, 287)
        Me.flwChildrenOutput.Name = "flwChildrenOutput"
        Me.flwChildrenOutput.Size = New System.Drawing.Size(653, 278)
        Me.flwChildrenOutput.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 568)
        Me.Controls.Add(Me.tblMain)
        Me.Name = "frmMain"
        Me.Text = "Mendel Sheep Breeder"
        Me.tblMain.ResumeLayout(False)
        Me.tblParents.ResumeLayout(False)
        CType(Me.pctParent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctParent1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlParentsGenomeP2.ResumeLayout(False)
        Me.tblParentsGenomeP2.ResumeLayout(False)
        Me.tblParentsGenomeP2.PerformLayout()
        CType(Me.nmrParentsGenome2Hue2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrParentsGenome2Hue1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrParentsGenome2Lightness2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrParentsGenome2Lightness1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrParentsGenome2Colourness2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrParentsGenome2Colourness1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrParentsGenome2Naturalness2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrParentsGenome2Naturalness1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlParentsGenomeP1.ResumeLayout(False)
        Me.tblParentsGenomeP1.ResumeLayout(False)
        Me.tblParentsGenomeP1.PerformLayout()
        CType(Me.nmrParentsGenome1Lightness2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrParentsGenome1Lightness1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrParentsGenome1Hue2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrParentsGenome1Hue1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrParentsGenome1Colourness1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrParentsGenome1Naturalness1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrParentsGenome1Naturalness2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrParentsGenome1Colourness2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblParents As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlParentsGenomeP1 As System.Windows.Forms.Panel
    Friend WithEvents tblParentsGenomeP1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblParentsGenomeP1Naturalness As System.Windows.Forms.Label
    Friend WithEvents lblParentsGenomeP1Colourness As System.Windows.Forms.Label
    Friend WithEvents pnlParentsGenomeP2 As System.Windows.Forms.Panel
    Friend WithEvents tblParentsGenomeP2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblParentsGenomeP2Naturalness As System.Windows.Forms.Label
    Friend WithEvents lblParentsGenomeP2Colourness As System.Windows.Forms.Label
    Friend WithEvents lblParentsGenomeP2Lightness As System.Windows.Forms.Label
    Friend WithEvents lblParentsGenomeP2Hue As System.Windows.Forms.Label
    Friend WithEvents lblParentsGenomeP1Lightness As System.Windows.Forms.Label
    Friend WithEvents lblParentsGenomeP1Hue As System.Windows.Forms.Label
    Friend WithEvents nmrParentsGenome2Hue2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nmrParentsGenome2Hue1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nmrParentsGenome2Lightness2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nmrParentsGenome2Lightness1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nmrParentsGenome2Colourness2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nmrParentsGenome2Colourness1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nmrParentsGenome2Naturalness2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nmrParentsGenome2Naturalness1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nmrParentsGenome1Lightness2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nmrParentsGenome1Lightness1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nmrParentsGenome1Hue2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nmrParentsGenome1Hue1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nmrParentsGenome1Colourness1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nmrParentsGenome1Naturalness1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nmrParentsGenome1Naturalness2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nmrParentsGenome1Colourness2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents pctParent2 As System.Windows.Forms.PictureBox
    Friend WithEvents pctParent1 As System.Windows.Forms.PictureBox
    Friend WithEvents flwChildrenOutput As System.Windows.Forms.FlowLayoutPanel

End Class
