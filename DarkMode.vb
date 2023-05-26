Imports System.Drawing
Imports System.Windows.Forms

Module DarkMode

    Private darkModeEnabled = False
    Private currentSettings As New Dictionary(Of Control, Color)
    Private darkModeSettings As New Dictionary(Of Control, Color)

    Public Sub SetDarkMode(b As Boolean)
        darkModeEnabled = b
    End Sub

    Public Function GetDarkMode() As Boolean
        Return darkModeEnabled
    End Function

    Public Sub SetMode(f As Form)
        If GetDarkMode() = True Then
            EnableDarkMode(f)
        Else
            DisableDarkMode(f)
        End If
    End Sub

    Private Sub EnableDarkMode(f As Form)
        f.BackColor = Color.FromArgb(30, 30, 30)

        For Each control As Control In f.Controls
            currentSettings(control) = control.BackColor

            If TypeOf control Is TextBox Or TypeOf control Is ComboBox Or TypeOf control Is ListBox Then
                control.BackColor = Color.FromArgb(60, 60, 60)
                control.ForeColor = Color.White
            ElseIf TypeOf control Is Label Or TypeOf control Is CheckBox Then
                control.ForeColor = Color.White
            ElseIf TypeOf control Is Button Or TypeOf control Is ScrollBar Then
                control.BackColor = Color.FromArgb(45, 45, 45)
                control.ForeColor = Color.White
            ElseIf TypeOf control Is Panel Then
                For Each labels As Label In control.Controls.OfType(Of Label)
                    labels.ForeColor = Color.White
                Next
            End If
            darkModeSettings(control) = control.BackColor
            If TypeOf control Is PictureBox Then
                control.BackgroundImage = Image.FromFile("../../images/mastermindDark.png")
            End If
        Next
    End Sub

    Private Sub DisableDarkMode(f As Form)
        f.BackColor = SystemColors.Control

        For Each control As Control In f.Controls
            If currentSettings.ContainsKey(control) Then
                control.BackColor = currentSettings(control)
                control.ForeColor = Color.Black
            ElseIf TypeOf control Is PictureBox Then
                control.BackgroundImage = Image.FromFile("../../images/mastermindWhite.png")
            End If
        Next

        If f Is FormMenu Then
            FormMenu.pbMaster.BackgroundImage = Image.FromFile("../../images/mastermindWhite.png")
        End If
        darkModeSettings.Clear()
    End Sub

End Module
