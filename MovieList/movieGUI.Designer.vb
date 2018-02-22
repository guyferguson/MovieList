<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class movieGUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbMovieName = New System.Windows.Forms.TextBox()
        Me.btSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbFilePath = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fbFilePath = New System.Windows.Forms.FolderBrowserDialog()
        Me.wbOutput = New System.Windows.Forms.WebBrowser()
        Me.tbTtId = New System.Windows.Forms.TextBox()
        Me.lbImdbid = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbYear = New System.Windows.Forms.TextBox()
        Me.tbTitle = New System.Windows.Forms.TextBox()
        Me.tbRuntime = New System.Windows.Forms.TextBox()
        Me.tbGenre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbDirector1 = New System.Windows.Forms.TextBox()
        Me.lbWriters = New System.Windows.Forms.Label()
        Me.pbPoster = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbPlot = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbImagePath = New System.Windows.Forms.TextBox()
        Me.btWriteXML = New System.Windows.Forms.Button()
        Me.lbActors = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbFilesize = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbFiletype = New System.Windows.Forms.ComboBox()
        Me.cbSubtitles = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbDiscName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbWatched = New System.Windows.Forms.ComboBox()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtLastWatched = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbDimX = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbDimY = New System.Windows.Forms.TextBox()
        Me.tbVBitrate = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbABitrate = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbQf = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbSource = New System.Windows.Forms.ComboBox()
        Me.cbWatchedEver = New System.Windows.Forms.CheckBox()
        Me.btViewAll = New System.Windows.Forms.Button()
        Me.tbSeasons = New System.Windows.Forms.TextBox()
        Me.tbEpsiodes = New System.Windows.Forms.TextBox()
        Me.lbSeasons = New System.Windows.Forms.Label()
        Me.lbEpisodes = New System.Windows.Forms.Label()
        Me.pnlMovies = New System.Windows.Forms.Panel()
        Me.lbTotalEp = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tbTotalEpisodes = New System.Windows.Forms.TextBox()
        Me.pnlExistingEp = New System.Windows.Forms.Panel()
        Me.lbExistingEp = New System.Windows.Forms.Label()
        Me.lbVersion = New System.Windows.Forms.Label()
        Me.lbFreeSpace = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.btUploadToWeb = New System.Windows.Forms.Button()
        Me.btClearForm = New System.Windows.Forms.Button()
        CType(Me.pbPoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMovies.SuspendLayout()
        Me.pnlExistingEp.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbMovieName
        '
        Me.tbMovieName.BackColor = System.Drawing.Color.Gold
        Me.tbMovieName.Location = New System.Drawing.Point(290, 27)
        Me.tbMovieName.Name = "tbMovieName"
        Me.tbMovieName.Size = New System.Drawing.Size(156, 20)
        Me.tbMovieName.TabIndex = 0
        Me.tbMovieName.Text = "Ghost World"
        '
        'btSearch
        '
        Me.btSearch.Location = New System.Drawing.Point(454, 28)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(75, 23)
        Me.btSearch.TabIndex = 1
        Me.btSearch.Text = "Search"
        Me.btSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(243, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter movie name"
        '
        'tbFilePath
        '
        Me.tbFilePath.Location = New System.Drawing.Point(716, 22)
        Me.tbFilePath.Name = "tbFilePath"
        Me.tbFilePath.Size = New System.Drawing.Size(255, 20)
        Me.tbFilePath.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(716, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Path to XML file"
        '
        'fbFilePath
        '
        Me.fbFilePath.SelectedPath = "my.settings.filePath"
        '
        'wbOutput
        '
        Me.wbOutput.AllowWebBrowserDrop = False
        Me.wbOutput.CausesValidation = False
        Me.wbOutput.Location = New System.Drawing.Point(604, 228)
        Me.wbOutput.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbOutput.Name = "wbOutput"
        Me.wbOutput.ScriptErrorsSuppressed = True
        Me.wbOutput.Size = New System.Drawing.Size(298, 275)
        Me.wbOutput.TabIndex = 7
        '
        'tbTtId
        '
        Me.tbTtId.Location = New System.Drawing.Point(63, 9)
        Me.tbTtId.Name = "tbTtId"
        Me.tbTtId.Size = New System.Drawing.Size(128, 20)
        Me.tbTtId.TabIndex = 8
        '
        'lbImdbid
        '
        Me.lbImdbid.AutoSize = True
        Me.lbImdbid.Location = New System.Drawing.Point(13, 12)
        Me.lbImdbid.Name = "lbImdbid"
        Me.lbImdbid.Size = New System.Drawing.Size(48, 13)
        Me.lbImdbid.TabIndex = 9
        Me.lbImdbid.Text = "IMDB ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Title"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Year"
        '
        'tbYear
        '
        Me.tbYear.Location = New System.Drawing.Point(63, 63)
        Me.tbYear.Name = "tbYear"
        Me.tbYear.Size = New System.Drawing.Size(128, 20)
        Me.tbYear.TabIndex = 12
        '
        'tbTitle
        '
        Me.tbTitle.Location = New System.Drawing.Point(63, 36)
        Me.tbTitle.Name = "tbTitle"
        Me.tbTitle.Size = New System.Drawing.Size(185, 20)
        Me.tbTitle.TabIndex = 13
        '
        'tbRuntime
        '
        Me.tbRuntime.Location = New System.Drawing.Point(63, 117)
        Me.tbRuntime.Name = "tbRuntime"
        Me.tbRuntime.Size = New System.Drawing.Size(128, 20)
        Me.tbRuntime.TabIndex = 14
        '
        'tbGenre
        '
        Me.tbGenre.Location = New System.Drawing.Point(63, 90)
        Me.tbGenre.Name = "tbGenre"
        Me.tbGenre.Size = New System.Drawing.Size(128, 20)
        Me.tbGenre.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Runtime"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Genre(s)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Director"
        '
        'tbDirector1
        '
        Me.tbDirector1.Location = New System.Drawing.Point(63, 144)
        Me.tbDirector1.Name = "tbDirector1"
        Me.tbDirector1.Size = New System.Drawing.Size(128, 20)
        Me.tbDirector1.TabIndex = 18
        '
        'lbWriters
        '
        Me.lbWriters.AutoSize = True
        Me.lbWriters.Location = New System.Drawing.Point(213, 93)
        Me.lbWriters.Name = "lbWriters"
        Me.lbWriters.Size = New System.Drawing.Size(35, 13)
        Me.lbWriters.TabIndex = 21
        Me.lbWriters.Text = "Writer"
        '
        'pbPoster
        '
        Me.pbPoster.Location = New System.Drawing.Point(16, 315)
        Me.pbPoster.Name = "pbPoster"
        Me.pbPoster.Size = New System.Drawing.Size(175, 202)
        Me.pbPoster.TabIndex = 22
        Me.pbPoster.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 279)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Poster"
        '
        'tbPlot
        '
        Me.tbPlot.Location = New System.Drawing.Point(225, 315)
        Me.tbPlot.Multiline = True
        Me.tbPlot.Name = "tbPlot"
        Me.tbPlot.Size = New System.Drawing.Size(177, 156)
        Me.tbPlot.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(716, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Path to image file"
        '
        'tbImagePath
        '
        Me.tbImagePath.Location = New System.Drawing.Point(719, 73)
        Me.tbImagePath.Name = "tbImagePath"
        Me.tbImagePath.Size = New System.Drawing.Size(252, 20)
        Me.tbImagePath.TabIndex = 25
        '
        'btWriteXML
        '
        Me.btWriteXML.BackColor = System.Drawing.Color.Chocolate
        Me.btWriteXML.Location = New System.Drawing.Point(550, 16)
        Me.btWriteXML.Name = "btWriteXML"
        Me.btWriteXML.Size = New System.Drawing.Size(122, 44)
        Me.btWriteXML.TabIndex = 27
        Me.btWriteXML.Text = "Write to file"
        Me.btWriteXML.UseVisualStyleBackColor = False
        '
        'lbActors
        '
        Me.lbActors.AutoSize = True
        Me.lbActors.Location = New System.Drawing.Point(437, 93)
        Me.lbActors.Name = "lbActors"
        Me.lbActors.Size = New System.Drawing.Size(32, 13)
        Me.lbActors.TabIndex = 29
        Me.lbActors.Text = "Actor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(214, 492)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Filesize (MB)"
        '
        'tbFilesize
        '
        Me.tbFilesize.Location = New System.Drawing.Point(282, 489)
        Me.tbFilesize.Name = "tbFilesize"
        Me.tbFilesize.Size = New System.Drawing.Size(63, 20)
        Me.tbFilesize.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(214, 518)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "FileType"
        '
        'cbFiletype
        '
        Me.cbFiletype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFiletype.FormattingEnabled = True
        Me.cbFiletype.Items.AddRange(New Object() {"AVI", "BIN", "DIVX", "DVD", "MKV", "MP4", "XVID"})
        Me.cbFiletype.Location = New System.Drawing.Point(281, 515)
        Me.cbFiletype.Name = "cbFiletype"
        Me.cbFiletype.Size = New System.Drawing.Size(64, 21)
        Me.cbFiletype.TabIndex = 35
        '
        'cbSubtitles
        '
        Me.cbSubtitles.AutoSize = True
        Me.cbSubtitles.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbSubtitles.Location = New System.Drawing.Point(13, 210)
        Me.cbSubtitles.Name = "cbSubtitles"
        Me.cbSubtitles.Size = New System.Drawing.Size(66, 17)
        Me.cbSubtitles.TabIndex = 37
        Me.cbSubtitles.Text = "Subtitles"
        Me.cbSubtitles.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(82, 210)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Disc name"
        '
        'tbDiscName
        '
        Me.tbDiscName.Location = New System.Drawing.Point(145, 204)
        Me.tbDiscName.Name = "tbDiscName"
        Me.tbDiscName.Size = New System.Drawing.Size(43, 20)
        Me.tbDiscName.TabIndex = 38
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 245)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Times Watched"
        '
        'cbWatched
        '
        Me.cbWatched.DisplayMember = "0"
        Me.cbWatched.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWatched.FormattingEnabled = True
        Me.cbWatched.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "SAD"})
        Me.cbWatched.Location = New System.Drawing.Point(104, 240)
        Me.cbWatched.Name = "cbWatched"
        Me.cbWatched.Size = New System.Drawing.Size(39, 21)
        Me.cbWatched.TabIndex = 42
        '
        'cbType
        '
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"MOVIE", "TV"})
        Me.cbType.Location = New System.Drawing.Point(65, 176)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(60, 21)
        Me.cbType.TabIndex = 44
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 181)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Type"
        '
        'dtLastWatched
        '
        Me.dtLastWatched.Location = New System.Drawing.Point(454, 512)
        Me.dtLastWatched.Name = "dtLastWatched"
        Me.dtLastWatched.Size = New System.Drawing.Size(131, 20)
        Me.dtLastWatched.TabIndex = 45
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(374, 518)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 13)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Last Watched"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(422, 339)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 13)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "Dim Y"
        '
        'tbDimX
        '
        Me.tbDimX.Location = New System.Drawing.Point(477, 308)
        Me.tbDimX.Name = "tbDimX"
        Me.tbDimX.Size = New System.Drawing.Size(43, 20)
        Me.tbDimX.TabIndex = 47
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(422, 311)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 13)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "Dim X"
        '
        'tbDimY
        '
        Me.tbDimY.Location = New System.Drawing.Point(477, 336)
        Me.tbDimY.Name = "tbDimY"
        Me.tbDimY.Size = New System.Drawing.Size(43, 20)
        Me.tbDimY.TabIndex = 49
        '
        'tbVBitrate
        '
        Me.tbVBitrate.Location = New System.Drawing.Point(477, 364)
        Me.tbVBitrate.Name = "tbVBitrate"
        Me.tbVBitrate.Size = New System.Drawing.Size(43, 20)
        Me.tbVBitrate.TabIndex = 52
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(422, 367)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 13)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "V Bitrate"
        '
        'tbABitrate
        '
        Me.tbABitrate.Location = New System.Drawing.Point(477, 390)
        Me.tbABitrate.Name = "tbABitrate"
        Me.tbABitrate.Size = New System.Drawing.Size(43, 20)
        Me.tbABitrate.TabIndex = 54
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(422, 393)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 13)
        Me.Label19.TabIndex = 53
        Me.Label19.Text = "A Bitrate"
        '
        'tbQf
        '
        Me.tbQf.Location = New System.Drawing.Point(477, 419)
        Me.tbQf.Name = "tbQf"
        Me.tbQf.Size = New System.Drawing.Size(43, 20)
        Me.tbQf.TabIndex = 56
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(422, 422)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(18, 13)
        Me.Label20.TabIndex = 55
        Me.Label20.Text = "Qf"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(422, 451)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(41, 13)
        Me.Label21.TabIndex = 57
        Me.Label21.Text = "Source"
        '
        'cbSource
        '
        Me.cbSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSource.FormattingEnabled = True
        Me.cbSource.Items.AddRange(New Object() {"BLU-RAY", "CAM", "DVDRIP", "R5", "TELESYNC"})
        Me.cbSource.Location = New System.Drawing.Point(477, 448)
        Me.cbSource.Name = "cbSource"
        Me.cbSource.Size = New System.Drawing.Size(84, 21)
        Me.cbSource.TabIndex = 58
        '
        'cbWatchedEver
        '
        Me.cbWatchedEver.AutoSize = True
        Me.cbWatchedEver.Location = New System.Drawing.Point(381, 492)
        Me.cbWatchedEver.Name = "cbWatchedEver"
        Me.cbWatchedEver.Size = New System.Drawing.Size(76, 17)
        Me.cbWatchedEver.TabIndex = 59
        Me.cbWatchedEver.Text = "Watched?"
        Me.cbWatchedEver.UseVisualStyleBackColor = True
        '
        'btViewAll
        '
        Me.btViewAll.Location = New System.Drawing.Point(998, 12)
        Me.btViewAll.Name = "btViewAll"
        Me.btViewAll.Size = New System.Drawing.Size(114, 38)
        Me.btViewAll.TabIndex = 61
        Me.btViewAll.Text = "Edit All"
        Me.btViewAll.UseVisualStyleBackColor = True
        '
        'tbSeasons
        '
        Me.tbSeasons.Location = New System.Drawing.Point(855, 111)
        Me.tbSeasons.Name = "tbSeasons"
        Me.tbSeasons.Size = New System.Drawing.Size(116, 20)
        Me.tbSeasons.TabIndex = 62
        Me.tbSeasons.Visible = False
        '
        'tbEpsiodes
        '
        Me.tbEpsiodes.Location = New System.Drawing.Point(855, 136)
        Me.tbEpsiodes.Name = "tbEpsiodes"
        Me.tbEpsiodes.Size = New System.Drawing.Size(116, 20)
        Me.tbEpsiodes.TabIndex = 63
        Me.tbEpsiodes.Visible = False
        '
        'lbSeasons
        '
        Me.lbSeasons.AutoSize = True
        Me.lbSeasons.Location = New System.Drawing.Point(786, 119)
        Me.lbSeasons.Name = "lbSeasons"
        Me.lbSeasons.Size = New System.Drawing.Size(54, 13)
        Me.lbSeasons.TabIndex = 64
        Me.lbSeasons.Text = "Season(s)"
        Me.lbSeasons.Visible = False
        '
        'lbEpisodes
        '
        Me.lbEpisodes.AutoSize = True
        Me.lbEpisodes.Location = New System.Drawing.Point(918, 146)
        Me.lbEpisodes.Name = "lbEpisodes"
        Me.lbEpisodes.Size = New System.Drawing.Size(56, 13)
        Me.lbEpisodes.TabIndex = 65
        Me.lbEpisodes.Text = "Episode(s)"
        Me.lbEpisodes.Visible = False
        '
        'pnlMovies
        '
        Me.pnlMovies.Controls.Add(Me.lbTotalEp)
        Me.pnlMovies.Controls.Add(Me.Label23)
        Me.pnlMovies.Controls.Add(Me.tbTotalEpisodes)
        Me.pnlMovies.Controls.Add(Me.pnlExistingEp)
        Me.pnlMovies.Controls.Add(Me.lbVersion)
        Me.pnlMovies.Controls.Add(Me.lbFreeSpace)
        Me.pnlMovies.Controls.Add(Me.Label22)
        Me.pnlMovies.Controls.Add(Me.CheckedListBox1)
        Me.pnlMovies.Controls.Add(Me.btUploadToWeb)
        Me.pnlMovies.Controls.Add(Me.btClearForm)
        Me.pnlMovies.Controls.Add(Me.tbTtId)
        Me.pnlMovies.Controls.Add(Me.lbImdbid)
        Me.pnlMovies.Controls.Add(Me.Label9)
        Me.pnlMovies.Controls.Add(Me.lbSeasons)
        Me.pnlMovies.Controls.Add(Me.cbWatchedEver)
        Me.pnlMovies.Controls.Add(Me.Label3)
        Me.pnlMovies.Controls.Add(Me.cbSource)
        Me.pnlMovies.Controls.Add(Me.tbEpsiodes)
        Me.pnlMovies.Controls.Add(Me.Label21)
        Me.pnlMovies.Controls.Add(Me.Label4)
        Me.pnlMovies.Controls.Add(Me.tbQf)
        Me.pnlMovies.Controls.Add(Me.tbSeasons)
        Me.pnlMovies.Controls.Add(Me.Label20)
        Me.pnlMovies.Controls.Add(Me.tbYear)
        Me.pnlMovies.Controls.Add(Me.tbABitrate)
        Me.pnlMovies.Controls.Add(Me.btViewAll)
        Me.pnlMovies.Controls.Add(Me.Label19)
        Me.pnlMovies.Controls.Add(Me.tbTitle)
        Me.pnlMovies.Controls.Add(Me.tbVBitrate)
        Me.pnlMovies.Controls.Add(Me.tbRuntime)
        Me.pnlMovies.Controls.Add(Me.Label18)
        Me.pnlMovies.Controls.Add(Me.tbGenre)
        Me.pnlMovies.Controls.Add(Me.Label17)
        Me.pnlMovies.Controls.Add(Me.Label5)
        Me.pnlMovies.Controls.Add(Me.tbDimY)
        Me.pnlMovies.Controls.Add(Me.Label6)
        Me.pnlMovies.Controls.Add(Me.Label16)
        Me.pnlMovies.Controls.Add(Me.tbDirector1)
        Me.pnlMovies.Controls.Add(Me.tbDimX)
        Me.pnlMovies.Controls.Add(Me.Label7)
        Me.pnlMovies.Controls.Add(Me.Label15)
        Me.pnlMovies.Controls.Add(Me.tbFilePath)
        Me.pnlMovies.Controls.Add(Me.dtLastWatched)
        Me.pnlMovies.Controls.Add(Me.tbMovieName)
        Me.pnlMovies.Controls.Add(Me.cbFiletype)
        Me.pnlMovies.Controls.Add(Me.cbType)
        Me.pnlMovies.Controls.Add(Me.Label11)
        Me.pnlMovies.Controls.Add(Me.btSearch)
        Me.pnlMovies.Controls.Add(Me.Label8)
        Me.pnlMovies.Controls.Add(Me.Label14)
        Me.pnlMovies.Controls.Add(Me.tbFilesize)
        Me.pnlMovies.Controls.Add(Me.Label1)
        Me.pnlMovies.Controls.Add(Me.tbPlot)
        Me.pnlMovies.Controls.Add(Me.cbWatched)
        Me.pnlMovies.Controls.Add(Me.Label2)
        Me.pnlMovies.Controls.Add(Me.pbPoster)
        Me.pnlMovies.Controls.Add(Me.Label13)
        Me.pnlMovies.Controls.Add(Me.btWriteXML)
        Me.pnlMovies.Controls.Add(Me.Label12)
        Me.pnlMovies.Controls.Add(Me.tbImagePath)
        Me.pnlMovies.Controls.Add(Me.tbDiscName)
        Me.pnlMovies.Controls.Add(Me.cbSubtitles)
        Me.pnlMovies.Controls.Add(Me.lbWriters)
        Me.pnlMovies.Controls.Add(Me.Label10)
        Me.pnlMovies.Controls.Add(Me.lbActors)
        Me.pnlMovies.Controls.Add(Me.wbOutput)
        Me.pnlMovies.Location = New System.Drawing.Point(31, 12)
        Me.pnlMovies.Name = "pnlMovies"
        Me.pnlMovies.Size = New System.Drawing.Size(1130, 565)
        Me.pnlMovies.TabIndex = 66
        '
        'lbTotalEp
        '
        Me.lbTotalEp.AutoSize = True
        Me.lbTotalEp.Location = New System.Drawing.Point(745, 165)
        Me.lbTotalEp.Name = "lbTotalEp"
        Me.lbTotalEp.Size = New System.Drawing.Size(104, 13)
        Me.lbTotalEp.TabIndex = 74
        Me.lbTotalEp.Text = "Episode(s) in season"
        Me.lbTotalEp.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(737, 143)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(112, 13)
        Me.Label23.TabIndex = 73
        Me.Label23.Text = "Episode(s) on this disk"
        Me.Label23.Visible = False
        '
        'tbTotalEpisodes
        '
        Me.tbTotalEpisodes.Location = New System.Drawing.Point(855, 162)
        Me.tbTotalEpisodes.Name = "tbTotalEpisodes"
        Me.tbTotalEpisodes.Size = New System.Drawing.Size(27, 20)
        Me.tbTotalEpisodes.TabIndex = 72
        Me.tbTotalEpisodes.Visible = False
        '
        'pnlExistingEp
        '
        Me.pnlExistingEp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlExistingEp.Controls.Add(Me.lbExistingEp)
        Me.pnlExistingEp.Location = New System.Drawing.Point(985, 104)
        Me.pnlExistingEp.Name = "pnlExistingEp"
        Me.pnlExistingEp.Size = New System.Drawing.Size(136, 149)
        Me.pnlExistingEp.TabIndex = 71
        Me.pnlExistingEp.Visible = False
        '
        'lbExistingEp
        '
        Me.lbExistingEp.AutoSize = True
        Me.lbExistingEp.Location = New System.Drawing.Point(3, 11)
        Me.lbExistingEp.Name = "lbExistingEp"
        Me.lbExistingEp.Size = New System.Drawing.Size(64, 13)
        Me.lbExistingEp.TabIndex = 0
        Me.lbExistingEp.Text = "Pre-existing "
        '
        'lbVersion
        '
        Me.lbVersion.AutoSize = True
        Me.lbVersion.Location = New System.Drawing.Point(992, 537)
        Me.lbVersion.Name = "lbVersion"
        Me.lbVersion.Size = New System.Drawing.Size(153, 13)
        Me.lbVersion.TabIndex = 70
        Me.lbVersion.Text = "14.0.23107.0 built by: D14REL"
        '
        'lbFreeSpace
        '
        Me.lbFreeSpace.AutoSize = True
        Me.lbFreeSpace.Location = New System.Drawing.Point(725, 43)
        Me.lbFreeSpace.Name = "lbFreeSpace"
        Me.lbFreeSpace.Size = New System.Drawing.Size(0, 13)
        Me.lbFreeSpace.TabIndex = 69
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(982, 256)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 13)
        Me.Label22.TabIndex = 68
        Me.Label22.Text = "Episodes"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(988, 272)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(46, 259)
        Me.CheckedListBox1.TabIndex = 67
        '
        'btUploadToWeb
        '
        Me.btUploadToWeb.BackColor = System.Drawing.Color.DarkOrange
        Me.btUploadToWeb.Location = New System.Drawing.Point(550, 67)
        Me.btUploadToWeb.Name = "btUploadToWeb"
        Me.btUploadToWeb.Size = New System.Drawing.Size(122, 39)
        Me.btUploadToWeb.TabIndex = 66
        Me.btUploadToWeb.Text = "Upload via FTP"
        Me.btUploadToWeb.UseVisualStyleBackColor = False
        '
        'btClearForm
        '
        Me.btClearForm.Location = New System.Drawing.Point(684, 119)
        Me.btClearForm.Name = "btClearForm"
        Me.btClearForm.Size = New System.Drawing.Size(75, 23)
        Me.btClearForm.TabIndex = 65
        Me.btClearForm.Text = "Clear All"
        Me.btClearForm.UseVisualStyleBackColor = True
        '
        'movieGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 596)
        Me.Controls.Add(Me.pnlMovies)
        Me.Controls.Add(Me.lbEpisodes)
        Me.Name = "movieGUI"
        CType(Me.pbPoster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMovies.ResumeLayout(False)
        Me.pnlMovies.PerformLayout()
        Me.pnlExistingEp.ResumeLayout(False)
        Me.pnlExistingEp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbMovieName As System.Windows.Forms.TextBox
    Friend WithEvents btSearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbFilePath As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fbFilePath As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents wbOutput As System.Windows.Forms.WebBrowser
    Friend WithEvents tbTtId As System.Windows.Forms.TextBox
    Friend WithEvents lbImdbid As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbYear As System.Windows.Forms.TextBox
    Friend WithEvents tbTitle As System.Windows.Forms.TextBox
    Friend WithEvents tbRuntime As System.Windows.Forms.TextBox
    Friend WithEvents tbGenre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbDirector1 As System.Windows.Forms.TextBox
    Friend WithEvents lbWriters As System.Windows.Forms.Label
    Friend WithEvents pbPoster As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbPlot As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbImagePath As System.Windows.Forms.TextBox
    Friend WithEvents btWriteXML As System.Windows.Forms.Button
    Friend WithEvents lbActors As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbFilesize As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbFiletype As System.Windows.Forms.ComboBox
    Friend WithEvents cbSubtitles As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbDiscName As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbWatched As System.Windows.Forms.ComboBox
    Friend WithEvents cbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtLastWatched As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tbDimX As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tbDimY As System.Windows.Forms.TextBox
    Friend WithEvents tbVBitrate As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tbABitrate As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tbQf As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cbSource As System.Windows.Forms.ComboBox
    Friend WithEvents cbWatchedEver As System.Windows.Forms.CheckBox
    Friend WithEvents btViewAll As System.Windows.Forms.Button
    Friend WithEvents tbSeasons As System.Windows.Forms.TextBox
    Friend WithEvents tbEpsiodes As System.Windows.Forms.TextBox
    Friend WithEvents lbSeasons As System.Windows.Forms.Label
    Friend WithEvents lbEpisodes As System.Windows.Forms.Label
    Friend WithEvents pnlMovies As System.Windows.Forms.Panel
    Friend WithEvents btClearForm As System.Windows.Forms.Button
    Friend WithEvents btUploadToWeb As System.Windows.Forms.Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Label22 As Label
    Friend WithEvents lbFreeSpace As Label
    Friend WithEvents lbVersion As Label
    Friend WithEvents pnlExistingEp As Panel
    Friend WithEvents lbExistingEp As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents tbTotalEpisodes As TextBox
    Friend WithEvents lbTotalEp As Label
End Class
