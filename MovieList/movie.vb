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
        '    Dim doc = _
        '             <ImdbEntity id="tt1190080">2012
        '		<Description>2009/I,     
        '			<a href='/name/nm0000386/'>Roland Emmerich
        '			</a>
        '                </Description>
        '           </ImdbEntity>


        Dim output As String = ""

        Dim doc = XDocument.Parse(xmlText).<IMDbResults>...<ImdbEntity>

            
      
        For Each s In doc.Nodes().OfType(Of XText)()

            Dim att As XAttribute = s.Parent.Attribute("id")

            output += "<br><b><a href='http://www.imdb.com/title/" & att.Value.ToString & "'> " & s.ToString & "</a></b>" & s.Parent...<Description>.Value & "</br>"
            MsgBox(output)
        Next


        '   output = "Name of root element is " & root.Name.ToString
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
