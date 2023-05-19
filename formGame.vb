Imports System.Drawing
Imports System.Windows.Forms

Public Class FormGame
    Private nbTries As Integer = 15
    Private Sub FormGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSel.Text = PlayableCharToString()
        Me.Text = "Il vous reste " & nbTries & " coup(s)..."
        tmEnd.Start()

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
            If tb.Text = getCodeInd(ind) Then
                tb.BackColor = Color.LimeGreen
                cpt += 1
            ElseIf GetCode().Contains(tb.Text) Then
                tb.BackColor = Color.Orange
            Else
                tb.BackColor = Color.Red
            End If
            colors(ind) = tb.BackColor
            ind += 1
        Next
        SaveTry(entry, colors)

        If cpt = GetCode().Length Then
            pnlTextBox.Enabled = False
            btnGuess.Enabled = False
            lblFound.Visible = True
            btnBack.Visible = True
        End If

        nbTries -= 1
        Me.Text = "Il vous reste " & nbTries & " coup(s)..."
    End Sub

    Private Sub tmEnd_Tick(sender As Object, e As EventArgs) Handles tmEnd.Tick
        'Fin du jeu
        pnlTextBox.Enabled = False
        btnGuess.Enabled = False
        btnBack.Visible = True
    End Sub
End Class