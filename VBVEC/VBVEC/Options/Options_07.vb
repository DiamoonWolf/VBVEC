Public Class Options_07
    Private Sub LogInButtonWithProgress1_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress1.Click

        My.Settings.PresetVir_No_008 = "'=== Open webpage ===
        Dim webAddress As String = " & Chr(34) & LogInNormalTextBox1.Text & Chr(34) & "
        Process.Start(webAddress)"
        Me.Close()
    End Sub
End Class