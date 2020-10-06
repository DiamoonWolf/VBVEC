Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions

Module Manager
    Dim ErrorMessages As Dictionary(Of String, String) = New Dictionary(Of String, String) From {
    {"ERROR_BDD_CONNECTION", "Connexion au serveur impossible."},
    {"NO_ACTION", "No action defined."},
    {"INVALID_SESSION_ID", "Erreur de requête."},
    {"USER_NOT_FOUND", "L'utilisateur ou le mot de passe est incorrect."},
    {"INVALID_KEY", "Clé invalide."},
    {"KEY_ALREADY_USED", "Clé invalide ou déjà utilisée."},
    {"USER_ALREADY_EXIST", "Le nom d'utilisateur existe déjà."},
    {"INCORRECT_PASSWORD", "L'utilisateur ou le mot de passe est incorrect."},
    {"USER_BANNED", "Votre compte à été suspendu."}
    }



    Public Sub ErrorMsg(Text As String)
        MessageBox.Show(Text, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Function dossierdebase() As String
        Return System.AppDomain.CurrentDomain.BaseDirectory()
    End Function



    Public Function CloneIt(ByVal SourceFile As String, ByVal DestinationFiles As String)
        If File.Exists(dossierdebase() & "\\res.exe") Then
            File.Delete(dossierdebase() & "\\res.exe")
        End If
        File.WriteAllBytes(dossierdebase() & "\\res.exe", My.Resources.res)
        Interaction.Shell(String.Concat(New String() {dossierdebase(), "\\res.exe -extract ", SourceFile, ",", dossierdebase(), "\\info.res,VERSIONINFO,,"}), AppWinStyle.Hide, False, -1)
        Interaction.Shell(String.Concat(New String() {dossierdebase(), "\\res.exe -delete ", DestinationFiles, ",", dossierdebase(), "\\res.exe,VERSIONINFO,,"}), AppWinStyle.Hide, False, -1)
        Interaction.Shell(String.Concat(New String() {dossierdebase(), "\\res.exe -delete ", DestinationFiles, ",", dossierdebase(), "\\res.exe,VERSIONINFO,1,"}), AppWinStyle.Hide, False, -1)
        Interaction.Shell(String.Concat(New String() {dossierdebase(), "\\res.exe -addoverwrite ", DestinationFiles, ",", DestinationFiles, ",", dossierdebase(), "\\info.res,VERSIONINFO,1,"}), AppWinStyle.Hide, False, -1)
        If File.Exists(dossierdebase() & "\\res.exe") Then
            File.Delete(dossierdebase() & "\\res.exe")
        End If
        If File.Exists(dossierdebase() & "\\res.ini") Then
            File.Delete(dossierdebase() & "\\res.ini")
        End If
        If File.Exists(dossierdebase() & "\\res.log") Then
            File.Delete(dossierdebase() & "\\res.log")
        End If
        If File.Exists(dossierdebase() & "\\info.res") Then
            File.Delete(dossierdebase() & "\\info.res")
        End If

    End Function
    Private Function start_batch(ByVal bat_command As String)

        Dim file_path As String = IO.Path.GetTempPath

        Dim FILE_NAME As String = file_path & "\000.bat"

        Dim fs As FileStream = File.Create(FILE_NAME)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(bat_command)
        fs.Write(info, 0, info.Length)
        fs.Close()
        Dim start_info As New ProcessStartInfo(FILE_NAME)
        start_info.UseShellExecute = False
        start_info.CreateNoWindow = True
        start_info.RedirectStandardOutput = True
        start_info.RedirectStandardError = True

        Dim proc As New Process()
        proc.StartInfo = start_info
        proc.Start()

        Dim a_out As String
        Dim std_out As StreamReader = proc.StandardOutput()
        Dim std_err As StreamReader = proc.StandardError()


        Return std_out.ReadToEnd()

        std_out.Close()
        std_err.Close()
        proc.Close()
        My.Computer.FileSystem.DeleteFile(FILE_NAME)
    End Function
    Public Function Opt_04(Title As String, Args As String) As String
        Dim ab As New Options_04
        ab.Text = Title
        ab.LogInLabel1.Text = "Fichiers"

        If Args = "direc" Then
            ab.LogInLabel1.Text = "Dossiers"
            ab.LogInLabel5.Text = "Nombre de dossiers à créer : "
            ab.LogInLabel4.Visible = True

            ab.LogInNormalTextBox2.Visible = False
            ab.LogInLabel3.Visible = False
        End If

        ab.ShowDialog()
        Return ab.Response
    End Function
    Public Function Info(Title As String, Text As String) As String
        Dim ab As New infoBox
        ab.Text = Title

        ab.LogInNormalTextBox1.Text = Text
        ab.ShowDialog()
    End Function

    Public Function Ask(Title As String, Args As String) As String
        Dim ab As New inputBox
        ab.Text = Title

        ab.ShowDialog()
        Return ab.Response
    End Function



    Public Function GetResponse(SessionID As String, URL As String) As String
        Dim Result As String
        Dim WC As New System.Net.WebClient

        Try
            Result = WC.DownloadString(URL)
            Result = RC4(Result, SessionID)
            Return Result
        Catch ex As Exception
            ErrorMsg("Impossible de se connecter au serveur.")
        End Try

    End Function

    Public Function SetD(generated As String)
        Dim Response As String
        Dim SessionID As String = RandomChar(10)


        Response = GetResponse(SessionID, "https://votreserveur.com/actionvbvec.php?" &
                               "action=set" &
                               "&sessionID=" & SessionID &
                               "&generated=" & generated &
                               "&user=" & My.Settings.U_Name)

        If Response = Nothing Then Return 0
        If CheckError(Response) = True Then Return 0
        If Not Response.StartsWith("OK") Then
            MsgBox("ERR TEST") '<- SUPPRIMER
            Return 0 'CHANGER -> 1
        End If

        Return 1

    End Function

    Public Function CheckError(Text As String) As Boolean
        Dim Array As String()
        Dim Message As String = "Error."

        If Not Text.StartsWith("ERROR") Then
            Return False
        End If
        Array = Text.Split(":")
        If Array.Length = 2 AndAlso ErrorMessages.ContainsKey(Array(1)) Then
            Message = ErrorMessages(Array(1))
        End If
        ErrorMsg(Message)
        Return True
    End Function

    Public Function RandomChar(Lenght As Integer) As String
        Dim Chr() As Char = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890"
        Dim Result As String
        For i = 1 To Lenght
            Result &= Chr(Random(Chr.Length - 1))
        Next
        Return Result

    End Function

    Public Function Random(Max As Integer) As String
        Randomize()
        Return Rnd() * Max
    End Function

    Public Function RC4(ByVal message As String, ByVal password As String) As String

        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim cipher As New System.Text.StringBuilder
        Dim returnCipher As String = String.Empty
        Dim sbox As Integer() = New Integer(256) {}
        Dim Key As Integer() = New Integer(256) {}
        Dim intLength As Integer = password.Length
        Dim a As Integer = 0

        While a <= 255
            Dim ctmp As Char = (password.Substring((a Mod intLength), 1).ToCharArray()(0))
            Key(a) = Microsoft.VisualBasic.Strings.Asc(ctmp)
            sbox(a) = a
            System.Math.Max(System.Threading.Interlocked.Increment(a), a - 1)
        End While

        Dim x As Integer = 0
        Dim b As Integer = 0
        While b <= 255
            x = (x + sbox(b) + Key(b)) Mod 256
            Dim TempSwap As Integer = sbox(b)
            sbox(b) = sbox(x)
            sbox(x) = TempSwap
            System.Math.Max(Threading.Interlocked.Increment(b), b - 1)
        End While

        a = 1

        While a <= message.Length
            Dim itmp As Integer = 0
            i = (i + 1) Mod 256
            j = (j + sbox(i)) Mod 256
            itmp = sbox(i)
            sbox(i) = sbox(j)
            sbox(j) = itmp
            Dim k As Integer = sbox((sbox(i) + sbox(j)) Mod 256)
            Dim ctmp As Char = message.Substring(a - 1, 1).ToCharArray()(0)
            itmp = Asc(ctmp)
            Dim cipherby As Integer = itmp Xor k
            cipher.Append(Chr(cipherby))
            System.Math.Max(System.Threading.Interlocked.Increment(a), a - 1)
        End While

        returnCipher = cipher.ToString
        cipher.Length = 0
        Return returnCipher

    End Function

End Module
