<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogInLabel1 = New VBVEC_ADMIN.LogInLabel()
        Me.LogInTabControl1 = New VBVEC_ADMIN.LogInTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.FlatButton8 = New VBVEC_ADMIN.FlatButton()
        Me.FlatTextBox1 = New VBVEC_ADMIN.FlatTextBox()
        Me.LogInLabel2 = New VBVEC_ADMIN.LogInLabel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Banned = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Premium = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Registration_Date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Expiration = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Generated = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Rank = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LogInGroupBox1 = New VBVEC_ADMIN.LogInGroupBox()
        Me.LogInSeperator2 = New VBVEC_ADMIN.LogInSeperator()
        Me.FlatButton11 = New VBVEC_ADMIN.FlatButton()
        Me.LogInSeperator1 = New VBVEC_ADMIN.LogInSeperator()
        Me.FlatButton7 = New VBVEC_ADMIN.FlatButton()
        Me.FlatButton6 = New VBVEC_ADMIN.FlatButton()
        Me.FlatButton5 = New VBVEC_ADMIN.FlatButton()
        Me.FlatButton4 = New VBVEC_ADMIN.FlatButton()
        Me.FlatButton3 = New VBVEC_ADMIN.FlatButton()
        Me.FlatButton2 = New VBVEC_ADMIN.FlatButton()
        Me.FlatButton1 = New VBVEC_ADMIN.FlatButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.FlatButton10 = New VBVEC_ADMIN.FlatButton()
        Me.FlatButton9 = New VBVEC_ADMIN.FlatButton()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.LogInTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.LogInGroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopierToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(123, 28)
        '
        'CopierToolStripMenuItem
        '
        Me.CopierToolStripMenuItem.Name = "CopierToolStripMenuItem"
        Me.CopierToolStripMenuItem.Size = New System.Drawing.Size(122, 24)
        Me.CopierToolStripMenuItem.Text = "Copier"
        '
        'LogInLabel1
        '
        Me.LogInLabel1.AutoSize = True
        Me.LogInLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!)
        Me.LogInLabel1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.Location = New System.Drawing.Point(304, 24)
        Me.LogInLabel1.Name = "LogInLabel1"
        Me.LogInLabel1.Size = New System.Drawing.Size(969, 85)
        Me.LogInLabel1.TabIndex = 1
        Me.LogInLabel1.Text = "PANEL ADMINISTRATEUR"
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
        Me.LogInTabControl1.HorizontalLineColour = System.Drawing.Color.Purple
        Me.LogInTabControl1.ItemSize = New System.Drawing.Size(240, 32)
        Me.LogInTabControl1.Location = New System.Drawing.Point(3, 126)
        Me.LogInTabControl1.Name = "LogInTabControl1"
        Me.LogInTabControl1.SelectedIndex = 0
        Me.LogInTabControl1.Size = New System.Drawing.Size(1309, 651)
        Me.LogInTabControl1.TabIndex = 0
        Me.LogInTabControl1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInTabControl1.UpLineColour = System.Drawing.Color.Purple
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.FlatButton8)
        Me.TabPage1.Controls.Add(Me.FlatTextBox1)
        Me.TabPage1.Controls.Add(Me.LogInLabel2)
        Me.TabPage1.Controls.Add(Me.ListView1)
        Me.TabPage1.Controls.Add(Me.LogInGroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 36)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1301, 611)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Utilisateurs"
        '
        'FlatButton8
        '
        Me.FlatButton8.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton8.BaseColor = System.Drawing.Color.Gray
        Me.FlatButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton8.Location = New System.Drawing.Point(499, 555)
        Me.FlatButton8.Name = "FlatButton8"
        Me.FlatButton8.Rounded = False
        Me.FlatButton8.Size = New System.Drawing.Size(219, 34)
        Me.FlatButton8.TabIndex = 8
        Me.FlatButton8.Text = "Actualiser"
        Me.FlatButton8.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatTextBox1
        '
        Me.FlatTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox1.Location = New System.Drawing.Point(276, 555)
        Me.FlatTextBox1.MaxLength = 32767
        Me.FlatTextBox1.Multiline = False
        Me.FlatTextBox1.Name = "FlatTextBox1"
        Me.FlatTextBox1.ReadOnly = False
        Me.FlatTextBox1.Size = New System.Drawing.Size(217, 34)
        Me.FlatTextBox1.TabIndex = 3
        Me.FlatTextBox1.Text = "Tb6df*apxJN@rjD^"
        Me.FlatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox1.UseSystemPasswordChar = True
        '
        'LogInLabel2
        '
        Me.LogInLabel2.AutoSize = True
        Me.LogInLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.LogInLabel2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel2.Location = New System.Drawing.Point(78, 557)
        Me.LogInLabel2.Name = "LogInLabel2"
        Me.LogInLabel2.Size = New System.Drawing.Size(201, 25)
        Me.LogInLabel2.TabIndex = 2
        Me.LogInLabel2.Text = "Mot de passe admin :  "
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Username, Me.Banned, Me.Premium, Me.Registration_Date, Me.Expiration, Me.Email, Me.Generated, Me.Rank})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(6, 36)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(795, 499)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 38
        '
        'Username
        '
        Me.Username.Text = "Username"
        Me.Username.Width = 92
        '
        'Banned
        '
        Me.Banned.Text = "Banned"
        Me.Banned.Width = 80
        '
        'Premium
        '
        Me.Premium.Text = "Premium"
        Me.Premium.Width = 90
        '
        'Registration_Date
        '
        Me.Registration_Date.Text = "Registration Date"
        Me.Registration_Date.Width = 146
        '
        'Expiration
        '
        Me.Expiration.Text = "Expiration"
        Me.Expiration.Width = 178
        '
        'Email
        '
        Me.Email.Text = "Email"
        Me.Email.Width = 131
        '
        'Generated
        '
        Me.Generated.Text = "Generated"
        '
        'Rank
        '
        Me.Rank.Text = "Rank"
        '
        'LogInGroupBox1
        '
        Me.LogInGroupBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInGroupBox1.Controls.Add(Me.LogInSeperator2)
        Me.LogInGroupBox1.Controls.Add(Me.FlatButton11)
        Me.LogInGroupBox1.Controls.Add(Me.LogInSeperator1)
        Me.LogInGroupBox1.Controls.Add(Me.FlatButton7)
        Me.LogInGroupBox1.Controls.Add(Me.FlatButton6)
        Me.LogInGroupBox1.Controls.Add(Me.FlatButton5)
        Me.LogInGroupBox1.Controls.Add(Me.FlatButton4)
        Me.LogInGroupBox1.Controls.Add(Me.FlatButton3)
        Me.LogInGroupBox1.Controls.Add(Me.FlatButton2)
        Me.LogInGroupBox1.Controls.Add(Me.FlatButton1)
        Me.LogInGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LogInGroupBox1.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInGroupBox1.Location = New System.Drawing.Point(807, 6)
        Me.LogInGroupBox1.MainColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInGroupBox1.Name = "LogInGroupBox1"
        Me.LogInGroupBox1.Size = New System.Drawing.Size(487, 529)
        Me.LogInGroupBox1.TabIndex = 0
        Me.LogInGroupBox1.Text = "Options"
        Me.LogInGroupBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'LogInSeperator2
        '
        Me.LogInSeperator2.Alignment = VBVEC_ADMIN.LogInSeperator.Style.Horizontal
        Me.LogInSeperator2.BackColor = System.Drawing.Color.Transparent
        Me.LogInSeperator2.Location = New System.Drawing.Point(11, 447)
        Me.LogInSeperator2.Name = "LogInSeperator2"
        Me.LogInSeperator2.SeperatorColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInSeperator2.Size = New System.Drawing.Size(463, 11)
        Me.LogInSeperator2.TabIndex = 10
        Me.LogInSeperator2.Text = "LogInSeperator2"
        Me.LogInSeperator2.Thickness = 1.0!
        '
        'FlatButton11
        '
        Me.FlatButton11.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton11.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton11.Location = New System.Drawing.Point(12, 470)
        Me.FlatButton11.Name = "FlatButton11"
        Me.FlatButton11.Rounded = False
        Me.FlatButton11.Size = New System.Drawing.Size(463, 43)
        Me.FlatButton11.TabIndex = 9
        Me.FlatButton11.Text = "Créer un nouvel utilisateur"
        Me.FlatButton11.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'LogInSeperator1
        '
        Me.LogInSeperator1.Alignment = VBVEC_ADMIN.LogInSeperator.Style.Horizontal
        Me.LogInSeperator1.BackColor = System.Drawing.Color.Transparent
        Me.LogInSeperator1.Location = New System.Drawing.Point(12, 371)
        Me.LogInSeperator1.Name = "LogInSeperator1"
        Me.LogInSeperator1.SeperatorColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInSeperator1.Size = New System.Drawing.Size(463, 11)
        Me.LogInSeperator1.TabIndex = 7
        Me.LogInSeperator1.Text = "LogInSeperator1"
        Me.LogInSeperator1.Thickness = 1.0!
        '
        'FlatButton7
        '
        Me.FlatButton7.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton7.BaseColor = System.Drawing.Color.Firebrick
        Me.FlatButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton7.Location = New System.Drawing.Point(11, 395)
        Me.FlatButton7.Name = "FlatButton7"
        Me.FlatButton7.Rounded = False
        Me.FlatButton7.Size = New System.Drawing.Size(464, 40)
        Me.FlatButton7.TabIndex = 6
        Me.FlatButton7.Text = "Supprimer l'utilisateur"
        Me.FlatButton7.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton6
        '
        Me.FlatButton6.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton6.BaseColor = System.Drawing.Color.Gray
        Me.FlatButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton6.Location = New System.Drawing.Point(12, 292)
        Me.FlatButton6.Name = "FlatButton6"
        Me.FlatButton6.Rounded = False
        Me.FlatButton6.Size = New System.Drawing.Size(464, 61)
        Me.FlatButton6.TabIndex = 5
        Me.FlatButton6.Text = "Changer le mot de passe"
        Me.FlatButton6.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton5
        '
        Me.FlatButton5.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton5.BaseColor = System.Drawing.Color.Gray
        Me.FlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton5.Location = New System.Drawing.Point(12, 215)
        Me.FlatButton5.Name = "FlatButton5"
        Me.FlatButton5.Rounded = False
        Me.FlatButton5.Size = New System.Drawing.Size(464, 61)
        Me.FlatButton5.TabIndex = 4
        Me.FlatButton5.Text = "Changer le pseudo"
        Me.FlatButton5.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton4
        '
        Me.FlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton4.BaseColor = System.Drawing.Color.RoyalBlue
        Me.FlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton4.Location = New System.Drawing.Point(257, 132)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.Rounded = False
        Me.FlatButton4.Size = New System.Drawing.Size(219, 61)
        Me.FlatButton4.TabIndex = 3
        Me.FlatButton4.Text = "Retirer premium"
        Me.FlatButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.Goldenrod
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(12, 132)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(219, 61)
        Me.FlatButton3.TabIndex = 2
        Me.FlatButton3.Text = "Premium"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(257, 55)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(219, 61)
        Me.FlatButton2.TabIndex = 1
        Me.FlatButton2.Text = "Débannir"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FlatButton1.Location = New System.Drawing.Point(12, 55)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(219, 61)
        Me.FlatButton1.TabIndex = 0
        Me.FlatButton1.Text = "Bannir"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.FlatButton10)
        Me.TabPage2.Controls.Add(Me.FlatButton9)
        Me.TabPage2.Controls.Add(Me.ListView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1301, 611)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Clés de license"
        '
        'FlatButton10
        '
        Me.FlatButton10.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton10.BaseColor = System.Drawing.Color.Gray
        Me.FlatButton10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton10.Location = New System.Drawing.Point(706, 298)
        Me.FlatButton10.Name = "FlatButton10"
        Me.FlatButton10.Rounded = False
        Me.FlatButton10.Size = New System.Drawing.Size(305, 53)
        Me.FlatButton10.TabIndex = 11
        Me.FlatButton10.Text = "Actualiser"
        Me.FlatButton10.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton9
        '
        Me.FlatButton9.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton9.BaseColor = System.Drawing.Color.Gray
        Me.FlatButton9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton9.Location = New System.Drawing.Point(706, 224)
        Me.FlatButton9.Name = "FlatButton9"
        Me.FlatButton9.Rounded = False
        Me.FlatButton9.Size = New System.Drawing.Size(305, 53)
        Me.FlatButton9.TabIndex = 10
        Me.FlatButton9.Text = "Générer Une clé de license"
        Me.FlatButton9.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader11, Me.ColumnHeader7})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(6, 6)
        Me.ListView2.MultiSelect = False
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(454, 597)
        Me.ListView2.TabIndex = 2
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ID"
        Me.ColumnHeader3.Width = 38
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Key"
        Me.ColumnHeader11.Width = 140
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Username"
        Me.ColumnHeader7.Width = 265
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1314, 779)
        Me.Controls.Add(Me.LogInLabel1)
        Me.Controls.Add(Me.LogInTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Panel"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.LogInTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.LogInGroupBox1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LogInTabControl1 As LogInTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents LogInLabel1 As LogInLabel
    Friend WithEvents FlatButton8 As FlatButton
    Friend WithEvents FlatTextBox1 As FlatTextBox
    Friend WithEvents LogInLabel2 As LogInLabel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents Username As ColumnHeader
    Friend WithEvents Banned As ColumnHeader
    Friend WithEvents Premium As ColumnHeader
    Friend WithEvents Registration_Date As ColumnHeader
    Friend WithEvents LogInGroupBox1 As LogInGroupBox
    Friend WithEvents LogInSeperator1 As LogInSeperator
    Friend WithEvents FlatButton7 As FlatButton
    Friend WithEvents FlatButton6 As FlatButton
    Friend WithEvents FlatButton5 As FlatButton
    Friend WithEvents FlatButton4 As FlatButton
    Friend WithEvents FlatButton3 As FlatButton
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents FlatButton9 As FlatButton
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents FlatButton10 As FlatButton
    Friend WithEvents Expiration As ColumnHeader
    Friend WithEvents Email As ColumnHeader
    Friend WithEvents Generated As ColumnHeader
    Friend WithEvents Rank As ColumnHeader
    Friend WithEvents LogInSeperator2 As LogInSeperator
    Friend WithEvents FlatButton11 As FlatButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CopierToolStripMenuItem As ToolStripMenuItem
End Class
