Imports System.Media

Module Music

    Private WithEvents Music As New SoundPlayer
    Private isPlaying As Boolean = False

    Public Sub SetIsPlaying(b As Boolean)
        isPlaying = b
    End Sub

    Public Function GetIsPlaying() As Boolean
        Return isPlaying
    End Function

    Public Sub PlayMusic(musicFile As String)
        Music.SoundLocation = musicFile
        Music.Load()
        Music.PlayLooping()
    End Sub

    Public Sub StopMusic()
        Music.Stop()
    End Sub
End Module
