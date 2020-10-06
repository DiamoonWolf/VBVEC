Module Manager
    Dim ErrorMessages As Dictionary(Of String, String) = New Dictionary(Of String, String) From {
    {"ERROR_BDD_CONNECTION", "Unable to connect to server."},
    {"NO_ACTION", "No action defined."},
    {"INVALID_SESSION_ID", "Request error."},
    {"USER_NOT_FOUND", "The user does not exist."},
    {"ADMIN_PASSWORD_INCORRECT", "Mot de passe incorrect."}
    }

    Public Sub ErrorMsg(Text As String)
        MessageBox.Show(Text, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Function Ask(Text As String, Type As String) As String
        Dim ab As New inputBox
        ab.Text = Text
        If Type = "Pass" Then
            ab.LogInNormalTextBox1.UseSystemPasswordChar = True
        End If
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
            ErrorMsg("Unable to connect to server")
        End Try

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
