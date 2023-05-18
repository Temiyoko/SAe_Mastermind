Imports System.Windows.Forms

Public Class FormCode

    Private Sub FormCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSel.Text = PlayableCharToString()
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        ' 308 est le résultat de 4 (Oui/Non) + 48 (Exclamation ) + 256 (2e bouton par défaut)
        If MsgBox("Voulez-vous abandonner ?", 308, "Attention !") Then
            Me.Close()
            FormMenu.Show()
        End If
    End Sub

    Private Sub TbCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCode1.KeyPress, tbCode2.KeyPress, tbCode3.KeyPress, tbCode4.KeyPress, tbCode5.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) And Not getPlayableChar().Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class