Imports System.Drawing

Module Settings
    Private colors(colorSize) As Color
    Private chronoEnabled As Boolean = True
    Private nbTries As Integer = 15
    Private maxTime As Integer = 90
    Const colorSize As Integer = 3

    Public Function GetMaxTime() As Integer
        Return maxTime
    End Function

    Public Function GetTimeToString(i As Integer) As String
        If i = Integer.MaxValue Then
            Return "-"
        Else
            Dim minutes As Integer = i \ 60
            Dim seconds As Integer = i Mod 60

            Return minutes & " minute(s) et " & seconds & " seconde(s)"
        End If
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
End Module
