<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options_02
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LogInLabel1 = New VBVEC.LogInLabel()
        Me.LogInTabControl1 = New VBVEC.LogInTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LogInButtonWithProgress2 = New VBVEC.LogInButtonWithProgress()
        Me.LogInLabel3 = New VBVEC.LogInLabel()
        Me.LogInNormalTextBox2 = New VBVEC.LogInNormalTextBox()
        Me.LogInLabel2 = New VBVEC.LogInLabel()
        Me.LogInNormalTextBox1 = New VBVEC.LogInNormalTextBox()
        Me.LogInButtonWithProgress1 = New VBVEC.LogInButtonWithProgress()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LogInGroupBox2 = New VBVEC.LogInGroupBox()
        Me.LogInRadioButton_AbandonnerReessayerIgnorer = New VBVEC.LogInRadioButton()
        Me.LogInRadioButton_Ok = New VBVEC.LogInRadioButton()
        Me.LogInRadioButton_OuiNonAnnuler = New VBVEC.LogInRadioButton()
        Me.LogInRadioButton_OuiNon = New VBVEC.LogInRadioButton()
        Me.LogInRadioButton_ReessayerAnnuler = New VBVEC.LogInRadioButton()
        Me.LogInRadioButton_OkAnnuler = New VBVEC.LogInRadioButton()
        Me.LogInGroupBox1 = New VBVEC.LogInGroupBox()
        Me.LogInRadioButton_Question = New VBVEC.LogInRadioButton()
        Me.LogInRadioButton_Critique = New VBVEC.LogInRadioButton()
        Me.LogInRadioButton_Alerte = New VBVEC.LogInRadioButton()
        Me.LogInRadioButton_Information = New VBVEC.LogInRadioButton()
        Me.LogInTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.LogInGroupBox2.SuspendLayout()
        Me.LogInGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LogInLabel1
        '
        Me.LogInLabel1.AutoSize = True
        Me.LogInLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogInLabel1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.Location = New System.Drawing.Point(111, 11)
        Me.LogInLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LogInLabel1.Name = "LogInLabel1"
        Me.LogInLabel1.Size = New System.Drawing.Size(390, 54)
        Me.LogInLabel1.TabIndex = 3
        Me.LogInLabel1.Text = "Afficher un message"
        '
        'LogInTabControl1
        '
        Me.LogInTabControl1.ActiveColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInTabControl1.BackTabColour = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LogInTabControl1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInTabControl1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.LogInTabControl1.Controls.Add(Me.TabPage1)
        Me.LogInTabControl1.Controls.Add(Me.TabPage2)
        Me.LogInTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LogInTabControl1.HorizontalLineColour = System.Drawing.Color.Firebrick
        Me.LogInTabControl1.ItemSize = New System.Drawing.Size(240, 32)
        Me.LogInTabControl1.Location = New System.Drawing.Point(0, 80)
        Me.LogInTabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LogInTabControl1.Name = "LogInTabControl1"
        Me.LogInTabControl1.SelectedIndex = 0
        Me.LogInTabControl1.Size = New System.Drawing.Size(652, 370)
        Me.LogInTabControl1.TabIndex = 2
        Me.LogInTabControl1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInTabControl1.UpLineColour = System.Drawing.Color.Firebrick
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.LogInButtonWithProgress2)
        Me.TabPage1.Controls.Add(Me.LogInLabel3)
        Me.TabPage1.Controls.Add(Me.LogInNormalTextBox2)
        Me.TabPage1.Controls.Add(Me.LogInLabel2)
        Me.TabPage1.Controls.Add(Me.LogInNormalTextBox1)
        Me.TabPage1.Controls.Add(Me.LogInButtonWithProgress1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 36)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(644, 330)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Options du message"
        '
        'LogInButtonWithProgress2
        '
        Me.LogInButtonWithProgress2.BackColor = System.Drawing.Color.Transparent
        Me.LogInButtonWithProgress2.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButtonWithProgress2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButtonWithProgress2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress2.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButtonWithProgress2.Location = New System.Drawing.Point(201, 191)
        Me.LogInButtonWithProgress2.Margin = New System.Windows.Forms.Padding(4)
        Me.LogInButtonWithProgress2.Maximum = 100
        Me.LogInButtonWithProgress2.Name = "LogInButtonWithProgress2"
        Me.LogInButtonWithProgress2.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButtonWithProgress2.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress2.Size = New System.Drawing.Size(223, 54)
        Me.LogInButtonWithProgress2.TabIndex = 8
        Me.LogInButtonWithProgress2.Text = "Tester"
        Me.LogInButtonWithProgress2.Value = 0
        '
        'LogInLabel3
        '
        Me.LogInLabel3.AutoSize = True
        Me.LogInLabel3.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LogInLabel3.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel3.Location = New System.Drawing.Point(43, 78)
        Me.LogInLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LogInLabel3.Name = "LogInLabel3"
        Me.LogInLabel3.Size = New System.Drawing.Size(103, 28)
        Me.LogInLabel3.TabIndex = 7
        Me.LogInLabel3.Text = "Message :"
        '
        'LogInNormalTextBox2
        '
        Me.LogInNormalTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.LogInNormalTextBox2.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInNormalTextBox2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInNormalTextBox2.Location = New System.Drawing.Point(83, 107)
        Me.LogInNormalTextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.LogInNormalTextBox2.MaxLength = 32767
        Me.LogInNormalTextBox2.Multiline = False
        Me.LogInNormalTextBox2.Name = "LogInNormalTextBox2"
        Me.LogInNormalTextBox2.ReadOnly = False
        Me.LogInNormalTextBox2.Size = New System.Drawing.Size(472, 34)
        Me.LogInNormalTextBox2.Style = VBVEC.LogInNormalTextBox.Styles.NotRounded
        Me.LogInNormalTextBox2.TabIndex = 6
        Me.LogInNormalTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.LogInNormalTextBox2.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInNormalTextBox2.UseSystemPasswordChar = False
        '
        'LogInLabel2
        '
        Me.LogInLabel2.AutoSize = True
        Me.LogInLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LogInLabel2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel2.Location = New System.Drawing.Point(43, 9)
        Me.LogInLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LogInLabel2.Name = "LogInLabel2"
        Me.LogInLabel2.Size = New System.Drawing.Size(180, 28)
        Me.LogInLabel2.TabIndex = 5
        Me.LogInLabel2.Text = "Titre du message :"
        '
        'LogInNormalTextBox1
        '
        Me.LogInNormalTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.LogInNormalTextBox1.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInNormalTextBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInNormalTextBox1.Location = New System.Drawing.Point(83, 38)
        Me.LogInNormalTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.LogInNormalTextBox1.MaxLength = 32767
        Me.LogInNormalTextBox1.Multiline = False
        Me.LogInNormalTextBox1.Name = "LogInNormalTextBox1"
        Me.LogInNormalTextBox1.ReadOnly = False
        Me.LogInNormalTextBox1.Size = New System.Drawing.Size(472, 34)
        Me.LogInNormalTextBox1.Style = VBVEC.LogInNormalTextBox.Styles.NotRounded
        Me.LogInNormalTextBox1.TabIndex = 4
        Me.LogInNormalTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.LogInNormalTextBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInNormalTextBox1.UseSystemPasswordChar = False
        '
        'LogInButtonWithProgress1
        '
        Me.LogInButtonWithProgress1.BackColor = System.Drawing.Color.Transparent
        Me.LogInButtonWithProgress1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButtonWithProgress1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButtonWithProgress1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButtonWithProgress1.Location = New System.Drawing.Point(201, 252)
        Me.LogInButtonWithProgress1.Margin = New System.Windows.Forms.Padding(4)
        Me.LogInButtonWithProgress1.Maximum = 100
        Me.LogInButtonWithProgress1.Name = "LogInButtonWithProgress1"
        Me.LogInButtonWithProgress1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButtonWithProgress1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress1.Size = New System.Drawing.Size(223, 54)
        Me.LogInButtonWithProgress1.TabIndex = 3
        Me.LogInButtonWithProgress1.Text = "Valider et quitter"
        Me.LogInButtonWithProgress1.Value = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.LogInGroupBox2)
        Me.TabPage2.Controls.Add(Me.LogInGroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(644, 330)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Styles"
        '
        'LogInGroupBox2
        '
        Me.LogInGroupBox2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInGroupBox2.Controls.Add(Me.LogInRadioButton_AbandonnerReessayerIgnorer)
        Me.LogInGroupBox2.Controls.Add(Me.LogInRadioButton_Ok)
        Me.LogInGroupBox2.Controls.Add(Me.LogInRadioButton_OuiNonAnnuler)
        Me.LogInGroupBox2.Controls.Add(Me.LogInRadioButton_OuiNon)
        Me.LogInGroupBox2.Controls.Add(Me.LogInRadioButton_ReessayerAnnuler)
        Me.LogInGroupBox2.Controls.Add(Me.LogInRadioButton_OkAnnuler)
        Me.LogInGroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.LogInGroupBox2.Enabled = False
        Me.LogInGroupBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LogInGroupBox2.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInGroupBox2.Location = New System.Drawing.Point(279, 4)
        Me.LogInGroupBox2.MainColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInGroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.LogInGroupBox2.Name = "LogInGroupBox2"
        Me.LogInGroupBox2.Size = New System.Drawing.Size(359, 320)
        Me.LogInGroupBox2.TabIndex = 22
        Me.LogInGroupBox2.Text = "Boutons"
        Me.LogInGroupBox2.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'LogInRadioButton_AbandonnerReessayerIgnorer
        '
        Me.LogInRadioButton_AbandonnerReessayerIgnorer.BackColor = System.Drawing.Color.Transparent
        Me.LogInRadioButton_AbandonnerReessayerIgnorer.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInRadioButton_AbandonnerReessayerIgnorer.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInRadioButton_AbandonnerReessayerIgnorer.Checked = False
        Me.LogInRadioButton_AbandonnerReessayerIgnorer.CheckedColour = System.Drawing.Color.Firebrick
        Me.LogInRadioButton_AbandonnerReessayerIgnorer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInRadioButton_AbandonnerReessayerIgnorer.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LogInRadioButton_AbandonnerReessayerIgnorer.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInRadioButton_AbandonnerReessayerIgnorer.HighlightColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.LogInRadioButton_AbandonnerReessayerIgnorer.Location = New System.Drawing.Point(11, 219)
        Me.LogInRadioButton_AbandonnerReessayerIgnorer.Margin = New System.Windows.Forms.Padding(4)
        Me.LogInRadioButton_AbandonnerReessayerIgnorer.Name = "LogInRadioButton_AbandonnerReessayerIgnorer"
        Me.LogInRadioButton_AbandonnerReessayerIgnorer.Size = New System.Drawing.Size(332, 22)
        Me.LogInRadioButton_AbandonnerReessayerIgnorer.TabIndex = 21
        Me.LogInRadioButton_AbandonnerReessayerIgnorer.Text = "Abandonner, Réessayer et Ignorer "
        '
        'LogInRadioButton_Ok
        '
        Me.LogInRadioButton_Ok.BackColor = System.Drawing.Color.Transparent
        Me.LogInRadioButton_Ok.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInRadioButton_Ok.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInRadioButton_Ok.Checked = False
        Me.LogInRadioButton_Ok.CheckedColour = System.Drawing.Color.Firebrick
        Me.LogInRadioButton_Ok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInRadioButton_Ok.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LogInRadioButton_Ok.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInRadioButton_Ok.HighlightColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.LogInRadioButton_Ok.Location = New System.Drawing.Point(11, 47)
        Me.LogInRadioButton_Ok.Margin = New System.Windows.Forms.Padding(4)
        Me.LogInRadioButton_Ok.Name = "LogInRadioButton_Ok"
        Me.LogInRadioButton_Ok.Size = New System.Drawing.Size(147, 22)
        Me.LogInRadioButton_Ok.TabIndex = 20
        Me.LogInRadioButton_Ok.Text = "Ok"
        '
        'LogInRadioButton_OuiNonAnnuler
        '
        Me.LogInRadioButton_OuiNonAnnuler.BackColor = System.Drawing.Color.Transparent
        Me.LogInRadioButton_OuiNonAnnuler.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInRadioButton_OuiNonAnnuler.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInRadioButton_OuiNonAnnuler.Checked = False
        Me.LogInRadioButton_OuiNonAnnuler.CheckedColour = System.Drawing.Color.Firebrick
        Me.LogInRadioButton_OuiNonAnnuler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInRadioButton_OuiNonAnnuler.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LogInRadioButton_OuiNonAnnuler.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInRadioButton_OuiNonAnnuler.HighlightColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.LogInRadioButton_OuiNonAnnuler.Location = New System.Drawing.Point(11, 185)
        Me.LogInRadioButton_OuiNonAnnuler.Margin = New System.Windows.Forms.Padding(4)
        Me.LogInRadioButton_OuiNonAnnuler.Name = "LogInRadioButton_OuiNonAnnuler"
        Me.LogInRadioButton_OuiNonAnnuler.Size = New System.Drawing.Size(253, 22)
        Me.LogInRadioButton_OuiNonAnnuler.TabIndex = 15
        Me.LogInRadioButton_OuiNonAnnuler.Text = "Oui, Non et Annuler"
        '
        'LogInRadioButton_OuiNon
        '
        Me.LogInRadioButton_OuiNon.BackColor = System.Drawing.Color.Transparent
        Me.LogInRadioButton_OuiNon.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInRadioButton_OuiNon.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInRadioButton_OuiNon.Checked = False
        Me.LogInRadioButton_OuiNon.CheckedColour = System.Drawing.Color.Firebrick
        Me.LogInRadioButton_OuiNon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInRadioButton_OuiNon.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LogInRadioButton_OuiNon.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInRadioButton_OuiNon.HighlightColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.LogInRadioButton_OuiNon.Location = New System.Drawing.Point(11, 150)
        Me.LogInRadioButton_OuiNon.Margin = New System.Windows.Forms.Padding(4)
        Me.LogInRadioButton_OuiNon.Name = "LogInRadioButton_OuiNon"
        Me.LogInRadioButton_OuiNon.Size = New System.Drawing.Size(253, 22)
        Me.LogInRadioButton_OuiNon.TabIndex = 14
        Me.LogInRadioButton_OuiNon.Text = "Oui et Non"
        '
        'LogInRadioButton_ReessayerAnnuler
        '
        Me.LogInRadioButton_ReessayerAnnuler.BackColor = System.Drawing.Color.Transparent
        Me.LogInRadioButton_ReessayerAnnuler.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInRadioButton_ReessayerAnnuler.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInRadioButton_ReessayerAnnuler.Checked = False
        Me.LogInRadioButton_ReessayerAnnuler.CheckedColour = System.Drawing.Color.Firebrick
        Me.LogInRadioButton_ReessayerAnnuler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInRadioButton_ReessayerAnnuler.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LogInRadioButton_ReessayerAnnuler.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInRadioButton_ReessayerAnnuler.HighlightColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.LogInRadioButton_ReessayerAnnuler.Location = New System.Drawing.Point(11, 116)
        Me.LogInRadioButton_ReessayerAnnuler.Margin = New System.Windows.Forms.Padding(4)
        Me.LogInRadioButton_ReessayerAnnuler.Name = "LogInRadioButton_ReessayerAnnuler"
        Me.LogInRadioButton_ReessayerAnnuler.Size = New System.Drawing.Size(225, 22)
        Me.LogInRadioButton_ReessayerAnnuler.TabIndex = 13
        Me.LogInRadioButton_ReessayerAnnuler.Text = "Réessayer et Annuler"
        '
        'LogInRadioButton_OkAnnuler
        '
        Me.LogInRadioButton_OkAnnuler.BackColor = System.Drawing.Color.Transparent
        Me.LogInRadioButton_OkAnnuler.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInRadioButton_OkAnnuler.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInRadioButton_OkAnnuler.Checked = False
        Me.LogInRadioButton_OkAnnuler.CheckedColour = System.Drawing.Color.Firebrick
        Me.LogInRadioButton_OkAnnuler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInRadioButton_OkAnnuler.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LogInRadioButton_OkAnnuler.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInRadioButton_OkAnnuler.HighlightColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.LogInRadioButton_OkAnnuler.Location = New System.Drawing.Point(11, 81)
        Me.LogInRadioButton_OkAnnuler.Margin = New System.Windows.Forms.Padding(4)
        Me.LogInRadioButton_OkAnnuler.Name = "LogInRadioButton_OkAnnuler"
        Me.LogInRadioButton_OkAnnuler.Size = New System.Drawing.Size(167, 22)
        Me.LogInRadioButton_OkAnnuler.TabIndex = 12
        Me.LogInRadioButton_OkAnnuler.Text = "Ok et Annuler"
        '
        'LogInGroupBox1
        '
        Me.LogInGroupBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInGroupBox1.Controls.Add(Me.LogInRadioButton_Question)
        Me.LogInGroupBox1.Controls.Add(Me.LogInRadioButton_Critique)
        Me.LogInGroupBox1.Controls.Add(Me.LogInRadioButton_Alerte)
        Me.LogInGroupBox1.Controls.Add(Me.LogInRadioButton_Information)
        Me.LogInGroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LogInGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LogInGroupBox1.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInGroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.LogInGroupBox1.MainColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInGroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.LogInGroupBox1.Name = "LogInGroupBox1"
        Me.LogInGroupBox1.Size = New System.Drawing.Size(213, 320)
        Me.LogInGroupBox1.TabIndex = 21
        Me.LogInGroupBox1.Text = "Icône"
        Me.LogInGroupBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'LogInRadioButton_Question
        '
        Me.LogInRadioButton_Question.BackColor = System.Drawing.Color.Transparent
        Me.LogInRadioButton_Question.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInRadioButton_Question.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInRadioButton_Question.Checked = False
        Me.LogInRadioButton_Question.CheckedColour = System.Drawing.Color.Firebrick
        Me.LogInRadioButton_Question.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInRadioButton_Question.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LogInRadioButton_Question.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInRadioButton_Question.HighlightColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.LogInRadioButton_Question.Location = New System.Drawing.Point(4, 151)
        Me.LogInRadioButton_Question.Margin = New System.Windows.Forms.Padding(4)
        Me.LogInRadioButton_Question.Name = "LogInRadioButton_Question"
        Me.LogInRadioButton_Question.Size = New System.Drawing.Size(124, 22)
        Me.LogInRadioButton_Question.TabIndex = 15
        Me.LogInRadioButton_Question.Text = "Question"
        '
        'LogInRadioButton_Critique
        '
        Me.LogInRadioButton_Critique.BackColor = System.Drawing.Color.Transparent
        Me.LogInRadioButton_Critique.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInRadioButton_Critique.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInRadioButton_Critique.Checked = False
        Me.LogInRadioButton_Critique.CheckedColour = System.Drawing.Color.Firebrick
        Me.LogInRadioButton_Critique.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInRadioButton_Critique.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LogInRadioButton_Critique.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInRadioButton_Critique.HighlightColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.LogInRadioButton_Critique.Location = New System.Drawing.Point(4, 116)
        Me.LogInRadioButton_Critique.Margin = New System.Windows.Forms.Padding(4)
        Me.LogInRadioButton_Critique.Name = "LogInRadioButton_Critique"
        Me.LogInRadioButton_Critique.Size = New System.Drawing.Size(109, 22)
        Me.LogInRadioButton_Critique.TabIndex = 14
        Me.LogInRadioButton_Critique.Text = "Critique"
        '
        'LogInRadioButton_Alerte
        '
        Me.LogInRadioButton_Alerte.BackColor = System.Drawing.Color.Transparent
        Me.LogInRadioButton_Alerte.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInRadioButton_Alerte.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInRadioButton_Alerte.Checked = False
        Me.LogInRadioButton_Alerte.CheckedColour = System.Drawing.Color.Firebrick
        Me.LogInRadioButton_Alerte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInRadioButton_Alerte.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LogInRadioButton_Alerte.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInRadioButton_Alerte.HighlightColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.LogInRadioButton_Alerte.Location = New System.Drawing.Point(4, 82)
        Me.LogInRadioButton_Alerte.Margin = New System.Windows.Forms.Padding(4)
        Me.LogInRadioButton_Alerte.Name = "LogInRadioButton_Alerte"
        Me.LogInRadioButton_Alerte.Size = New System.Drawing.Size(109, 22)
        Me.LogInRadioButton_Alerte.TabIndex = 13
        Me.LogInRadioButton_Alerte.Text = "Alerte"
        '
        'LogInRadioButton_Information
        '
        Me.LogInRadioButton_Information.BackColor = System.Drawing.Color.Transparent
        Me.LogInRadioButton_Information.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInRadioButton_Information.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInRadioButton_Information.Checked = True
        Me.LogInRadioButton_Information.CheckedColour = System.Drawing.Color.Firebrick
        Me.LogInRadioButton_Information.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInRadioButton_Information.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LogInRadioButton_Information.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInRadioButton_Information.HighlightColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.LogInRadioButton_Information.Location = New System.Drawing.Point(4, 47)
        Me.LogInRadioButton_Information.Margin = New System.Windows.Forms.Padding(4)
        Me.LogInRadioButton_Information.Name = "LogInRadioButton_Information"
        Me.LogInRadioButton_Information.Size = New System.Drawing.Size(147, 22)
        Me.LogInRadioButton_Information.TabIndex = 12
        Me.LogInRadioButton_Information.Text = "Information"
        '
        'Options_02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(645, 444)
        Me.Controls.Add(Me.LogInLabel1)
        Me.Controls.Add(Me.LogInTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Options_02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Afficher un message"
        Me.LogInTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.LogInGroupBox2.ResumeLayout(False)
        Me.LogInGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LogInLabel1 As VBVEC.LogInLabel
    Friend WithEvents LogInTabControl1 As VBVEC.LogInTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents LogInLabel3 As VBVEC.LogInLabel
    Friend WithEvents LogInNormalTextBox2 As VBVEC.LogInNormalTextBox
    Friend WithEvents LogInLabel2 As VBVEC.LogInLabel
    Friend WithEvents LogInNormalTextBox1 As VBVEC.LogInNormalTextBox
    Friend WithEvents LogInButtonWithProgress1 As VBVEC.LogInButtonWithProgress
    Friend WithEvents LogInGroupBox2 As VBVEC.LogInGroupBox
    Friend WithEvents LogInRadioButton_AbandonnerReessayerIgnorer As VBVEC.LogInRadioButton
    Friend WithEvents LogInRadioButton_Ok As VBVEC.LogInRadioButton
    Friend WithEvents LogInRadioButton_OuiNonAnnuler As VBVEC.LogInRadioButton
    Friend WithEvents LogInRadioButton_OuiNon As VBVEC.LogInRadioButton
    Friend WithEvents LogInRadioButton_ReessayerAnnuler As VBVEC.LogInRadioButton
    Friend WithEvents LogInRadioButton_OkAnnuler As VBVEC.LogInRadioButton
    Friend WithEvents LogInGroupBox1 As VBVEC.LogInGroupBox
    Friend WithEvents LogInRadioButton_Question As VBVEC.LogInRadioButton
    Friend WithEvents LogInRadioButton_Critique As VBVEC.LogInRadioButton
    Friend WithEvents LogInRadioButton_Alerte As VBVEC.LogInRadioButton
    Friend WithEvents LogInRadioButton_Information As VBVEC.LogInRadioButton
    Friend WithEvents LogInButtonWithProgress2 As VBVEC.LogInButtonWithProgress
End Class
