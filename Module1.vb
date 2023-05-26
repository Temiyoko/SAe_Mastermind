﻿Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Windows.Forms

Module Module1
    Private playableChar() As Char
    Private code() As Char
    ReadOnly idFile As Integer = FreeFile()
    Private closeSource As String = ""
    Private colors(colorSize) As Color
    Private chronoEnabled As Boolean = True
    Private nbTries As Integer = 15
    Private maxTime As Integer = 90
    Const colorSize As Integer = 3

    Public Structure Player
        Dim Name As String
        Dim Score As Integer
        Dim BestTime As Integer
        Dim P1 As Integer
        Dim P2 As Integer
        Dim TotalTime As Integer
    End Structure

    Public Function GetMaxTime() As Integer
        Return maxTime
    End Function

    Public Function GetTimeToString(i As Integer) As String
        Dim minutes As Integer = i \ 60
        Dim seconds As Integer = i Mod 60

        Return minutes & " minute(s) et " & seconds & " seconde(s)"
    End Function

    Public Sub SetMaxTime(i As Integer)
        maxTime = i
    End Sub

    Public Function GetChronoEnabled() As Boolean
        Return chronoEnabled
    End Function

    Public Sub SetChronoEnabled(b As Boolean)
        chronoEnabled = b
    End Sub

    Public Function GetNbTries() As Integer
        Return nbTries
    End Function

    Public Sub SetNbTries(i As Integer)
        nbTries = i
    End Sub

    Public Function GetColorSize() As Integer
        Return colorSize
    End Function

    Public Function GetColor(i As Integer) As Color
        Debug.Assert(i >= 0 And i <= UBound(colors))
        Return colors(i)
    End Function

    Public Sub SetColor(c As Color())
        Debug.Assert(c.Length >= 0 And UBound(c) <= colorSize)
        colors = c
    End Sub

    Public Function GetCloseSource() As String
        Return closeSource
    End Function

    Public Sub SetCloseSource(s As String)
        closeSource = s
    End Sub

    Public Sub SetPlayableChar(s As String)
        playableChar = s.ToCharArray()
    End Sub

    Public Function GetPlayableChar() As Char()
        Return playableChar
    End Function

    Public Function GetIdFile() As Integer
        Return idFile
    End Function

    Public Function PlayableCharToString() As String
        Dim label As String = ""
        For Each c As Char In playableChar
            label += " " & c
        Next
        Return label
    End Function

    Public Sub SetCode(s As String)
        code = s.ToCharArray()
    End Sub

    Private Function PlayerExist(s As String) As Boolean
        Dim nextLine As String
        FileOpen(idFile, "playerSave.txt", OpenMode.Input)
        Do Until EOF(idFile)
            nextLine = LineInput(idFile)
            Dim playerInfo As String() = nextLine.Split(" ")
            If playerInfo(0) = s Then
                FileClose(idFile)
                Return True
            End If
        Loop
        FileClose(idFile)
        Return False
    End Function

    Public Function GetCode() As Char()
        Return code
    End Function

    Public Function GetCodeInd(i As Integer) As Char
        Debug.Assert(i >= 0 And i <= UBound(code))
        Return code(i)
    End Function

    Public Sub NewPlayer(s As String)
        Dim score As Integer = 0, bestTime = Integer.MaxValue, p1Games = 0, p2Games = 0, totalGuessTime = 0
        '$ facilite la concatenation des variables dans une chaîne de format
        Dim playerInfo As String = $"{s} {score} {bestTime} {p1Games} {p2Games} {totalGuessTime}"
        FileOpen(idFile, "playerSave.txt", OpenMode.Append)
        PrintLine(idFile, String.Join(" ", playerInfo))
        FileClose(idFile)
    End Sub

    Public Sub UpdatePlayer(s As String, time As Integer, player As Integer, win As Boolean)
        Dim lines As New List(Of String)()

        If Not PlayerExist(s) Then NewPlayer(s)

        FileOpen(idFile, "playerSave.txt", OpenMode.Input)
        Do Until EOF(idFile)
            Dim nextLine As String = LineInput(idFile)
            Dim playerInfo As String() = nextLine.Split(" ")

            If playerInfo(0) = s Then

                If win Then
                    Dim score As Integer
                    If Integer.TryParse(playerInfo(1), score) Then
                        score += 1
                        playerInfo(1) = score.ToString()
                    End If
                End If

                If player = 2 Then
                    If time < playerInfo(2) Then playerInfo(2) = time.ToString()
                    playerInfo(5) += time
                End If

                Dim nbGames As Integer
                If Integer.TryParse(playerInfo(2 + player), nbGames) Then
                    nbGames += 1
                    playerInfo(2 + player) = nbGames.ToString()
                End If
            End If

            lines.Add(String.Join(" ", playerInfo))
        Loop
        FileClose(idFile)

        FileOpen(idFile, "playerSave.txt", OpenMode.Output)
        For Each line As String In lines
            PrintLine(idFile, line)
        Next
        FileClose(idFile)
    End Sub

    Public Function GetAllNames() As String()
        Dim nextLine As String
        Dim list As New List(Of String)
        FileOpen(idFile, "playerSave.txt", OpenMode.Input)

        Do Until EOF(idFile)
            nextLine = LineInput(idFile)
            Dim playerInfo As String() = nextLine.Split(" ")
            list.Add(playerInfo(0))
        Loop
        FileClose(idFile)
        Return list.ToArray()
    End Function

    Public Function GetAllPlayer() As List(Of Player)
        Dim nextLine As String
        Dim list As New List(Of Player)
        FileOpen(idFile, "playerSave.txt", OpenMode.Input)

        Do Until EOF(idFile)
            nextLine = LineInput(idFile)
            Dim playerInfo As String() = nextLine.Split(" ")
            Dim p As Player
            With p
                .Name = playerInfo(0)
                .Score = playerInfo(1)
                .BestTime = playerInfo(2)
                .P1 = playerInfo(3)
                .P2 = playerInfo(4)
                .TotalTime = playerInfo(5)
            End With
            list.Add(p)
        Loop
        FileClose(idFile)
        Return list
    End Function

    Public Function PlayerToString(s As String, list As List(Of Player)) As String
        Dim ppl As Player = Nothing

        For Each p As Player In list
            If p.Name = s Then
                ppl = p
                Exit For
            End If
        Next

        If Not IsNothing(ppl) Then
            Dim bestTime As String = If(ppl.BestTime.ToString() = Integer.MaxValue.ToString(), "-", ppl.BestTime.ToString())
            Return "Le joueur " & ppl.Name & " a un score de " & ppl.Score & " point(s)." & vbCr _
                & "Il a joué " & ppl.P1 & " fois comme joueur 1 et " & ppl.P2 & " fois comme joueur 2." _
                & vbCr & "Son meilleur temps est de " & bestTime & " secondes sur un total de " & ppl.TotalTime & " secondes."
        End If
        Return "Aucun joueur n'a été trouvé."
    End Function

    Public Sub RoundButton(button As Button, cornerRadius As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90)
        path.AddLine(cornerRadius, 0, button.Width - cornerRadius, 0)
        path.AddArc(button.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2, 270, 90)
        path.AddLine(button.Width, cornerRadius, button.Width, button.Height - cornerRadius)
        path.AddArc(button.Width - cornerRadius * 2, button.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90)
        path.AddLine(button.Width - cornerRadius, button.Height, cornerRadius, button.Height)
        path.AddArc(0, button.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90)
        path.AddLine(0, button.Height - cornerRadius, 0, cornerRadius)

        button.Region = New Region(path)
    End Sub

    Sub Main()
        Dim defaultColors As Color() = {Color.LimeGreen, Color.Orange, Color.Red}
        SetColor(defaultColors)

        If Not File.Exists("playerSave.txt") Then
            File.Create("playerSave.txt").Dispose() ' Crée le fichier s'il n'existe pas
        End If

        Application.Run(FormMenu)
    End Sub

End Module
