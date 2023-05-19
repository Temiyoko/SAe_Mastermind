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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlTextBox.SuspendLayout()
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
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(77, 255)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(620, 175)
        Me.Panel1.TabIndex = 27
        '
        'FormGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1135, 933)
        Me.Controls.Add(Me.Panel1)
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
    Friend WithEvents Panel1 As Windows.Forms.Panel
End Class
