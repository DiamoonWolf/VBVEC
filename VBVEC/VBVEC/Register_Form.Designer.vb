<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register_Form))
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LogInLabel5 = New VBVEC.LogInLabel()
        Me.LogInNormalTextBox5 = New VBVEC.LogInNormalTextBox()
        Me.LogInButtonWithProgress1 = New VBVEC.LogInButtonWithProgress()
        Me.LogInLabel4 = New VBVEC.LogInLabel()
        Me.LogInNormalTextBox4 = New VBVEC.LogInNormalTextBox()
        Me.LogInLabel3 = New VBVEC.LogInLabel()
        Me.LogInNormalTextBox3 = New VBVEC.LogInNormalTextBox()
        Me.LogInLabel2 = New VBVEC.LogInLabel()
        Me.LogInLabel1 = New VBVEC.LogInLabel()
        Me.LogInNormalTextBox2 = New VBVEC.LogInNormalTextBox()
        Me.LogInNormalTextBox1 = New VBVEC.LogInNormalTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.Firebrick
        Me.CheckBox1.Location = New System.Drawing.Point(82, 401)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(384, 21)
        Me.CheckBox1.TabIndex = 26
        Me.CheckBox1.Text = "J'accepte les CGU/CGV/Politique de confidentialité..... ..."
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.DarkRed
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Firebrick
        Me.LinkLabel1.Location = New System.Drawing.Point(188, 491)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(248, 17)
        Me.LinkLabel1.TabIndex = 27
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "CGU; CGV; Politique de confidentialité"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Firebrick
        '
        'LogInLabel5
        '
        Me.LogInLabel5.AutoSize = True
        Me.LogInLabel5.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel5.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel5.Location = New System.Drawing.Point(78, 214)
        Me.LogInLabel5.Name = "LogInLabel5"
        Me.LogInLabel5.Size = New System.Drawing.Size(178, 20)
        Me.LogInLabel5.TabIndex = 25
        Me.LogInLabel5.Text = "Adresse eMail (facultatif):"
        '
        'LogInNormalTextBox5
        '
        Me.LogInNormalTextBox5.BackColor = System.Drawing.Color.Transparent
        Me.LogInNormalTextBox5.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInNormalTextBox5.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInNormalTextBox5.Location = New System.Drawing.Point(90, 238)
        Me.LogInNormalTextBox5.MaxLength = 70
        Me.LogInNormalTextBox5.Multiline = False
        Me.LogInNormalTextBox5.Name = "LogInNormalTextBox5"
        Me.LogInNormalTextBox5.ReadOnly = False
        Me.LogInNormalTextBox5.Size = New System.Drawing.Size(448, 34)
        Me.LogInNormalTextBox5.Style = VBVEC.LogInNormalTextBox.Styles.NotRounded
        Me.LogInNormalTextBox5.TabIndex = 24
        Me.LogInNormalTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.LogInNormalTextBox5.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInNormalTextBox5.UseSystemPasswordChar = False
        '
        'LogInButtonWithProgress1
        '
        Me.LogInButtonWithProgress1.BackColor = System.Drawing.Color.Transparent
        Me.LogInButtonWithProgress1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButtonWithProgress1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButtonWithProgress1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButtonWithProgress1.Location = New System.Drawing.Point(212, 430)
        Me.LogInButtonWithProgress1.Maximum = 100
        Me.LogInButtonWithProgress1.Name = "LogInButtonWithProgress1"
        Me.LogInButtonWithProgress1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButtonWithProgress1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress1.Size = New System.Drawing.Size(193, 49)
        Me.LogInButtonWithProgress1.TabIndex = 23
        Me.LogInButtonWithProgress1.Text = "Register"
        Me.LogInButtonWithProgress1.Value = 0
        '
        'LogInLabel4
        '
        Me.LogInLabel4.AutoSize = True
        Me.LogInLabel4.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel4.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel4.Location = New System.Drawing.Point(76, 340)
        Me.LogInLabel4.Name = "LogInLabel4"
        Me.LogInLabel4.Size = New System.Drawing.Size(186, 20)
        Me.LogInLabel4.TabIndex = 22
        Me.LogInLabel4.Text = "Confirmez le mot de passe"
        '
        'LogInNormalTextBox4
        '
        Me.LogInNormalTextBox4.BackColor = System.Drawing.Color.Transparent
        Me.LogInNormalTextBox4.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInNormalTextBox4.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInNormalTextBox4.Location = New System.Drawing.Point(88, 361)
        Me.LogInNormalTextBox4.MaxLength = 120
        Me.LogInNormalTextBox4.Multiline = False
        Me.LogInNormalTextBox4.Name = "LogInNormalTextBox4"
        Me.LogInNormalTextBox4.ReadOnly = False
        Me.LogInNormalTextBox4.Size = New System.Drawing.Size(448, 34)
        Me.LogInNormalTextBox4.Style = VBVEC.LogInNormalTextBox.Styles.NotRounded
        Me.LogInNormalTextBox4.TabIndex = 21
        Me.LogInNormalTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.LogInNormalTextBox4.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInNormalTextBox4.UseSystemPasswordChar = True
        '
        'LogInLabel3
        '
        Me.LogInLabel3.AutoSize = True
        Me.LogInLabel3.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel3.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel3.Location = New System.Drawing.Point(76, 274)
        Me.LogInLabel3.Name = "LogInLabel3"
        Me.LogInLabel3.Size = New System.Drawing.Size(101, 20)
        Me.LogInLabel3.TabIndex = 20
        Me.LogInLabel3.Text = "Mot de passe:"
        '
        'LogInNormalTextBox3
        '
        Me.LogInNormalTextBox3.BackColor = System.Drawing.Color.Transparent
        Me.LogInNormalTextBox3.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInNormalTextBox3.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInNormalTextBox3.Location = New System.Drawing.Point(88, 297)
        Me.LogInNormalTextBox3.MaxLength = 120
        Me.LogInNormalTextBox3.Multiline = False
        Me.LogInNormalTextBox3.Name = "LogInNormalTextBox3"
        Me.LogInNormalTextBox3.ReadOnly = False
        Me.LogInNormalTextBox3.Size = New System.Drawing.Size(448, 34)
        Me.LogInNormalTextBox3.Style = VBVEC.LogInNormalTextBox.Styles.NotRounded
        Me.LogInNormalTextBox3.TabIndex = 19
        Me.LogInNormalTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.LogInNormalTextBox3.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInNormalTextBox3.UseSystemPasswordChar = True
        '
        'LogInLabel2
        '
        Me.LogInLabel2.AutoSize = True
        Me.LogInLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel2.Location = New System.Drawing.Point(76, 154)
        Me.LogInLabel2.Name = "LogInLabel2"
        Me.LogInLabel2.Size = New System.Drawing.Size(126, 20)
        Me.LogInLabel2.TabIndex = 17
        Me.LogInLabel2.Text = "Nom d'utilisateur:"
        '
        'LogInLabel1
        '
        Me.LogInLabel1.AutoSize = True
        Me.LogInLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.Location = New System.Drawing.Point(76, 91)
        Me.LogInLabel1.Name = "LogInLabel1"
        Me.LogInLabel1.Size = New System.Drawing.Size(103, 20)
        Me.LogInLabel1.TabIndex = 16
        Me.LogInLabel1.Text = "Clé de license:"
        '
        'LogInNormalTextBox2
        '
        Me.LogInNormalTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.LogInNormalTextBox2.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInNormalTextBox2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInNormalTextBox2.Location = New System.Drawing.Point(88, 178)
        Me.LogInNormalTextBox2.MaxLength = 20
        Me.LogInNormalTextBox2.Multiline = False
        Me.LogInNormalTextBox2.Name = "LogInNormalTextBox2"
        Me.LogInNormalTextBox2.ReadOnly = False
        Me.LogInNormalTextBox2.Size = New System.Drawing.Size(448, 34)
        Me.LogInNormalTextBox2.Style = VBVEC.LogInNormalTextBox.Styles.NotRounded
        Me.LogInNormalTextBox2.TabIndex = 15
        Me.LogInNormalTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.LogInNormalTextBox2.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInNormalTextBox2.UseSystemPasswordChar = False
        '
        'LogInNormalTextBox1
        '
        Me.LogInNormalTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.LogInNormalTextBox1.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInNormalTextBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInNormalTextBox1.Location = New System.Drawing.Point(88, 114)
        Me.LogInNormalTextBox1.MaxLength = 32767
        Me.LogInNormalTextBox1.Multiline = False
        Me.LogInNormalTextBox1.Name = "LogInNormalTextBox1"
        Me.LogInNormalTextBox1.ReadOnly = False
        Me.LogInNormalTextBox1.Size = New System.Drawing.Size(448, 34)
        Me.LogInNormalTextBox1.Style = VBVEC.LogInNormalTextBox.Styles.NotRounded
        Me.LogInNormalTextBox1.TabIndex = 14
        Me.LogInNormalTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.LogInNormalTextBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInNormalTextBox1.UseSystemPasswordChar = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(188, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(241, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Register_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(617, 517)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.LogInLabel5)
        Me.Controls.Add(Me.LogInNormalTextBox5)
        Me.Controls.Add(Me.LogInButtonWithProgress1)
        Me.Controls.Add(Me.LogInLabel4)
        Me.Controls.Add(Me.LogInNormalTextBox4)
        Me.Controls.Add(Me.LogInLabel3)
        Me.Controls.Add(Me.LogInNormalTextBox3)
        Me.Controls.Add(Me.LogInLabel2)
        Me.Controls.Add(Me.LogInLabel1)
        Me.Controls.Add(Me.LogInNormalTextBox2)
        Me.Controls.Add(Me.LogInNormalTextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Register_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Register_Form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LogInLabel2 As LogInLabel
    Friend WithEvents LogInLabel1 As LogInLabel
    Friend WithEvents LogInNormalTextBox2 As LogInNormalTextBox
    Friend WithEvents LogInNormalTextBox1 As LogInNormalTextBox
    Friend WithEvents LogInLabel3 As LogInLabel
    Friend WithEvents LogInNormalTextBox3 As LogInNormalTextBox
    Friend WithEvents LogInLabel4 As LogInLabel
    Friend WithEvents LogInNormalTextBox4 As LogInNormalTextBox
    Friend WithEvents LogInButtonWithProgress1 As LogInButtonWithProgress
    Friend WithEvents LogInLabel5 As LogInLabel
    Friend WithEvents LogInNormalTextBox5 As LogInNormalTextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class
