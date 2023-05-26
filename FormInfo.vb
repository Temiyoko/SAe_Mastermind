Imports System.Drawing
Imports System.Windows.Forms

Public Class FormInfo
    Private Sub FormInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetCloseSource("")
        pbCredits.BackgroundImage = Image.FromFile("../../images/Credits1.png")
        RoundButton(btnRetour, 15)
    End Sub
    Private Sub FormInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If GetCloseSource() <> "Button" Then
            If MsgBox("Voulez-vous vraiment fermer cette fenêtre ?", 276, "Attention !") = vbNo Then
                e.Cancel = True
            Else
                FormSettings.Show()
            End If
        Else
            FormSettings.Show()
        End If
    End Sub
    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        SetCloseSource("Button")
        Me.Close()
    End Sub
End Class