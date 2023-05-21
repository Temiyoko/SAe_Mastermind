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
        Dim score As Integer = 0
        '$ facilite la concatenation des variables dans une chaîne de format
        Dim playerInfo As String = $"{s} {score}"
        PrintLine(idFile, playerInfo)
    End Sub

    Sub Main()
        FileOpen(idFile, "playerSave.txt", OpenMode.Append)
        Application.Run(FormMenu)
        FileClose(idFile)
    End Sub

End Module
