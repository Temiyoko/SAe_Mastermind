﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormScore
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
        Me.lstName = New System.Windows.Forms.ListBox()
        Me.lstScore = New System.Windows.Forms.ListBox()
        Me.lstBestTime = New System.Windows.Forms.ListBox()
        Me.lstNbGames = New System.Windows.Forms.ListBox()
        Me.lstTotalTime = New System.Windows.Forms.ListBox()
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
        'lstName
        '
        Me.lstName.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstName.FormattingEnabled = True
        Me.lstName.ItemHeight = 40
        Me.lstName.Location = New System.Drawing.Point(12, 179)
        Me.lstName.Name = "lstName"
        Me.lstName.Size = New System.Drawing.Size(198, 44)
        Me.lstName.TabIndex = 2
        '
        'lstScore
        '
        Me.lstScore.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstScore.FormattingEnabled = True
        Me.lstScore.ItemHeight = 40
        Me.lstScore.Location = New System.Drawing.Point(238, 179)
        Me.lstScore.Name = "lstScore"
        Me.lstScore.Size = New System.Drawing.Size(198, 44)
        Me.lstScore.TabIndex = 3
        '
        'lstBestTime
        '
        Me.lstBestTime.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBestTime.FormattingEnabled = True
        Me.lstBestTime.ItemHeight = 40
        Me.lstBestTime.Location = New System.Drawing.Point(467, 179)
        Me.lstBestTime.Name = "lstBestTime"
        Me.lstBestTime.Size = New System.Drawing.Size(198, 44)
        Me.lstBestTime.TabIndex = 4
        '
        'lstNbGames
        '
        Me.lstNbGames.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstNbGames.FormattingEnabled = True
        Me.lstNbGames.ItemHeight = 40
        Me.lstNbGames.Location = New System.Drawing.Point(705, 179)
        Me.lstNbGames.Name = "lstNbGames"
        Me.lstNbGames.Size = New System.Drawing.Size(198, 44)
        Me.lstNbGames.TabIndex = 5
        '
        'lstTotalTime
        '
        Me.lstTotalTime.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTotalTime.FormattingEnabled = True
        Me.lstTotalTime.ItemHeight = 40
        Me.lstTotalTime.Location = New System.Drawing.Point(929, 179)
        Me.lstTotalTime.Name = "lstTotalTime"
        Me.lstTotalTime.Size = New System.Drawing.Size(198, 44)
        Me.lstTotalTime.TabIndex = 6
        '
        'FormScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 587)
        Me.Controls.Add(Me.lstTotalTime)
        Me.Controls.Add(Me.lstNbGames)
        Me.Controls.Add(Me.lstBestTime)
        Me.Controls.Add(Me.lstScore)
        Me.Controls.Add(Me.lstName)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormScore"
        Me.Text = "FormScore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Windows.Forms.Label
    Friend WithEvents lstName As Windows.Forms.ListBox
    Friend WithEvents lstScore As Windows.Forms.ListBox
    Friend WithEvents lstBestTime As Windows.Forms.ListBox
    Friend WithEvents lstNbGames As Windows.Forms.ListBox
    Friend WithEvents lstTotalTime As Windows.Forms.ListBox
End Class
