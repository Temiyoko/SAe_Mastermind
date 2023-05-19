Imports System.Windows.Forms

Module Module1
    Private playableChar() As Char
    Private code() As Char

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

    Public Function getCodeInd(i As Integer) As Char
        Debug.Assert(i >= 0 And i <= UBound(code))
        Return code(i)
    End Function

    Sub Main()
        Application.Run(FormMenu)
    End Sub

End Module
