<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblP1 = New System.Windows.Forms.Label()
        Me.cboP1 = New System.Windows.Forms.ComboBox()
        Me.cboP2 = New System.Windows.Forms.ComboBox()
        Me.lblP2 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnScores = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
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
        Me.cboP1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboP1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboP1.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboP1.FormattingEnabled = True
        Me.cboP1.Location = New System.Drawing.Point(79, 231)
        Me.cboP1.Name = "cboP1"
        Me.cboP1.Size = New System.Drawing.Size(356, 48)
        Me.cboP1.Sorted = True
        Me.cboP1.TabIndex = 3
        '
        'cboP2
        '
        Me.cboP2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboP2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboP2.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboP2.FormattingEnabled = True
        Me.cboP2.Location = New System.Drawing.Point(680, 231)
        Me.cboP2.Name = "cboP2"
        Me.cboP2.Size = New System.Drawing.Size(356, 48)
        Me.cboP2.Sorted = True
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
        Me.btnStart.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnStart.FlatAppearance.BorderSize = 0
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStart.Location = New System.Drawing.Point(79, 412)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(457, 58)
        Me.btnStart.TabIndex = 6
        Me.btnStart.TabStop = False
        Me.btnStart.Text = "Jouer !"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnScores
        '
        Me.btnScores.AutoSize = True
        Me.btnScores.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnScores.FlatAppearance.BorderSize = 0
        Me.btnScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScores.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScores.Location = New System.Drawing.Point(579, 412)
        Me.btnScores.Name = "btnScores"
        Me.btnScores.Size = New System.Drawing.Size(457, 58)
        Me.btnScores.TabIndex = 7
        Me.btnScores.TabStop = False
        Me.btnScores.Text = "Scores"
        Me.btnScores.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnQuit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnQuit.FlatAppearance.BorderSize = 0
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnQuit.Location = New System.Drawing.Point(79, 490)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(957, 58)
        Me.btnQuit.TabIndex = 8
        Me.btnQuit.TabStop = False
        Me.btnQuit.Text = "Quitter"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackgroundImage = Global.SAé_Mastermind.My.Resources.Resources.cog
        Me.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.Location = New System.Drawing.Point(1038, 12)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(70, 70)
        Me.btnSettings.TabIndex = 9
        Me.btnSettings.TabStop = False
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1130, 587)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnScores)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.cboP2)
        Me.Controls.Add(Me.lblP2)
        Me.Controls.Add(Me.cboP1)
        Me.Controls.Add(Me.lblP1)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents btnScores As Windows.Forms.Button
    Friend WithEvents btnQuit As Windows.Forms.Button
    Friend WithEvents btnSettings As Windows.Forms.Button
End Class
