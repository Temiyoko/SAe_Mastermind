Imports System.Windows.Forms

Module Module1
    Private playableChar() As Char = "#$£%@".ToCharArray()
    Private code() As Char
    Const taille As Integer = 5

    Public Function getPlayableChar() As Char()
        Return playableChar
    End Function

    Public Function PlayableCharToString() As String
        Dim label As String = ""
        For Each c As Char In playableChar
            label += " " & c
        Next
        Return label
    End Function

    Sub Main()
        Dim code(taille) As Char
        Application.Run(FormMenu)
    End Sub

End Module
