Imports System.Windows.Forms

Public Class FormGame
    Private Sub FormGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSel.Text = PlayableCharToString()
    End Sub

    Private Sub TbCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCode1.KeyPress, tbCode2.KeyPress, tbCode3.KeyPress, tbCode4.KeyPress, tbCode5.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) And Not GetPlayableChar().Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        FormMenu.Show()
    End Sub

    Private Sub TbCode_TextChanged(sender As Object, e As EventArgs) Handles tbCode1.TextChanged, tbCode2.TextChanged, tbCode3.TextChanged, tbCode4.TextChanged, tbCode5.TextChanged
        Dim cpt As Integer = 0

        For Each tb As TextBox In pnlTextBox.Controls
            If Not tb.Text = "" Then
                Dim nextTb As Integer = (pnlTextBox.Controls.IndexOf(tb) + 1) Mod pnlTextBox.Controls.Count
                DirectCast(pnlTextBox.Controls(nextTb), TextBox).Focus()
                cpt += 1
            End If
        Next

        If cpt = pnlTextBox.Controls.Count Then
            btnGuess.Enabled = True
        Else
            btnGuess.Enabled = False
        End If
    End Sub
End Class