﻿Imports System.Drawing
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

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If cboP1.Text = "" Then
            lblP1.ForeColor = Color.Red
        ElseIf cboP2.Text = "" Then
            lblP2.ForeColor = Color.Red
        Else
            cboP1.Items.Add(cboP1.Text)
            cboP1.Items.Add(cboP2.Text)
            cboP2.Items.Add(cboP2.Text)
            cboP2.Items.Add(cboP1.Text)
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

End Class