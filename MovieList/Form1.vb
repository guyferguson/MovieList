
Imports System.Xml
Imports System.Text

Public Class Form1

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        Dim strMovieName As String
        strMovieName = tbMovieName.Text
        Dim webClient As New System.Net.WebClient
        Dim result As String = webClient.DownloadString("http://www.imdb.com/xml/find?xml=1&nr=1&tt=on&q=" & strMovieName)
        Dim mv As New Movie
        result = result
        tbResult.Text = mv.showPossibles(result)
    End Sub


End Class
