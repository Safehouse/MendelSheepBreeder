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
        Me.pnlParentsGenomeP2 = New System.Windows.Forms.Panel()
        Me.tblParentsGenomeP2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblParentsGenomeP2Naturalness = New System.Windows.Forms.Label()
        Me.lblParentsGenomeP2Colourness = New System.Windows.Forms.Label()
        Me.lblParentsGenomeP2Lightness = New System.Windows.Forms.Label()
        Me.lblParentsGenomeP2Hue = New System.Windows.Forms.Label()
        Me.pnlParentsGenomeP1 = New System.Windows.Forms.Panel()
        Me.tblParentsGenomeP1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblParentsGenomeP1Naturalness = New System.Windows.Forms.Label()
        Me.lblParentsGenomeP1Colourness = New System.Windows.Forms.Label()
        Me.lblParentsGenomeP1Lightness = New System.Windows.Forms.Label()
        Me.lblParentsGenomeP1Hue = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown5 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown6 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown7 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown8 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown9 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown11 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown12 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown13 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown10 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown14 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown15 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown16 = New System.Windows.Forms.NumericUpDown()
        Me.tblMain.SuspendLayout()
        Me.tblParents.SuspendLayout()
        Me.pnlParentsGenomeP2.SuspendLayout()
        Me.tblParentsGenomeP2.SuspendLayout()
        Me.pnlParentsGenomeP1.SuspendLayout()
        Me.tblParentsGenomeP1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblMain
        '
        Me.tblMain.ColumnCount = 2
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblMain.Controls.Add(Me.tblParents, 0, 0)
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
        Me.tblParents.Controls.Add(Me.pnlParentsGenomeP2, 1, 1)
        Me.tblParents.Controls.Add(Me.pnlParentsGenomeP1, 0, 1)
        Me.tblParents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblParents.Location = New System.Drawing.Point(3, 3)
        Me.tblParents.Name = "tblParents"
        Me.tblParents.RowCount = 2
        Me.tblParents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.15108!))
        Me.tblParents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.84892!))
        Me.tblParents.Size = New System.Drawing.Size(462, 278)
        Me.tblParents.TabIndex = 0
        '
        'pnlParentsGenomeP2
        '
        Me.pnlParentsGenomeP2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlParentsGenomeP2.Controls.Add(Me.tblParentsGenomeP2)
        Me.pnlParentsGenomeP2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlParentsGenomeP2.Location = New System.Drawing.Point(234, 173)
        Me.pnlParentsGenomeP2.Name = "pnlParentsGenomeP2"
        Me.pnlParentsGenomeP2.Size = New System.Drawing.Size(225, 102)
        Me.pnlParentsGenomeP2.TabIndex = 2
        '
        'tblParentsGenomeP2
        '
        Me.tblParentsGenomeP2.ColumnCount = 4
        Me.tblParentsGenomeP2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblParentsGenomeP2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblParentsGenomeP2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblParentsGenomeP2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblParentsGenomeP2.Controls.Add(Me.NumericUpDown8, 3, 3)
        Me.tblParentsGenomeP2.Controls.Add(Me.NumericUpDown7, 2, 3)
        Me.tblParentsGenomeP2.Controls.Add(Me.NumericUpDown6, 1, 3)
        Me.tblParentsGenomeP2.Controls.Add(Me.NumericUpDown5, 0, 3)
        Me.tblParentsGenomeP2.Controls.Add(Me.NumericUpDown4, 3, 1)
        Me.tblParentsGenomeP2.Controls.Add(Me.NumericUpDown3, 2, 1)
        Me.tblParentsGenomeP2.Controls.Add(Me.NumericUpDown2, 1, 1)
        Me.tblParentsGenomeP2.Controls.Add(Me.lblParentsGenomeP2Naturalness, 0, 0)
        Me.tblParentsGenomeP2.Controls.Add(Me.lblParentsGenomeP2Colourness, 2, 0)
        Me.tblParentsGenomeP2.Controls.Add(Me.lblParentsGenomeP2Lightness, 0, 2)
        Me.tblParentsGenomeP2.Controls.Add(Me.lblParentsGenomeP2Hue, 2, 2)
        Me.tblParentsGenomeP2.Controls.Add(Me.NumericUpDown1, 0, 1)
        Me.tblParentsGenomeP2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblParentsGenomeP2.Location = New System.Drawing.Point(0, 0)
        Me.tblParentsGenomeP2.Name = "tblParentsGenomeP2"
        Me.tblParentsGenomeP2.RowCount = 4
        Me.tblParentsGenomeP2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblParentsGenomeP2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblParentsGenomeP2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblParentsGenomeP2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblParentsGenomeP2.Size = New System.Drawing.Size(223, 100)
        Me.tblParentsGenomeP2.TabIndex = 1
        '
        'lblParentsGenomeP2Naturalness
        '
        Me.lblParentsGenomeP2Naturalness.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblParentsGenomeP2Naturalness.AutoSize = True
        Me.tblParentsGenomeP2.SetColumnSpan(Me.lblParentsGenomeP2Naturalness, 2)
        Me.lblParentsGenomeP2Naturalness.Location = New System.Drawing.Point(23, 7)
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
        Me.lblParentsGenomeP2Colourness.Location = New System.Drawing.Point(137, 7)
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
        Me.lblParentsGenomeP2Lightness.Location = New System.Drawing.Point(29, 57)
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
        Me.lblParentsGenomeP2Hue.Location = New System.Drawing.Point(153, 57)
        Me.lblParentsGenomeP2Hue.Name = "lblParentsGenomeP2Hue"
        Me.lblParentsGenomeP2Hue.Size = New System.Drawing.Size(27, 13)
        Me.lblParentsGenomeP2Hue.TabIndex = 4
        Me.lblParentsGenomeP2Hue.Text = "Hue"
        '
        'pnlParentsGenomeP1
        '
        Me.pnlParentsGenomeP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlParentsGenomeP1.Controls.Add(Me.tblParentsGenomeP1)
        Me.pnlParentsGenomeP1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlParentsGenomeP1.Location = New System.Drawing.Point(3, 173)
        Me.pnlParentsGenomeP1.Name = "pnlParentsGenomeP1"
        Me.pnlParentsGenomeP1.Size = New System.Drawing.Size(225, 102)
        Me.pnlParentsGenomeP1.TabIndex = 3
        '
        'tblParentsGenomeP1
        '
        Me.tblParentsGenomeP1.ColumnCount = 4
        Me.tblParentsGenomeP1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblParentsGenomeP1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblParentsGenomeP1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblParentsGenomeP1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblParentsGenomeP1.Controls.Add(Me.NumericUpDown16, 0, 3)
        Me.tblParentsGenomeP1.Controls.Add(Me.NumericUpDown15, 0, 3)
        Me.tblParentsGenomeP1.Controls.Add(Me.NumericUpDown14, 0, 3)
        Me.tblParentsGenomeP1.Controls.Add(Me.NumericUpDown13, 0, 3)
        Me.tblParentsGenomeP1.Controls.Add(Me.lblParentsGenomeP1Naturalness, 0, 0)
        Me.tblParentsGenomeP1.Controls.Add(Me.lblParentsGenomeP1Colourness, 2, 0)
        Me.tblParentsGenomeP1.Controls.Add(Me.lblParentsGenomeP1Lightness, 0, 2)
        Me.tblParentsGenomeP1.Controls.Add(Me.lblParentsGenomeP1Hue, 2, 2)
        Me.tblParentsGenomeP1.Controls.Add(Me.NumericUpDown12, 2, 1)
        Me.tblParentsGenomeP1.Controls.Add(Me.NumericUpDown9, 0, 1)
        Me.tblParentsGenomeP1.Controls.Add(Me.NumericUpDown10, 1, 1)
        Me.tblParentsGenomeP1.Controls.Add(Me.NumericUpDown11, 3, 1)
        Me.tblParentsGenomeP1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblParentsGenomeP1.Location = New System.Drawing.Point(0, 0)
        Me.tblParentsGenomeP1.Name = "tblParentsGenomeP1"
        Me.tblParentsGenomeP1.RowCount = 4
        Me.tblParentsGenomeP1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblParentsGenomeP1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblParentsGenomeP1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblParentsGenomeP1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblParentsGenomeP1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblParentsGenomeP1.Size = New System.Drawing.Size(223, 100)
        Me.tblParentsGenomeP1.TabIndex = 0
        '
        'lblParentsGenomeP1Naturalness
        '
        Me.lblParentsGenomeP1Naturalness.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblParentsGenomeP1Naturalness.AutoSize = True
        Me.tblParentsGenomeP1.SetColumnSpan(Me.lblParentsGenomeP1Naturalness, 2)
        Me.lblParentsGenomeP1Naturalness.Location = New System.Drawing.Point(23, 7)
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
        Me.lblParentsGenomeP1Colourness.Location = New System.Drawing.Point(137, 7)
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
        Me.lblParentsGenomeP1Lightness.Location = New System.Drawing.Point(29, 57)
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
        Me.lblParentsGenomeP1Hue.Location = New System.Drawing.Point(153, 57)
        Me.lblParentsGenomeP1Hue.Name = "lblParentsGenomeP1Hue"
        Me.lblParentsGenomeP1Hue.Size = New System.Drawing.Size(27, 13)
        Me.lblParentsGenomeP1Hue.TabIndex = 4
        Me.lblParentsGenomeP1Hue.Text = "Hue"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(3, 23)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(49, 20)
        Me.NumericUpDown1.TabIndex = 5
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(58, 23)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(49, 20)
        Me.NumericUpDown2.TabIndex = 6
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(113, 23)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(49, 20)
        Me.NumericUpDown3.TabIndex = 7
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Location = New System.Drawing.Point(168, 23)
        Me.NumericUpDown4.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(49, 20)
        Me.NumericUpDown4.TabIndex = 8
        '
        'NumericUpDown5
        '
        Me.NumericUpDown5.Location = New System.Drawing.Point(3, 73)
        Me.NumericUpDown5.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown5.Name = "NumericUpDown5"
        Me.NumericUpDown5.Size = New System.Drawing.Size(49, 20)
        Me.NumericUpDown5.TabIndex = 9
        '
        'NumericUpDown6
        '
        Me.NumericUpDown6.Location = New System.Drawing.Point(58, 73)
        Me.NumericUpDown6.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown6.Name = "NumericUpDown6"
        Me.NumericUpDown6.Size = New System.Drawing.Size(49, 20)
        Me.NumericUpDown6.TabIndex = 10
        '
        'NumericUpDown7
        '
        Me.NumericUpDown7.Location = New System.Drawing.Point(113, 73)
        Me.NumericUpDown7.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown7.Name = "NumericUpDown7"
        Me.NumericUpDown7.Size = New System.Drawing.Size(49, 20)
        Me.NumericUpDown7.TabIndex = 11
        '
        'NumericUpDown8
        '
        Me.NumericUpDown8.Location = New System.Drawing.Point(168, 73)
        Me.NumericUpDown8.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown8.Name = "NumericUpDown8"
        Me.NumericUpDown8.Size = New System.Drawing.Size(49, 20)
        Me.NumericUpDown8.TabIndex = 12
        '
        'NumericUpDown9
        '
        Me.NumericUpDown9.Location = New System.Drawing.Point(3, 23)
        Me.NumericUpDown9.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown9.Name = "NumericUpDown9"
        Me.NumericUpDown9.Size = New System.Drawing.Size(49, 20)
        Me.NumericUpDown9.TabIndex = 6
        '
        'NumericUpDown11
        '
        Me.NumericUpDown11.Location = New System.Drawing.Point(168, 23)
        Me.NumericUpDown11.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown11.Name = "NumericUpDown11"
        Me.NumericUpDown11.Size = New System.Drawing.Size(49, 20)
        Me.NumericUpDown11.TabIndex = 8
        '
        'NumericUpDown12
        '
        Me.NumericUpDown12.Location = New System.Drawing.Point(113, 23)
        Me.NumericUpDown12.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown12.Name = "NumericUpDown12"
        Me.NumericUpDown12.Size = New System.Drawing.Size(49, 20)
        Me.NumericUpDown12.TabIndex = 9
        '
        'NumericUpDown13
        '
        Me.NumericUpDown13.Location = New System.Drawing.Point(113, 73)
        Me.NumericUpDown13.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown13.Name = "NumericUpDown13"
        Me.NumericUpDown13.Size = New System.Drawing.Size(49, 20)
        Me.NumericUpDown13.TabIndex = 10
        '
        'NumericUpDown10
        '
        Me.NumericUpDown10.Location = New System.Drawing.Point(58, 23)
        Me.NumericUpDown10.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown10.Name = "NumericUpDown10"
        Me.NumericUpDown10.Size = New System.Drawing.Size(49, 20)
        Me.NumericUpDown10.TabIndex = 11
        '
        'NumericUpDown14
        '
        Me.NumericUpDown14.Location = New System.Drawing.Point(168, 73)
        Me.NumericUpDown14.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown14.Name = "NumericUpDown14"
        Me.NumericUpDown14.Size = New System.Drawing.Size(49, 20)
        Me.NumericUpDown14.TabIndex = 12
        '
        'NumericUpDown15
        '
        Me.NumericUpDown15.Location = New System.Drawing.Point(3, 73)
        Me.NumericUpDown15.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown15.Name = "NumericUpDown15"
        Me.NumericUpDown15.Size = New System.Drawing.Size(49, 20)
        Me.NumericUpDown15.TabIndex = 13
        '
        'NumericUpDown16
        '
        Me.NumericUpDown16.Location = New System.Drawing.Point(58, 73)
        Me.NumericUpDown16.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown16.Name = "NumericUpDown16"
        Me.NumericUpDown16.Size = New System.Drawing.Size(49, 20)
        Me.NumericUpDown16.TabIndex = 14
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
        Me.pnlParentsGenomeP2.ResumeLayout(False)
        Me.tblParentsGenomeP2.ResumeLayout(False)
        Me.tblParentsGenomeP2.PerformLayout()
        Me.pnlParentsGenomeP1.ResumeLayout(False)
        Me.tblParentsGenomeP1.ResumeLayout(False)
        Me.tblParentsGenomeP1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown16, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents NumericUpDown8 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown7 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown6 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown16 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown15 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown14 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown13 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown12 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown9 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown10 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown11 As System.Windows.Forms.NumericUpDown

End Class
