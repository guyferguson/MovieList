Imports System.Xml
Imports Newtonsoft.Json
Imports System.Drawing.Drawing2D
Imports System.IO

Public Class movieGUI

    Dim mv As New Movie
    Dim newmv As MovieJS
    Dim elDup As XElement

    ' An XML memory  object to hold the  xml file that we want to write eventually.
    Dim doc As XDocument

    ' An integer to count how many actors in an instance
    Dim ActCnt As Integer
    Dim WritCnt As Integer

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' Read the filePath fron the Settings object
        tbFilePath.Text = My.Settings.filePath
        Dim fi As New DirectoryInfo(tbFilePath.Text)
        Dim testXML As String
        tbImagePath.Text = My.Settings.imagePath
        Dim ip As New DirectoryInfo(tbImagePath.Text)
        ' Determine if these paths are available - if not, exit, advising user how to fix
        If Not (fi.Exists) Then
            MsgBox(fi.ToString & " is not accessible - please update the app.config file, or make this path accessible")
            End
        End If
        If Not (ip.Exists) Then
            MsgBox(ip.ToString & " is not accessible - please update the app.config file, or make this path accessible")
            End
        End If
        'Set last watched to today's date
        dtLastWatched.Value = Today

        ' Select the first item in the several dropdown lists
        cbFiletype.SelectedIndex = 0
        cbType.SelectedIndex = 0
        cbWatched.SelectedIndex = 0

        ' Display the filename in the Title Bar
        Me.Text = "We are working with " & My.Settings.fileName

        'Check if the xml file is well-formed - if not, no point continuing
        Dim objReader As New System.IO.StreamReader(tbFilePath.Text & "\" & My.Settings.fileName)

        testXML = objReader.ReadToEnd

        objReader.Close()

        'Check if the XML file is well-formed before proceeding - this gives user a nicer error message
        If (Not (IsValidXML(testXML))) Then
            MsgBox(My.Settings.fileName & " is not well-formed - please correct and re-run this application")
            End
        End If

        ' Load the existing xml file to speed up later usage of it.  Originally it loaded at each 'Write' button-push
        doc = XDocument.Load(tbFilePath.Text & "\" & My.Settings.fileName)

    End Sub
    Public Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        ' Return button text to 'write' setting, as new search may be an addition
        btWriteXML.Text = "Write to file"
        'Clear out current GUI
        resetGUI()
        wbOutput.Visible = True
        Dim strMovieName As String
        Dim webcall As String
        strMovieName = tbMovieName.Text
        ' 271217...need to remove /xml  from url        webcall = http://www.imdb.com/find?xml=1&nr=1&tt=on&q=" & strMovieName
        ' webcall = "http://www.imdb.com/find?xml=1&nr=1&tt=on&q=" & strMovieName
        webcall = "http://www.omdbapi.com/?r=xml&s=" & strMovieName & "&apikey=f8c6d0cf"

        webcall = webcall & ""
        Try
            Dim webClient As New System.Net.WebClient
            ' Create url for data call
            Dim result As String = webClient.DownloadString(webcall)
            ' This web query returns a valid xml string, but for display purposes we just treat it as a string
            wbOutput.DocumentText = mv.showPossibles(result)
        Catch
            MsgBox("Cannot access internet ... exiting")
            End
        End Try
        'MsgBox(result)
    End Sub
    ''' <summary>
    '''  A function to check that the xml file used to store movie history is well-formed.
    ''' </summary>
    ''' <param name="value">This is the full path and filename of the xml file we wish to check the well-formedness of.</param>
    ''' <returns>True if the xml file is well-formed</returns>
    ''' <remarks>A hackish test - if you can load the file without erros, it must be valid. This function does not actually check every individual set of paired tages, or nesting etc.</remarks>
    Private Function IsValidXML(value As String)
        Try
            'Check we actually have been passed a value
            If (Not (String.IsNullOrEmpty(value))) Then
                'Try to load the value into a document
                Dim xmlDoc As New XmlDocument()
                xmlDoc.LoadXml(value)
                'If we managed with no exception then this is valid XML!
                Return True
            Else
                ' A blank value is not valid xml
                Return False
            End If
        Catch e As System.Xml.XmlException
        End Try
        Return False
    End Function

    Private Sub wbOutput_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles wbOutput.Navigated
        'Update free space on writing directory
        Dim freeS As System.IO.DriveInfo
        freeS = My.Computer.FileSystem.GetDriveInfo(tbFilePath.Text & "\")
        lbFreeSpace.Text = "Free space: " & freeS.TotalFreeSpace.ToString("0,0", Globalization.CultureInfo.InvariantCulture)
        If Not (IsNothing(wbOutput.DocumentText)) Then
            ' A very hackish and childish way of determing if we have arrived at a JSON string 
            If (wbOutput.DocumentText.ToCharArray()(0) = "{") Then
                newmv = readJson(wbOutput.DocumentText)
                newmv.ttId = (wbOutput.Url.Query.Split("=")(1).Split("&")(0))

                ' Then populate GUI
                populateGUI(newmv)
                ' Check for matches
                ' Check first if file contains this movie
                ' Bring the xml down to just the nodes we want - the ImdbEntity nodes
                wbOutput.Visible = False
                For Each el As XElement In doc.<CATALOG>...<MEDIA>
                    If ((String.Compare(el.<TITLE>...<IMDBR>.Value, tbTtId.Text) = 0)) Then
                        btWriteXML.Text = "Update movie file"
                        Me.BackColor = Color.Azure
                        compare(el)
                        elDup = el
                        Exit For
                    Else
                        Me.BackColor = SystemColors.Control
                        btWriteXML.Text = "Write to file"

                    End If
                Next
            End If
        End If

    End Sub

    Function readJson(ob As String)
        Return JsonConvert.DeserializeObject(Of MovieJS)(ob)

    End Function
    Private Sub populateGUI(newmv As MovieJS)
        ' This function makes several calls to other functions that assist in data cleansing
        ' for final presentation
        tbTtId.Text = newmv.ttId
        tbTitle.Text = prefixSuffix(newmv)
        tbYear.Text = newmv.year
        ' TO DO - COnvert IMDB Genres to mine. And do we allow multiple genres?
        tbGenre.Text = newmv.genre
        tbRuntime.Text = timeToMins(newmv)
        splitWriters(newmv)
        tbDirector1.Text = newmv.director

        ' Handle type of media (Movie or TV)
        If (newmv.type = "movie") Then
            cbType.SelectedIndex = 0
        ElseIf (newmv.type = "series") Then
            cbType.SelectedIndex = 1
        End If

        ' Handle multiple actors - always keep the array together but split for display purposes
        splitActors(newmv)
        tbPlot.Text = newmv.plot
        'Handle the movie poster - check there is one first
        If Not (newmv.poster = "N/A") Then
            pbPoster.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(newmv.poster)))
            Dim resized As Image = ResizeImage(pbPoster.Image, New Size(pbPoster.Width, pbPoster.Height))
            pbPoster.Image = resized
        Else
            newmv.poster = "Unavailable"
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

        ' Check that a time has been returned - IMDB can hold NULL or N/A
        If Not newmv.runtime.Contains("m") Then
            Return "N/A"
        End If

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
    ' Resize an image 
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

        ActCnt = mv.actors.Split(",").Count
        Dim i As Integer
        'Just list first 8 actors if there are many...
        If ActCnt > 8 Then
            ActCnt = 8
        End If
        For i = 1 To ActCnt
            Dim cntrName As String = "tbActor" & i
            Dim newActor As New System.Windows.Forms.TextBox
            newActor.Location = New System.Drawing.Point(474, 61 + (25 * i))
            newActor.Name = cntrName
            newActor.Size = New System.Drawing.Size(95, 20)
            newActor.TabIndex = 9 + i
            ' Break up the comma separated names and strip leading and trailing spaces
            newActor.Text = mv.actors.Split(",")(i - 1).Trim(" ")
            Me.pnlMovies.Controls.Add(newActor)
        Next
        If i > 2 Then
            lbActors.Text = "Actors"
        Else
            lbActors.Text = "Actor"
        End If

    End Sub


    ' A sub to split the multiple actors into individual names
    ' and put them in text boxes, without affecting the original value
    '
    ' Checks for instances where same writer has several credits (e.g. novel and screenplay)
    ' and only reports one instance of that name
    '

    Private Sub splitWriters(mv As MovieJS)

        WritCnt = mv.writer.Split(",").Count
        Dim tmpWriters As String() = {"", "", "", "", "", "", "", "", "", "", "", "", ""}
        Dim tmpWritersRoles As String() = {"", "", "", "", "", "", "", "", "", "", "", ""}
        Dim i As Integer
        'Just list first 8 Writers if there are many...
        If WritCnt > 8 Then
            WritCnt = 8
        End If
        For i = 1 To WritCnt
            Dim cntrName As String = "tbWriter" & i
            Dim newctl As New System.Windows.Forms.TextBox
            Dim newctlRole As New System.Windows.Forms.TextBox

            ' Check for duplicated writers
            '   If tmpWriters.Contains(mv.writer.Split(",")(i - 1).Trim(" ")) Then
            'WritCnt -= 1
            ' Exit For
            ' End If

            ' CHeck for role
            tmpWriters(i - 1) = mv.writer.Split(",")(i - 1).Trim(" ")
            If tmpWriters(i - 1).Contains("(") Then
                ' We have found a writer with a role in brackets, split this out
                tmpWritersRoles(i - 1) = tmpWriters(i - 1).Split("(")(1).Trim(")")
                tmpWritersRoles(i - 1) = StrConv(tmpWritersRoles(i - 1), VbStrConv.ProperCase)
                tmpWriters(i - 1) = tmpWriters(i - 1).Split("(")(0)
                '  MsgBox(tmpWritersRoles(i - 1))
            End If

            newctl.Location = New System.Drawing.Point(255, 61 + (25 * i))
            newctl.Name = cntrName
            newctl.Size = New System.Drawing.Size(95, 37)
            newctl.TabIndex = 9 + i
            ' Add a box if there's a role

            If (tmpWritersRoles(i - 1).Length > 0) Then
                newctlRole.Location = New System.Drawing.Point(360, 61 + (25 * i))
                newctlRole.Name = cntrName & "_" & i
                newctlRole.Size = New System.Drawing.Size(65, 37)
                newctlRole.Text = tmpWritersRoles(i - 1).ToString
                Me.pnlMovies.Controls.Add(newctlRole)
            End If
            ' Break up the comma separated names and strip leading and trailing spaces
            newctl.Text = tmpWriters(i - 1).ToString   'mv.writer.Split(",")(i - 1).Trim(" ")
            Me.pnlMovies.Controls.Add(newctl)

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

        'For Each ctrl As Control In Me.Controls
        '    '  MsgBox("Working with " & ctrl.Name & " Type = " & ctrl.GetType.ToString)
        '    If (TypeOf ctrl Is TextBox) Then
        '        If Not ((ctrl.Name = "tbMovieName") Or (ctrl.Name = "tbFilePath") Or (ctrl.Name = "tbImagePath")) Then
        '            ctrl.Text = ""
        '        End If
        '        If (ctrl.Name.Contains("tbActor") Or ctrl.Name.Contains("tbWriter")) Then
        '            Me.Controls.Remove(ctrl)

        '        End If
        '    End If
        '    If Not ((pbPoster.Image) Is Nothing) Then
        '        pbPoster.Image.Dispose()
        '    End If
        'Next
        'For Each ctrl As Control In Me.Controls
        '    If (TypeOf ctrl Is TextBox) Then
        '        If Not ((ctrl.Name = "tbMovieName") Or (ctrl.Name = "tbFilePath") Or (ctrl.Name = "tbImagePath")) Then
        '            ctrl.Text = ""
        '        End If
        '        If (ctrl.Name.Contains("tbActor") Or ctrl.Name.Contains("tbWriter")) Then
        '            Me.Controls.Remove(ctrl)

        '        End If
        '    End If

        '    If Not ((pbPoster.Image) Is Nothing) Then
        '        pbPoster.Image.Dispose()
        '    End If

        'Next
        'For Each ctrl As Control In Me.Controls
        '    If (TypeOf ctrl Is TextBox) Then
        '        If Not ((ctrl.Name = "tbMovieName") Or (ctrl.Name = "tbFilePath") Or (ctrl.Name = "tbImagePath")) Then
        '            ctrl.Text = ""
        '        End If
        '        If (ctrl.Name.Contains("tbActor") Or ctrl.Name.Contains("tbWriter")) Then
        '            Me.Controls.Remove(ctrl)

        '        End If
        '    End If
        '    If Not ((pbPoster.Image) Is Nothing) Then
        '        pbPoster.Image.Dispose()
        '    End If
        'Next

        ' Reset the label text
        lbActors.Text = "Actor"
        lbWriters.Text = "Writer"

        cbWatchedEver.Checked = False
    End Sub

    Private Sub writeXML(sender As Object, e As EventArgs) Handles btWriteXML.Click

        ' Check there is space on drive to write new xml to:
        Dim writeSpace As System.IO.DriveInfo
        writeSpace = My.Computer.FileSystem.GetDriveInfo(tbFilePath.Text & "\")
        If (writeSpace.TotalFreeSpace < 10000000) Then      '10MB.  As of Nov17 the xml file is 1.3MB
            MsgBox("Total free space: " & CStr(writeSpace.TotalFreeSpace) & " is insufficient for the GetXmlNamespace file).")
            Return
        End If
        If (tbTitle.Text = "") Then
            MsgBox("Cannot add media with no title")
            Return
        End If

        ' Create new node of new media
        Dim xmlToAdd As New XElement("MEDIA")
        Dim xmlTitle As New XElement("TITLE")
        xmlTitle.Add(New XElement("COUNTRY", New XText("AUS"), New XElement("NAME", tbTitle.Text)), New XElement("IMDBR", tbTtId.Text), New XElement("TYPE", cbType.SelectedItem), New XElement("YEAR", tbYear.Text), New XElement("RUNTIME", tbRuntime.Text))
        ' Handle TV discs
        If (cbType.SelectedIndex = 1) Then
            xmlTitle.Add(New XElement("SEASONS", tbSeasons.Text, New XElement("EPISODES", tbEpsiodes.Text)))
        End If
        'Handle Genres
        Dim xmlGenres As New XElement("GENRES")
        For i = 1 To tbGenre.Text.Split(", ").Count
            xmlGenres.Add(New XElement("GENRE", tbGenre.Text.Split(", ")(i - 1).Replace(" ", "").ToUpper))
        Next
        xmlTitle.Add(xmlGenres)
        xmlTitle.Add(New XElement("PLOT", tbPlot.Text))

        xmlToAdd.Add(xmlTitle)
        ' Handle Directors
        Dim xmlDir As New XElement("DIRECTORS")
        xmlDir.Add(New XElement("DIRECTOR", tbDirector1.Text))

        'Handle Writers
        Dim xmlWrit As New XElement("WRITERS")

        For i = 1 To WritCnt
            ' See if there are any roles recorded
            If (Me.pnlMovies.Controls("tbWriter" & i & "_" & i) IsNot Nothing) Then
                xmlWrit.Add(New XElement("WRITER", New XElement("ROLE", Me.pnlMovies.Controls("tbWriter" & i & "_" & i).Text), Me.pnlMovies.Controls("tbWriter" & i).Text))
            ElseIf (Me.pnlMovies.Controls("tbWriter" & i).Enabled) Then
                xmlWrit.Add(New XElement("WRITER", Me.pnlMovies.Controls("tbWriter" & i).Text))
            End If

        Next

        'Handle Actors
        Dim xmlAct As New XElement("ACTORS")

        For i = 1 To ActCnt
            If (Me.pnlMovies.Controls("tbActor" & i).Text <> "") Then
                xmlAct.Add(New XElement("ACTOR", Me.pnlMovies.Controls("tbActor" & i).Text))
            End If

        Next
        ' Clean image name
        Dim imgFile As String

        If (pbPoster.Image IsNot Nothing) Then
            imgFile = tbTitle.Text.ToLower.Replace(" ", "")
            imgFile = imgFile.Replace("?", "")
            imgFile = imgFile.Replace(":  ", "")
            imgFile = imgFile.Replace("/", "")
            imgFile = imgFile.Replace("'", "")
            imgFile = imgFile.Replace("\", "")
            imgFile = imgFile.Replace(",", "")
            imgFile = imgFile.Replace(".", "")
            imgFile = imgFile.Replace("&", "")
        Else
            imgFile = "Unavailable"
        End If

        Dim xmlCopy As New XElement("COPY")
        xmlCopy.Add(New XElement("IDENTIFIER", tbDiscName.Text))
        xmlCopy.Add(New XElement("COPYTYPE", cbSource.SelectedItem))
        xmlCopy.Add(New XElement("FILESIZE", tbFilesize.Text))
        xmlCopy.Add(New XElement("FILETYPE", cbFiletype.SelectedItem))
        xmlCopy.Add(New XElement("DIMX", tbDimX.Text))
        xmlCopy.Add(New XElement("DIMY", tbDimY.Text))
        xmlCopy.Add(New XElement("VBITRATE", tbVBitrate.Text))
        xmlCopy.Add(New XElement("ABITRATE", tbABitrate.Text))
        xmlCopy.Add(New XElement("QF", tbQf.Text))
        xmlCopy.Add(New XElement("LASTWATCHED", dtLastWatched.Value.ToString("dd/MM/yyyy")))
        xmlCopy.Add(New XElement("WATCHEDCOUNT", cbWatched.SelectedItem))
        xmlCopy.Add(New XElement("DATEADDED"))
        xmlCopy.Add(New XElement("DATEENTERED", Now().ToString))
        If cbSubtitles.Checked Then
            xmlCopy.Add(New XElement("SUBTITLES", "Y"))
        Else
            xmlCopy.Add(New XElement("SUBTITLES", "N"))
        End If
        xmlToAdd.Add(New XElement("CREATORS", xmlDir, xmlWrit, xmlAct))

        ' Check that poster has an image
        If (pbPoster.Image IsNot Nothing) Then
            ' Check if file already exists - different movies can have same names - e.g. Anna Karenina
            Dim pstName As String
            pstName = tbImagePath.Text & "\" & imgFile & ".jpg"
            Dim wordy As String = imgFile.Replace(".", "").Replace("!", "").Replace(" ", "").Replace("'", "").Replace("?", "") _
        .Replace(",", "").Replace("-", "").Replace(":", "").Replace("\", "")
            If File.Exists(pstName) Then
                pbPoster.Image.Save(tbImagePath.Text & "\" & wordy & "_" & tbTtId.Text & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                xmlCopy.Add(New XElement("IMAGEFILENAME", wordy & "_" & tbTtId.Text))
            Else
                pbPoster.Image.Save(tbImagePath.Text & "\" & wordy & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                xmlCopy.Add(New XElement("IMAGEFILENAME", wordy))
            End If
            '   Else
            'update record
        End If

        xmlToAdd.Add(xmlCopy)
        ' We have created a full node for the media item

        'Add text to xml file from path. Determine if it's an update or new addition
        If (newmv.update) Then
            elDup.ReplaceWith(xmlToAdd)
        Else
            doc.Element("CATALOG").Add(New XElement(xmlToAdd))
        End If
        doc.Save(tbFilePath.Text & "\" & My.Settings.fileName)

        ' If all data was written successfully, change the button
        btWriteXML.BackColor = Color.AliceBlue
        Me.BackColor = SystemColors.Control
        btWriteXML.Text = "Written"

    End Sub


    ' Compares xmlNode from file to current movie values in GUI
    Private Sub compare(xn As XElement)
        If (String.Compare(tbTitle.Text, xn.<TITLE>...<COUNTRY>...<NAME>.Value) <> 0) Then
            tbTitle.BackColor = Color.Yellow
            tbTitle.Text = ""
            tbTitle.Text += xn.<TITLE>...<COUNTRY>...<NAME>.Value
        End If

        ' Ask operator if they want to update or add record
        Dim result As Integer = MessageBox.Show("Select Yes if you want to replace the existing record, press No if you wish to add a duplicate", "Update or add record", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            btWriteXML.Text = "Write to file"
            newmv.update = False
        ElseIf result = DialogResult.Yes Then
            newmv.update = True
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Dim filePath As String = tbFilePath.Text & "\" & My.Settings.fileName
        Dim xDoc As New XDocument
        xDoc = XDocument.Load(filePath)


        'Dim branchDS As New DataSet
        'branchDS = GridView1.DataSource '  BindingSource1.DataSource
        'branchDS.WriteXml(Replace(filePath, "MEDIA", "newbranch"))
        ''Employee Must match with the element name in 

        ''your file

        'Dim dt As New DataTable("MEDIA")
        'Dim ds As New DataSet()
        'ds.ReadXml(filePath)
        'Try
        '    With GridView1
        '        .DataSource = ds
        '        .DataMember = "branch"
        '        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        '        .AutoSize = True
        '        .EditMode = DataGridViewEditMode.EditOnEnter
        '    End With
        'Catch ex As Exception
        '    MsgBox("Branch XML File Could Not Be Loaded: " & ex.Message)
        'End Try




        'Add Columns in datatable

        'Column names must match XML File nodes



        'Read XML File And Display Data in GridView

        'dt.ReadXml(filePath)

        ' GridView1.DataSource = dt

        '   GridView1.DataBindings


    End Sub


    ''' <summary>
    ''' If user hits Enter key, commence search
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub tbMovieName_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles tbMovieName.KeyPress

        If (Convert.ToInt32(e.KeyChar) = 13) Then
            btSearch_Click(sender, e)
        End If
    End Sub



    Private Sub cbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbType.SelectedIndexChanged
        ' Display furtehr options if TV selected
        If (cbType.SelectedIndex = 1) Then
            lbEpisodes.Visible = True
            lbSeasons.Visible = True
            tbEpsiodes.Visible = True
            tbSeasons.Visible = True
        Else
            lbEpisodes.Visible = False
            lbSeasons.Visible = False
            tbEpsiodes.Visible = False
            tbSeasons.Visible = False
        End If
    End Sub

    Private Sub btClearForm_Click(sender As Object, e As EventArgs) Handles btClearForm.Click
        pnlMovies.Controls.Clear()
    End Sub

    Private Sub pnlMovies_Paint(sender As Object, e As PaintEventArgs) Handles pnlMovies.Paint

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub wbOutput_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbOutput.DocumentCompleted

    End Sub

    Private Sub movieGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
