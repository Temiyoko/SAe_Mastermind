﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSettings
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlColors = New System.Windows.Forms.Panel()
        Me.tbMissing = New System.Windows.Forms.TextBox()
        Me.tbWrong = New System.Windows.Forms.TextBox()
        Me.tbRight = New System.Windows.Forms.TextBox()
        Me.lblMissing = New System.Windows.Forms.Label()
        Me.lblWrong = New System.Windows.Forms.Label()
        Me.lblRight = New System.Windows.Forms.Label()
        Me.lblColorCode = New System.Windows.Forms.Label()
        Me.cdLabels = New System.Windows.Forms.ColorDialog()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.pnlColors.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Poppins", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(425, 9)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(282, 70)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Mastermind"
        '
        'pnlColors
        '
        Me.pnlColors.Controls.Add(Me.tbMissing)
        Me.pnlColors.Controls.Add(Me.tbWrong)
        Me.pnlColors.Controls.Add(Me.tbRight)
        Me.pnlColors.Controls.Add(Me.lblMissing)
        Me.pnlColors.Controls.Add(Me.lblWrong)
        Me.pnlColors.Controls.Add(Me.lblRight)
        Me.pnlColors.Controls.Add(Me.lblColorCode)
        Me.pnlColors.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlColors.Location = New System.Drawing.Point(11, 309)
        Me.pnlColors.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.pnlColors.Name = "pnlColors"
        Me.pnlColors.Size = New System.Drawing.Size(434, 259)
        Me.pnlColors.TabIndex = 9
        '
        'tbMissing
        '
        Me.tbMissing.Location = New System.Drawing.Point(212, 69)
        Me.tbMissing.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tbMissing.Name = "tbMissing"
        Me.tbMissing.ReadOnly = True
        Me.tbMissing.Size = New System.Drawing.Size(184, 42)
        Me.tbMissing.TabIndex = 15
        '
        'tbWrong
        '
        Me.tbWrong.Location = New System.Drawing.Point(212, 140)
        Me.tbWrong.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tbWrong.Name = "tbWrong"
        Me.tbWrong.ReadOnly = True
        Me.tbWrong.Size = New System.Drawing.Size(184, 42)
        Me.tbWrong.TabIndex = 14
        '
        'tbRight
        '
        Me.tbRight.Location = New System.Drawing.Point(212, 202)
        Me.tbRight.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tbRight.Name = "tbRight"
        Me.tbRight.ReadOnly = True
        Me.tbRight.Size = New System.Drawing.Size(184, 42)
        Me.tbRight.TabIndex = 10
        '
        'lblMissing
        '
        Me.lblMissing.AutoSize = True
        Me.lblMissing.Location = New System.Drawing.Point(18, 205)
        Me.lblMissing.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMissing.Name = "lblMissing"
        Me.lblMissing.Size = New System.Drawing.Size(107, 40)
        Me.lblMissing.TabIndex = 13
        Me.lblMissing.Text = "Absent :"
        '
        'lblWrong
        '
        Me.lblWrong.AutoSize = True
        Me.lblWrong.Location = New System.Drawing.Point(18, 143)
        Me.lblWrong.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWrong.Name = "lblWrong"
        Me.lblWrong.Size = New System.Drawing.Size(136, 40)
        Me.lblWrong.TabIndex = 12
        Me.lblWrong.Text = "Mal placé :"
        '
        'lblRight
        '
        Me.lblRight.AutoSize = True
        Me.lblRight.Location = New System.Drawing.Point(18, 72)
        Me.lblRight.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(144, 40)
        Me.lblRight.TabIndex = 11
        Me.lblRight.Text = "Bien placé :"
        '
        'lblColorCode
        '
        Me.lblColorCode.AutoSize = True
        Me.lblColorCode.Location = New System.Drawing.Point(8, 4)
        Me.lblColorCode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblColorCode.Name = "lblColorCode"
        Me.lblColorCode.Size = New System.Drawing.Size(182, 40)
        Me.lblColorCode.TabIndex = 10
        Me.lblColorCode.Text = "Code couleur :"
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(777, 526)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(325, 42)
        Me.btnQuit.TabIndex = 11
        Me.btnQuit.Text = "Abandonner"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.Location = New System.Drawing.Point(777, 470)
        Me.btnDone.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(325, 42)
        Me.btnDone.TabIndex = 10
        Me.btnDone.Text = "Valider"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'FormSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1130, 587)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.pnlColors)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormSettings"
        Me.Text = "Paramètres"
        Me.pnlColors.ResumeLayout(False)
        Me.pnlColors.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Windows.Forms.Label
    Friend WithEvents pnlColors As Windows.Forms.Panel
    Friend WithEvents lblMissing As Windows.Forms.Label
    Friend WithEvents lblWrong As Windows.Forms.Label
    Friend WithEvents lblRight As Windows.Forms.Label
    Friend WithEvents lblColorCode As Windows.Forms.Label
    Friend WithEvents tbRight As Windows.Forms.TextBox
    Friend WithEvents cdLabels As Windows.Forms.ColorDialog
    Friend WithEvents tbMissing As Windows.Forms.TextBox
    Friend WithEvents tbWrong As Windows.Forms.TextBox
    Friend WithEvents btnQuit As Windows.Forms.Button
    Friend WithEvents btnDone As Windows.Forms.Button
End Class
