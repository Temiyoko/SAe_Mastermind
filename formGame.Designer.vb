<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGame
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnGuess = New System.Windows.Forms.Button()
        Me.tbCode5 = New System.Windows.Forms.TextBox()
        Me.tbCode4 = New System.Windows.Forms.TextBox()
        Me.tbCode3 = New System.Windows.Forms.TextBox()
        Me.tbCode2 = New System.Windows.Forms.TextBox()
        Me.tbCode1 = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTries = New System.Windows.Forms.Label()
        Me.lblColorCode = New System.Windows.Forms.Label()
        Me.pnlTries = New System.Windows.Forms.Panel()
        Me.lblTry10 = New System.Windows.Forms.Label()
        Me.lblTry9 = New System.Windows.Forms.Label()
        Me.lblTry8 = New System.Windows.Forms.Label()
        Me.lblTry7 = New System.Windows.Forms.Label()
        Me.lblTry6 = New System.Windows.Forms.Label()
        Me.lblTry5 = New System.Windows.Forms.Label()
        Me.lblTry4 = New System.Windows.Forms.Label()
        Me.lblTry3 = New System.Windows.Forms.Label()
        Me.lblTry2 = New System.Windows.Forms.Label()
        Me.lblTry1 = New System.Windows.Forms.Label()
        Me.lblMissing = New System.Windows.Forms.Label()
        Me.lblSel = New System.Windows.Forms.Label()
        Me.lblChar = New System.Windows.Forms.Label()
        Me.lblFound = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblWrong = New System.Windows.Forms.Label()
        Me.lblRight = New System.Windows.Forms.Label()
        Me.pnlTries.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGuess
        '
        Me.btnGuess.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuess.Location = New System.Drawing.Point(930, 134)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(147, 42)
        Me.btnGuess.TabIndex = 14
        Me.btnGuess.Text = "Valider"
        Me.btnGuess.UseVisualStyleBackColor = True
        '
        'tbCode5
        '
        Me.tbCode5.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCode5.Location = New System.Drawing.Point(755, 134)
        Me.tbCode5.MaxLength = 1
        Me.tbCode5.Name = "tbCode5"
        Me.tbCode5.Size = New System.Drawing.Size(147, 42)
        Me.tbCode5.TabIndex = 13
        Me.tbCode5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbCode4
        '
        Me.tbCode4.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCode4.Location = New System.Drawing.Point(577, 134)
        Me.tbCode4.MaxLength = 1
        Me.tbCode4.Name = "tbCode4"
        Me.tbCode4.Size = New System.Drawing.Size(147, 42)
        Me.tbCode4.TabIndex = 12
        Me.tbCode4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbCode3
        '
        Me.tbCode3.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCode3.Location = New System.Drawing.Point(401, 134)
        Me.tbCode3.MaxLength = 1
        Me.tbCode3.Name = "tbCode3"
        Me.tbCode3.Size = New System.Drawing.Size(147, 42)
        Me.tbCode3.TabIndex = 11
        Me.tbCode3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbCode2
        '
        Me.tbCode2.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCode2.Location = New System.Drawing.Point(221, 134)
        Me.tbCode2.MaxLength = 1
        Me.tbCode2.Name = "tbCode2"
        Me.tbCode2.Size = New System.Drawing.Size(147, 42)
        Me.tbCode2.TabIndex = 10
        Me.tbCode2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbCode1
        '
        Me.tbCode1.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCode1.Location = New System.Drawing.Point(43, 134)
        Me.tbCode1.MaxLength = 1
        Me.tbCode1.Name = "tbCode1"
        Me.tbCode1.Size = New System.Drawing.Size(147, 42)
        Me.tbCode1.TabIndex = 9
        Me.tbCode1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Poppins", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(425, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(282, 70)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "Mastermind"
        '
        'lblTries
        '
        Me.lblTries.AutoSize = True
        Me.lblTries.Font = New System.Drawing.Font("Poppins SemiBold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTries.Location = New System.Drawing.Point(273, 212)
        Me.lblTries.Name = "lblTries"
        Me.lblTries.Size = New System.Drawing.Size(237, 40)
        Me.lblTries.TabIndex = 15
        Me.lblTries.Text = "Précédents essais :"
        '
        'lblColorCode
        '
        Me.lblColorCode.AutoSize = True
        Me.lblColorCode.Font = New System.Drawing.Font("Poppins SemiBold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColorCode.Location = New System.Drawing.Point(720, 212)
        Me.lblColorCode.Name = "lblColorCode"
        Me.lblColorCode.Size = New System.Drawing.Size(184, 40)
        Me.lblColorCode.TabIndex = 16
        Me.lblColorCode.Text = "Code couleur :"
        '
        'pnlTries
        '
        Me.pnlTries.Controls.Add(Me.lblTry10)
        Me.pnlTries.Controls.Add(Me.lblTry9)
        Me.pnlTries.Controls.Add(Me.lblTry8)
        Me.pnlTries.Controls.Add(Me.lblTry7)
        Me.pnlTries.Controls.Add(Me.lblTry6)
        Me.pnlTries.Controls.Add(Me.lblTry5)
        Me.pnlTries.Controls.Add(Me.lblTry4)
        Me.pnlTries.Controls.Add(Me.lblTry3)
        Me.pnlTries.Controls.Add(Me.lblTry2)
        Me.pnlTries.Controls.Add(Me.lblTry1)
        Me.pnlTries.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTries.Location = New System.Drawing.Point(221, 274)
        Me.pnlTries.Name = "pnlTries"
        Me.pnlTries.Size = New System.Drawing.Size(327, 489)
        Me.pnlTries.TabIndex = 17
        '
        'lblTry10
        '
        Me.lblTry10.AutoSize = True
        Me.lblTry10.Location = New System.Drawing.Point(21, 374)
        Me.lblTry10.Name = "lblTry10"
        Me.lblTry10.Size = New System.Drawing.Size(97, 40)
        Me.lblTry10.TabIndex = 33
        Me.lblTry10.Text = "lblTry10"
        '
        'lblTry9
        '
        Me.lblTry9.AutoSize = True
        Me.lblTry9.Location = New System.Drawing.Point(21, 334)
        Me.lblTry9.Name = "lblTry9"
        Me.lblTry9.Size = New System.Drawing.Size(90, 40)
        Me.lblTry9.TabIndex = 32
        Me.lblTry9.Text = "lblTry9"
        '
        'lblTry8
        '
        Me.lblTry8.AutoSize = True
        Me.lblTry8.Location = New System.Drawing.Point(20, 294)
        Me.lblTry8.Name = "lblTry8"
        Me.lblTry8.Size = New System.Drawing.Size(90, 40)
        Me.lblTry8.TabIndex = 31
        Me.lblTry8.Text = "lblTry8"
        '
        'lblTry7
        '
        Me.lblTry7.AutoSize = True
        Me.lblTry7.Location = New System.Drawing.Point(21, 254)
        Me.lblTry7.Name = "lblTry7"
        Me.lblTry7.Size = New System.Drawing.Size(88, 40)
        Me.lblTry7.TabIndex = 30
        Me.lblTry7.Text = "lblTry7"
        '
        'lblTry6
        '
        Me.lblTry6.AutoSize = True
        Me.lblTry6.Location = New System.Drawing.Point(21, 214)
        Me.lblTry6.Name = "lblTry6"
        Me.lblTry6.Size = New System.Drawing.Size(90, 40)
        Me.lblTry6.TabIndex = 29
        Me.lblTry6.Text = "lblTry6"
        '
        'lblTry5
        '
        Me.lblTry5.AutoSize = True
        Me.lblTry5.Location = New System.Drawing.Point(22, 174)
        Me.lblTry5.Name = "lblTry5"
        Me.lblTry5.Size = New System.Drawing.Size(90, 40)
        Me.lblTry5.TabIndex = 28
        Me.lblTry5.Text = "lblTry5"
        '
        'lblTry4
        '
        Me.lblTry4.AutoSize = True
        Me.lblTry4.Location = New System.Drawing.Point(22, 134)
        Me.lblTry4.Name = "lblTry4"
        Me.lblTry4.Size = New System.Drawing.Size(90, 40)
        Me.lblTry4.TabIndex = 27
        Me.lblTry4.Text = "lblTry4"
        '
        'lblTry3
        '
        Me.lblTry3.AutoSize = True
        Me.lblTry3.Location = New System.Drawing.Point(21, 94)
        Me.lblTry3.Name = "lblTry3"
        Me.lblTry3.Size = New System.Drawing.Size(90, 40)
        Me.lblTry3.TabIndex = 26
        Me.lblTry3.Text = "lblTry3"
        '
        'lblTry2
        '
        Me.lblTry2.AutoSize = True
        Me.lblTry2.Location = New System.Drawing.Point(22, 54)
        Me.lblTry2.Name = "lblTry2"
        Me.lblTry2.Size = New System.Drawing.Size(89, 40)
        Me.lblTry2.TabIndex = 25
        Me.lblTry2.Text = "lblTry2"
        '
        'lblTry1
        '
        Me.lblTry1.AutoSize = True
        Me.lblTry1.Location = New System.Drawing.Point(22, 14)
        Me.lblTry1.Name = "lblTry1"
        Me.lblTry1.Size = New System.Drawing.Size(83, 40)
        Me.lblTry1.TabIndex = 24
        Me.lblTry1.Text = "lblTry1"
        '
        'lblMissing
        '
        Me.lblMissing.AutoSize = True
        Me.lblMissing.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMissing.ForeColor = System.Drawing.Color.Red
        Me.lblMissing.Location = New System.Drawing.Point(748, 252)
        Me.lblMissing.Name = "lblMissing"
        Me.lblMissing.Size = New System.Drawing.Size(97, 40)
        Me.lblMissing.TabIndex = 18
        Me.lblMissing.Text = "Absent"
        '
        'lblSel
        '
        Me.lblSel.AutoSize = True
        Me.lblSel.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSel.Location = New System.Drawing.Point(748, 426)
        Me.lblSel.Name = "lblSel"
        Me.lblSel.Size = New System.Drawing.Size(74, 40)
        Me.lblSel.TabIndex = 21
        Me.lblSel.Text = "lblSel"
        '
        'lblChar
        '
        Me.lblChar.AutoSize = True
        Me.lblChar.Font = New System.Drawing.Font("Poppins SemiBold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChar.Location = New System.Drawing.Point(720, 386)
        Me.lblChar.Name = "lblChar"
        Me.lblChar.Size = New System.Drawing.Size(265, 40)
        Me.lblChar.TabIndex = 20
        Me.lblChar.Text = "Caractères jouables :"
        '
        'lblFound
        '
        Me.lblFound.AutoSize = True
        Me.lblFound.Font = New System.Drawing.Font("Poppins", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFound.Location = New System.Drawing.Point(715, 549)
        Me.lblFound.Name = "lblFound"
        Me.lblFound.Size = New System.Drawing.Size(196, 70)
        Me.lblFound.TabIndex = 22
        Me.lblFound.Text = "Trouvé !"
        Me.lblFound.Visible = False
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(930, 720)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(147, 43)
        Me.btnBack.TabIndex = 23
        Me.btnBack.Text = "Retour"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblWrong
        '
        Me.lblWrong.AutoSize = True
        Me.lblWrong.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWrong.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblWrong.Location = New System.Drawing.Point(748, 292)
        Me.lblWrong.Name = "lblWrong"
        Me.lblWrong.Size = New System.Drawing.Size(126, 40)
        Me.lblWrong.TabIndex = 24
        Me.lblWrong.Text = "Mal placé"
        '
        'lblRight
        '
        Me.lblRight.AutoSize = True
        Me.lblRight.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRight.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblRight.Location = New System.Drawing.Point(748, 328)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(134, 40)
        Me.lblRight.TabIndex = 25
        Me.lblRight.Text = "Bien placé"
        '
        'FormGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 775)
        Me.Controls.Add(Me.lblRight)
        Me.Controls.Add(Me.lblWrong)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblFound)
        Me.Controls.Add(Me.lblSel)
        Me.Controls.Add(Me.lblChar)
        Me.Controls.Add(Me.lblMissing)
        Me.Controls.Add(Me.pnlTries)
        Me.Controls.Add(Me.lblColorCode)
        Me.Controls.Add(Me.lblTries)
        Me.Controls.Add(Me.btnGuess)
        Me.Controls.Add(Me.tbCode5)
        Me.Controls.Add(Me.tbCode4)
        Me.Controls.Add(Me.tbCode3)
        Me.Controls.Add(Me.tbCode2)
        Me.Controls.Add(Me.tbCode1)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "FormGame"
        Me.Text = "formGame"
        Me.pnlTries.ResumeLayout(False)
        Me.pnlTries.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbCode5 As Windows.Forms.TextBox
    Friend WithEvents tbCode4 As Windows.Forms.TextBox
    Friend WithEvents tbCode3 As Windows.Forms.TextBox
    Friend WithEvents tbCode2 As Windows.Forms.TextBox
    Friend WithEvents tbCode1 As Windows.Forms.TextBox
    Friend WithEvents lblTitle As Windows.Forms.Label
    Friend WithEvents lblTries As Windows.Forms.Label
    Friend WithEvents lblColorCode As Windows.Forms.Label
    Friend WithEvents pnlTries As Windows.Forms.Panel
    Friend WithEvents lblMissing As Windows.Forms.Label
    Friend WithEvents lblSel As Windows.Forms.Label
    Friend WithEvents lblChar As Windows.Forms.Label
    Friend WithEvents btnGuess As Windows.Forms.Button
    Friend WithEvents lblFound As Windows.Forms.Label
    Friend WithEvents btnBack As Windows.Forms.Button
    Friend WithEvents lblTry10 As Windows.Forms.Label
    Friend WithEvents lblTry9 As Windows.Forms.Label
    Friend WithEvents lblTry8 As Windows.Forms.Label
    Friend WithEvents lblTry7 As Windows.Forms.Label
    Friend WithEvents lblTry6 As Windows.Forms.Label
    Friend WithEvents lblTry5 As Windows.Forms.Label
    Friend WithEvents lblTry4 As Windows.Forms.Label
    Friend WithEvents lblTry3 As Windows.Forms.Label
    Friend WithEvents lblTry2 As Windows.Forms.Label
    Friend WithEvents lblTry1 As Windows.Forms.Label
    Friend WithEvents lblWrong As Windows.Forms.Label
    Friend WithEvents lblRight As Windows.Forms.Label
End Class
