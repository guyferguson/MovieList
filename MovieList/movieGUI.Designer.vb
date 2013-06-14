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
        Me.tbResult = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbOriginal = New System.Windows.Forms.TextBox()
        Me.tbFilePath = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fbFilePath = New System.Windows.Forms.FolderBrowserDialog()
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
        'tbResult
        '
        Me.tbResult.Location = New System.Drawing.Point(528, 231)
        Me.tbResult.Multiline = True
        Me.tbResult.Name = "tbResult"
        Me.tbResult.Size = New System.Drawing.Size(439, 176)
        Me.tbResult.TabIndex = 2
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
        'tbOriginal
        '
        Me.tbOriginal.Location = New System.Drawing.Point(54, 231)
        Me.tbOriginal.Multiline = True
        Me.tbOriginal.Name = "tbOriginal"
        Me.tbOriginal.Size = New System.Drawing.Size(439, 176)
        Me.tbOriginal.TabIndex = 4
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 446)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbFilePath)
        Me.Controls.Add(Me.tbOriginal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbResult)
        Me.Controls.Add(Me.btSearch)
        Me.Controls.Add(Me.tbMovieName)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbMovieName As System.Windows.Forms.TextBox
    Friend WithEvents btSearch As System.Windows.Forms.Button
    Friend WithEvents tbResult As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbOriginal As System.Windows.Forms.TextBox
    Friend WithEvents tbFilePath As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fbFilePath As System.Windows.Forms.FolderBrowserDialog

End Class
