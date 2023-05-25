<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormScores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormScores))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lstName = New System.Windows.Forms.ListBox()
        Me.lstScore = New System.Windows.Forms.ListBox()
        Me.lstBestTime = New System.Windows.Forms.ListBox()
        Me.lstP1 = New System.Windows.Forms.ListBox()
        Me.lstTotalTime = New System.Windows.Forms.ListBox()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblBestTime = New System.Windows.Forms.Label()
        Me.lblNbGames = New System.Windows.Forms.Label()
        Me.lblTotalTime = New System.Windows.Forms.Label()
        Me.lblP1 = New System.Windows.Forms.Label()
        Me.lstP2 = New System.Windows.Forms.ListBox()
        Me.lblP2 = New System.Windows.Forms.Label()
        Me.pnlList = New System.Windows.Forms.Panel()
        Me.cboSearch = New System.Windows.Forms.ComboBox()
        Me.btnName = New System.Windows.Forms.Button()
        Me.btnBestScore = New System.Windows.Forms.Button()
        Me.btnBestTime = New System.Windows.Forms.Button()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.pnlList.SuspendLayout()
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
        Me.lstName.Location = New System.Drawing.Point(0, 13)
        Me.lstName.Name = "lstName"
        Me.lstName.Size = New System.Drawing.Size(162, 44)
        Me.lstName.TabIndex = 2
        Me.lstName.TabStop = False
        Me.lstName.UseTabStops = False
        '
        'lstScore
        '
        Me.lstScore.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstScore.FormattingEnabled = True
        Me.lstScore.ItemHeight = 40
        Me.lstScore.Location = New System.Drawing.Point(183, 13)
        Me.lstScore.Name = "lstScore"
        Me.lstScore.Size = New System.Drawing.Size(162, 44)
        Me.lstScore.TabIndex = 3
        Me.lstScore.TabStop = False
        Me.lstScore.UseTabStops = False
        '
        'lstBestTime
        '
        Me.lstBestTime.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBestTime.FormattingEnabled = True
        Me.lstBestTime.ItemHeight = 40
        Me.lstBestTime.Location = New System.Drawing.Point(373, 13)
        Me.lstBestTime.Name = "lstBestTime"
        Me.lstBestTime.Size = New System.Drawing.Size(162, 44)
        Me.lstBestTime.TabIndex = 4
        Me.lstBestTime.TabStop = False
        Me.lstBestTime.UseTabStops = False
        '
        'lstP1
        '
        Me.lstP1.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstP1.FormattingEnabled = True
        Me.lstP1.ItemHeight = 40
        Me.lstP1.Location = New System.Drawing.Point(563, 13)
        Me.lstP1.Name = "lstP1"
        Me.lstP1.Size = New System.Drawing.Size(162, 44)
        Me.lstP1.TabIndex = 5
        Me.lstP1.TabStop = False
        Me.lstP1.UseTabStops = False
        '
        'lstTotalTime
        '
        Me.lstTotalTime.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTotalTime.FormattingEnabled = True
        Me.lstTotalTime.ItemHeight = 40
        Me.lstTotalTime.Location = New System.Drawing.Point(944, 13)
        Me.lstTotalTime.Name = "lstTotalTime"
        Me.lstTotalTime.Size = New System.Drawing.Size(162, 44)
        Me.lstTotalTime.TabIndex = 6
        Me.lstTotalTime.TabStop = False
        Me.lstTotalTime.UseTabStops = False
        '
        'btnRetour
        '
        Me.btnRetour.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnRetour.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRetour.FlatAppearance.BorderSize = 0
        Me.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetour.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetour.Location = New System.Drawing.Point(956, 436)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(162, 52)
        Me.btnRetour.TabIndex = 7
        Me.btnRetour.TabStop = False
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(44, 136)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(72, 40)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Nom"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(236, 136)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(82, 40)
        Me.lblScore.TabIndex = 9
        Me.lblScore.Text = "Score"
        '
        'lblBestTime
        '
        Me.lblBestTime.AutoSize = True
        Me.lblBestTime.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBestTime.Location = New System.Drawing.Point(356, 136)
        Me.lblBestTime.Name = "lblBestTime"
        Me.lblBestTime.Size = New System.Drawing.Size(220, 40)
        Me.lblBestTime.TabIndex = 10
        Me.lblBestTime.Text = "Meilleur temps (s)"
        Me.lblBestTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNbGames
        '
        Me.lblNbGames.AutoSize = True
        Me.lblNbGames.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNbGames.Location = New System.Drawing.Point(598, 96)
        Me.lblNbGames.Name = "lblNbGames"
        Me.lblNbGames.Size = New System.Drawing.Size(312, 40)
        Me.lblNbGames.TabIndex = 11
        Me.lblNbGames.Text = "Nombre de parties jouées"
        '
        'lblTotalTime
        '
        Me.lblTotalTime.AutoSize = True
        Me.lblTotalTime.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTime.Location = New System.Drawing.Point(932, 136)
        Me.lblTotalTime.Name = "lblTotalTime"
        Me.lblTotalTime.Size = New System.Drawing.Size(186, 40)
        Me.lblTotalTime.TabIndex = 12
        Me.lblTotalTime.Text = "Temps joué (s)"
        '
        'lblP1
        '
        Me.lblP1.AutoSize = True
        Me.lblP1.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1.Location = New System.Drawing.Point(598, 136)
        Me.lblP1.Name = "lblP1"
        Me.lblP1.Size = New System.Drawing.Size(109, 40)
        Me.lblP1.TabIndex = 13
        Me.lblP1.Text = "Joueur 1"
        '
        'lstP2
        '
        Me.lstP2.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstP2.FormattingEnabled = True
        Me.lstP2.ItemHeight = 40
        Me.lstP2.Location = New System.Drawing.Point(755, 13)
        Me.lstP2.Name = "lstP2"
        Me.lstP2.Size = New System.Drawing.Size(162, 44)
        Me.lstP2.TabIndex = 14
        Me.lstP2.TabStop = False
        Me.lstP2.UseTabStops = False
        '
        'lblP2
        '
        Me.lblP2.AutoSize = True
        Me.lblP2.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2.Location = New System.Drawing.Point(789, 136)
        Me.lblP2.Name = "lblP2"
        Me.lblP2.Size = New System.Drawing.Size(115, 40)
        Me.lblP2.TabIndex = 15
        Me.lblP2.Text = "Joueur 2"
        '
        'pnlList
        '
        Me.pnlList.Controls.Add(Me.lstP2)
        Me.pnlList.Controls.Add(Me.lstName)
        Me.pnlList.Controls.Add(Me.lstScore)
        Me.pnlList.Controls.Add(Me.lstBestTime)
        Me.pnlList.Controls.Add(Me.lstP1)
        Me.pnlList.Controls.Add(Me.lstTotalTime)
        Me.pnlList.Location = New System.Drawing.Point(12, 179)
        Me.pnlList.Name = "pnlList"
        Me.pnlList.Size = New System.Drawing.Size(1106, 71)
        Me.pnlList.TabIndex = 16
        '
        'cboSearch
        '
        Me.cboSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSearch.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearch.FormattingEnabled = True
        Me.cboSearch.Location = New System.Drawing.Point(13, 440)
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Size = New System.Drawing.Size(498, 48)
        Me.cboSearch.TabIndex = 17
        '
        'btnName
        '
        Me.btnName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnName.FlatAppearance.BorderSize = 0
        Me.btnName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnName.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnName.Location = New System.Drawing.Point(13, 386)
        Me.btnName.Name = "btnName"
        Me.btnName.Size = New System.Drawing.Size(162, 48)
        Me.btnName.TabIndex = 18
        Me.btnName.TabStop = False
        Me.btnName.Text = "A-Z"
        Me.btnName.UseVisualStyleBackColor = False
        '
        'btnBestScore
        '
        Me.btnBestScore.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBestScore.FlatAppearance.BorderSize = 0
        Me.btnBestScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBestScore.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBestScore.Location = New System.Drawing.Point(181, 386)
        Me.btnBestScore.Name = "btnBestScore"
        Me.btnBestScore.Size = New System.Drawing.Size(162, 48)
        Me.btnBestScore.TabIndex = 19
        Me.btnBestScore.TabStop = False
        Me.btnBestScore.Text = "Score"
        Me.btnBestScore.UseVisualStyleBackColor = False
        '
        'btnBestTime
        '
        Me.btnBestTime.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBestTime.FlatAppearance.BorderSize = 0
        Me.btnBestTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBestTime.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBestTime.Location = New System.Drawing.Point(349, 386)
        Me.btnBestTime.Name = "btnBestTime"
        Me.btnBestTime.Size = New System.Drawing.Size(162, 48)
        Me.btnBestTime.TabIndex = 20
        Me.btnBestTime.TabStop = False
        Me.btnBestTime.Text = "Temps"
        Me.btnBestTime.UseVisualStyleBackColor = False
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Font = New System.Drawing.Font("Poppins SemiBold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilter.Location = New System.Drawing.Point(220, 343)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(86, 40)
        Me.lblFilter.TabIndex = 21
        Me.lblFilter.Text = "Filtres"
        '
        'FormScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1130, 587)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.btnBestTime)
        Me.Controls.Add(Me.btnBestScore)
        Me.Controls.Add(Me.btnName)
        Me.Controls.Add(Me.cboSearch)
        Me.Controls.Add(Me.pnlList)
        Me.Controls.Add(Me.lblP2)
        Me.Controls.Add(Me.lblP1)
        Me.Controls.Add(Me.lblTotalTime)
        Me.Controls.Add(Me.lblNbGames)
        Me.Controls.Add(Me.lblBestTime)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormScores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scores"
        Me.pnlList.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Windows.Forms.Label
    Friend WithEvents lstName As Windows.Forms.ListBox
    Friend WithEvents lstScore As Windows.Forms.ListBox
    Friend WithEvents lstBestTime As Windows.Forms.ListBox
    Friend WithEvents lstP1 As Windows.Forms.ListBox
    Friend WithEvents lstTotalTime As Windows.Forms.ListBox
    Friend WithEvents btnRetour As Windows.Forms.Button
    Friend WithEvents lblName As Windows.Forms.Label
    Friend WithEvents lblScore As Windows.Forms.Label
    Friend WithEvents lblBestTime As Windows.Forms.Label
    Friend WithEvents lblNbGames As Windows.Forms.Label
    Friend WithEvents lblTotalTime As Windows.Forms.Label
    Friend WithEvents lblP1 As Windows.Forms.Label
    Friend WithEvents lstP2 As Windows.Forms.ListBox
    Friend WithEvents lblP2 As Windows.Forms.Label
    Friend WithEvents pnlList As Windows.Forms.Panel
    Friend WithEvents cboSearch As Windows.Forms.ComboBox
    Friend WithEvents btnName As Windows.Forms.Button
    Friend WithEvents btnBestScore As Windows.Forms.Button
    Friend WithEvents btnBestTime As Windows.Forms.Button
    Friend WithEvents lblFilter As Windows.Forms.Label
End Class
