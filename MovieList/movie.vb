Imports System.Xml
Imports System.Text
Imports System.Text.RegularExpressions
'Imports System.IO

Public Class Movie

    Private resultSet

    'from a supplied string of xml text, return a list of movie titles 
    '
    ' PRE: Valid XML string
    ' POST: List of possible movie titles


    Public Function showPossibles(xmlText As String)

        If (xmlText.Length < 1) Then
            System.Diagnostics.Debug.WriteLine("Supplied xmltext is null")
            '  Return Nothing
        Else
            '    MsgBox(xmlText)
            '  System.Diagnostics.Debug.WriteLine(xmlText)
            ' Bring the xml  to just the nodes we want - the ImdbEntity nodes
            Dim doc As XDocument
            ' doc = XDocument.Parse(xmlText).<IMDbResults>...<ImdbEntity>
            doc = XDocument.Parse(xmlText)
            System.Diagnostics.Debug.WriteLine(doc)
            '  doc = findXtexts(doc)
            ' MsgBox(findXtexts(doc))
            Return findXtexts(doc)
        End If
        Return Nothing
    End Function
    Private Function findXtexts(doc As XDocument)
        Dim output As String = ""
        Dim cntres As Integer = 0
        Dim apiKey As String

        Dim webcall As String
        apiKey = "15cbdfea"
        System.Diagnostics.Debug.WriteLine(doc)
        'Loop through the xml node and find XTexts
        Dim outputX As New StringBuilder("")
        For Each s In doc.Descendants("result")
            Dim att As XAttribute = s.Attribute("imdbID")
            Dim titX As XAttribute = s.Attribute("title")
            Dim yearX As XAttribute = s.Attribute("year")
            outputX.Equals("")
            webcall = "http://www.omdbapi.com/?i=" & att.Value.ToString & "&apikey=" & apiKey
            '  MsgBox(webcall)
            'Redirect the hyperlink to the imdbapi site to retrieve data based upon IMDB tt
            outputX.Append("<br><b><a href='" & webcall & "'> " & titX.Value.ToString & "</a></b>" & yearX.Value.ToString & "</br>")
            cntres += 1
        Next

        ' Add a prefix of count of results, and return string
        Return "<p>Results :" & cntres & "</p>" & outputX.ToString
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
