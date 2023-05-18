Imports System.Windows.Forms

Public Class FormCode

    Private Sub FormCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSel.Text = PlayableCharToString()
        btnHide.Text = "Afficher"
        ObfuscateTextboxes()
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        ' 308 est le résultat de 4 (Oui/Non) + 48 (Exclamation ) + 256 (2e bouton par défaut)
        If MsgBox("Voulez-vous abandonner ?", 308, "Attention !") Then
            Me.Close()
            FormMenu.Show()
        End If
    End Sub

    Private Sub TbCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCode1.KeyPress, tbCode2.KeyPress, tbCode3.KeyPress, tbCode4.KeyPress, tbCode5.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) And Not GetPlayableChar().Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ObfuscateTextboxes()
        For Each tb As TextBox In pnlTextBox.Controls
            tb.PasswordChar = "*"c
        Next
    End Sub

    Private Sub RevealTextboxes()
        For Each tb As TextBox In pnlTextBox.Controls
            tb.PasswordChar = ControlChars.NullChar
        Next
    End Sub

    Private Sub BtnHide_MouseDown(sender As Object, e As MouseEventArgs) Handles btnHide.MouseDown
        btnHide.Text = "Cacher"
        RevealTextboxes()
    End Sub

    Private Sub BtnHide_MouseUp(sender As Object, e As MouseEventArgs) Handles btnHide.MouseUp
        btnHide.Text = "Afficher"
        ObfuscateTextboxes()
    End Sub

    Private Sub TbCode_TextChanged(sender As Object, e As EventArgs) Handles tbCode1.TextChanged, tbCode2.TextChanged, tbCode3.TextChanged, tbCode4.TextChanged, tbCode5.TextChanged
        Dim cpt As Integer = 0

        For Each tb As TextBox In pnlTextBox.Controls
            If Not tb.Text = "" Then
                cpt += 1
            End If
        Next

        If cpt = pnlTextBox.Controls.Count Then
            btnDone.Visible = True
        Else
            btnDone.Visible = False
        End If
    End Sub

    Private Sub BtnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim code As String = ""
        For Each tb As TextBox In pnlTextBox.Controls
            code += tb.Text
        Next
        SetCode(code)

        Me.Close()
        FormGame.Show()
    End Sub
End Class