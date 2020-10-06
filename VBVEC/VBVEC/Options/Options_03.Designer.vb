<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options_03
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options_03))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LogInLabel1 = New VBVEC.LogInLabel()
        Me.LogInTabControl1 = New VBVEC.LogInTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LogInButtonWithProgress2 = New VBVEC.LogInButtonWithProgress()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LogInButtonWithProgress1 = New VBVEC.LogInButtonWithProgress()
        Me.LogInNormalTextBox1 = New VBVEC.LogInNormalTextBox()
        Me.LogInCheckBox3 = New VBVEC.LogInCheckBox()
        Me.LogInCheckBox2 = New VBVEC.LogInCheckBox()
        Me.LogInCheckBox1 = New VBVEC.LogInCheckBox()
        Me.LogInRadioButton4 = New VBVEC.LogInRadioButton()
        Me.LogInRadioButton3 = New VBVEC.LogInRadioButton()
        Me.LogInRadioButton2 = New VBVEC.LogInRadioButton()
        Me.LogInRadioButton1 = New VBVEC.LogInRadioButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.LogInTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'LogInLabel1
        '
        Me.LogInLabel1.AutoSize = True
        Me.LogInLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogInLabel1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.Location = New System.Drawing.Point(130, 9)
        Me.LogInLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LogInLabel1.Name = "LogInLabel1"
        Me.LogInLabel1.Size = New System.Drawing.Size(377, 54)
        Me.LogInLabel1.TabIndex = 3
        Me.LogInLabel1.Text = "Eteindre la machine"
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
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.LogInCheckBox3)
        Me.TabPage1.Controls.Add(Me.LogInCheckBox2)
        Me.TabPage1.Controls.Add(Me.LogInCheckBox1)
        Me.TabPage1.Controls.Add(Me.LogInRadioButton4)
        Me.TabPage1.Controls.Add(Me.LogInRadioButton3)
        Me.TabPage1.Controls.Add(Me.LogInRadioButton2)
        Me.TabPage1.Controls.Add(Me.LogInRadioButton1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 36)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(644, 330)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Options"
        '
        'LogInButtonWithProgress2
        '
        Me.LogInButtonWithProgress2.BackColor = System.Drawing.Color.Transparent
        Me.LogInButtonWithProgress2.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButtonWithProgress2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButtonWithProgress2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress2.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButtonWithProgress2.Location = New System.Drawing.Point(198, 269)
        Me.LogInButtonWithProgress2.Maximum = 100
        Me.LogInButtonWithProgress2.Name = "LogInButtonWithProgress2"
        Me.LogInButtonWithProgress2.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButtonWithProgress2.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress2.Size = New System.Drawing.Size(237, 50)
        Me.LogInButtonWithProgress2.TabIndex = 2
        Me.LogInButtonWithProgress2.Text = "Valider"
        Me.LogInButtonWithProgress2.Value = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LogInButtonWithProgress1)
        Me.GroupBox1.Controls.Add(Me.LogInNormalTextBox1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(7, 182)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(621, 77)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Commande batch :"
        '
        'LogInButtonWithProgress1
        '
        Me.LogInButtonWithProgress1.BackColor = System.Drawing.Color.Transparent
        Me.LogInButtonWithProgress1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButtonWithProgress1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButtonWithProgress1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButtonWithProgress1.Location = New System.Drawing.Point(523, 31)
        Me.LogInButtonWithProgress1.Maximum = 100
        Me.LogInButtonWithProgress1.Name = "LogInButtonWithProgress1"
        Me.LogInButtonWithProgress1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButtonWithProgress1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress1.Size = New System.Drawing.Size(83, 34)
        Me.LogInButtonWithProgress1.TabIndex = 1
        Me.LogInButtonWithProgress1.Text = "Copier"
        Me.LogInButtonWithProgress1.Value = 0
        '
        'LogInNormalTextBox1
        '
        Me.LogInNormalTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.LogInNormalTextBox1.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInNormalTextBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInNormalTextBox1.Location = New System.Drawing.Point(16, 29)
        Me.LogInNormalTextBox1.MaxLength = 32767
        Me.LogInNormalTextBox1.Multiline = False
        Me.LogInNormalTextBox1.Name = "LogInNormalTextBox1"
        Me.LogInNormalTextBox1.ReadOnly = True
        Me.LogInNormalTextBox1.Size = New System.Drawing.Size(501, 34)
        Me.LogInNormalTextBox1.Style = VBVEC.LogInNormalTextBox.Styles.NotRounded
        Me.LogInNormalTextBox1.TabIndex = 0
        Me.LogInNormalTextBox1.Text = "shutdown"
        Me.LogInNormalTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.LogInNormalTextBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInNormalTextBox1.UseSystemPasswordChar = False
        '
        'LogInCheckBox3
        '
        Me.LogInCheckBox3.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInCheckBox3.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInCheckBox3.Checked = False
        Me.LogInCheckBox3.CheckedColour = System.Drawing.Color.Firebrick
        Me.LogInCheckBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInCheckBox3.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInCheckBox3.Location = New System.Drawing.Point(392, 88)
        Me.LogInCheckBox3.Name = "LogInCheckBox3"
        Me.LogInCheckBox3.Size = New System.Drawing.Size(224, 22)
        Me.LogInCheckBox3.TabIndex = 6
        Me.LogInCheckBox3.Text = "Définir un temps d'arrêt"
        '
        'LogInCheckBox2
        '
        Me.LogInCheckBox2.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInCheckBox2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInCheckBox2.Checked = False
        Me.LogInCheckBox2.CheckedColour = System.Drawing.Color.Firebrick
        Me.LogInCheckBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInCheckBox2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInCheckBox2.Location = New System.Drawing.Point(392, 52)
        Me.LogInCheckBox2.Name = "LogInCheckBox2"
        Me.LogInCheckBox2.Size = New System.Drawing.Size(224, 22)
        Me.LogInCheckBox2.TabIndex = 5
        Me.LogInCheckBox2.Text = "Ajouter un commentaire"
        '
        'LogInCheckBox1
        '
        Me.LogInCheckBox1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInCheckBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInCheckBox1.Checked = False
        Me.LogInCheckBox1.CheckedColour = System.Drawing.Color.Firebrick
        Me.LogInCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInCheckBox1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInCheckBox1.Location = New System.Drawing.Point(392, 16)
        Me.LogInCheckBox1.Name = "LogInCheckBox1"
        Me.LogInCheckBox1.Size = New System.Drawing.Size(224, 22)
        Me.LogInCheckBox1.TabIndex = 4
        Me.LogInCheckBox1.Text = "Forcer le processus"
        '
        'LogInRadioButton4
        '
        Me.LogInRadioButton4.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInRadioButton4.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInRadioButton4.Checked = False
        Me.LogInRadioButton4.CheckedColour = System.Drawing.Color.Firebrick
        Me.LogInRadioButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInRadioButton4.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInRadioButton4.HighlightColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.LogInRadioButton4.Location = New System.Drawing.Point(26, 110)
        Me.LogInRadioButton4.Name = "LogInRadioButton4"
        Me.LogInRadioButton4.Size = New System.Drawing.Size(350, 22)
        Me.LogInRadioButton4.TabIndex = 3
        Me.LogInRadioButton4.Text = "Mettre l'ordinateur en veille prolongée"
        '
        'LogInRadioButton3
        '
        Me.LogInRadioButton3.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInRadioButton3.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInRadioButton3.Checked = False
        Me.LogInRadioButton3.CheckedColour = System.Drawing.Color.Firebrick
        Me.LogInRadioButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInRadioButton3.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInRadioButton3.HighlightColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.LogInRadioButton3.Location = New System.Drawing.Point(26, 74)
        Me.LogInRadioButton3.Name = "LogInRadioButton3"
        Me.LogInRadioButton3.Size = New System.Drawing.Size(350, 22)
        Me.LogInRadioButton3.TabIndex = 2
        Me.LogInRadioButton3.Text = "Redémarrer l'ordinateur"
        '
        'LogInRadioButton2
        '
        Me.LogInRadioButton2.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInRadioButton2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInRadioButton2.Checked = False
        Me.LogInRadioButton2.CheckedColour = System.Drawing.Color.Firebrick
        Me.LogInRadioButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInRadioButton2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInRadioButton2.HighlightColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.LogInRadioButton2.Location = New System.Drawing.Point(26, 38)
        Me.LogInRadioButton2.Name = "LogInRadioButton2"
        Me.LogInRadioButton2.Size = New System.Drawing.Size(350, 22)
        Me.LogInRadioButton2.TabIndex = 1
        Me.LogInRadioButton2.Text = "Arrêter l'ordinateur"
        '
        'LogInRadioButton1
        '
        Me.LogInRadioButton1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInRadioButton1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInRadioButton1.Checked = True
        Me.LogInRadioButton1.CheckedColour = System.Drawing.Color.Firebrick
        Me.LogInRadioButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInRadioButton1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInRadioButton1.HighlightColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.LogInRadioButton1.Location = New System.Drawing.Point(26, 2)
        Me.LogInRadioButton1.Name = "LogInRadioButton1"
        Me.LogInRadioButton1.Size = New System.Drawing.Size(350, 22)
        Me.LogInRadioButton1.TabIndex = 0
        Me.LogInRadioButton1.Text = "Déconnecter immédiatement l'utilisateur"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.RichTextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(644, 330)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Documentation/Aide"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.RichTextBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.SystemColors.Menu
        Me.RichTextBox1.Location = New System.Drawing.Point(1, 2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(635, 319)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Options_03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(645, 444)
        Me.Controls.Add(Me.LogInLabel1)
        Me.Controls.Add(Me.LogInTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Options_03"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Eteindre la machine"
        Me.LogInTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LogInLabel1 As VBVEC.LogInLabel
    Friend WithEvents LogInTabControl1 As VBVEC.LogInTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents LogInCheckBox3 As LogInCheckBox
    Friend WithEvents LogInCheckBox2 As LogInCheckBox
    Friend WithEvents LogInCheckBox1 As LogInCheckBox
    Friend WithEvents LogInRadioButton4 As LogInRadioButton
    Friend WithEvents LogInRadioButton3 As LogInRadioButton
    Friend WithEvents LogInRadioButton2 As LogInRadioButton
    Friend WithEvents LogInRadioButton1 As LogInRadioButton
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LogInNormalTextBox1 As LogInNormalTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LogInButtonWithProgress1 As LogInButtonWithProgress
    Friend WithEvents LogInButtonWithProgress2 As LogInButtonWithProgress
End Class
