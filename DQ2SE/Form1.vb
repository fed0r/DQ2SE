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
            DiffEasy.Enabled = True
            DiffNormal.Enabled = True
            DiffHC.Enabled = True
            DifficultyBtn.Enabled = True
            '--------------------
            'Difficulty Checker
            Dim difficultycheck As New IO.FileStream(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Appdata\\LocalLow\Brain Seal Ltd\Dark Quest 2\" & PlayerProfiles.SelectedItem & ".bin", FileMode.Open, FileAccess.Read)
            difficultycheck.Position = &H4D
            Difficulty.Text = difficultycheck.ReadByte.ToString()
            If Difficulty.Text = "2" Then 'Hardcore
                DiffHC.Checked = True
            ElseIf Difficulty.Text = "1" Then 'Easy
                DiffEasy.Checked = True
            ElseIf Difficulty.Text = "0" Then 'Normal
                DiffNormal.Checked = True
            End If

            '--------------------
        ElseIf PlayerProfiles.SelectedItem = "" Then
            MsgBox("Notice: You did not select a file!", MsgBoxStyle.Exclamation, "DQ2SE")
        Else
            MsgBox("Notice: Unknown error. Please try again!", MsgBoxStyle.Information, "DQ2SE")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AddGoldBtn.Click
        Dim AddGold As New IO.FileStream(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Appdata\\LocalLow\Brain Seal Ltd\Dark Quest 2\" & PlayerProfiles.SelectedItem & ".bin", FileMode.Open, FileAccess.ReadWrite)
        AddGold.Position = &H37
        AddGold.WriteByte(&H98)
        AddGold.Position = &H38
        AddGold.WriteByte(&H96)
        AddGold.Position = &H39
        AddGold.WriteByte(&H80)
        AddGold.Close()
        AddGold.Dispose()
        StatusLabel.ForeColor = Color.Red
        StatusLabel.Text = "GOLD ADDED!"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MsgBox("DQ2SE By ALTHiR. This tool is 100% Freeware and was made for my own entertainment. Version 1.0", MsgBoxStyle.Information, "DQ2SE")
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles PotsButton.Click
        Dim AddPots As New IO.FileStream(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Appdata\\LocalLow\Brain Seal Ltd\Dark Quest 2\" & PlayerProfiles.SelectedItem & ".bin", FileMode.Open, FileAccess.ReadWrite)
        AddPots.Position = &H175
        AddPots.WriteByte(&HFF)
        AddPots.Position = &H176
        AddPots.WriteByte(&HFF)
        AddPots.Position = &H177
        AddPots.WriteByte(&HFF)
        AddPots.Close()
        AddPots.Dispose()
        StatusLabel.ForeColor = Color.Red
        StatusLabel.Text = "POTS ADDED!"
    End Sub

    Private Sub DifficultyBtn_Click(sender As Object, e As EventArgs) Handles DifficultyBtn.Click
        Dim ChangeDiff As New IO.FileStream(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Appdata\\LocalLow\Brain Seal Ltd\Dark Quest 2\" & PlayerProfiles.SelectedItem & ".bin", FileMode.Open, FileAccess.ReadWrite)
        If DiffEasy.Checked Then
            ChangeDiff.Position = &H4D
            ChangeDiff.WriteByte(&H1)
        ElseIf DiffNormal.Checked Then
            ChangeDiff.Position = &H4D
            ChangeDiff.WriteByte(&H0)
        ElseIf DiffHC.Checked Then
            ChangeDiff.Position = &H4D
            ChangeDiff.WriteByte(&H2)
        End If
        ChangeDiff.Close()
        ChangeDiff.Dispose()
        StatusLabel.ForeColor = Color.Red
        StatusLabel.Text = "DIFFICULTY CHANGED!"
    End Sub
End Class
