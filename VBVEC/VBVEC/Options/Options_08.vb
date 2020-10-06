Public Class Options_08

    Private Sub LogInButtonWithProgress2_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress2.Click
        '=== Speaking Computer ===
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.Speak(RichTextBox1.Text)

    End Sub

    Private Sub LogInButtonWithProgress1_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress1.Click
        My.Settings.PresetVir_No_009 = " '=== Speaking Computer ===
        Dim SAPI
        SAPI = CreateObject(" & Chr(34) & "SAPI.spvoice" & Chr(34) & ")
        SAPI.Speak(" & Chr(34) & RichTextBox1.Text & Chr(34) & ")"
        Me.Close()
    End Sub
End Class