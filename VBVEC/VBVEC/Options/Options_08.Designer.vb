<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Options_08
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LogInLabel1 = New VBVEC.LogInLabel()
        Me.LogInTabControl1 = New VBVEC.LogInTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.LogInButtonWithProgress2 = New VBVEC.LogInButtonWithProgress()
        Me.LogInLabel2 = New VBVEC.LogInLabel()
        Me.LogInButtonWithProgress1 = New VBVEC.LogInButtonWithProgress()
        Me.LogInTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LogInLabel1
        '
        Me.LogInLabel1.AutoSize = True
        Me.LogInLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogInLabel1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.Location = New System.Drawing.Point(101, 9)
        Me.LogInLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LogInLabel1.Name = "LogInLabel1"
        Me.LogInLabel1.Size = New System.Drawing.Size(447, 54)
        Me.LogInLabel1.TabIndex = 3
        Me.LogInLabel1.Text = "Faire parler l'ordinateur"
        '
        'LogInTabControl1
        '
        Me.LogInTabControl1.ActiveColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInTabControl1.BackTabColour = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LogInTabControl1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInTabControl1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.LogInTabControl1.Controls.Add(Me.TabPage1)
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
        Me.TabPage1.Controls.Add(Me.RichTextBox1)
        Me.TabPage1.Controls.Add(Me.LogInButtonWithProgress2)
        Me.TabPage1.Controls.Add(Me.LogInLabel2)
        Me.TabPage1.Controls.Add(Me.LogInButtonWithProgress1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 36)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(644, 330)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Texte à prononcer"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.RichTextBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.SystemColors.Menu
        Me.RichTextBox1.Location = New System.Drawing.Point(149, 63)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(367, 123)
        Me.RichTextBox1.TabIndex = 11
        Me.RichTextBox1.Text = "Je suis une petite voix."
        '
        'LogInButtonWithProgress2
        '
        Me.LogInButtonWithProgress2.BackColor = System.Drawing.Color.Transparent
        Me.LogInButtonWithProgress2.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButtonWithProgress2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButtonWithProgress2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress2.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButtonWithProgress2.Location = New System.Drawing.Point(216, 196)
        Me.LogInButtonWithProgress2.Margin = New System.Windows.Forms.Padding(4)
        Me.LogInButtonWithProgress2.Maximum = 100
        Me.LogInButtonWithProgress2.Name = "LogInButtonWithProgress2"
        Me.LogInButtonWithProgress2.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButtonWithProgress2.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress2.Size = New System.Drawing.Size(223, 35)
        Me.LogInButtonWithProgress2.TabIndex = 10
        Me.LogInButtonWithProgress2.Text = "Tester"
        Me.LogInButtonWithProgress2.Value = 0
        '
        'LogInLabel2
        '
        Me.LogInLabel2.AutoSize = True
        Me.LogInLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LogInLabel2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel2.Location = New System.Drawing.Point(85, 32)
        Me.LogInLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LogInLabel2.Name = "LogInLabel2"
        Me.LogInLabel2.Size = New System.Drawing.Size(187, 28)
        Me.LogInLabel2.TabIndex = 8
        Me.LogInLabel2.Text = "Texte à prononcer :"
        '
        'LogInButtonWithProgress1
        '
        Me.LogInButtonWithProgress1.BackColor = System.Drawing.Color.Transparent
        Me.LogInButtonWithProgress1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButtonWithProgress1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButtonWithProgress1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButtonWithProgress1.Location = New System.Drawing.Point(216, 237)
        Me.LogInButtonWithProgress1.Margin = New System.Windows.Forms.Padding(4)
        Me.LogInButtonWithProgress1.Maximum = 100
        Me.LogInButtonWithProgress1.Name = "LogInButtonWithProgress1"
        Me.LogInButtonWithProgress1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButtonWithProgress1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress1.Size = New System.Drawing.Size(223, 54)
        Me.LogInButtonWithProgress1.TabIndex = 6
        Me.LogInButtonWithProgress1.Text = "Valider et quitter"
        Me.LogInButtonWithProgress1.Value = 0
        '
        'Options_08
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(645, 444)
        Me.Controls.Add(Me.LogInLabel1)
        Me.Controls.Add(Me.LogInTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Options_08"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Faire parler l'ordinateur"
        Me.LogInTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LogInLabel1 As VBVEC.LogInLabel
    Friend WithEvents LogInTabControl1 As VBVEC.LogInTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents LogInButtonWithProgress2 As LogInButtonWithProgress
    Friend WithEvents LogInLabel2 As LogInLabel
    Friend WithEvents LogInButtonWithProgress1 As LogInButtonWithProgress
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
