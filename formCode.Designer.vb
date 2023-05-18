<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCode
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tbCode1 = New System.Windows.Forms.TextBox()
        Me.tbCode2 = New System.Windows.Forms.TextBox()
        Me.tbCode3 = New System.Windows.Forms.TextBox()
        Me.tbCode4 = New System.Windows.Forms.TextBox()
        Me.tbCode5 = New System.Windows.Forms.TextBox()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.lblChar = New System.Windows.Forms.Label()
        Me.lblSel = New System.Windows.Forms.Label()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Poppins", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(425, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(282, 70)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Mastermind"
        '
        'tbCode1
        '
        Me.tbCode1.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCode1.Location = New System.Drawing.Point(43, 134)
        Me.tbCode1.MaxLength = 1
        Me.tbCode1.Name = "tbCode1"
        Me.tbCode1.Size = New System.Drawing.Size(147, 42)
        Me.tbCode1.TabIndex = 2
        Me.tbCode1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbCode2
        '
        Me.tbCode2.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCode2.Location = New System.Drawing.Point(221, 134)
        Me.tbCode2.MaxLength = 1
        Me.tbCode2.Name = "tbCode2"
        Me.tbCode2.Size = New System.Drawing.Size(147, 42)
        Me.tbCode2.TabIndex = 3
        Me.tbCode2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbCode3
        '
        Me.tbCode3.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCode3.Location = New System.Drawing.Point(401, 134)
        Me.tbCode3.MaxLength = 1
        Me.tbCode3.Name = "tbCode3"
        Me.tbCode3.Size = New System.Drawing.Size(147, 42)
        Me.tbCode3.TabIndex = 4
        Me.tbCode3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbCode4
        '
        Me.tbCode4.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCode4.Location = New System.Drawing.Point(577, 134)
        Me.tbCode4.MaxLength = 1
        Me.tbCode4.Name = "tbCode4"
        Me.tbCode4.Size = New System.Drawing.Size(147, 42)
        Me.tbCode4.TabIndex = 5
        Me.tbCode4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbCode5
        '
        Me.tbCode5.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCode5.Location = New System.Drawing.Point(755, 134)
        Me.tbCode5.MaxLength = 1
        Me.tbCode5.Name = "tbCode5"
        Me.tbCode5.Size = New System.Drawing.Size(147, 42)
        Me.tbCode5.TabIndex = 6
        Me.tbCode5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnHide
        '
        Me.btnHide.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHide.Location = New System.Drawing.Point(930, 134)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(147, 42)
        Me.btnHide.TabIndex = 7
        Me.btnHide.Text = "btnHide"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'lblChar
        '
        Me.lblChar.AutoSize = True
        Me.lblChar.Font = New System.Drawing.Font("Poppins SemiBold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChar.Location = New System.Drawing.Point(748, 219)
        Me.lblChar.Name = "lblChar"
        Me.lblChar.Size = New System.Drawing.Size(265, 40)
        Me.lblChar.TabIndex = 8
        Me.lblChar.Text = "Caractères jouables :"
        '
        'lblSel
        '
        Me.lblSel.AutoSize = True
        Me.lblSel.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSel.Location = New System.Drawing.Point(771, 259)
        Me.lblSel.Name = "lblSel"
        Me.lblSel.Size = New System.Drawing.Size(74, 40)
        Me.lblSel.TabIndex = 9
        Me.lblSel.Text = "lblSel"
        '
        'btnDone
        '
        Me.btnDone.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.Location = New System.Drawing.Point(43, 235)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(325, 42)
        Me.btnDone.TabIndex = 10
        Me.btnDone.Text = "Valider"
        Me.btnDone.UseVisualStyleBackColor = True
        Me.btnDone.Visible = False
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(43, 283)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(325, 42)
        Me.btnQuit.TabIndex = 11
        Me.btnQuit.Text = "Abandonner"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'FormCode
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1130, 337)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.lblSel)
        Me.Controls.Add(Me.lblChar)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.tbCode5)
        Me.Controls.Add(Me.tbCode4)
        Me.Controls.Add(Me.tbCode3)
        Me.Controls.Add(Me.tbCode2)
        Me.Controls.Add(Me.tbCode1)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormCode"
        Me.Text = "Saisie du code"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Windows.Forms.Label
    Friend WithEvents tbCode1 As Windows.Forms.TextBox
    Friend WithEvents tbCode2 As Windows.Forms.TextBox
    Friend WithEvents tbCode3 As Windows.Forms.TextBox
    Friend WithEvents tbCode4 As Windows.Forms.TextBox
    Friend WithEvents tbCode5 As Windows.Forms.TextBox
    Friend WithEvents btnHide As Windows.Forms.Button
    Friend WithEvents lblChar As Windows.Forms.Label
    Friend WithEvents lblSel As Windows.Forms.Label
    Friend WithEvents btnDone As Windows.Forms.Button
    Friend WithEvents btnQuit As Windows.Forms.Button
End Class
