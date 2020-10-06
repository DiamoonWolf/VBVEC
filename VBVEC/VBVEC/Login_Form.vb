Public Class Login_Form
    Private Sub LogInLogButton1_Click(sender As Object, e As EventArgs) Handles LogInLogButton1.Click
        login()
    End Sub
    Private Sub login()
        Dim Result As Integer
        If LogInNormalTextBox1.Text = Nothing Or LogInNormalTextBox2.Text = Nothing Then
            ErrorMsg("Veuillez remplir tous les champs.")
            Exit Sub
        End If


        Result = Connect(LogInNormalTextBox1.Text, LogInNormalTextBox2.Text)
        If Result > 0 Then

            MessageBox.Show("Succès" & vbNewLine & If(Result = 2, "Premium!", "Non Premium"), "Connecté", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If Result = 2 Then
                My.Settings.CheckPremium = True
            Else
                My.Settings.CheckPremium = False
            End If
            Form1.Show()
            If LogInNormalTextBox1.Text <> My.Settings.U_Name Then
                My.Settings.Generated = 0

            End If

            My.Settings.U_Name = LogInNormalTextBox1.Text
            Me.Close()

        End If
    End Sub
    Public Function Connect(User As String, Password As String)
        Dim Response As String
        Dim SessionID As String = RandomChar(10)

        Response = GetResponse(SessionID, "https://votreserveur.com/actionvbvec.php?" & "action=connect" & "&sessionID=" & SessionID & "&user=" & User & "&password=" & Password)

        If Response = Nothing Then Return 0
        If CheckError(Response) = True Then Return 0
        If Not Response.StartsWith("OK") Then
            ErrorMsg("Error")
            Return 0
        End If

        Return If(Response.EndsWith("1"), 2, 1)

    End Function

   

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim f As New Register_Form

        f.ShowDialog()

    End Sub

    Private Sub FlatStickyButton1_Click(sender As Object, e As EventArgs)

        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Close()
    End Sub
End Class