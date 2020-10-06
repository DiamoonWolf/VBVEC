Public Class Options_03
    Dim Sparam1, SparamMsg, SparamTime, SparamTot As String

    Private Function checkParam1()
        SparamTot = SparamMsg & SparamTime
        If LogInRadioButton1.Checked = True Then
            Sparam1 = "-l"
            LogInNormalTextBox1.Text = "shutdown " & Sparam1
        ElseIf LogInRadioButton2.Checked = True Then
            Sparam1 = "-s"
            LogInNormalTextBox1.Text = "shutdown " & Sparam1 & " " & SparamTot
        ElseIf LogInRadioButton3.Checked = True Then
            Sparam1 = "-r"
            LogInNormalTextBox1.Text = "shutdown " & Sparam1 & " " & SparamTot
        ElseIf LogInRadioButton4.Checked = True Then
            Sparam1 = "-h"
            LogInNormalTextBox1.Text = "shutdown " & Sparam1
        End If


        Return Sparam1
    End Function

    Private Function checkParam2(Sdata As String)
        If LogInCheckBox3.Checked = True Then
            SparamTime = "-t " & Sdata & " "

        ElseIf LogInCheckBox2.Checked = True Then
            SparamMsg = "-c " & Chr(34) & Chr(38) & " Chr(34) " & Chr(38) & Chr(34) & Sdata & Chr(34) & Chr(38) & " Chr(34) " & Chr(38) & Chr(34) & " "

        End If
        SparamTot = SparamMsg & SparamTime
        Return SparamTot
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        checkParam1()

        If LogInCheckBox1.Checked = True Then
            LogInNormalTextBox1.Text += "-f"
        End If

    End Sub

    Private Sub LogInButtonWithProgress1_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress1.Click
        My.Computer.Clipboard.SetText(LogInNormalTextBox1.Text)
    End Sub

    Private Sub LogInButtonWithProgress2_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress2.Click
        My.Settings.PresetVir_No_003 = "'=== Shutdown Computer ===
Shell (" & Chr(34) & "cmd /c " & LogInNormalTextBox1.Text & Chr(34) & ", vbHide)"
        Me.Close()
    End Sub

    Private Sub Options_03_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub LogInCheckBox2_CheckedChanged(sender As Object) Handles LogInCheckBox2.CheckedChanged
        If LogInCheckBox2.Checked = True Then
            LogInNormalTextBox1.Text += checkParam2(Ask("Ajouter un commentaire", "Text"))
        End If

    End Sub

    Private Sub LogInCheckBox3_CheckedChanged(sender As Object) Handles LogInCheckBox3.CheckedChanged
        If LogInCheckBox3.Checked = True Then
            LogInNormalTextBox1.Text += checkParam2(Ask("Définir un temps (En secondes)", "Integer"))

        End If

    End Sub
End Class