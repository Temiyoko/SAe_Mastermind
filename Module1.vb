Imports System.IO
Imports System.Windows.Forms

Module Module1
    Private playableChar() As Char
    Private code() As Char
    Private idFile As Integer = FreeFile()

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

    Public Function GetCode() As Char()
        Return code
    End Function

    Public Function GetCodeInd(i As Integer) As Char
        Debug.Assert(i >= 0 And i <= UBound(code))
        Return code(i)
    End Function

    Public Sub NewPlayer(s As String)
        Dim score As Integer = 0, bestTime = 0, p1Games = 0, p2Games = 0, totalGuessTime = 0
        '$ facilite la concatenation des variables dans une chaîne de format
        Dim playerInfo As String = $"{s} {score} {bestTime} {p1Games} {p2Games} {totalGuessTime}"
        FileOpen(idFile, "playerSave.txt", OpenMode.Append)
        PrintLine(idFile, playerInfo)
        FileClose(idFile)
    End Sub

    Public Sub AddScore(s As String)
        Dim lines As New List(Of String)()

        FileOpen(idFile, "playerSave.txt", OpenMode.Input)

        Do Until EOF(idFile)
            Dim nextLine As String = LineInput(idFile)
            Dim playerInfo As String() = nextLine.Split(" ")

            If playerInfo(0) = s Then
                Dim score As Integer
                If Integer.TryParse(playerInfo(1), score) Then
                    score += 1
                    playerInfo(1) = score.ToString()
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

    Public Sub UpdateScore(s As String, won As Boolean)
        Dim nextLine As String
        FileOpen(idFile, "playerSave.txt", OpenMode.Input)

        Do Until EOF(idFile)
            nextLine = LineInput(idFile)
            Dim playerInfo As String() = nextLine.Split(" ")

            If playerInfo(0) = s Then
                FileClose(idFile)
                If won Then AddScore(s)
                Exit Sub
            End If
        Loop

        FileClose(idFile)
        NewPlayer(s)
        If won Then AddScore(s)
    End Sub

    Sub Main()
        Application.Run(FormMenu)
    End Sub

End Module
