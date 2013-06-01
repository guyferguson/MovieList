<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.tbResult.Location = New System.Drawing.Point(51, 229)
        Me.tbResult.Multiline = True
        Me.tbResult.Name = "tbResult"
        Me.tbResult.Size = New System.Drawing.Size(365, 176)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 446)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbResult)
        Me.Controls.Add(Me.btSearch)
        Me.Controls.Add(Me.tbMovieName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbMovieName As System.Windows.Forms.TextBox
    Friend WithEvents btSearch As System.Windows.Forms.Button
    Friend WithEvents tbResult As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
