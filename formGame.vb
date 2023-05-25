Imports System.Drawing
Imports System.Windows.Forms

Public Class FormGame
    Private nbTries As Integer = GetNbTries()
    Private maxTime = 90
    Private currentTime = 90
    Private Sub FormGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetCloseSource("")
        Dim cpt As Integer = 0
        For Each lbl As Label In pnlLabels.Controls
            lbl.ForeColor = GetColor(cpt)
            cpt += 1
        Next
        lblSel.Text = PlayableCharToString()
        UpdateTime()
        tmEnd.Start()
    End Sub

    Private Sub TbCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCode1.KeyPress, tbCode2.KeyPress, tbCode3.KeyPress, tbCode4.KeyPress, tbCode5.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) And Not GetPlayableChar().Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        SetCloseSource("Button")
        FormMenu.NextGame()
        Me.Close()
    End Sub

    Private Sub TbCode_TextChanged(sender As Object, e As EventArgs) Handles tbCode1.TextChanged, tbCode2.TextChanged, tbCode3.TextChanged, tbCode4.TextChanged, tbCode5.TextChanged
        Dim cpt As Integer = 0

        For Each tb As TextBox In pnlTextBox.Controls
            If Not tb.Text = "" Then cpt += 1
        Next

        Dim txtBox As TextBox = DirectCast(sender, TextBox)
        If txtBox.Text <> "" Then
            Dim nextTb As Integer = (pnlTextBox.Controls.IndexOf(txtBox) + 1) Mod pnlTextBox.Controls.Count
            DirectCast(pnlTextBox.Controls(nextTb), TextBox).Focus()
        End If

        If cpt = pnlTextBox.Controls.Count Then
            btnGuess.Enabled = True
        Else
            btnGuess.Enabled = False
        End If
    End Sub

    Private Sub SaveTry(s As String, c As Color())
        Dim ind As Integer = 0
        For Each pnl As Panel In pnlTries.Controls
            If pnl.Visible = False Then
                pnl.Visible = True
                For Each label As Label In pnl.Controls
                    label.Text = s.Substring(0, 1)
                    label.ForeColor = c(ind)
                    s = s.Remove(0, 1)
                    ind += 1
                Next
                Exit Sub
            End If
        Next
    End Sub

    Private Sub BtnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        Dim ind As Integer = 0
        Dim cpt As Integer = 0
        Dim entry As String = ""
        Dim colors(pnlTextBox.Controls.Count) As Color

        For Each tb As TextBox In pnlTextBox.Controls
            entry += tb.Text
            If tb.Text = GetCodeInd(ind) Then
                tb.BackColor = GetColor(0)
                cpt += 1
            ElseIf GetCode().Contains(tb.Text) Then
                tb.BackColor = GetColor(1)
            Else
                tb.BackColor = GetColor(2)
            End If
            colors(ind) = tb.BackColor
            ind += 1
        Next
        SaveTry(entry, colors)

        If cpt = GetCode().Length Then
            WonGame()
        End If

        nbTries -= 1

        If nbTries = 0 Then
            LostGame()
            MsgBox("Vous avez utilisé tous vos essais", MsgBoxStyle.Critical, "Dommage...")
        End If

        UpdateTime()
    End Sub

    Private Sub TmEnd_Tick(sender As Object, e As EventArgs) Handles tmEnd.Tick
        currentTime -= 1
        UpdateTime()

        If currentTime = 0 Then
            LostGame()
            MsgBox("Le temps est écoulé", MsgBoxStyle.Critical, "Zut...")
        End If
    End Sub

    Private Sub LostGame()
        tmEnd.Stop()
        pnlTextBox.Enabled = False
        btnGuess.Enabled = False
        btnBack.Visible = True
        UpdateTime()
        UpdatePlayer(FormMenu.cboP1.Text, maxTime - currentTime, 1, True)
        UpdatePlayer(FormMenu.cboP2.Text, maxTime - currentTime, 2, False)
    End Sub

    Private Sub WonGame()
        tmEnd.Stop()
        pnlTextBox.Enabled = False
        btnGuess.Enabled = False
        lblFound.Visible = True
        btnBack.Visible = True
        UpdatePlayer(FormMenu.cboP1.Text, maxTime - currentTime, 1, False)
        UpdatePlayer(FormMenu.cboP2.Text, maxTime - currentTime, 2, True)
    End Sub

    Private Sub UpdateTime()
        Dim minutes As Integer = currentTime \ 60
        Dim seconds As Integer = currentTime Mod 60

        Me.Text = "Il vous reste " & nbTries & " coup(s) et " & minutes & " minute et " & seconds & " secondes"
    End Sub

    Private Sub FormGame_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If GetCloseSource() <> "Button" Then
            tmEnd.Stop()
            If MsgBox("Voulez-vous vraiment fermer cette fenêtre ?", 276, "Attention !") = vbNo Then
                e.Cancel = True
                tmEnd.Start()
            Else
                FormMenu.Show()
            End If
        Else
            FormMenu.Show()
        End If
    End Sub

End Class