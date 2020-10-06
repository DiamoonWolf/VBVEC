Public Class inputBoxDbl


    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        regcommand()

    End Sub


    Private Sub regcommand()
        Dim Result As Integer
        If LogInNormalTextBox1.Text = Nothing Or LogInNormalTextBox2.Text = Nothing Or LogInNormalTextBox3.Text = Nothing Then
            ErrorMsg("Veuillez remplir tous les champs.")
            Exit Sub
        End If



        Result = Register(LogInNormalTextBox1.Text, LogInNormalTextBox2.Text, LogInNormalTextBox3.Text, "mail")
        If Result = 1 Then
            MessageBox.Show("Incription terminée !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Public Function Register(RegisterKey As String, User As String, Password As String, Email As String)
        Dim Response As String
        Dim SessionID As String = RandomChar(10)

        Response = GetResponse(SessionID, "https://votreserveurcom/actionvbvec.php?" &
                               "action=register" &
                               "&sessionID=" & SessionID &
                               "&user=" & User &
                               "&password=" & Password &
                               "&registerKey=" & RegisterKey &
                               "&email=" & Email)

        If Response = Nothing Then Return 0
        If CheckError(Response) = True Then Return 0
        If Not Response.StartsWith("OK") Then
            ErrorMsg("Error not Ok")
            Return 0
        End If

        Return 1

    End Function
End Class