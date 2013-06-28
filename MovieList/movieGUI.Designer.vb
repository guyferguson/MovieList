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
        Me.tbImdbid = New System.Windows.Forms.TextBox()
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
        Me.tbDirector = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tbMovieName
        '
        Me.tbMovieName.Location = New System.Drawing.Point(316, 120)
        Me.tbMovieName.Name = "tbMovieName"
        Me.tbMovieName.Size = New System.Drawing.Size(100, 20)
        Me.tbMovieName.TabIndex = 0
        '
        'btSearch
        '
        Me.btSearch.Location = New System.Drawing.Point(330, 171)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(75, 23)
        Me.btSearch.TabIndex = 1
        Me.btSearch.Text = "Search"
        Me.btSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(218, 127)
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
        Me.wbOutput.Location = New System.Drawing.Point(499, 68)
        Me.wbOutput.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbOutput.Name = "wbOutput"
        Me.wbOutput.Size = New System.Drawing.Size(458, 348)
        Me.wbOutput.TabIndex = 7
        '
        'tbImdbid
        '
        Me.tbImdbid.Location = New System.Drawing.Point(62, 10)
        Me.tbImdbid.Name = "tbImdbid"
        Me.tbImdbid.Size = New System.Drawing.Size(100, 20)
        Me.tbImdbid.TabIndex = 8
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
        Me.Label3.Location = New System.Drawing.Point(12, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Title"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Year"
        '
        'tbYear
        '
        Me.tbYear.Location = New System.Drawing.Point(62, 61)
        Me.tbYear.Name = "tbYear"
        Me.tbYear.Size = New System.Drawing.Size(100, 20)
        Me.tbYear.TabIndex = 12
        '
        'tbTitle
        '
        Me.tbTitle.Location = New System.Drawing.Point(62, 35)
        Me.tbTitle.Name = "tbTitle"
        Me.tbTitle.Size = New System.Drawing.Size(100, 20)
        Me.tbTitle.TabIndex = 13
        '
        'tbRuntime
        '
        Me.tbRuntime.Location = New System.Drawing.Point(62, 120)
        Me.tbRuntime.Name = "tbRuntime"
        Me.tbRuntime.Size = New System.Drawing.Size(100, 20)
        Me.tbRuntime.TabIndex = 14
        '
        'tbGenre
        '
        Me.tbGenre.Location = New System.Drawing.Point(62, 87)
        Me.tbGenre.Name = "tbGenre"
        Me.tbGenre.Size = New System.Drawing.Size(100, 20)
        Me.tbGenre.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Runtime"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Genre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Director"
        '
        'tbDirector
        '
        Me.tbDirector.Location = New System.Drawing.Point(62, 146)
        Me.tbDirector.Name = "tbDirector"
        Me.tbDirector.Size = New System.Drawing.Size(100, 20)
        Me.tbDirector.TabIndex = 18
        '
        'movieGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 446)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbDirector)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbGenre)
        Me.Controls.Add(Me.tbRuntime)
        Me.Controls.Add(Me.tbTitle)
        Me.Controls.Add(Me.tbYear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbImdbid)
        Me.Controls.Add(Me.tbImdbid)
        Me.Controls.Add(Me.wbOutput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbFilePath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btSearch)
        Me.Controls.Add(Me.tbMovieName)
        Me.Name = "movieGUI"
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
    Friend WithEvents tbImdbid As System.Windows.Forms.TextBox
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
    Friend WithEvents tbDirector As System.Windows.Forms.TextBox

End Class
