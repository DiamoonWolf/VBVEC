Public Class inputBox
    Public Response As String
    Private Sub LogInButtonWithProgress1_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress1.Click
        If LogInNormalTextBox1.Text = Nothing Then
            ErrorMsg("Erreur: Vide")
            Exit Sub
        End If
        Response = LogInNormalTextBox1.Text
        Me.Close()
    End Sub
End Class