Imports System.Xml
Imports System.Text
Imports System.Xml.XPath.Extensions
Imports System.Text.RegularExpressions
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

        ' Bring the xml down to just the nodes we want - the ImdbEntity nodes
        Dim doc = XDocument.Parse(xmlText).<IMDbResults>...<ImdbEntity>

        Return findXtests(doc)
    End Function
    Private Function findXtests(doc As IEnumerable(Of System.Xml.Linq.XElement))
        Dim output As String = ""
        Dim cntres As Integer = 0

        'Loop through the xml node and find XTexts
        For Each s In doc.Nodes().OfType(Of XText)()

            Dim att As XAttribute = s.Parent.Attribute("id")
            'Redirect the hyperlink to the imdbapi site to retrieve data based upon IMDB tt
            output += "<br><b><a href='http://www.imdbapi.com/?i=" & att.Value.ToString & "'> " & s.ToString & "</a></b>" & s.Parent...<Description>.Value & "</br>"
            cntres += 1
        Next

        ' Add a prefix of count of results, and return string
        Return "<p>Results :" & cntres & "</p>" & output.ToString
    End Function

    Private Function CleanInput(strIn As String) As String
        ' Replace invalid characters with empty strings. 
        Try
            Return Regex.Replace(strIn, "[^\w\.@<>-]\ ", "")
            ' If we timeout when replacing invalid characters,  
            ' we should return String.Empty. 
        Catch e As RegexMatchTimeoutException
            Return String.Empty
        End Try
    End Function
End Class
