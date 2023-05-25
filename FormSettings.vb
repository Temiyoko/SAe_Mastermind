Imports System.Drawing
Imports System.Reflection.Emit
Imports System.Windows.Forms

Public Class FormSettings
    Private maxTries As Integer = 15
    Private tries = GetNbTries()
    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetCloseSource("")
        tbTries.Text = GetNbTries().ToString()
        Dim cpt As Integer = 0
        For Each tb As TextBox In pnlColors.Controls.OfType(Of TextBox)
            tb.BackColor = GetColor(cpt)
            cpt += 1
        Next
    End Sub

    Private Sub FormSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If GetCloseSource() <> "Button" Then
            If MsgBox("Voulez-vous vraiment fermer cette fenêtre ?", 276, "Attention !") = vbNo Then
                e.Cancel = True
            Else
                FormMenu.Show()
            End If
        Else
            FormMenu.Show()
        End If
    End Sub

    Private Sub Tb_Click(sender As Object, e As EventArgs) Handles tbRight.Click, tbWrong.Click, tbMissing.Click
        Dim send As TextBox = DirectCast(sender, TextBox)
        If cdLabels.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            send.BackColor = cdLabels.Color
        End If
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        SetCloseSource("Button")
        Me.Close()
    End Sub

    Private Sub BtnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        SetCloseSource("Button")
        ' On valide les changements
        Dim tabColor(GetColorSize()) As Color
        Dim cpt As Integer = 0
        For Each tb As TextBox In pnlColors.Controls.OfType(Of TextBox)
            tabColor(cpt) = tb.BackColor
            cpt += 1
        Next
        SetColor(tabColor)
        SetNbTries(tries)
        Me.Close()
    End Sub

    Private Sub TbTries_TextChanged(sender As Object, e As EventArgs) Handles tbTries.TextChanged
        Dim nbTries As Integer
        Integer.TryParse(tbTries.Text, nbTries)
        If tbTries.Text <> "" And (nbTries <= 0 Or nbTries > GetNbTries()) Then
            MsgBox("Veuillez entrer une valeur entre 1 et 15 compris.", MsgBoxStyle.Information, "Attention !")
            tbTries.Text = GetNbTries().ToString()
        Else
            tries = nbTries
        End If
    End Sub

    Private Sub TbTries_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbTries.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class