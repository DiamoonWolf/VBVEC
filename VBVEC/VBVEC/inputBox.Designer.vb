<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inputBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inputBox))
        Me.LogInButtonWithProgress1 = New VBVEC.LogInButtonWithProgress()
        Me.LogInNormalTextBox1 = New VBVEC.LogInNormalTextBox()
        Me.SuspendLayout()
        '
        'LogInButtonWithProgress1
        '
        Me.LogInButtonWithProgress1.BackColor = System.Drawing.Color.Transparent
        Me.LogInButtonWithProgress1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButtonWithProgress1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButtonWithProgress1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButtonWithProgress1.Location = New System.Drawing.Point(70, 77)
        Me.LogInButtonWithProgress1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LogInButtonWithProgress1.Maximum = 100
        Me.LogInButtonWithProgress1.Name = "LogInButtonWithProgress1"
        Me.LogInButtonWithProgress1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButtonWithProgress1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress1.Size = New System.Drawing.Size(287, 41)
        Me.LogInButtonWithProgress1.TabIndex = 5
        Me.LogInButtonWithProgress1.Text = "OK"
        Me.LogInButtonWithProgress1.Value = 0
        '
        'LogInNormalTextBox1
        '
        Me.LogInNormalTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.LogInNormalTextBox1.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInNormalTextBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInNormalTextBox1.Location = New System.Drawing.Point(14, 15)
        Me.LogInNormalTextBox1.MaxLength = 32767
        Me.LogInNormalTextBox1.Multiline = False
        Me.LogInNormalTextBox1.Name = "LogInNormalTextBox1"
        Me.LogInNormalTextBox1.ReadOnly = False
        Me.LogInNormalTextBox1.Size = New System.Drawing.Size(395, 34)
        Me.LogInNormalTextBox1.Style = VBVEC.LogInNormalTextBox.Styles.NotRounded
        Me.LogInNormalTextBox1.TabIndex = 6
        Me.LogInNormalTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.LogInNormalTextBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInNormalTextBox1.UseSystemPasswordChar = False
        '
        'inputBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(425, 130)
        Me.Controls.Add(Me.LogInNormalTextBox1)
        Me.Controls.Add(Me.LogInButtonWithProgress1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "inputBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "infoBox"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LogInButtonWithProgress1 As LogInButtonWithProgress
    Friend WithEvents LogInNormalTextBox1 As LogInNormalTextBox
End Class
