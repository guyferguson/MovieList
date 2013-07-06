
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
        tbImagePath.Text = My.Settings.imagePath

        ' Select the first item in the filetype list
        cbFiletype.SelectedIndex = 0

        ' Display the filename in the Title Bar
        Me.Text = "We are working with " & My.Settings.fileName
    End Sub
    Public Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click

        'Clear out current GUI
        resetGUI()
        wbOutput.Visible = True
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
                wbOutput.Visible = False
            End If
        End If

    End Sub

    Function readJson(ob As String)
        ' Msgbox to check we're looking at JSON here...
        ' MsgBox(ob)
        Return JsonConvert.DeserializeObject(Of MovieJS)(ob)

    End Function
    Private Sub populateGUI(newmv As MovieJS)
        ' This function makes several calls to other functions taht assist in data cleansing
        ' for final presentation
        tbTtId.Text = newmv.ttId
        tbTitle.Text = prefixSuffix(newmv)
        tbYear.Text = newmv.year
        tbGenre.Text = newmv.genre
        tbRuntime.Text = timeToMins(newmv)
        tbDirector1.Text = newmv.director
        splitWriters(newmv)
        tbDirector1.Text = newmv.director

        ' Handle multiple actors - always keep the array together but split for diaply purposes
        splitActors(newmv)
        tbPlot.Text = newmv.plot
        'Handle the movie poster - check there is one first
        If Not (newmv.poster = "N/A") Then
            pbPoster.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(newmv.poster)))
            Dim resized As Image = ResizeImage(pbPoster.Image, New Size(pbPoster.Width, pbPoster.Height))
            pbPoster.Image = resized

        End If
    End Sub

    Private Function prefixSuffix(newmv As MovieJS)
        ' If the movie title starts with'The', moves it to the end after a comma.

        If (newmv.title.Trim.StartsWith("The ")) Then
            newmv.title = newmv.title.Substring(4) & ", The"
        End If
        Return newmv.title
    End Function
    Private Function timeToMins(newmv As MovieJS)
        ' Function to convert the IMDB string, e.g. '1h 39m' into minutes, e.g. 99
        Dim hours As Integer
        Dim min As Integer
        If newmv.runtime.Contains("h") Then

            hours = newmv.runtime.Split("h")(0)
            Dim minAt As Integer = newmv.runtime.IndexOf("m")
            min = CInt(Mid(newmv.runtime, minAt - 2, 2))
        Else
            hours = 0
            min = CInt((newmv.runtime.Split(" "c)(0)))
        End If
        Return (hours * 60) + min
    End Function
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


    ' A sub to split the multiple actors into individual names
    ' and put them in text boxes, without affecting the original value
    '
    ' PRE: A non-null string containing at least one actor name
    '

    Private Sub splitActors(mv As MovieJS)

        Dim charCnt As Integer = mv.actors.Split(",").Count
        Dim i As Integer
        'Just list first 8 actors if there are many...
        If charCnt > 8 Then
            charCnt = 8
        End If
        For i = 1 To charCnt
            Dim cntrName As String = "tbActor" & i
            Dim newActor As New System.Windows.Forms.TextBox
            '   Dim newctl As New System.Windows.Forms.TextBox



            newActor.Location = New System.Drawing.Point(474, 61 + (25 * i))
            newActor.Name = cntrName
            newActor.Size = New System.Drawing.Size(95, 20)
            newActor.TabIndex = 9 + i
            ' Break up the comma separated names and strip leading and trailing spaces
            newActor.Text = mv.actors.Split(",")(i - 1).Trim(" ")
            Me.Controls.Add(newActor)

        Next
        If i > 2 Then
            lbActors.Text = "Actors"
        End If

    End Sub


    ' A sub to split the multiple actors into individual names
    ' and put them in text boxes, without affecting the original value
    '
    ' Checks for instances where same writer has several credits (e.g. novel and screenplay)
    ' and only reports one instance of that name
    '

    Private Sub splitWriters(mv As MovieJS)

        Dim charCnt As Integer = mv.writer.Split(",").Count
        Dim tmpWriters() As String = {"", "", "", "", "", ""}
        Dim i As Integer
        'Just list first 8 Writers if there are many...
        If charCnt > 8 Then
            charCnt = 8
        End If
        For i = 1 To charCnt
            Dim cntrName As String = "tbWriter" & i
            Dim newctl As New System.Windows.Forms.TextBox
            If tmpWriters.Contains(mv.writer.Split(",")(i - 1).Trim(" ")) Then
                Exit For
            End If
            tmpWriters(i - 1) = mv.writer.Split(",")(i - 1).Trim(" ")


            newctl.Location = New System.Drawing.Point(277, 61 + (25 * i))
            newctl.Name = cntrName
            newctl.Size = New System.Drawing.Size(115, 20)
            newctl.TabIndex = 9 + i
            ' Break up the comma separated names and strip leading and trailing spaces
            newctl.Text = mv.writer.Split(",")(i - 1).Trim(" ")
            Me.Controls.Add(newctl)
        Next

        If i > 2 Then
            lbWriters.Text = "Writers"
        End If
    End Sub

    '
    ' A sub to loop through controls and clean them up, and remove any dynamically added
    ' controls such as textboxes...
    ' Crazy but the only way I've been able to get it to clear all dynamically added boxes is to loop through the same 
    ' collection three times
    '
    Private Sub resetGUI()

        For Each ctrl As Control In Me.Controls
            '  MsgBox("Working with " & ctrl.Name & " Type = " & ctrl.GetType.ToString)
            If (TypeOf ctrl Is TextBox) Then
                If Not ((ctrl.Name = "tbMovieName") Or (ctrl.Name = "tbFilePath") Or (ctrl.Name = "tbImagePath")) Then
                    ctrl.Text = ""
                End If
                If (ctrl.Name.Contains("tbActor") Or ctrl.Name.Contains("tbWriter")) Then
                    Me.Controls.Remove(ctrl)

                End If
            End If

        Next
        For Each ctrl As Control In Me.Controls
            '  MsgBox("Working with " & ctrl.Name & " Type = " & ctrl.GetType.ToString)
            If (TypeOf ctrl Is TextBox) Then
                If Not ((ctrl.Name = "tbMovieName") Or (ctrl.Name = "tbFilePath") Or (ctrl.Name = "tbImagePath")) Then
                    ctrl.Text = ""
                End If
                If (ctrl.Name.Contains("tbActor") Or ctrl.Name.Contains("tbWriter")) Then
                    Me.Controls.Remove(ctrl)

                End If
            End If

        Next
        For Each ctrl As Control In Me.Controls
            '  MsgBox("Working with " & ctrl.Name & " Type = " & ctrl.GetType.ToString)
            If (TypeOf ctrl Is TextBox) Then
                If Not ((ctrl.Name = "tbMovieName") Or (ctrl.Name = "tbFilePath") Or (ctrl.Name = "tbImagePath")) Then
                    ctrl.Text = ""
                End If
                If (ctrl.Name.Contains("tbActor") Or ctrl.Name.Contains("tbWriter")) Then
                    Me.Controls.Remove(ctrl)

                End If
            End If

        Next
        ' Reset the label text

        lbActors.Text = "Actor"
        lbWriters.Text = "Writer"
    End Sub
End Class
