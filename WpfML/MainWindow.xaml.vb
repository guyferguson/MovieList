'add using statements for LINQ
Imports System.Xml
Imports System.Xml.Linq

Class MainWindow

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Load XML file and set the DataGrid data context
        Dim myMovies As XElement = XElement.Load("Z:\xml\movies\MovieListv2.xml")
        dg1.DataContext = myMovies.Elements("MEDIA")

    End Sub

End Class
