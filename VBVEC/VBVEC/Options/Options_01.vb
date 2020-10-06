Public Class Options_01

    Private Sub Options_01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LogInNormalTextBox1.Text = My.Settings.ProcessKill_Process


        Dim process() As System.Diagnostics.Process

        process = System.Diagnostics.Process.GetProcesses()

        For Each processus As System.Diagnostics.Process In process
            LogInListBox1.AddItem(processus.ProcessName)
        Next
    End Sub
    Private Sub LogInButtonWithProgress1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInButtonWithProgress1.Click
        My.Settings.ProcessKill_Process = LogInNormalTextBox1.Text
        My.Settings.PresetVir_No_001 = "'=== Kill Process ===
        Dim myProcesses As Process() = Process.GetProcessesByName(" & Chr(34) & My.Settings.ProcessKill_Process.ToString & Chr(34) & ")
        Dim myProcess As Process
        For Each myProcess In myProcesses
            myProcess.Kill()
        Next myProcess"
        Me.Close()
    End Sub

  
    Private Sub LogInButtonWithProgress2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInButtonWithProgress2.Click
        FlatAlertBox1.Visible = True
        FlatAlertBox1.Text = LogInListBox1.SelectedItem.ToString + " ajouté !"
        LogInNormalTextBox1.Text = LogInListBox1.SelectedItem.ToString
    End Sub
End Class