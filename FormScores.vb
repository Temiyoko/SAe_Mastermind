Imports System.Windows.Forms
Public Class FormScores
    Private Sub FormScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each lst As ListBox In pnlList.Controls
            lst.Items.Clear()
        Next
        lstName.Items.AddRange(GetStat(0))
        lstScore.Items.AddRange(GetStat(1))
        lstBestTime.Items.AddRange(GetStat(2))
        lstP1.Items.AddRange(GetStat(3))
        lstP2.Items.AddRange(GetStat(4))
        lstTotalTime.Items.AddRange(GetStat(5))

    End Sub

    Private Sub Lst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstName.SelectedIndexChanged, lstScore.SelectedIndexChanged, lstBestTime.SelectedIndexChanged, lstP1.SelectedIndexChanged, lstP2.SelectedIndexChanged, lstTotalTime.SelectedIndexChanged
        Dim send As ListBox = DirectCast(sender, ListBox)
        For Each lst As ListBox In pnlList.Controls
            lst.SelectedIndex = send.SelectedIndex
        Next
    End Sub

    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Close()
        FormMenu.Show()
    End Sub
End Class