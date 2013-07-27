<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

    <xsl:template match="@* | node()">
        <xsl:copy>
                <xsl:apply-templates select="@* | node()"/>
        </xsl:copy>
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
    </TITLE>
  </xsl:template>
</xsl:stylesheet>
