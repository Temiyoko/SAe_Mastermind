﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.components = New System.ComponentModel.Container()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblP1 = New System.Windows.Forms.Label()
        Me.cboP1 = New System.Windows.Forms.ComboBox()
        Me.cboP2 = New System.Windows.Forms.ComboBox()
        Me.lblP2 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnScore = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Poppins", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(425, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(282, 70)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Mastermind"
        '
        'lblP1
        '
        Me.lblP1.AutoSize = True
        Me.lblP1.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1.Location = New System.Drawing.Point(101, 188)
        Me.lblP1.Name = "lblP1"
        Me.lblP1.Size = New System.Drawing.Size(313, 40)
        Me.lblP1.TabIndex = 1
        Me.lblP1.Text = "Entrez le nom du joueur 1 !"
        '
        'cboP1
        '
        Me.cboP1.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboP1.FormattingEnabled = True
        Me.cboP1.Location = New System.Drawing.Point(79, 231)
        Me.cboP1.Name = "cboP1"
        Me.cboP1.Size = New System.Drawing.Size(356, 48)
        Me.cboP1.TabIndex = 3
        '
        'cboP2
        '
        Me.cboP2.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboP2.FormattingEnabled = True
        Me.cboP2.Location = New System.Drawing.Point(680, 231)
        Me.cboP2.Name = "cboP2"
        Me.cboP2.Size = New System.Drawing.Size(356, 48)
        Me.cboP2.TabIndex = 5
        '
        'lblP2
        '
        Me.lblP2.AutoSize = True
        Me.lblP2.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2.Location = New System.Drawing.Point(702, 188)
        Me.lblP2.Name = "lblP2"
        Me.lblP2.Size = New System.Drawing.Size(319, 40)
        Me.lblP2.TabIndex = 4
        Me.lblP2.Text = "Entrez le nom du joueur 2 !"
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(79, 412)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(457, 58)
        Me.btnStart.TabIndex = 6
        Me.btnStart.Text = "Jouer !"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnScore
        '
        Me.btnScore.AutoSize = True
        Me.btnScore.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScore.Location = New System.Drawing.Point(579, 412)
        Me.btnScore.Name = "btnScore"
        Me.btnScore.Size = New System.Drawing.Size(457, 58)
        Me.btnScore.TabIndex = 7
        Me.btnScore.Text = "Score"
        Me.btnScore.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(79, 490)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(957, 58)
        Me.btnQuit.TabIndex = 8
        Me.btnQuit.Text = "Quitter"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'formMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 587)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnScore)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.cboP2)
        Me.Controls.Add(Me.lblP2)
        Me.Controls.Add(Me.cboP1)
        Me.Controls.Add(Me.lblP1)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "formMenu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Windows.Forms.Label
    Friend WithEvents lblP1 As Windows.Forms.Label
    Friend WithEvents cboP1 As Windows.Forms.ComboBox
    Friend WithEvents cboP2 As Windows.Forms.ComboBox
    Friend WithEvents lblP2 As Windows.Forms.Label
    Friend WithEvents btnStart As Windows.Forms.Button
    Friend WithEvents btnScore As Windows.Forms.Button
    Friend WithEvents btnQuit As Windows.Forms.Button
    Friend WithEvents Timer1 As Windows.Forms.Timer
End Class
