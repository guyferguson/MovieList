<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

    <xsl:template match="@* | node()">
      
        <xsl:apply-templates select="@* | node()"/>
     
    </xsl:template>

  <xsl:template match="MOVIE">
    <MEDIA>
      <xsl:apply-templates select="@* | node()"/>
    </MEDIA>
  </xsl:template>
    
  <xsl:template match="TITLE">
    <TITLE>
      <COUNTRY>
        <xsl:text>AUS</xsl:text>
        <NAME>
          <xsl:value-of select="@NAME"></xsl:value-of>
        </NAME>
      </COUNTRY>
      <IMDBR>
        <xsl:value-of select="@IMDBR"></xsl:value-of>      
      </IMDBR>
      <TYPE>
        <xsl:value-of select="../STATS/@VIDEO"></xsl:value-of>
      </TYPE>
    </TITLE>
  </xsl:template>

  <xsl:template match="WRITERS">
    <CREATORS>
      <DIRECTORS>
          <xsl:copy-of select="../DIRECTOR"/>
         </DIRECTORS>
      <WRITERS>

       
          <WRITER> <ROLE>
            <xsl:copy-of select="*"/>
         </ROLE>  </WRITER>
       
        
      </WRITERS>
      <ACTORS>
          <xsl:copy-of select="../ACTORS/*"/>
      </ACTORS>
    </CREATORS>
  </xsl:template>

  <xsl:template match="STATS">
    <DATA>
      <UNIQUE>
        <YEAR>
          <xsl:value-of select="@YEAR"/>
        </YEAR>
        <RUNTIME>1502
          <xsl:value-of select="@LENGTH"/>          
        </RUNTIME>
        <GENRES>
          <GENRE>
            <xsl:value-of select="@GENRE"/>
          </GENRE>
        </GENRES>
        <xsl:if test="./@VIDEO='TV'">
          <SERIES>
            <SEASON>
              <EPISODES></EPISODES>
            </SEASON>
          </SERIES>
        </xsl:if>
      </UNIQUE>
      <PERSONAL>
        <IDENTIFIER>
          <xsl:value-of select="@MEDIANAME"/>
        </IDENTIFIER>
        <FILESIZE>
          <xsl:value-of select="@FILESIZE"/>
        </FILESIZE>
        <FILETYPE>
          <xsl:value-of select="@FORMAT"/>
        </FILETYPE>
        <DIMX>
          <xsl:value-of select="@DIMX"/>
        </DIMX>
        <DIMY>
          <xsl:value-of select="@DIMY"/>
        </DIMY>
        <VBITRATE>
          <xsl:value-of select="@VBITRATE"/>
        </VBITRATE>
        <ABITRATE>
          <xsl:value-of select="@ABITRATE"/>
        </ABITRATE>
        <QF>
          <xsl:value-of select="@QF"/>
        </QF>
        <LASTWATCHED>
          <xsl:value-of select="@LASTWATCH"/>
        </LASTWATCHED>
        <WATCHEDCOUNT>
          <xsl:value-of select="@WATCHED"/>
        </WATCHEDCOUNT>
        <IMAGEFILENAME>
          <xsl:value-of select="@IMGFLNAME"/>
        </IMAGEFILENAME>
        <DATEADDED>
          <xsl:value-of select="@DTEADDED"/>
        </DATEADDED>
        <SUBTITLES>
          <xsl:value-of select="@SUBTITLES"/>
        </SUBTITLES>
      </PERSONAL>
    </DATA>
    
  </xsl:template>
  
</xsl:stylesheet>
