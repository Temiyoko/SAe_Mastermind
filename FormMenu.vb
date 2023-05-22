Imports System.Drawing
Imports System.Windows.Forms

Public Class FormMenu

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        ' 276 est le résultat de 4 (Oui/Non) + 16 (Critical) + 256 (2e bouton par défaut)
        If MsgBox("Voulez-vous vraiment quitter ?", 276, "Attention") = vbYes Then Me.Close()
    End Sub

    Private Sub Cbo_GotFocus(sender As Object, e As EventArgs) Handles cboP1.GotFocus, cboP2.GotFocus
        If sender.Equals(cboP1) Then
            lblP1.ForeColor = Color.Black
        Else
            lblP2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub CheckPlayer(Name As String, Cbo As ComboBox)
        If Not Cbo.Items.Contains(Name) Then Cbo.Items.Add(Name)
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If cboP1.Text = "" Then
            lblP1.ForeColor = Color.Red
        ElseIf cboP2.Text = "" Then
            lblP2.ForeColor = Color.Red
        ElseIf cboP1.Text = cboP2.Text Then
            CheckPlayer(cboP1.Text, cboP1)
            CheckPlayer(cboP2.Text, cboP2)
            MsgBox("Vous ne pouvez pas jouer contre vous-même ...", MsgBoxStyle.Information, "Raté")
        Else
            SetPlayableChar("#$£%@")

            CheckPlayer(cboP1.Text, cboP1)
            CheckPlayer(cboP1.Text, cboP2)
            CheckPlayer(cboP2.Text, cboP2)
            CheckPlayer(cboP2.Text, cboP1)

            Me.Hide()
            FormCode.Show()
        End If
    End Sub

    Private Sub Cbo_Validated(sender As Object, e As EventArgs) Handles cboP1.Validated, cboP2.Validated
        Dim cbo As ComboBox = DirectCast(sender, ComboBox)
        cbo.Text = StrConv(cbo.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub BtnScores_Click(sender As Object, e As EventArgs) Handles btnScores.Click
        Me.Hide()
        FormScores.Show()
    End Sub

    Public Sub NextGame()
        Dim name As String = cboP1.Text
        cboP1.Text = cboP2.Text
        cboP2.Text = name
    End Sub

    Private Sub Cbo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboP1.KeyPress, cboP2.KeyPress
        If e.KeyChar = ChrW(Keys.Space) Then e.Handled = True
    End Sub

End Class