Imports System.Xml
Imports System.Text
Imports System.Xml.XPath.Extensions
Imports System.IO

Public Class Movie

    Private resultSet

    'from a supplied string of xsml text, return a list of movie titles 
    '
    ' PRE: Valid XML string
    ' POST: List of possible movie titles

    Public Function showPossibles(xmlText As String)

        If (xmltext.Length = 0) Then
            MsgBox("Supplied xmltext is null")
            Return Nothing
        End If
        Dim output As StringBuilder = New StringBuilder()
        Using xr As XmlReader = XmlReader.Create(New StringReader(xmlText))


            ' Parse the file and display each of the nodes.

            xr.ReadToFollowing("Description")

            xr.ReadElementContentAsString()
            If Not (xr.IsEmptyElement) Then
                output.AppendLine(xr.Value)
            End If


        End Using
        Return output.ToString








        'Dim myMovies As XElement = XElement.Parse(xmlText)
        ''   Dim res = myMovies.Elements("ImdbEntity")
        'Dim list2 As IEnumerable(Of XElement) = myMovies.XPathSelectElements("//ImdbEntity [2]")
        '' Dim titles = <t><%= From title In myMovies.Elements _
        ''                       Select title.Elements("ImdbEntity").FirstOrDefault
        ''                 %></t>


        'Dim take As String = ""

        ''Dim temp As StringBuilder = New StringBuilder(titles.ToString)
        'Dim temp As String = ""
        'For Each i In list2
        '    MsgBox(i)
        '    temp = temp & i.Value
        'Next
        'Dim p As String = ""
        '' For Each hap In res
        ''p = p + hap.ToString
        ''  Next hap

        'Return temp.ToString


    End Function

    Private Function phoneTypes() As Object
        Throw New NotImplementedException
    End Function

End Class
