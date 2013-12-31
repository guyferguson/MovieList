<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
>
    <xsl:output method="xml" indent="yes"/>
  <xsl:template match="/">
    <CATALOG>
    <xsl:apply-templates select="CATALOG"/>
  </CATALOG>
  </xsl:template>
  
  <xsl:template match="CATALOG">
      <xsl:apply-templates select="MOVIE"/>
  </xsl:template>
    
  <xsl:template match="MOVIE">
    <MEDIA>
      <xsl:apply-templates select="TITLE"/>
      <xsl:apply-templates select="WRITERS"/>
      <xsl:apply-templates select="STATS"/>
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
        <YEAR>
          <xsl:value-of select="../STATS/@YEAR"/>
        </YEAR>
        <RUNTIME>
          <xsl:value-of select="../STATS/@LENGTH"/>
        </RUNTIME>
        <GENRES>
          <GENRE>
            <xsl:value-of select="../STATS/@GENRE"/>
          </GENRE>
        </GENRES>
        <xsl:if test="../STATS/@VIDEO='TV'">
          <SERIES>
            <SEASON>
              <EPISODES></EPISODES>
            </SEASON>
          </SERIES>
        </xsl:if>
        <PLOT>
          <xsl:value-of select="../SYNOPSIS"/>
        </PLOT>
    </TITLE>
  </xsl:template>

  <xsl:template match="WRITERS">
    <CREATORS>
      <DIRECTORS>
          <xsl:copy-of select="../DIRECTOR"/>
         </DIRECTORS>
      <WRITERS>
                 <xsl:apply-templates select="WRITER"/>
      </WRITERS>
      <ACTORS>
          <xsl:copy-of select="../ACTORS/*"/>
      </ACTORS>
    </CREATORS>
  </xsl:template>

  <xsl:template match="WRITER">
    <WRITER>
      <xsl:value-of select ="."/>
      <ROLE/>
    </WRITER>
  </xsl:template>
  
  
  <xsl:template match="STATS">
    <COPY>
        <IDENTIFIER>
          <xsl:value-of select="@MEDIANAME"/>
        </IDENTIFIER>
        <COPYTYPE>
          <xsl:value-of select="@TYPE"/>
        </COPYTYPE>
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
      <DATEENTERED>
        <xsl:value-of select="@DATEENTERED"/>
      </DATEENTERED>
        <SUBTITLES>
          <xsl:value-of select="@SUBTITLES"/>
        </SUBTITLES>
      </COPY>
    
  </xsl:template>
  
</xsl:stylesheet>
