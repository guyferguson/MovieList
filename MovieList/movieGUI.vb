
Imports System.Xml
Imports System.Text

Public Class movieGUI
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' Read the filePath fron the Settings object
        tbFilePath.Text = My.Settings.filePath

        ' Display the filename in the Title Bar
        Me.Text = "We are working with " & My.Settings.fileName
    End Sub
    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        Dim strMovieName As String
        strMovieName = tbMovieName.Text
        Dim webClient As New System.Net.WebClient
        Dim result As String = webClient.DownloadString("http://www.imdb.com/xml/find?xml=1&nr=1&tt=on&q=" & strMovieName)
        Dim mv As New Movie
        tbOriginal.Text = result
        wbOutput.DocumentText = mv.showPossibles(result)
    End Sub


End Class
