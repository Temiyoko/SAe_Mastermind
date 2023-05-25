Imports System.Drawing
Imports System.Reflection.Emit
Imports System.Windows.Forms

Public Class FormSettings

    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetCloseSource("")
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
        Me.Close()
    End Sub
End Class