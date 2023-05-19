Imports System.Windows.Forms

Public Class FormGame
    Private Sub FormGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSel.Text = PlayableCharToString()
    End Sub

    Private Sub TbKeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCode1.KeyPress, tbCode2.KeyPress, tbCode3.KeyPress, tbCode4.KeyPress, tbCode5.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) And Not GetPlayableChar().Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        FormMenu.Show()
    End Sub
End Class