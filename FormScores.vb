Imports System.Windows.Forms
Public Class FormScores

    Private playerList As New List(Of Player)()

    Private Sub FormScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        playerList.Clear()
        playerList.AddRange(GetAllPlayer())
        PopulateListBoxes()
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

    Private Sub BtnName_Click(sender As Object, e As EventArgs) Handles btnName.Click
        playerList.Sort(Function(p1, p2) p1.Name.CompareTo(p2.Name))
        PopulateListBoxes()
    End Sub

    Private Sub BtnBestScore_Click(sender As Object, e As EventArgs) Handles btnBestScore.Click
        playerList.Sort(Function(p1, p2) p1.Score.CompareTo(p2.Score))
        PopulateListBoxes()
    End Sub

    Private Sub BtnBestTime_Click(sender As Object, e As EventArgs) Handles btnBestTime.Click
        playerList.Sort(Function(p1, p2) p1.BestTime.CompareTo(p2.BestTime))
        PopulateListBoxes()
    End Sub

    Private Sub PopulateListBoxes()
        For Each lst As ListBox In pnlList.Controls
            lst.Items.Clear()
        Next

        For Each p As Player In playerList
            lstName.Items.Add(p.Name.ToString())
            lstScore.Items.Add(p.Score.ToString())
            lstBestTime.Items.Add(If(p.BestTime.ToString() = Integer.MaxValue.ToString(), "-", p.BestTime.ToString()))
            lstP1.Items.Add(p.P1.ToString())
            lstP2.Items.Add(p.P2.ToString())
            lstTotalTime.Items.Add(p.TotalTime.ToString())
        Next
    End Sub

End Class