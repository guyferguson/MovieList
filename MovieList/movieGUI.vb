
Imports System.Xml
Imports System.Text
Imports Newtonsoft.Json



Public Class movieGUI

    Dim mv As New Movie
    Public Sub New()
        '     Dim g As Serialization.
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' Read the filePath fron the Settings object
        tbFilePath.Text = My.Settings.filePath

        ' Display the filename in the Title Bar
        Me.Text = "We are working with " & My.Settings.fileName
    End Sub
    Public Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click

        Dim strMovieName As String
        strMovieName = tbMovieName.Text
        Dim webClient As New System.Net.WebClient
        Dim result As String = webClient.DownloadString("http://www.imdb.com/xml/find?xml=1&nr=1&tt=on&q=" & strMovieName)

        '  tbOriginal.Text = result
        wbOutput.DocumentText = mv.showPossibles(result)
    End Sub


    Private Sub wbOutput_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbOutput.DocumentCompleted
        'Handle onhyperlinkclick

    End Sub


    Private Sub wbOutput_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles wbOutput.Navigated
        If Not (IsNothing(wbOutput.DocumentText)) Then

            ' A very hackish and childish way of determing if we have arrived at a JSON string 
            If (wbOutput.DocumentText.ToCharArray()(0) = "{") Then
                Dim newmv As MovieJS = readJson(wbOutput.DocumentText)

                ' Then populate GUI
                populateGUI(newmv)
            End If
        End If

    End Sub

    Private Sub wbOutput_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles wbOutput.Navigating
        '  If we are on the page of links then cancel navigation.
        If Not (IsNothing(wbOutput.Document)) Then
           
        End If


    End Sub

    Function readJson(ob As String)

        MsgBox(ob)
        Return JsonConvert.DeserializeObject(Of MovieJS)(ob)

    End Function
    Private Sub populateGUI(newmv As MovieJS)
        tbTitle.Text = newmv.title
        tbYear.Text = newmv.year
        tbGenre.Text = newmv.genre
        tbRuntime.Text = newmv.runtime
        tbDirector.Text = newmv.director
    End Sub
End Class
