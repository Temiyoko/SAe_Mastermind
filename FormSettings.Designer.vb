<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSettings))
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
        Me.lblTries = New System.Windows.Forms.Label()
        Me.tbTries = New System.Windows.Forms.TextBox()
        Me.cbDarkMode = New System.Windows.Forms.CheckBox()
        Me.lblChrono = New System.Windows.Forms.Label()
        Me.cbDisable = New System.Windows.Forms.CheckBox()
        Me.sbChrono = New System.Windows.Forms.HScrollBar()
        Me.lblDebut = New System.Windows.Forms.Label()
        Me.lblFin = New System.Windows.Forms.Label()
        Me.lblActualTime = New System.Windows.Forms.Label()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.cbMusic = New System.Windows.Forms.CheckBox()
        Me.pbMusic = New System.Windows.Forms.PictureBox()
        Me.pbDark = New System.Windows.Forms.PictureBox()
        Me.pbMaster = New System.Windows.Forms.PictureBox()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.pnlColors.SuspendLayout()
        CType(Me.pbMusic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlColors
        '
        Me.pnlColors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlColors.Controls.Add(Me.tbMissing)
        Me.pnlColors.Controls.Add(Me.tbWrong)
        Me.pnlColors.Controls.Add(Me.tbRight)
        Me.pnlColors.Controls.Add(Me.lblMissing)
        Me.pnlColors.Controls.Add(Me.lblWrong)
        Me.pnlColors.Controls.Add(Me.lblRight)
        Me.pnlColors.Controls.Add(Me.lblColorCode)
        Me.pnlColors.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlColors.Location = New System.Drawing.Point(57, 309)
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
        Me.tbMissing.TabStop = False
        '
        'tbWrong
        '
        Me.tbWrong.Location = New System.Drawing.Point(212, 133)
        Me.tbWrong.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tbWrong.Name = "tbWrong"
        Me.tbWrong.ReadOnly = True
        Me.tbWrong.Size = New System.Drawing.Size(184, 42)
        Me.tbWrong.TabIndex = 14
        Me.tbWrong.TabStop = False
        '
        'tbRight
        '
        Me.tbRight.Location = New System.Drawing.Point(212, 197)
        Me.tbRight.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tbRight.Name = "tbRight"
        Me.tbRight.ReadOnly = True
        Me.tbRight.Size = New System.Drawing.Size(184, 42)
        Me.tbRight.TabIndex = 10
        Me.tbRight.TabStop = False
        '
        'lblMissing
        '
        Me.lblMissing.AutoSize = True
        Me.lblMissing.Location = New System.Drawing.Point(18, 200)
        Me.lblMissing.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMissing.Name = "lblMissing"
        Me.lblMissing.Size = New System.Drawing.Size(107, 40)
        Me.lblMissing.TabIndex = 13
        Me.lblMissing.Text = "Absent :"
        '
        'lblWrong
        '
        Me.lblWrong.AutoSize = True
        Me.lblWrong.Location = New System.Drawing.Point(18, 136)
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
        Me.btnQuit.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnQuit.FlatAppearance.BorderSize = 0
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(619, 526)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(483, 42)
        Me.btnQuit.TabIndex = 11
        Me.btnQuit.TabStop = False
        Me.btnQuit.Text = "Abandonner"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnDone.FlatAppearance.BorderSize = 0
        Me.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDone.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.Location = New System.Drawing.Point(619, 470)
        Me.btnDone.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(483, 42)
        Me.btnDone.TabIndex = 10
        Me.btnDone.TabStop = False
        Me.btnDone.Text = "Valider"
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'lblTries
        '
        Me.lblTries.AutoSize = True
        Me.lblTries.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTries.Location = New System.Drawing.Point(45, 145)
        Me.lblTries.Name = "lblTries"
        Me.lblTries.Size = New System.Drawing.Size(344, 40)
        Me.lblTries.TabIndex = 12
        Me.lblTries.Text = "Nombre de coups autorisés :"
        '
        'tbTries
        '
        Me.tbTries.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTries.Location = New System.Drawing.Point(52, 200)
        Me.tbTries.MaxLength = 2
        Me.tbTries.Name = "tbTries"
        Me.tbTries.Size = New System.Drawing.Size(345, 42)
        Me.tbTries.TabIndex = 1
        Me.tbTries.TabStop = False
        Me.tbTries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbDarkMode
        '
        Me.cbDarkMode.AutoSize = True
        Me.cbDarkMode.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDarkMode.Location = New System.Drawing.Point(619, 395)
        Me.cbDarkMode.Name = "cbDarkMode"
        Me.cbDarkMode.Size = New System.Drawing.Size(18, 17)
        Me.cbDarkMode.TabIndex = 13
        Me.cbDarkMode.TabStop = False
        Me.cbDarkMode.UseVisualStyleBackColor = True
        '
        'lblChrono
        '
        Me.lblChrono.AutoSize = True
        Me.lblChrono.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChrono.Location = New System.Drawing.Point(606, 141)
        Me.lblChrono.Name = "lblChrono"
        Me.lblChrono.Size = New System.Drawing.Size(184, 40)
        Me.lblChrono.TabIndex = 15
        Me.lblChrono.Text = "Chronomètre :"
        '
        'cbDisable
        '
        Me.cbDisable.AutoSize = True
        Me.cbDisable.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDisable.Location = New System.Drawing.Point(942, 141)
        Me.cbDisable.Name = "cbDisable"
        Me.cbDisable.Size = New System.Drawing.Size(160, 44)
        Me.cbDisable.TabIndex = 16
        Me.cbDisable.TabStop = False
        Me.cbDisable.Text = "Désactiver"
        Me.cbDisable.UseVisualStyleBackColor = True
        '
        'sbChrono
        '
        Me.sbChrono.LargeChange = 60
        Me.sbChrono.Location = New System.Drawing.Point(619, 200)
        Me.sbChrono.Maximum = 359
        Me.sbChrono.Minimum = 10
        Me.sbChrono.Name = "sbChrono"
        Me.sbChrono.Size = New System.Drawing.Size(483, 37)
        Me.sbChrono.SmallChange = 5
        Me.sbChrono.TabIndex = 17
        Me.sbChrono.Value = 10
        '
        'lblDebut
        '
        Me.lblDebut.AutoSize = True
        Me.lblDebut.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebut.Location = New System.Drawing.Point(612, 246)
        Me.lblDebut.Name = "lblDebut"
        Me.lblDebut.Size = New System.Drawing.Size(70, 40)
        Me.lblDebut.TabIndex = 18
        Me.lblDebut.Text = "00:10"
        '
        'lblFin
        '
        Me.lblFin.AutoSize = True
        Me.lblFin.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFin.Location = New System.Drawing.Point(1026, 256)
        Me.lblFin.Name = "lblFin"
        Me.lblFin.Size = New System.Drawing.Size(77, 40)
        Me.lblFin.TabIndex = 19
        Me.lblFin.Text = "05:00"
        '
        'lblActualTime
        '
        Me.lblActualTime.AutoSize = True
        Me.lblActualTime.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualTime.Location = New System.Drawing.Point(606, 309)
        Me.lblActualTime.Name = "lblActualTime"
        Me.lblActualTime.Size = New System.Drawing.Size(182, 40)
        Me.lblActualTime.TabIndex = 20
        Me.lblActualTime.Text = "Temps actuel :"
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelected.Location = New System.Drawing.Point(794, 309)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(122, 36)
        Me.lblSelected.TabIndex = 21
        Me.lblSelected.Text = "lblSelected"
        '
        'cbMusic
        '
        Me.cbMusic.AutoSize = True
        Me.cbMusic.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMusic.Location = New System.Drawing.Point(942, 395)
        Me.cbMusic.Name = "cbMusic"
        Me.cbMusic.Size = New System.Drawing.Size(18, 17)
        Me.cbMusic.TabIndex = 31
        Me.cbMusic.TabStop = False
        Me.cbMusic.UseVisualStyleBackColor = True
        '
        'pbMusic
        '
        Me.pbMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbMusic.Location = New System.Drawing.Point(988, 366)
        Me.pbMusic.Name = "pbMusic"
        Me.pbMusic.Size = New System.Drawing.Size(70, 70)
        Me.pbMusic.TabIndex = 33
        Me.pbMusic.TabStop = False
        '
        'pbDark
        '
        Me.pbDark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbDark.Location = New System.Drawing.Point(664, 366)
        Me.pbDark.Name = "pbDark"
        Me.pbDark.Size = New System.Drawing.Size(70, 70)
        Me.pbDark.TabIndex = 32
        Me.pbDark.TabStop = False
        '
        'pbMaster
        '
        Me.pbMaster.BackgroundImage = CType(resources.GetObject("pbMaster.BackgroundImage"), System.Drawing.Image)
        Me.pbMaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbMaster.Location = New System.Drawing.Point(79, -108)
        Me.pbMaster.Name = "pbMaster"
        Me.pbMaster.Size = New System.Drawing.Size(957, 336)
        Me.pbMaster.TabIndex = 30
        Me.pbMaster.TabStop = False
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.Transparent
        Me.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInfo.FlatAppearance.BorderSize = 0
        Me.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfo.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfo.Location = New System.Drawing.Point(1043, 12)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(60, 60)
        Me.btnInfo.TabIndex = 34
        Me.btnInfo.TabStop = False
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'FormSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1130, 587)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.pbMusic)
        Me.Controls.Add(Me.pbDark)
        Me.Controls.Add(Me.cbMusic)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.lblActualTime)
        Me.Controls.Add(Me.lblFin)
        Me.Controls.Add(Me.lblDebut)
        Me.Controls.Add(Me.sbChrono)
        Me.Controls.Add(Me.cbDisable)
        Me.Controls.Add(Me.lblChrono)
        Me.Controls.Add(Me.cbDarkMode)
        Me.Controls.Add(Me.tbTries)
        Me.Controls.Add(Me.lblTries)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.pnlColors)
        Me.Controls.Add(Me.pbMaster)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paramètres"
        Me.pnlColors.ResumeLayout(False)
        Me.pnlColors.PerformLayout()
        CType(Me.pbMusic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents lblTries As Windows.Forms.Label
    Friend WithEvents tbTries As Windows.Forms.TextBox
    Friend WithEvents cbDarkMode As Windows.Forms.CheckBox
    Friend WithEvents lblChrono As Windows.Forms.Label
    Friend WithEvents cbDisable As Windows.Forms.CheckBox
    Friend WithEvents sbChrono As Windows.Forms.HScrollBar
    Friend WithEvents lblDebut As Windows.Forms.Label
    Friend WithEvents lblFin As Windows.Forms.Label
    Friend WithEvents lblActualTime As Windows.Forms.Label
    Friend WithEvents lblSelected As Windows.Forms.Label
    Friend WithEvents pbMaster As Windows.Forms.PictureBox
    Friend WithEvents btnMusic As Windows.Forms.Button
    Friend WithEvents cbMusic As Windows.Forms.CheckBox
    Friend WithEvents pbDark As Windows.Forms.PictureBox
    Friend WithEvents pbMusic As Windows.Forms.PictureBox
    Friend WithEvents btnInfo As Windows.Forms.Button
End Class
