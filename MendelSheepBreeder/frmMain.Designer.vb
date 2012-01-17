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
        Me.txtParentsGenomeP2Lightness2 = New System.Windows.Forms.TextBox()
        Me.txtParentsGenomeP2Lightness1 = New System.Windows.Forms.TextBox()
        Me.txtParentsGenomeP2Hue2 = New System.Windows.Forms.TextBox()
        Me.txtParentsGenomeP2Hue1 = New System.Windows.Forms.TextBox()
        Me.txtParentsGenomeP2Colourness2 = New System.Windows.Forms.TextBox()
        Me.txtParentsGenomeP2Colourness1 = New System.Windows.Forms.TextBox()
        Me.txtParentsGenomeP2Naturalness2 = New System.Windows.Forms.TextBox()
        Me.txtParentsGenomeP2Naturalness1 = New System.Windows.Forms.TextBox()
        Me.lblParentsGenomeP2Naturalness = New System.Windows.Forms.Label()
        Me.lblParentsGenomeP2Colourness = New System.Windows.Forms.Label()
        Me.lblParentsGenomeP2Lightness = New System.Windows.Forms.Label()
        Me.lblParentsGenomeP2Hue = New System.Windows.Forms.Label()
        Me.pnlParentsGenomeP1 = New System.Windows.Forms.Panel()
        Me.tblParentsGenomeP1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtParentsGenomeP1Lightness2 = New System.Windows.Forms.TextBox()
        Me.txtParentsGenomeP1Lightness1 = New System.Windows.Forms.TextBox()
        Me.txtParentsGenomeP1Hue2 = New System.Windows.Forms.TextBox()
        Me.txtParentsGenomeP1Hue1 = New System.Windows.Forms.TextBox()
        Me.txtParentsGenomeP1Colourness2 = New System.Windows.Forms.TextBox()
        Me.txtParentsGenomeP1Colourness1 = New System.Windows.Forms.TextBox()
        Me.txtParentsGenomeP1Naturalness2 = New System.Windows.Forms.TextBox()
        Me.txtParentsGenomeP1Naturalness1 = New System.Windows.Forms.TextBox()
        Me.lblParentsGenomeP1Naturalness = New System.Windows.Forms.Label()
        Me.lblParentsGenomeP1Colourness = New System.Windows.Forms.Label()
        Me.lblParentsGenomeP1Lightness = New System.Windows.Forms.Label()
        Me.lblParentsGenomeP1Hue = New System.Windows.Forms.Label()
        Me.tblMain.SuspendLayout()
        Me.tblParents.SuspendLayout()
        Me.pnlParentsGenomeP2.SuspendLayout()
        Me.tblParentsGenomeP2.SuspendLayout()
        Me.pnlParentsGenomeP1.SuspendLayout()
        Me.tblParentsGenomeP1.SuspendLayout()
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
        Me.tblParentsGenomeP2.Controls.Add(Me.txtParentsGenomeP2Lightness2, 0, 3)
        Me.tblParentsGenomeP2.Controls.Add(Me.txtParentsGenomeP2Lightness1, 0, 3)
        Me.tblParentsGenomeP2.Controls.Add(Me.txtParentsGenomeP2Hue2, 0, 3)
        Me.tblParentsGenomeP2.Controls.Add(Me.txtParentsGenomeP2Hue1, 0, 3)
        Me.tblParentsGenomeP2.Controls.Add(Me.txtParentsGenomeP2Colourness2, 3, 1)
        Me.tblParentsGenomeP2.Controls.Add(Me.txtParentsGenomeP2Colourness1, 2, 1)
        Me.tblParentsGenomeP2.Controls.Add(Me.txtParentsGenomeP2Naturalness2, 1, 1)
        Me.tblParentsGenomeP2.Controls.Add(Me.txtParentsGenomeP2Naturalness1, 0, 1)
        Me.tblParentsGenomeP2.Controls.Add(Me.lblParentsGenomeP2Naturalness, 0, 0)
        Me.tblParentsGenomeP2.Controls.Add(Me.lblParentsGenomeP2Colourness, 2, 0)
        Me.tblParentsGenomeP2.Controls.Add(Me.lblParentsGenomeP2Lightness, 0, 2)
        Me.tblParentsGenomeP2.Controls.Add(Me.lblParentsGenomeP2Hue, 2, 2)
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
        'txtParentsGenomeP2Lightness2
        '
        Me.txtParentsGenomeP2Lightness2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtParentsGenomeP2Lightness2.Location = New System.Drawing.Point(58, 73)
        Me.txtParentsGenomeP2Lightness2.MaxLength = 1
        Me.txtParentsGenomeP2Lightness2.Name = "txtParentsGenomeP2Lightness2"
        Me.txtParentsGenomeP2Lightness2.Size = New System.Drawing.Size(49, 20)
        Me.txtParentsGenomeP2Lightness2.TabIndex = 15
        Me.txtParentsGenomeP2Lightness2.Text = "1"
        '
        'txtParentsGenomeP2Lightness1
        '
        Me.txtParentsGenomeP2Lightness1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtParentsGenomeP2Lightness1.Location = New System.Drawing.Point(3, 73)
        Me.txtParentsGenomeP2Lightness1.MaxLength = 1
        Me.txtParentsGenomeP2Lightness1.Name = "txtParentsGenomeP2Lightness1"
        Me.txtParentsGenomeP2Lightness1.Size = New System.Drawing.Size(49, 20)
        Me.txtParentsGenomeP2Lightness1.TabIndex = 14
        Me.txtParentsGenomeP2Lightness1.Text = "1"
        '
        'txtParentsGenomeP2Hue2
        '
        Me.txtParentsGenomeP2Hue2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtParentsGenomeP2Hue2.Location = New System.Drawing.Point(168, 73)
        Me.txtParentsGenomeP2Hue2.MaxLength = 1
        Me.txtParentsGenomeP2Hue2.Name = "txtParentsGenomeP2Hue2"
        Me.txtParentsGenomeP2Hue2.Size = New System.Drawing.Size(52, 20)
        Me.txtParentsGenomeP2Hue2.TabIndex = 13
        Me.txtParentsGenomeP2Hue2.Text = "1"
        '
        'txtParentsGenomeP2Hue1
        '
        Me.txtParentsGenomeP2Hue1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtParentsGenomeP2Hue1.Location = New System.Drawing.Point(113, 73)
        Me.txtParentsGenomeP2Hue1.MaxLength = 1
        Me.txtParentsGenomeP2Hue1.Name = "txtParentsGenomeP2Hue1"
        Me.txtParentsGenomeP2Hue1.Size = New System.Drawing.Size(49, 20)
        Me.txtParentsGenomeP2Hue1.TabIndex = 12
        Me.txtParentsGenomeP2Hue1.Text = "1"
        '
        'txtParentsGenomeP2Colourness2
        '
        Me.txtParentsGenomeP2Colourness2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtParentsGenomeP2Colourness2.Location = New System.Drawing.Point(168, 23)
        Me.txtParentsGenomeP2Colourness2.MaxLength = 1
        Me.txtParentsGenomeP2Colourness2.Name = "txtParentsGenomeP2Colourness2"
        Me.txtParentsGenomeP2Colourness2.Size = New System.Drawing.Size(52, 20)
        Me.txtParentsGenomeP2Colourness2.TabIndex = 7
        Me.txtParentsGenomeP2Colourness2.Text = "1"
        '
        'txtParentsGenomeP2Colourness1
        '
        Me.txtParentsGenomeP2Colourness1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtParentsGenomeP2Colourness1.Location = New System.Drawing.Point(113, 23)
        Me.txtParentsGenomeP2Colourness1.MaxLength = 1
        Me.txtParentsGenomeP2Colourness1.Name = "txtParentsGenomeP2Colourness1"
        Me.txtParentsGenomeP2Colourness1.Size = New System.Drawing.Size(49, 20)
        Me.txtParentsGenomeP2Colourness1.TabIndex = 6
        Me.txtParentsGenomeP2Colourness1.Text = "1"
        '
        'txtParentsGenomeP2Naturalness2
        '
        Me.txtParentsGenomeP2Naturalness2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtParentsGenomeP2Naturalness2.Location = New System.Drawing.Point(58, 23)
        Me.txtParentsGenomeP2Naturalness2.MaxLength = 1
        Me.txtParentsGenomeP2Naturalness2.Name = "txtParentsGenomeP2Naturalness2"
        Me.txtParentsGenomeP2Naturalness2.Size = New System.Drawing.Size(49, 20)
        Me.txtParentsGenomeP2Naturalness2.TabIndex = 5
        Me.txtParentsGenomeP2Naturalness2.Text = "1"
        '
        'txtParentsGenomeP2Naturalness1
        '
        Me.txtParentsGenomeP2Naturalness1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtParentsGenomeP2Naturalness1.Location = New System.Drawing.Point(3, 23)
        Me.txtParentsGenomeP2Naturalness1.MaxLength = 1
        Me.txtParentsGenomeP2Naturalness1.Name = "txtParentsGenomeP2Naturalness1"
        Me.txtParentsGenomeP2Naturalness1.Size = New System.Drawing.Size(49, 20)
        Me.txtParentsGenomeP2Naturalness1.TabIndex = 0
        Me.txtParentsGenomeP2Naturalness1.Text = "1"
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
        Me.tblParentsGenomeP1.Controls.Add(Me.txtParentsGenomeP1Lightness2, 0, 3)
        Me.tblParentsGenomeP1.Controls.Add(Me.txtParentsGenomeP1Lightness1, 0, 3)
        Me.tblParentsGenomeP1.Controls.Add(Me.txtParentsGenomeP1Hue2, 0, 3)
        Me.tblParentsGenomeP1.Controls.Add(Me.txtParentsGenomeP1Hue1, 0, 3)
        Me.tblParentsGenomeP1.Controls.Add(Me.txtParentsGenomeP1Colourness2, 3, 1)
        Me.tblParentsGenomeP1.Controls.Add(Me.txtParentsGenomeP1Colourness1, 2, 1)
        Me.tblParentsGenomeP1.Controls.Add(Me.txtParentsGenomeP1Naturalness2, 1, 1)
        Me.tblParentsGenomeP1.Controls.Add(Me.txtParentsGenomeP1Naturalness1, 0, 1)
        Me.tblParentsGenomeP1.Controls.Add(Me.lblParentsGenomeP1Naturalness, 0, 0)
        Me.tblParentsGenomeP1.Controls.Add(Me.lblParentsGenomeP1Colourness, 2, 0)
        Me.tblParentsGenomeP1.Controls.Add(Me.lblParentsGenomeP1Lightness, 0, 2)
        Me.tblParentsGenomeP1.Controls.Add(Me.lblParentsGenomeP1Hue, 2, 2)
        Me.tblParentsGenomeP1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblParentsGenomeP1.Location = New System.Drawing.Point(0, 0)
        Me.tblParentsGenomeP1.Name = "tblParentsGenomeP1"
        Me.tblParentsGenomeP1.RowCount = 4
        Me.tblParentsGenomeP1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblParentsGenomeP1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblParentsGenomeP1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblParentsGenomeP1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblParentsGenomeP1.Size = New System.Drawing.Size(223, 100)
        Me.tblParentsGenomeP1.TabIndex = 0
        '
        'txtParentsGenomeP1Lightness2
        '
        Me.txtParentsGenomeP1Lightness2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtParentsGenomeP1Lightness2.Location = New System.Drawing.Point(58, 73)
        Me.txtParentsGenomeP1Lightness2.MaxLength = 1
        Me.txtParentsGenomeP1Lightness2.Name = "txtParentsGenomeP1Lightness2"
        Me.txtParentsGenomeP1Lightness2.Size = New System.Drawing.Size(49, 20)
        Me.txtParentsGenomeP1Lightness2.TabIndex = 15
        Me.txtParentsGenomeP1Lightness2.Text = "1"
        '
        'txtParentsGenomeP1Lightness1
        '
        Me.txtParentsGenomeP1Lightness1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtParentsGenomeP1Lightness1.Location = New System.Drawing.Point(3, 73)
        Me.txtParentsGenomeP1Lightness1.MaxLength = 1
        Me.txtParentsGenomeP1Lightness1.Name = "txtParentsGenomeP1Lightness1"
        Me.txtParentsGenomeP1Lightness1.Size = New System.Drawing.Size(49, 20)
        Me.txtParentsGenomeP1Lightness1.TabIndex = 14
        Me.txtParentsGenomeP1Lightness1.Text = "1"
        '
        'txtParentsGenomeP1Hue2
        '
        Me.txtParentsGenomeP1Hue2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtParentsGenomeP1Hue2.Location = New System.Drawing.Point(168, 73)
        Me.txtParentsGenomeP1Hue2.MaxLength = 1
        Me.txtParentsGenomeP1Hue2.Name = "txtParentsGenomeP1Hue2"
        Me.txtParentsGenomeP1Hue2.Size = New System.Drawing.Size(52, 20)
        Me.txtParentsGenomeP1Hue2.TabIndex = 13
        Me.txtParentsGenomeP1Hue2.Text = "1"
        '
        'txtParentsGenomeP1Hue1
        '
        Me.txtParentsGenomeP1Hue1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtParentsGenomeP1Hue1.Location = New System.Drawing.Point(113, 73)
        Me.txtParentsGenomeP1Hue1.MaxLength = 1
        Me.txtParentsGenomeP1Hue1.Name = "txtParentsGenomeP1Hue1"
        Me.txtParentsGenomeP1Hue1.Size = New System.Drawing.Size(49, 20)
        Me.txtParentsGenomeP1Hue1.TabIndex = 12
        Me.txtParentsGenomeP1Hue1.Text = "1"
        '
        'txtParentsGenomeP1Colourness2
        '
        Me.txtParentsGenomeP1Colourness2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtParentsGenomeP1Colourness2.Location = New System.Drawing.Point(168, 23)
        Me.txtParentsGenomeP1Colourness2.MaxLength = 1
        Me.txtParentsGenomeP1Colourness2.Name = "txtParentsGenomeP1Colourness2"
        Me.txtParentsGenomeP1Colourness2.Size = New System.Drawing.Size(52, 20)
        Me.txtParentsGenomeP1Colourness2.TabIndex = 7
        Me.txtParentsGenomeP1Colourness2.Text = "1"
        '
        'txtParentsGenomeP1Colourness1
        '
        Me.txtParentsGenomeP1Colourness1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtParentsGenomeP1Colourness1.Location = New System.Drawing.Point(113, 23)
        Me.txtParentsGenomeP1Colourness1.MaxLength = 1
        Me.txtParentsGenomeP1Colourness1.Name = "txtParentsGenomeP1Colourness1"
        Me.txtParentsGenomeP1Colourness1.Size = New System.Drawing.Size(49, 20)
        Me.txtParentsGenomeP1Colourness1.TabIndex = 6
        Me.txtParentsGenomeP1Colourness1.Text = "1"
        '
        'txtParentsGenomeP1Naturalness2
        '
        Me.txtParentsGenomeP1Naturalness2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtParentsGenomeP1Naturalness2.Location = New System.Drawing.Point(58, 23)
        Me.txtParentsGenomeP1Naturalness2.MaxLength = 1
        Me.txtParentsGenomeP1Naturalness2.Name = "txtParentsGenomeP1Naturalness2"
        Me.txtParentsGenomeP1Naturalness2.Size = New System.Drawing.Size(49, 20)
        Me.txtParentsGenomeP1Naturalness2.TabIndex = 5
        Me.txtParentsGenomeP1Naturalness2.Text = "1"
        '
        'txtParentsGenomeP1Naturalness1
        '
        Me.txtParentsGenomeP1Naturalness1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtParentsGenomeP1Naturalness1.Location = New System.Drawing.Point(3, 23)
        Me.txtParentsGenomeP1Naturalness1.MaxLength = 1
        Me.txtParentsGenomeP1Naturalness1.Name = "txtParentsGenomeP1Naturalness1"
        Me.txtParentsGenomeP1Naturalness1.Size = New System.Drawing.Size(49, 20)
        Me.txtParentsGenomeP1Naturalness1.TabIndex = 0
        Me.txtParentsGenomeP1Naturalness1.Text = "1"
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblParents As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtParentsGenomeP1Naturalness1 As System.Windows.Forms.TextBox
    Friend WithEvents pnlParentsGenomeP1 As System.Windows.Forms.Panel
    Friend WithEvents tblParentsGenomeP1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblParentsGenomeP1Naturalness As System.Windows.Forms.Label
    Friend WithEvents lblParentsGenomeP1Colourness As System.Windows.Forms.Label
    Friend WithEvents txtParentsGenomeP1Colourness2 As System.Windows.Forms.TextBox
    Friend WithEvents txtParentsGenomeP1Colourness1 As System.Windows.Forms.TextBox
    Friend WithEvents txtParentsGenomeP1Naturalness2 As System.Windows.Forms.TextBox
    Friend WithEvents pnlParentsGenomeP2 As System.Windows.Forms.Panel
    Friend WithEvents tblParentsGenomeP2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtParentsGenomeP2Lightness2 As System.Windows.Forms.TextBox
    Friend WithEvents txtParentsGenomeP2Lightness1 As System.Windows.Forms.TextBox
    Friend WithEvents txtParentsGenomeP2Hue2 As System.Windows.Forms.TextBox
    Friend WithEvents txtParentsGenomeP2Hue1 As System.Windows.Forms.TextBox
    Friend WithEvents txtParentsGenomeP2Colourness2 As System.Windows.Forms.TextBox
    Friend WithEvents txtParentsGenomeP2Colourness1 As System.Windows.Forms.TextBox
    Friend WithEvents txtParentsGenomeP2Naturalness2 As System.Windows.Forms.TextBox
    Friend WithEvents txtParentsGenomeP2Naturalness1 As System.Windows.Forms.TextBox
    Friend WithEvents lblParentsGenomeP2Naturalness As System.Windows.Forms.Label
    Friend WithEvents lblParentsGenomeP2Colourness As System.Windows.Forms.Label
    Friend WithEvents lblParentsGenomeP2Lightness As System.Windows.Forms.Label
    Friend WithEvents lblParentsGenomeP2Hue As System.Windows.Forms.Label
    Friend WithEvents txtParentsGenomeP1Lightness2 As System.Windows.Forms.TextBox
    Friend WithEvents txtParentsGenomeP1Lightness1 As System.Windows.Forms.TextBox
    Friend WithEvents txtParentsGenomeP1Hue2 As System.Windows.Forms.TextBox
    Friend WithEvents txtParentsGenomeP1Hue1 As System.Windows.Forms.TextBox
    Friend WithEvents lblParentsGenomeP1Lightness As System.Windows.Forms.Label
    Friend WithEvents lblParentsGenomeP1Hue As System.Windows.Forms.Label

End Class
