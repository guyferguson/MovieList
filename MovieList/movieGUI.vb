
Imports System.Xml
Imports System.Text
Imports Newtonsoft.Json
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO



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
                newmv.ttId = (wbOutput.Url.Query.Split("=")(1))
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
        ' Msgbox to check we're looking at JSON here...
        ' MsgBox(ob)
        Return JsonConvert.DeserializeObject(Of MovieJS)(ob)

    End Function
    Private Sub populateGUI(newmv As MovieJS)
        tbTtId.Text = newmv.ttId
        tbTitle.Text = newmv.title
        tbYear.Text = newmv.year
        tbGenre.Text = newmv.genre
        tbRuntime.Text = newmv.runtime
        tbDirector.Text = newmv.director
        tbWriter.Text = newmv.writer
        tbDirector.Text = newmv.director
        tbPlot.Text = newmv.plot
        'Handle the movie poster -check there is one first
        If Not (newmv.poster = "N/A") Then

            pbPoster.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(newmv.poster)))
            Dim resized As Image = ResizeImage(pbPoster.Image, New Size(pbPoster.Width, pbPoster.Height))
            pbPoster.Image = resized

        End If
    End Sub

    'Code to resize an image 

    Private Function ResizeImage(ByVal image As Image, _
  ByVal size As Size, Optional ByVal preserveAspectRatio As Boolean = True) As Image
        Dim newWidth As Integer
        Dim newHeight As Integer
        If preserveAspectRatio Then
            Dim originalWidth As Integer = image.Width
            Dim originalHeight As Integer = image.Height
            Dim percentWidth As Single = CSng(size.Width) / CSng(originalWidth)
            Dim percentHeight As Single = CSng(size.Height) / CSng(originalHeight)
            Dim percent As Single = If(percentHeight < percentWidth, percentHeight, percentWidth)
            newWidth = CInt(originalWidth * percent)
            newHeight = CInt(originalHeight * percent)
        Else
            newWidth = size.Width
            newHeight = size.Height
        End If

        Dim newImage As Image = New Bitmap(pbPoster.Width, pbPoster.Height)

        Using graphicsHandle As Graphics = Graphics.FromImage(newImage)
            graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic
            graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight)
        End Using
        Return newImage
    End Function

End Class
