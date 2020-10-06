Imports System.IO

Module Module1

    Public Sub Obfuscation()
        If Form2.LogInCheckBox1.Checked = True Then
            Dim FS As New FileStream(Form1.Label1.Text, FileMode.Open, FileAccess.Write)
            FS.Seek(244, SeekOrigin.Begin)
            FS.WriteByte(10)

            FS.Flush()
            FS.Close()

        Else
            Resume Next
        End If
    End Sub



End Module
