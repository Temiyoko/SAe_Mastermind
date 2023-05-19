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

    Private Sub lblTry1_Click(sender As Object, e As EventArgs) Handles lblTry1.Click

    End Sub

    Private Sub lblTry2_Click(sender As Object, e As EventArgs) Handles lblTry2.Click

    End Sub

    Private Sub lblTry3_Click(sender As Object, e As EventArgs) Handles lblTry3.Click

    End Sub

    Private Sub lblTry4_Click(sender As Object, e As EventArgs) Handles lblTry4.Click

    End Sub

    Private Sub lblTry5_Click(sender As Object, e As EventArgs) Handles lblTry5.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class