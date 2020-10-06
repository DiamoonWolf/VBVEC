Imports System.Web.Script.Serialization
Public Class Form1
    Public SelectedUser As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cm As ContextMenuStrip = ContextMenuStrip1
        ListView2.ContextMenuStrip = cm
    End Sub
    Private Sub tsmi_copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopierToolStripMenuItem.Click
        If ListView2.SelectedItems.Count = 0 Then Exit Sub
        Clipboard.Clear()
        Dim var2 As Integer
        If ListView2.SelectedItems.Count > 0 Then
            var2 = ListView2.Items.IndexOf(ListView2.SelectedItems(0))
        End If
        Dim item As New ListViewItem
        Clipboard.SetText(ListView2.Items(var2).SubItems(1).Text)
    End Sub

    Private Sub FlatButton10_Click(sender As Object, e As EventArgs) Handles FlatButton10.Click
        Dim Result As String
        Dim JSS As New JavaScriptSerializer
        Dim Datas As Object


        Result = GetKeysInfo(FlatTextBox1.Text)
        Datas = JSS.DeserializeObject(Result)
        ListView2.Items.Clear()

        For Each Data As Object In Datas
            AddItemKey(Data("ID"), Data("R_Key"), Data("User"))

        Next
    End Sub
    Public Sub AddItemKey(ID As String, R_Key As String, User As String)
        Dim item As New ListViewItem

        item.UseItemStyleForSubItems = False
        item.Text = ID
        item.SubItems.Add(R_Key)
        item.SubItems.Add(User)


        ListView2.Items.Add(item)
    End Sub
    Public Sub AddItem(ID As String, User As String, Banned As String, Premium As String, RegistrationDate As String, ExpDate As String, Email As String, GenCt As String, rnk As String)
        Dim item As New ListViewItem

        item.UseItemStyleForSubItems = False
        item.Text = ID
        item.SubItems.Add(User)
        
        item.SubItems.Add(If(Banned = 1, "BANNED", "NO"))
        item.SubItems(2).ForeColor = If(Banned = 1, Color.Firebrick, Color.Black)

        item.SubItems.Add(If(Premium = 1, "PREMIUM", "NO"))
        item.SubItems(3).ForeColor = If(Premium = 1, Color.Goldenrod, Color.Black)


        item.SubItems.Add(RegistrationDate)
        Dim timestamp As Long = ExpDate
        Dim epoch As New DateTime(1970, 1, 1)
        Dim dt As DateTime = epoch.AddSeconds(timestamp)

        item.SubItems.Add(dt.ToString("dd/MM/yyyy | H:m:s"))

        item.SubItems.Add(Email)
        item.SubItems.Add(GenCt)
        item.SubItems.Add(rnk)

        ListView1.Items.Add(item)
    End Sub

    Public Function GetUsersInfo(AdminPassword As String) As String
        Dim Response As String
        Dim SessionID As String = RandomChar(10)

        Response = GetResponse(SessionID, "https://votreserveur.com/admfile.php?" &
                               "action=getUsersInfo" &
                               "&adminPassword=" & AdminPassword &
                               "&sessionID=" & SessionID)


        If Response = Nothing Then Return 0
        If CheckError(Response) = True Then Return 0
        If Not Response.StartsWith("OK") Then
            ErrorMsg("Error")
            Return Nothing

        End If

        Response = Response.Remove(0, 3)
        Return Response
    End Function

    Public Function GetKeysInfo(AdminPassword As String) As String
        Dim Response As String
        Dim SessionID As String = RandomChar(10)

        Response = GetResponse(SessionID, "https://votreserveur.com/admfile.php?" &
                               "action=getKeysInfo" &
                               "&adminPassword=" & AdminPassword &
                               "&sessionID=" & SessionID)


        If Response = Nothing Then Return 0
        If CheckError(Response) = True Then Return 0
        If Not Response.StartsWith("OK") Then
            ErrorMsg("Error")
            Return Nothing
        End If

        Response = Response.Remove(0, 3)
        Return Response
    End Function

    Public Function Admin(Action As String, Args As String) As Integer
        Dim Response As String
        Dim SessionID As String = RandomChar(10)

        Response = GetResponse(SessionID, "https://votreserveur.com/admfile.php.php?" &
                               "action=" & Action &
                               "&adminPassword=" & FlatTextBox1.Text &
                               "&sessionID=" & SessionID &
                               "&" & Args)


        If Response = Nothing Then Return 0
        If CheckError(Response) = True Then Return 0
        If Not Response.StartsWith("OK") Then
            ErrorMsg("Error" & Response)
            Return 0
        End If

        Return 1
    End Function
    Private Sub FlatButton8_Click(sender As Object, e As EventArgs) Handles FlatButton8.Click
        Dim Result As String
        Dim JSS As New JavaScriptSerializer
        Dim Datas As Object


        Result = GetUsersInfo(FlatTextBox1.Text)
        Datas = JSS.DeserializeObject(Result)
        ListView1.Items.Clear()

        For Each Data As Object In Datas
            AddItem(Data("ID"), Data("username"), Data("status"), Data("membership"), Data("RegistrationDate"), Data("expire"), Data("email"), Data("generated"), Data("rank"))

        Next
    End Sub
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        If Admin("ban", "user=" & SelectedUser) = 1 Then
            FlatButton8_Click(Nothing, Nothing)
            MessageBox.Show("L'utilisateur à été banni", "Panel Administrateur", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        If Admin("unban", "user=" & SelectedUser) = 1 Then
            FlatButton8_Click(Nothing, Nothing)
            MessageBox.Show("L'utilisateur à été débanni", "Panel Administrateur", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        If Admin("changePremium", "user=" & SelectedUser & "&value=1") = 1 Then
            FlatButton8_Click(Nothing, Nothing)
            MessageBox.Show("L'utilisateur est maintenant premium", "Panel Administrateur", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        If Admin("changePremium", "user=" & SelectedUser & "&value=0") = 1 Then
            FlatButton8_Click(Nothing, Nothing)
            MessageBox.Show("L'utilisateur n'est plus premium", "Panel Administrateur", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs) Handles FlatButton5.Click
        If Admin("changeUsername", "user=" & SelectedUser & "&newName=" & Ask("Nouveau pseudo", "Pseudo")) = 1 Then
            FlatButton8_Click(Nothing, Nothing)
            MessageBox.Show("Le pseudo à été changé", "Panel Administrateur", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub FlatButton6_Click(sender As Object, e As EventArgs) Handles FlatButton6.Click
        If Admin("changePassword", "user=" & SelectedUser & "&newPassword=" & Ask("Nouveau mot de passe", "Pass")) = 1 Then
            FlatButton8_Click(Nothing, Nothing)
            MessageBox.Show("Le mot de passe à été changé", "Panel Administrateur", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub FlatButton7_Click(sender As Object, e As EventArgs) Handles FlatButton7.Click
        If Admin("removeUser", "user=" & SelectedUser) = 1 Then
            FlatButton8_Click(Nothing, Nothing)
            MessageBox.Show("L'utilisateur à été supprimé", "Panel Administrateur", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count = 0 Then
            SelectedUser = Nothing
            LogInGroupBox1.Text = "Options"
            Exit Sub
        End If
        SelectedUser = ListView1.SelectedItems(0).SubItems(1).Text
        LogInGroupBox1.Text = "Options pour " & SelectedUser
    End Sub

    Private Sub FlatButton9_Click(sender As Object, e As EventArgs) Handles FlatButton9.Click
        Dim Response As String

        Response = CreateRegisterKey(FlatTextBox1.Text)
        If Response = Nothing Then
            ErrorMsg("Impossible de créer la clé.")
            Exit Sub
        End If
        FlatButton10_Click(Nothing, Nothing)
        MessageBox.Show("Clé: " & Response & vbNewLine & vbNewLine & "Appuyez sur OK pour copier", "Clé de license", MessageBoxButtons.OK, MessageBoxIcon.Information)
        My.Computer.Clipboard.SetText(Response)
    End Sub

    Public Function CreateRegisterKey(AdminPassword As String) As String
        Dim Response As String
        Dim SessionID As String = RandomChar(10)

        Response = GetResponse(SessionID, "https://votreserveur.com/admfile.php?" &
                               "action=createRegisterKey" &
                               "&adminPassword=" & AdminPassword &
                               "&sessionID=" & SessionID)


        If Response = Nothing Then Return 0
        If CheckError(Response) = True Then Return 0
        If Not Response.StartsWith("OK") Then
            ErrorMsg("Error")
            Return Nothing
        End If

        Response = Response.Remove(0, 3)
        Return Response
    End Function


    Private Sub LogInLabel2_Click(sender As Object, e As EventArgs) Handles LogInLabel2.Click
        If FlatTextBox1.UseSystemPasswordChar = False Then
            FlatTextBox1.UseSystemPasswordChar = True
        Else
            FlatTextBox1.UseSystemPasswordChar = False
        End If

    End Sub

    Private Sub FlatButton11_Click(sender As Object, e As EventArgs) Handles FlatButton11.Click
        inputBoxDbl.ShowDialog()
    End Sub
End Class
