Imports System.Drawing
Imports System.Windows.Forms

Public Class FormSettings
    Private tries As Integer = GetNbTries()
    Private currentTime As Integer = GetMaxTime()
    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetMode(Me)
        SetCloseSource("")
        sbChrono.Value = 90
        tbTries.Text = GetNbTries().ToString()
        Dim cpt As Integer = 0
        For Each tb As TextBox In pnlColors.Controls.OfType(Of TextBox)
            tb.BackColor = GetColor(cpt)
            cpt += 1
        Next

        If GetDarkMode() = False Then
            pbDark.BackgroundImage = Image.FromFile("../../images/brush.png")
            pbMusic.BackgroundImage = Image.FromFile("../../images/music.png")
        Else
            pbDark.BackgroundImage = Image.FromFile("../../images/brushWhite.png")
            pbMusic.BackgroundImage = Image.FromFile("../../images/musicWhite.png")
        End If

        If GetMaxTime() = Integer.MaxValue Then cbDisable.Checked = True
        If GetDarkMode() Then cbDarkMode.Checked = True
        If GetIsPlaying() Then cbMusic.Checked = True
        CbDisable_CheckedChanged(cbDisable, New EventArgs())
        RoundButton(btnDone, 15)
        RoundButton(btnQuit, 15)

    End Sub

    Private Sub FormSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If GetCloseSource() <> "Button" Then
            If MsgBox("Voulez-vous vraiment fermer cette fenêtre ?", 276, "Attention !") = vbNo Then
                e.Cancel = True
            Else
                SetMode(FormMenu)
                FormMenu.Show()
            End If
        Else
            SetMode(FormMenu)
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

    Private Sub TbTries_TextChanged(sender As Object, e As EventArgs) Handles tbTries.TextChanged
        Dim nbTries As Integer
        Integer.TryParse(tbTries.Text, nbTries)
        If tbTries.Text <> "" And (nbTries <= 0 Or nbTries > GetNbTries()) Then
            MsgBox("Veuillez entrer une valeur entre 1 et 15 compris.", MsgBoxStyle.Information, "Attention !")
            tbTries.Text = GetNbTries().ToString()
        Else
            tries = nbTries
        End If
    End Sub

    Private Sub TbTries_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbTries.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
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

        If cbDisable.Checked = True Then
            SetChronoEnabled(False)
            SetMaxTime(Integer.MaxValue)
        Else
            SetChronoEnabled(True)
            SetMaxTime(sbChrono.Value)
        End If

        SetColor(tabColor)
        SetNbTries(tries)

        If cbDarkMode.Checked = True Then
            SetDarkMode(True)
        Else
            SetDarkMode(False)
        End If

        If cbMusic.Checked Then
            SetIsPlaying(True)
            PlayMusic("../../audios/music.wav")
        Else
            SetIsPlaying(False)
            StopMusic()
        End If


        Me.Close()
    End Sub

    Private Sub CbDisable_CheckedChanged(sender As Object, e As EventArgs) Handles cbDisable.CheckedChanged
        If cbDisable.Checked = True Then
            sbChrono.Enabled = False
            lblSelected.Text = "-"
        Else
            sbChrono.Enabled = True
            lblSelected.Text = GetTimeToString(currentTime)
        End If
    End Sub

    Private Sub SbChrono_Scroll(sender As Object, e As ScrollEventArgs) Handles sbChrono.Scroll
        currentTime = sbChrono.Value
        lblSelected.Text = GetTimeToString(currentTime)
    End Sub

End Class