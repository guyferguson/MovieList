Imports System.Xml
Imports System.Text
Imports System.IO

Public Class Movie

    Private resultSet

    'from a supplied string of xsml text, return a list of movie titles
    '
    ' PRE: Valid XML string
    ' POST: 

    Public Function showPossibles(xmltext)

        Dim output As StringBuilder = New StringBuilder()
        
        Using reader As XmlReader = XmlReader.Create(New StringReader(xmltext))
            While reader.Read()
                If reader.IsEmptyElement Then
                    output.AppendLine(reader.Value & " is an exmply element - how sad" & vbCrLf)
                End If

                reader.ReadToFollowing("Description")

                Dim genre As String = reader.Value
                output.AppendLine("The genre value: " + genre)

                '  reader.ReadToFollowing("Description")
                ' output.AppendLine("Content of the title element: " + reader.ReadElementContentAsString())
            End While

        End Using

        Return output.ToString()

    End Function

End Class
