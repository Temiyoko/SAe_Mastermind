Imports System.Windows.Forms

Public Class FormGame
    Private Sub FormGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSel.Text = PlayableCharToString()
    End Sub

    Private Sub TbKeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar <> ChrW(Keys.Back) And Not GetPlayableChar().Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        FormMenu.Show()
    End Sub

    Private Sub TbCode_TextChanged(sender As Object, e As EventArgs) Handles tbCode1.TextChanged, tbCode2.TextChanged, tbCode3.TextChanged, tbCode4.TextChanged, tbCode5.TextChanged

    End Sub
End Class