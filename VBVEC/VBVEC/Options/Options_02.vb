Public Class Options_02

    Private Sub LogInButtonWithProgress1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInButtonWithProgress1.Click
        Definir()
        My.Settings.PresetVir_No_002 = "'=== Custom MessageBox ===
        Dim Msg, Style, Title
        Msg = " & Chr(34) & My.Settings.MsgBox_Message & Chr(34) & "
        Style = " & My.Settings.MsgBox_Style & "
        Title = " & Chr(34) & My.Settings.MsgBox_Title & Chr(34) & "
        MsgBox(Msg, Style, Title)"
        Me.Close()
    End Sub

    Private Sub LogInButtonWithProgress2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInButtonWithProgress2.Click
        Definir()



        Dim Msg, Style, Title
        Msg = My.Settings.MsgBox_Message
        Style = My.Settings.MsgBox_Style
        Title = My.Settings.MsgBox_Title
        MsgBox(Msg, Style, Title)


    End Sub
    Private Sub Options_02_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogInNormalTextBox1.Text = My.Settings.MsgBox_Title
        LogInNormalTextBox2.Text = My.Settings.MsgBox_Message
    End Sub
    Private Sub Definir()
        My.Settings.MsgBox_Title = LogInNormalTextBox1.Text
        My.Settings.MsgBox_Message = LogInNormalTextBox2.Text

        If LogInRadioButton_Information.Checked = True Then
            My.Settings.MsgBox_Style = vbInformation
        ElseIf LogInRadioButton_Alerte.Checked = True Then
            My.Settings.MsgBox_Style = vbExclamation
        ElseIf LogInRadioButton_Critique.Checked = True Then
            My.Settings.MsgBox_Style = vbCritical
        ElseIf LogInRadioButton_Question.Checked = True Then
            My.Settings.MsgBox_Style = vbQuestion
        End If
        If LogInRadioButton_Ok.Checked = True Then
            My.Settings.MsgBox_ButtonStyle = vbOK
        ElseIf LogInRadioButton_OkAnnuler.Checked = True Then
            My.Settings.MsgBox_ButtonStyle = vbOKCancel
        ElseIf LogInRadioButton_ReessayerAnnuler.Checked = True Then
            My.Settings.MsgBox_ButtonStyle = vbAbortRetryIgnore
        ElseIf LogInRadioButton_OuiNon.Checked = True Then
            My.Settings.MsgBox_ButtonStyle = vbYesNo
        ElseIf LogInRadioButton_OuiNonAnnuler.Checked = True Then
            My.Settings.MsgBox_ButtonStyle = vbYesNoCancel
        ElseIf LogInRadioButton_AbandonnerReessayerIgnorer.Checked = True Then
            My.Settings.MsgBox_ButtonStyle = vbRetryCancel
        End If

    End Sub


End Class