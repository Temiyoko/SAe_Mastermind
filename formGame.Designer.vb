<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGame
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.lblColors = New System.Windows.Forms.Label()
        Me.lblSel = New System.Windows.Forms.Label()
        Me.lblChar = New System.Windows.Forms.Label()
        Me.lblFound = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
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
        '
        'tbCode4
        '
        Me.tbCode4.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCode4.Location = New System.Drawing.Point(577, 134)
        Me.tbCode4.MaxLength = 1
        Me.tbCode4.Name = "tbCode4"
        Me.tbCode4.Size = New System.Drawing.Size(147, 42)
        Me.tbCode4.TabIndex = 12
        '
        'tbCode3
        '
        Me.tbCode3.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCode3.Location = New System.Drawing.Point(401, 134)
        Me.tbCode3.MaxLength = 1
        Me.tbCode3.Name = "tbCode3"
        Me.tbCode3.Size = New System.Drawing.Size(147, 42)
        Me.tbCode3.TabIndex = 11
        '
        'tbCode2
        '
        Me.tbCode2.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCode2.Location = New System.Drawing.Point(221, 134)
        Me.tbCode2.MaxLength = 1
        Me.tbCode2.Name = "tbCode2"
        Me.tbCode2.Size = New System.Drawing.Size(147, 42)
        Me.tbCode2.TabIndex = 10
        '
        'tbCode1
        '
        Me.tbCode1.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCode1.Location = New System.Drawing.Point(43, 134)
        Me.tbCode1.MaxLength = 1
        Me.tbCode1.Name = "tbCode1"
        Me.tbCode1.Size = New System.Drawing.Size(147, 42)
        Me.tbCode1.TabIndex = 9
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
        Me.pnlTries.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTries.Location = New System.Drawing.Point(221, 274)
        Me.pnlTries.Name = "pnlTries"
        Me.pnlTries.Size = New System.Drawing.Size(327, 489)
        Me.pnlTries.TabIndex = 17
        '
        'lblColors
        '
        Me.lblColors.AutoSize = True
        Me.lblColors.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColors.Location = New System.Drawing.Point(748, 252)
        Me.lblColors.Name = "lblColors"
        Me.lblColors.Size = New System.Drawing.Size(116, 40)
        Me.lblColors.TabIndex = 18
        Me.lblColors.Text = "lblColors"
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
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(930, 720)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(147, 43)
        Me.btnQuit.TabIndex = 23
        Me.btnQuit.Text = "Quitter"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'FormGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 775)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.lblFound)
        Me.Controls.Add(Me.lblSel)
        Me.Controls.Add(Me.lblChar)
        Me.Controls.Add(Me.lblColors)
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
    Friend WithEvents lblColors As Windows.Forms.Label
    Friend WithEvents lblSel As Windows.Forms.Label
    Friend WithEvents lblChar As Windows.Forms.Label
    Friend WithEvents btnGuess As Windows.Forms.Button
    Friend WithEvents lblFound As Windows.Forms.Label
    Friend WithEvents btnQuit As Windows.Forms.Button
End Class
