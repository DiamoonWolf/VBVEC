Public Class About
    Private Sub FlatLabel4_Click(sender As Object, e As EventArgs) Handles FlatLabel4.Click
        Process.Start("https://twitter.com/DiamoonWolf")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Process.Start("https://twitter.com/DiamoonWolf")
    End Sub

    Private Sub FlatLabel3_Click(sender As Object, e As EventArgs) Handles FlatLabel3.Click
        Process.Start("https://github.com/DiamoonWolf")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) 
        Process.Start("https://github.com/DiamoonWolf")
    End Sub

    Private Sub FlatLabel2_Click(sender As Object, e As EventArgs) 
        My.Computer.Clipboard.SetText("DiamondWolf#5298")
        MsgBox("Pseudo copié dans le presse-papier !")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) 
        My.Computer.Clipboard.SetText("DiamondWolf#5298")
        MsgBox("Pseudo copié dans le presse-papier !")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) 
        Process.Start("https://diamondwolf-dev.xyz/")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) 
        Process.Start("https://diamondwolf.selly.store/")
    End Sub
End Class