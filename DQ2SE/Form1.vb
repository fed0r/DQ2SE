' Dark Quest II Save Editor
' Tool by Althir
' This software is provided free of charge
Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlayerProfiles.Items.Clear()
        Dim grade As New IO.DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Appdata\\LocalLow\Brain Seal Ltd\Dark Quest 2\")
        Dim diar As IO.FileInfo() = grade.GetFiles("*.bin")
        Dim dra As IO.FileInfo
        For Each dra In diar
            PlayerProfiles.Items.Add(System.IO.Path.GetFileNameWithoutExtension(dra.FullName))
        Next
        PlayerProfiles.Items.Remove("gamesettings")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles LoadFileBtn.Click
        If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Appdata\\LocalLow\Brain Seal Ltd\Dark Quest 2\" & PlayerProfiles.SelectedItem & ".bin") Then
            PlayerProfiles.Enabled = False
            LoadFileBtn.Enabled = False
            StatusLabel.Text = "Editing a file!"
            StatusLabel.ForeColor = Color.Green
            'Enable options after load
            AddGoldBtn.Enabled = True
            PotsButton.Enabled = True
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            RadioButton3.Enabled = True
            DifficultyBtn.Enabled = True
            '--------------------
            MsgBox("Notice: This tool is a save editor, not memory editor! Please exit from game completely before using this software.", MsgBoxStyle.Information, "DQ2SE")
        ElseIf PlayerProfiles.SelectedItem = "" Then
            MsgBox("Notice: You did not select a file!", MsgBoxStyle.Exclamation, "DQ2SE")
        Else
            MsgBox("Notice: Unknown error. Please try again!", MsgBoxStyle.Information, "DQ2SE")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AddGoldBtn.Click
        Dim fs As New IO.FileStream(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Appdata\\LocalLow\Brain Seal Ltd\Dark Quest 2\" & PlayerProfiles.SelectedItem & ".bin", FileMode.Open, FileAccess.ReadWrite)
        fs.Position = &H37
        fs.WriteByte(&H98)
        fs.Position = &H38
        fs.WriteByte(&H96)
        fs.Position = &H39
        fs.WriteByte(&H80)
        fs.Close()
        fs.Dispose()
        StatusLabel.ForeColor = Color.Red
        StatusLabel.Text = "GOLD ADDED!"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MsgBox("DQ2SE By ALTHiR. This tool is 100% Freeware and was made for my own entertainment. Version 1.0", MsgBoxStyle.Information, "DQ2SE")
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles PotsButton.Click
        Dim fs As New IO.FileStream(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Appdata\\LocalLow\Brain Seal Ltd\Dark Quest 2\" & PlayerProfiles.SelectedItem & ".bin", FileMode.Open, FileAccess.ReadWrite)
        fs.Position = &H16D
        fs.WriteByte(&HFF)
        fs.Position = &H16E
        fs.WriteByte(&HFF)
        fs.Position = &H16F
        fs.WriteByte(&HFF)
        fs.Close()
        fs.Dispose()
        StatusLabel.ForeColor = Color.Red
        StatusLabel.Text = "POTS ADDED!"
    End Sub
End Class
