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
        Me.pnlTry1 = New System.Windows.Forms.Panel()
        Me.lblTry5 = New System.Windows.Forms.Label()
        Me.lblTry4 = New System.Windows.Forms.Label()
        Me.lblTry3 = New System.Windows.Forms.Label()
        Me.lblTry2 = New System.Windows.Forms.Label()
        Me.lblTry1 = New System.Windows.Forms.Label()
        Me.pnlTries = New System.Windows.Forms.Panel()
        Me.pnlTry11 = New System.Windows.Forms.Panel()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.pnlTry15 = New System.Windows.Forms.Panel()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.pnlTry10 = New System.Windows.Forms.Panel()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.pnlTry14 = New System.Windows.Forms.Panel()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.pnlTry13 = New System.Windows.Forms.Panel()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.pnlTry12 = New System.Windows.Forms.Panel()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.pnlTry2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlTextBox = New System.Windows.Forms.Panel()
        Me.tbCode5 = New System.Windows.Forms.TextBox()
        Me.tbCode1 = New System.Windows.Forms.TextBox()
        Me.tbCode2 = New System.Windows.Forms.TextBox()
        Me.tbCode3 = New System.Windows.Forms.TextBox()
        Me.tbCode4 = New System.Windows.Forms.TextBox()
        Me.pnlTry1.SuspendLayout()
        Me.pnlTries.SuspendLayout()
        Me.pnlTry11.SuspendLayout()
        Me.pnlTry15.SuspendLayout()
        Me.pnlTry10.SuspendLayout()
        Me.pnlTry14.SuspendLayout()
        Me.pnlTry13.SuspendLayout()
        Me.pnlTry12.SuspendLayout()
        Me.pnlTry2.SuspendLayout()
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
        'pnlTry1
        '
        Me.pnlTry1.Controls.Add(Me.lblTry5)
        Me.pnlTry1.Controls.Add(Me.lblTry4)
        Me.pnlTry1.Controls.Add(Me.lblTry3)
        Me.pnlTry1.Controls.Add(Me.lblTry2)
        Me.pnlTry1.Controls.Add(Me.lblTry1)
        Me.pnlTry1.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTry1.Location = New System.Drawing.Point(2, 303)
        Me.pnlTry1.Name = "pnlTry1"
        Me.pnlTry1.Size = New System.Drawing.Size(414, 37)
        Me.pnlTry1.TabIndex = 26
        Me.pnlTry1.Visible = False
        '
        'lblTry5
        '
        Me.lblTry5.AutoSize = True
        Me.lblTry5.Location = New System.Drawing.Point(332, 4)
        Me.lblTry5.Name = "lblTry5"
        Me.lblTry5.Size = New System.Drawing.Size(71, 31)
        Me.lblTry5.TabIndex = 28
        Me.lblTry5.Text = "lblTry5"
        '
        'lblTry4
        '
        Me.lblTry4.AutoSize = True
        Me.lblTry4.Location = New System.Drawing.Point(247, 4)
        Me.lblTry4.Name = "lblTry4"
        Me.lblTry4.Size = New System.Drawing.Size(71, 31)
        Me.lblTry4.TabIndex = 27
        Me.lblTry4.Text = "lblTry4"
        '
        'lblTry3
        '
        Me.lblTry3.AutoSize = True
        Me.lblTry3.Location = New System.Drawing.Point(163, 4)
        Me.lblTry3.Name = "lblTry3"
        Me.lblTry3.Size = New System.Drawing.Size(71, 31)
        Me.lblTry3.TabIndex = 26
        Me.lblTry3.Text = "lblTry3"
        '
        'lblTry2
        '
        Me.lblTry2.AutoSize = True
        Me.lblTry2.Location = New System.Drawing.Point(84, 4)
        Me.lblTry2.Name = "lblTry2"
        Me.lblTry2.Size = New System.Drawing.Size(70, 31)
        Me.lblTry2.TabIndex = 25
        Me.lblTry2.Text = "lblTry2"
        '
        'lblTry1
        '
        Me.lblTry1.AutoSize = True
        Me.lblTry1.Location = New System.Drawing.Point(5, 4)
        Me.lblTry1.Name = "lblTry1"
        Me.lblTry1.Size = New System.Drawing.Size(65, 31)
        Me.lblTry1.TabIndex = 24
        Me.lblTry1.Text = "lblTry1"
        '
        'pnlTries
        '
        Me.pnlTries.Controls.Add(Me.pnlTry11)
        Me.pnlTries.Controls.Add(Me.pnlTry15)
        Me.pnlTries.Controls.Add(Me.pnlTry10)
        Me.pnlTries.Controls.Add(Me.pnlTry12)
        Me.pnlTries.Controls.Add(Me.pnlTry14)
        Me.pnlTries.Controls.Add(Me.pnlTry13)
        Me.pnlTries.Controls.Add(Me.pnlTry2)
        Me.pnlTries.Controls.Add(Me.pnlTry1)
        Me.pnlTries.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTries.Location = New System.Drawing.Point(172, 255)
        Me.pnlTries.Name = "pnlTries"
        Me.pnlTries.Size = New System.Drawing.Size(417, 647)
        Me.pnlTries.TabIndex = 17
        '
        'pnlTry11
        '
        Me.pnlTry11.Controls.Add(Me.Label46)
        Me.pnlTry11.Controls.Add(Me.Label47)
        Me.pnlTry11.Controls.Add(Me.Label48)
        Me.pnlTry11.Controls.Add(Me.Label49)
        Me.pnlTry11.Controls.Add(Me.Label50)
        Me.pnlTry11.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTry11.Location = New System.Drawing.Point(1, 3)
        Me.pnlTry11.Name = "pnlTry11"
        Me.pnlTry11.Size = New System.Drawing.Size(414, 37)
        Me.pnlTry11.TabIndex = 29
        Me.pnlTry11.Visible = False
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(332, 4)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(83, 31)
        Me.Label46.TabIndex = 28
        Me.Label46.Text = "Label46"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(247, 4)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(81, 31)
        Me.Label47.TabIndex = 27
        Me.Label47.Text = "Label47"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(163, 4)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(83, 31)
        Me.Label48.TabIndex = 26
        Me.Label48.Text = "Label48"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(84, 4)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(83, 31)
        Me.Label49.TabIndex = 25
        Me.Label49.Text = "Label49"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(5, 4)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(83, 31)
        Me.Label50.TabIndex = 24
        Me.Label50.Text = "Label50"
        '
        'pnlTry15
        '
        Me.pnlTry15.Controls.Add(Me.Label66)
        Me.pnlTry15.Controls.Add(Me.Label67)
        Me.pnlTry15.Controls.Add(Me.Label68)
        Me.pnlTry15.Controls.Add(Me.Label69)
        Me.pnlTry15.Controls.Add(Me.Label70)
        Me.pnlTry15.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTry15.Location = New System.Drawing.Point(2, 43)
        Me.pnlTry15.Name = "pnlTry15"
        Me.pnlTry15.Size = New System.Drawing.Size(414, 37)
        Me.pnlTry15.TabIndex = 29
        Me.pnlTry15.Visible = False
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(332, 4)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(83, 31)
        Me.Label66.TabIndex = 28
        Me.Label66.Text = "Label66"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(247, 4)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(81, 31)
        Me.Label67.TabIndex = 27
        Me.Label67.Text = "Label67"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(163, 4)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(83, 31)
        Me.Label68.TabIndex = 26
        Me.Label68.Text = "Label68"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(84, 4)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(83, 31)
        Me.Label69.TabIndex = 25
        Me.Label69.Text = "Label69"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(5, 4)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(81, 31)
        Me.Label70.TabIndex = 24
        Me.Label70.Text = "Label70"
        '
        'pnlTry10
        '
        Me.pnlTry10.Controls.Add(Me.Label41)
        Me.pnlTry10.Controls.Add(Me.Label42)
        Me.pnlTry10.Controls.Add(Me.Label43)
        Me.pnlTry10.Controls.Add(Me.Label44)
        Me.pnlTry10.Controls.Add(Me.Label45)
        Me.pnlTry10.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTry10.Location = New System.Drawing.Point(3, 86)
        Me.pnlTry10.Name = "pnlTry10"
        Me.pnlTry10.Size = New System.Drawing.Size(414, 37)
        Me.pnlTry10.TabIndex = 29
        Me.pnlTry10.Visible = False
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(332, 4)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(77, 31)
        Me.Label41.TabIndex = 28
        Me.Label41.Text = "Label41"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(247, 4)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(82, 31)
        Me.Label42.TabIndex = 27
        Me.Label42.Text = "Label42"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(163, 4)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(83, 31)
        Me.Label43.TabIndex = 26
        Me.Label43.Text = "Label43"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(84, 4)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(83, 31)
        Me.Label44.TabIndex = 25
        Me.Label44.Text = "Label44"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(5, 4)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(83, 31)
        Me.Label45.TabIndex = 24
        Me.Label45.Text = "Label45"
        '
        'pnlTry14
        '
        Me.pnlTry14.Controls.Add(Me.Label61)
        Me.pnlTry14.Controls.Add(Me.Label62)
        Me.pnlTry14.Controls.Add(Me.Label63)
        Me.pnlTry14.Controls.Add(Me.Label64)
        Me.pnlTry14.Controls.Add(Me.Label65)
        Me.pnlTry14.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTry14.Location = New System.Drawing.Point(3, 174)
        Me.pnlTry14.Name = "pnlTry14"
        Me.pnlTry14.Size = New System.Drawing.Size(414, 37)
        Me.pnlTry14.TabIndex = 29
        Me.pnlTry14.Visible = False
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(332, 4)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(77, 31)
        Me.Label61.TabIndex = 28
        Me.Label61.Text = "Label61"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(247, 4)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(82, 31)
        Me.Label62.TabIndex = 27
        Me.Label62.Text = "Label62"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(163, 4)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(83, 31)
        Me.Label63.TabIndex = 26
        Me.Label63.Text = "Label63"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(84, 4)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(83, 31)
        Me.Label64.TabIndex = 25
        Me.Label64.Text = "Label64"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(5, 4)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(83, 31)
        Me.Label65.TabIndex = 24
        Me.Label65.Text = "Label65"
        '
        'pnlTry13
        '
        Me.pnlTry13.Controls.Add(Me.Label56)
        Me.pnlTry13.Controls.Add(Me.Label57)
        Me.pnlTry13.Controls.Add(Me.Label58)
        Me.pnlTry13.Controls.Add(Me.Label59)
        Me.pnlTry13.Controls.Add(Me.Label60)
        Me.pnlTry13.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTry13.Location = New System.Drawing.Point(2, 217)
        Me.pnlTry13.Name = "pnlTry13"
        Me.pnlTry13.Size = New System.Drawing.Size(414, 37)
        Me.pnlTry13.TabIndex = 29
        Me.pnlTry13.Visible = False
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(332, 4)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(83, 31)
        Me.Label56.TabIndex = 28
        Me.Label56.Text = "Label56"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(247, 4)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(81, 31)
        Me.Label57.TabIndex = 27
        Me.Label57.Text = "Label57"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(163, 4)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(83, 31)
        Me.Label58.TabIndex = 26
        Me.Label58.Text = "Label58"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(84, 4)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(83, 31)
        Me.Label59.TabIndex = 25
        Me.Label59.Text = "Label59"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(5, 4)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(83, 31)
        Me.Label60.TabIndex = 24
        Me.Label60.Text = "Label60"
        '
        'pnlTry12
        '
        Me.pnlTry12.Controls.Add(Me.Label51)
        Me.pnlTry12.Controls.Add(Me.Label52)
        Me.pnlTry12.Controls.Add(Me.Label53)
        Me.pnlTry12.Controls.Add(Me.Label54)
        Me.pnlTry12.Controls.Add(Me.Label55)
        Me.pnlTry12.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTry12.Location = New System.Drawing.Point(3, 129)
        Me.pnlTry12.Name = "pnlTry12"
        Me.pnlTry12.Size = New System.Drawing.Size(414, 37)
        Me.pnlTry12.TabIndex = 29
        Me.pnlTry12.Visible = False
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(332, 4)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(77, 31)
        Me.Label51.TabIndex = 28
        Me.Label51.Text = "Label51"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(247, 4)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(82, 31)
        Me.Label52.TabIndex = 27
        Me.Label52.Text = "Label52"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(163, 4)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(83, 31)
        Me.Label53.TabIndex = 26
        Me.Label53.Text = "Label53"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(84, 4)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(83, 31)
        Me.Label54.TabIndex = 25
        Me.Label54.Text = "Label54"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(5, 4)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(83, 31)
        Me.Label55.TabIndex = 24
        Me.Label55.Text = "Label55"
        '
        'pnlTry2
        '
        Me.pnlTry2.Controls.Add(Me.Label1)
        Me.pnlTry2.Controls.Add(Me.Label2)
        Me.pnlTry2.Controls.Add(Me.Label3)
        Me.pnlTry2.Controls.Add(Me.Label4)
        Me.pnlTry2.Controls.Add(Me.Label5)
        Me.pnlTry2.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTry2.Location = New System.Drawing.Point(3, 260)
        Me.pnlTry2.Name = "pnlTry2"
        Me.pnlTry2.Size = New System.Drawing.Size(414, 37)
        Me.pnlTry2.TabIndex = 29
        Me.pnlTry2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(332, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 31)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(247, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 31)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(163, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 31)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 31)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 31)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Label5"
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
        'FormGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 933)
        Me.Controls.Add(Me.pnlTextBox)
        Me.Controls.Add(Me.lblRight)
        Me.Controls.Add(Me.lblWrong)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblFound)
        Me.Controls.Add(Me.lblSel)
        Me.Controls.Add(Me.lblChar)
        Me.Controls.Add(Me.lblMissing)
        Me.Controls.Add(Me.pnlTries)
        Me.Controls.Add(Me.lblColorCode)
        Me.Controls.Add(Me.lblTries)
        Me.Controls.Add(Me.btnGuess)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormGame"
        Me.Text = "formGame"
        Me.pnlTry1.ResumeLayout(False)
        Me.pnlTry1.PerformLayout()
        Me.pnlTries.ResumeLayout(False)
        Me.pnlTry11.ResumeLayout(False)
        Me.pnlTry11.PerformLayout()
        Me.pnlTry15.ResumeLayout(False)
        Me.pnlTry15.PerformLayout()
        Me.pnlTry10.ResumeLayout(False)
        Me.pnlTry10.PerformLayout()
        Me.pnlTry14.ResumeLayout(False)
        Me.pnlTry14.PerformLayout()
        Me.pnlTry13.ResumeLayout(False)
        Me.pnlTry13.PerformLayout()
        Me.pnlTry12.ResumeLayout(False)
        Me.pnlTry12.PerformLayout()
        Me.pnlTry2.ResumeLayout(False)
        Me.pnlTry2.PerformLayout()
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
    Friend WithEvents pnlTry1 As Windows.Forms.Panel
    Friend WithEvents lblTry5 As Windows.Forms.Label
    Friend WithEvents lblTry4 As Windows.Forms.Label
    Friend WithEvents lblTry3 As Windows.Forms.Label
    Friend WithEvents lblTry2 As Windows.Forms.Label
    Friend WithEvents lblTry1 As Windows.Forms.Label
    Friend WithEvents pnlTries As Windows.Forms.Panel
    Friend WithEvents pnlTry14 As Windows.Forms.Panel
    Friend WithEvents Label61 As Windows.Forms.Label
    Friend WithEvents Label62 As Windows.Forms.Label
    Friend WithEvents Label63 As Windows.Forms.Label
    Friend WithEvents Label64 As Windows.Forms.Label
    Friend WithEvents Label65 As Windows.Forms.Label
    Friend WithEvents pnlTry12 As Windows.Forms.Panel
    Friend WithEvents Label51 As Windows.Forms.Label
    Friend WithEvents Label52 As Windows.Forms.Label
    Friend WithEvents Label53 As Windows.Forms.Label
    Friend WithEvents Label54 As Windows.Forms.Label
    Friend WithEvents Label55 As Windows.Forms.Label
    Friend WithEvents pnlTry2 As Windows.Forms.Panel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents pnlTry10 As Windows.Forms.Panel
    Friend WithEvents Label41 As Windows.Forms.Label
    Friend WithEvents Label42 As Windows.Forms.Label
    Friend WithEvents Label43 As Windows.Forms.Label
    Friend WithEvents Label44 As Windows.Forms.Label
    Friend WithEvents Label45 As Windows.Forms.Label
    Friend WithEvents pnlTry11 As Windows.Forms.Panel
    Friend WithEvents Label46 As Windows.Forms.Label
    Friend WithEvents Label47 As Windows.Forms.Label
    Friend WithEvents Label48 As Windows.Forms.Label
    Friend WithEvents Label49 As Windows.Forms.Label
    Friend WithEvents Label50 As Windows.Forms.Label
    Friend WithEvents pnlTry13 As Windows.Forms.Panel
    Friend WithEvents Label56 As Windows.Forms.Label
    Friend WithEvents Label57 As Windows.Forms.Label
    Friend WithEvents Label58 As Windows.Forms.Label
    Friend WithEvents Label59 As Windows.Forms.Label
    Friend WithEvents Label60 As Windows.Forms.Label
    Friend WithEvents pnlTry15 As Windows.Forms.Panel
    Friend WithEvents Label66 As Windows.Forms.Label
    Friend WithEvents Label67 As Windows.Forms.Label
    Friend WithEvents Label68 As Windows.Forms.Label
    Friend WithEvents Label69 As Windows.Forms.Label
    Friend WithEvents Label70 As Windows.Forms.Label
    Friend WithEvents pnlTextBox As Windows.Forms.Panel
    Friend WithEvents tbCode5 As Windows.Forms.TextBox
    Friend WithEvents tbCode1 As Windows.Forms.TextBox
    Friend WithEvents tbCode2 As Windows.Forms.TextBox
    Friend WithEvents tbCode3 As Windows.Forms.TextBox
    Friend WithEvents tbCode4 As Windows.Forms.TextBox
End Class
