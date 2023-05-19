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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTries = New System.Windows.Forms.Label()
        Me.lblColorCode = New System.Windows.Forms.Label()
        Me.lblMissing = New System.Windows.Forms.Label()
        Me.lblSel = New System.Windows.Forms.Label()
        Me.lblChar = New System.Windows.Forms.Label()
        Me.lblFound = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblWrong = New System.Windows.Forms.Label()
        Me.lblRight = New System.Windows.Forms.Label()
        Me.pnlTextBox = New System.Windows.Forms.Panel()
        Me.tbCode5 = New System.Windows.Forms.TextBox()
        Me.tbCode1 = New System.Windows.Forms.TextBox()
        Me.tbCode2 = New System.Windows.Forms.TextBox()
        Me.tbCode3 = New System.Windows.Forms.TextBox()
        Me.tbCode4 = New System.Windows.Forms.TextBox()
        Me.pnlTries = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnlTextBox.SuspendLayout()
        Me.pnlTries.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGuess
        '
        Me.btnGuess.Enabled = False
        Me.btnGuess.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuess.Location = New System.Drawing.Point(930, 134)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(147, 42)
        Me.btnGuess.TabIndex = 14
        Me.btnGuess.Text = "Valider"
        Me.btnGuess.UseVisualStyleBackColor = True
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
        Me.lblTries.Location = New System.Drawing.Point(260, 212)
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
        Me.lblFound.Location = New System.Drawing.Point(715, 658)
        Me.lblFound.Name = "lblFound"
        Me.lblFound.Size = New System.Drawing.Size(196, 70)
        Me.lblFound.TabIndex = 22
        Me.lblFound.Text = "Trouvé !"
        Me.lblFound.Visible = False
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(930, 851)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(147, 43)
        Me.btnBack.TabIndex = 23
        Me.btnBack.Text = "Retour"
        Me.btnBack.UseVisualStyleBackColor = True
        Me.btnBack.Visible = False
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
        'pnlTextBox
        '
        Me.pnlTextBox.Controls.Add(Me.tbCode5)
        Me.pnlTextBox.Controls.Add(Me.tbCode1)
        Me.pnlTextBox.Controls.Add(Me.tbCode2)
        Me.pnlTextBox.Controls.Add(Me.tbCode3)
        Me.pnlTextBox.Controls.Add(Me.tbCode4)
        Me.pnlTextBox.Location = New System.Drawing.Point(33, 99)
        Me.pnlTextBox.Name = "pnlTextBox"
        Me.pnlTextBox.Size = New System.Drawing.Size(891, 100)
        Me.pnlTextBox.TabIndex = 26
        '
        'tbCode5
        '
        Me.tbCode5.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCode5.Location = New System.Drawing.Point(10, 35)
        Me.tbCode5.MaxLength = 1
        Me.tbCode5.Name = "tbCode5"
        Me.tbCode5.Size = New System.Drawing.Size(147, 42)
        Me.tbCode5.TabIndex = 5
        Me.tbCode5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbCode1
        '
        Me.tbCode1.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCode1.Location = New System.Drawing.Point(188, 35)
        Me.tbCode1.MaxLength = 1
        Me.tbCode1.Name = "tbCode1"
        Me.tbCode1.Size = New System.Drawing.Size(147, 42)
        Me.tbCode1.TabIndex = 1
        Me.tbCode1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbCode2
        '
        Me.tbCode2.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCode2.Location = New System.Drawing.Point(366, 35)
        Me.tbCode2.MaxLength = 1
        Me.tbCode2.Name = "tbCode2"
        Me.tbCode2.Size = New System.Drawing.Size(147, 42)
        Me.tbCode2.TabIndex = 2
        Me.tbCode2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbCode3
        '
        Me.tbCode3.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCode3.Location = New System.Drawing.Point(546, 35)
        Me.tbCode3.MaxLength = 1
        Me.tbCode3.Name = "tbCode3"
        Me.tbCode3.Size = New System.Drawing.Size(147, 42)
        Me.tbCode3.TabIndex = 3
        Me.tbCode3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbCode4
        '
        Me.tbCode4.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCode4.Location = New System.Drawing.Point(722, 35)
        Me.tbCode4.MaxLength = 1
        Me.tbCode4.Name = "tbCode4"
        Me.tbCode4.Size = New System.Drawing.Size(147, 42)
        Me.tbCode4.TabIndex = 4
        Me.tbCode4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlTries
        '
        Me.pnlTries.Controls.Add(Me.Panel15)
        Me.pnlTries.Controls.Add(Me.Panel14)
        Me.pnlTries.Controls.Add(Me.Panel13)
        Me.pnlTries.Controls.Add(Me.Panel12)
        Me.pnlTries.Controls.Add(Me.Panel11)
        Me.pnlTries.Controls.Add(Me.Panel10)
        Me.pnlTries.Controls.Add(Me.Panel9)
        Me.pnlTries.Controls.Add(Me.Panel8)
        Me.pnlTries.Controls.Add(Me.Panel1)
        Me.pnlTries.Controls.Add(Me.Panel7)
        Me.pnlTries.Controls.Add(Me.Panel6)
        Me.pnlTries.Controls.Add(Me.Panel5)
        Me.pnlTries.Controls.Add(Me.Panel4)
        Me.pnlTries.Controls.Add(Me.Panel3)
        Me.pnlTries.Controls.Add(Me.Panel2)
        Me.pnlTries.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTries.Location = New System.Drawing.Point(176, 252)
        Me.pnlTries.Name = "pnlTries"
        Me.pnlTries.Size = New System.Drawing.Size(405, 642)
        Me.pnlTries.TabIndex = 27
        '
        'Panel7
        '
        Me.Panel7.Location = New System.Drawing.Point(0, 383)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(619, 37)
        Me.Panel7.TabIndex = 5
        Me.Panel7.Visible = False
        '
        'Panel6
        '
        Me.Panel6.Location = New System.Drawing.Point(0, 426)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(619, 37)
        Me.Panel6.TabIndex = 4
        Me.Panel6.Visible = False
        '
        'Panel5
        '
        Me.Panel5.Location = New System.Drawing.Point(0, 469)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(619, 37)
        Me.Panel5.TabIndex = 3
        Me.Panel5.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(0, 512)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(619, 37)
        Me.Panel4.TabIndex = 2
        Me.Panel4.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Location = New System.Drawing.Point(0, 555)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(619, 37)
        Me.Panel3.TabIndex = 1
        Me.Panel3.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 598)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(619, 37)
        Me.Panel2.TabIndex = 0
        Me.Panel2.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 340)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(619, 37)
        Me.Panel1.TabIndex = 6
        Me.Panel1.Visible = False
        '
        'Panel8
        '
        Me.Panel8.Location = New System.Drawing.Point(0, 297)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(619, 37)
        Me.Panel8.TabIndex = 7
        Me.Panel8.Visible = False
        '
        'Panel9
        '
        Me.Panel9.Location = New System.Drawing.Point(0, 254)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(619, 37)
        Me.Panel9.TabIndex = 8
        Me.Panel9.Visible = False
        '
        'Panel10
        '
        Me.Panel10.Location = New System.Drawing.Point(0, 211)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(619, 37)
        Me.Panel10.TabIndex = 9
        Me.Panel10.Visible = False
        '
        'Panel11
        '
        Me.Panel11.Location = New System.Drawing.Point(0, 171)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(619, 37)
        Me.Panel11.TabIndex = 10
        Me.Panel11.Visible = False
        '
        'Panel12
        '
        Me.Panel12.Location = New System.Drawing.Point(0, 128)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(619, 37)
        Me.Panel12.TabIndex = 11
        Me.Panel12.Visible = False
        '
        'Panel13
        '
        Me.Panel13.Location = New System.Drawing.Point(0, 85)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(619, 37)
        Me.Panel13.TabIndex = 12
        Me.Panel13.Visible = False
        '
        'Panel14
        '
        Me.Panel14.Location = New System.Drawing.Point(0, 42)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(619, 37)
        Me.Panel14.TabIndex = 13
        Me.Panel14.Visible = False
        '
        'Panel15
        '
        Me.Panel15.Location = New System.Drawing.Point(0, 3)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(619, 37)
        Me.Panel15.TabIndex = 28
        Me.Panel15.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(325, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 31)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(248, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 31)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(170, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 31)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(92, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 31)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 31)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 31)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(92, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 31)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(170, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 31)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(248, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 31)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Label9"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(325, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 31)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Label10"
        '
        'FormGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1135, 933)
        Me.Controls.Add(Me.pnlTries)
        Me.Controls.Add(Me.pnlTextBox)
        Me.Controls.Add(Me.lblRight)
        Me.Controls.Add(Me.lblWrong)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblFound)
        Me.Controls.Add(Me.lblSel)
        Me.Controls.Add(Me.lblChar)
        Me.Controls.Add(Me.lblMissing)
        Me.Controls.Add(Me.lblColorCode)
        Me.Controls.Add(Me.lblTries)
        Me.Controls.Add(Me.btnGuess)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormGame"
        Me.Text = "formGame"
        Me.pnlTextBox.ResumeLayout(False)
        Me.pnlTextBox.PerformLayout()
        Me.pnlTries.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As Windows.Forms.Label
    Friend WithEvents lblTries As Windows.Forms.Label
    Friend WithEvents lblColorCode As Windows.Forms.Label
    Friend WithEvents lblMissing As Windows.Forms.Label
    Friend WithEvents lblSel As Windows.Forms.Label
    Friend WithEvents lblChar As Windows.Forms.Label
    Friend WithEvents btnGuess As Windows.Forms.Button
    Friend WithEvents lblFound As Windows.Forms.Label
    Friend WithEvents btnBack As Windows.Forms.Button
    Friend WithEvents lblWrong As Windows.Forms.Label
    Friend WithEvents lblRight As Windows.Forms.Label
    Friend WithEvents pnlTextBox As Windows.Forms.Panel
    Friend WithEvents tbCode5 As Windows.Forms.TextBox
    Friend WithEvents tbCode1 As Windows.Forms.TextBox
    Friend WithEvents tbCode2 As Windows.Forms.TextBox
    Friend WithEvents tbCode3 As Windows.Forms.TextBox
    Friend WithEvents tbCode4 As Windows.Forms.TextBox
    Friend WithEvents pnlTries As Windows.Forms.Panel
    Friend WithEvents Panel7 As Windows.Forms.Panel
    Friend WithEvents Panel6 As Windows.Forms.Panel
    Friend WithEvents Panel5 As Windows.Forms.Panel
    Friend WithEvents Panel4 As Windows.Forms.Panel
    Friend WithEvents Panel3 As Windows.Forms.Panel
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents Panel15 As Windows.Forms.Panel
    Friend WithEvents Panel14 As Windows.Forms.Panel
    Friend WithEvents Panel13 As Windows.Forms.Panel
    Friend WithEvents Panel12 As Windows.Forms.Panel
    Friend WithEvents Panel11 As Windows.Forms.Panel
    Friend WithEvents Panel10 As Windows.Forms.Panel
    Friend WithEvents Panel9 As Windows.Forms.Panel
    Friend WithEvents Panel8 As Windows.Forms.Panel
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
End Class
