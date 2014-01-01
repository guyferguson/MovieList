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
        Me.tbTest = New System.Windows.Forms.TextBox()
        CType(Me.pbPoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbMovieName
        '
        Me.tbMovieName.BackColor = System.Drawing.Color.Gold
        Me.tbMovieName.Location = New System.Drawing.Point(219, 35)
        Me.tbMovieName.Name = "tbMovieName"
        Me.tbMovieName.Size = New System.Drawing.Size(156, 20)
        Me.tbMovieName.TabIndex = 0
        Me.tbMovieName.Text = "Ghost World"
        '
        'btSearch
        '
        Me.btSearch.Location = New System.Drawing.Point(388, 34)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(75, 23)
        Me.btSearch.TabIndex = 1
        Me.btSearch.Text = "Search"
        Me.btSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(216, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter movie name"
        '
        'tbFilePath
        '
        Me.tbFilePath.Location = New System.Drawing.Point(689, 28)
        Me.tbFilePath.Name = "tbFilePath"
        Me.tbFilePath.Size = New System.Drawing.Size(255, 20)
        Me.tbFilePath.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(689, 13)
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
        Me.wbOutput.Location = New System.Drawing.Point(613, 121)
        Me.wbOutput.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbOutput.Name = "wbOutput"
        Me.wbOutput.Size = New System.Drawing.Size(344, 275)
        Me.wbOutput.TabIndex = 7
        '
        'tbTtId
        '
        Me.tbTtId.Location = New System.Drawing.Point(62, 10)
        Me.tbTtId.Name = "tbTtId"
        Me.tbTtId.Size = New System.Drawing.Size(128, 20)
        Me.tbTtId.TabIndex = 8
        '
        'lbImdbid
        '
        Me.lbImdbid.AutoSize = True
        Me.lbImdbid.Location = New System.Drawing.Point(12, 13)
        Me.lbImdbid.Name = "lbImdbid"
        Me.lbImdbid.Size = New System.Drawing.Size(48, 13)
        Me.lbImdbid.TabIndex = 9
        Me.lbImdbid.Text = "IMDB ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Title"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Year"
        '
        'tbYear
        '
        Me.tbYear.Location = New System.Drawing.Point(62, 64)
        Me.tbYear.Name = "tbYear"
        Me.tbYear.Size = New System.Drawing.Size(128, 20)
        Me.tbYear.TabIndex = 12
        '
        'tbTitle
        '
        Me.tbTitle.Location = New System.Drawing.Point(62, 37)
        Me.tbTitle.Name = "tbTitle"
        Me.tbTitle.Size = New System.Drawing.Size(128, 20)
        Me.tbTitle.TabIndex = 13
        '
        'tbRuntime
        '
        Me.tbRuntime.Location = New System.Drawing.Point(62, 118)
        Me.tbRuntime.Name = "tbRuntime"
        Me.tbRuntime.Size = New System.Drawing.Size(128, 20)
        Me.tbRuntime.TabIndex = 14
        '
        'tbGenre
        '
        Me.tbGenre.Location = New System.Drawing.Point(62, 91)
        Me.tbGenre.Name = "tbGenre"
        Me.tbGenre.Size = New System.Drawing.Size(128, 20)
        Me.tbGenre.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Runtime"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Genre(s)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Director"
        '
        'tbDirector1
        '
        Me.tbDirector1.Location = New System.Drawing.Point(62, 145)
        Me.tbDirector1.Name = "tbDirector1"
        Me.tbDirector1.Size = New System.Drawing.Size(128, 20)
        Me.tbDirector1.TabIndex = 18
        '
        'lbWriters
        '
        Me.lbWriters.AutoSize = True
        Me.lbWriters.Location = New System.Drawing.Point(227, 86)
        Me.lbWriters.Name = "lbWriters"
        Me.lbWriters.Size = New System.Drawing.Size(35, 13)
        Me.lbWriters.TabIndex = 21
        Me.lbWriters.Text = "Writer"
        '
        'pbPoster
        '
        Me.pbPoster.Location = New System.Drawing.Point(62, 222)
        Me.pbPoster.Name = "pbPoster"
        Me.pbPoster.Size = New System.Drawing.Size(175, 202)
        Me.pbPoster.TabIndex = 22
        Me.pbPoster.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 222)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Poster"
        '
        'tbPlot
        '
        Me.tbPlot.Location = New System.Drawing.Point(271, 222)
        Me.tbPlot.Multiline = True
        Me.tbPlot.Name = "tbPlot"
        Me.tbPlot.Size = New System.Drawing.Size(177, 156)
        Me.tbPlot.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(686, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Path to image file"
        '
        'tbImagePath
        '
        Me.tbImagePath.Location = New System.Drawing.Point(689, 83)
        Me.tbImagePath.Name = "tbImagePath"
        Me.tbImagePath.Size = New System.Drawing.Size(252, 20)
        Me.tbImagePath.TabIndex = 25
        '
        'btWriteXML
        '
        Me.btWriteXML.BackColor = System.Drawing.Color.Chocolate
        Me.btWriteXML.Location = New System.Drawing.Point(523, 22)
        Me.btWriteXML.Name = "btWriteXML"
        Me.btWriteXML.Size = New System.Drawing.Size(122, 44)
        Me.btWriteXML.TabIndex = 27
        Me.btWriteXML.Text = "Write to file"
        Me.btWriteXML.UseVisualStyleBackColor = False
        '
        'lbActors
        '
        Me.lbActors.AutoSize = True
        Me.lbActors.Location = New System.Drawing.Point(424, 89)
        Me.lbActors.Name = "lbActors"
        Me.lbActors.Size = New System.Drawing.Size(32, 13)
        Me.lbActors.TabIndex = 29
        Me.lbActors.Text = "Actor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(260, 399)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Filesize (MB)"
        '
        'tbFilesize
        '
        Me.tbFilesize.Location = New System.Drawing.Point(328, 396)
        Me.tbFilesize.Name = "tbFilesize"
        Me.tbFilesize.Size = New System.Drawing.Size(63, 20)
        Me.tbFilesize.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(260, 425)
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
        Me.cbFiletype.Location = New System.Drawing.Point(327, 422)
        Me.cbFiletype.Name = "cbFiletype"
        Me.cbFiletype.Size = New System.Drawing.Size(64, 21)
        Me.cbFiletype.TabIndex = 35
        '
        'cbSubtitles
        '
        Me.cbSubtitles.AutoSize = True
        Me.cbSubtitles.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbSubtitles.Location = New System.Drawing.Point(15, 180)
        Me.cbSubtitles.Name = "cbSubtitles"
        Me.cbSubtitles.Size = New System.Drawing.Size(66, 17)
        Me.cbSubtitles.TabIndex = 37
        Me.cbSubtitles.Text = "Subtitles"
        Me.cbSubtitles.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(84, 180)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Disc name"
        '
        'tbDiscName
        '
        Me.tbDiscName.Location = New System.Drawing.Point(147, 174)
        Me.tbDiscName.Name = "tbDiscName"
        Me.tbDiscName.Size = New System.Drawing.Size(43, 20)
        Me.tbDiscName.TabIndex = 38
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(216, 181)
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
        Me.cbWatched.Location = New System.Drawing.Point(304, 176)
        Me.cbWatched.Name = "cbWatched"
        Me.cbWatched.Size = New System.Drawing.Size(39, 21)
        Me.cbWatched.TabIndex = 42
        '
        'cbType
        '
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"MOVIE", "TV"})
        Me.cbType.Location = New System.Drawing.Point(388, 176)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(60, 21)
        Me.cbType.TabIndex = 44
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(360, 181)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Type"
        '
        'dtLastWatched
        '
        Me.dtLastWatched.Location = New System.Drawing.Point(589, 416)
        Me.dtLastWatched.Name = "dtLastWatched"
        Me.dtLastWatched.Size = New System.Drawing.Size(131, 20)
        Me.dtLastWatched.TabIndex = 45
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(509, 422)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 13)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Last Watched"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(468, 246)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 13)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "Dim Y"
        '
        'tbDimX
        '
        Me.tbDimX.Location = New System.Drawing.Point(523, 215)
        Me.tbDimX.Name = "tbDimX"
        Me.tbDimX.Size = New System.Drawing.Size(43, 20)
        Me.tbDimX.TabIndex = 47
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(468, 218)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 13)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "Dim X"
        '
        'tbDimY
        '
        Me.tbDimY.Location = New System.Drawing.Point(523, 243)
        Me.tbDimY.Name = "tbDimY"
        Me.tbDimY.Size = New System.Drawing.Size(43, 20)
        Me.tbDimY.TabIndex = 49
        '
        'tbVBitrate
        '
        Me.tbVBitrate.Location = New System.Drawing.Point(523, 271)
        Me.tbVBitrate.Name = "tbVBitrate"
        Me.tbVBitrate.Size = New System.Drawing.Size(43, 20)
        Me.tbVBitrate.TabIndex = 52
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(468, 274)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 13)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "V Bitrate"
        '
        'tbABitrate
        '
        Me.tbABitrate.Location = New System.Drawing.Point(523, 297)
        Me.tbABitrate.Name = "tbABitrate"
        Me.tbABitrate.Size = New System.Drawing.Size(43, 20)
        Me.tbABitrate.TabIndex = 54
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(468, 300)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 13)
        Me.Label19.TabIndex = 53
        Me.Label19.Text = "A Bitrate"
        '
        'tbQf
        '
        Me.tbQf.Location = New System.Drawing.Point(523, 326)
        Me.tbQf.Name = "tbQf"
        Me.tbQf.Size = New System.Drawing.Size(43, 20)
        Me.tbQf.TabIndex = 56
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(468, 329)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(18, 13)
        Me.Label20.TabIndex = 55
        Me.Label20.Text = "Qf"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(468, 358)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(41, 13)
        Me.Label21.TabIndex = 57
        Me.Label21.Text = "Source"
        '
        'cbSource
        '
        Me.cbSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSource.FormattingEnabled = True
        Me.cbSource.Items.AddRange(New Object() {"CAM", "DVDRIP", "R5", "TELESYNC"})
        Me.cbSource.Location = New System.Drawing.Point(523, 355)
        Me.cbSource.Name = "cbSource"
        Me.cbSource.Size = New System.Drawing.Size(84, 21)
        Me.cbSource.TabIndex = 58
        '
        'cbWatchedEver
        '
        Me.cbWatchedEver.AutoSize = True
        Me.cbWatchedEver.Location = New System.Drawing.Point(427, 399)
        Me.cbWatchedEver.Name = "cbWatchedEver"
        Me.cbWatchedEver.Size = New System.Drawing.Size(76, 17)
        Me.cbWatchedEver.TabIndex = 59
        Me.cbWatchedEver.Text = "Watched?"
        Me.cbWatchedEver.UseVisualStyleBackColor = True
        '
        'tbTest
        '
        Me.tbTest.Location = New System.Drawing.Point(952, 164)
        Me.tbTest.Multiline = True
        Me.tbTest.Name = "tbTest"
        Me.tbTest.Size = New System.Drawing.Size(209, 260)
        Me.tbTest.TabIndex = 60
        '
        'movieGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 446)
        Me.Controls.Add(Me.tbTest)
        Me.Controls.Add(Me.cbWatchedEver)
        Me.Controls.Add(Me.cbSource)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.tbQf)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.tbABitrate)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.tbVBitrate)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.tbDimY)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.tbDimX)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dtLastWatched)
        Me.Controls.Add(Me.cbType)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbWatched)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tbDiscName)
        Me.Controls.Add(Me.cbSubtitles)
        Me.Controls.Add(Me.cbFiletype)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbFilesize)
        Me.Controls.Add(Me.lbActors)
        Me.Controls.Add(Me.btWriteXML)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tbImagePath)
        Me.Controls.Add(Me.tbPlot)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.pbPoster)
        Me.Controls.Add(Me.lbWriters)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbDirector1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbGenre)
        Me.Controls.Add(Me.tbRuntime)
        Me.Controls.Add(Me.tbTitle)
        Me.Controls.Add(Me.tbYear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbImdbid)
        Me.Controls.Add(Me.tbTtId)
        Me.Controls.Add(Me.wbOutput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbFilePath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btSearch)
        Me.Controls.Add(Me.tbMovieName)
        Me.Name = "movieGUI"
        CType(Me.pbPoster, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents tbTest As System.Windows.Forms.TextBox

End Class
