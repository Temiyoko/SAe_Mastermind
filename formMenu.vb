Public Class FormMenu
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        ' 276 est le résultat de 4 (Oui/Non) + 16 (Critical) + 256 (2e bouton par défaut)
        If MsgBox("Voulez-vous vraiment quitter ?", 276, "Attention") = vbYes Then Me.Close()
    End Sub
End Class