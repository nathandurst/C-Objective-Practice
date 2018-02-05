<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="2.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl" xmlns:exsl="http://exslt.org/common">
  <xsl:output method="xml" indent="yes"/>

  <xsl:template match="/ | @* | node()">
    <xsl:for-each select="/*/*/EXCHANGERATES/EXCHANGERATE">
      <!--exsl:document href="{@id}.xml" method="xml"-->
      <WSOXML>
        <xsl:copy-of select="/*/@*" />
        <EXCHANGERATEINTERFACE>
          <xsl:attribute name="version">
            <xsl:value-of select="/*/EXCHANGERATEINTERFACE/@version"/>
          </xsl:attribute>
          <xsl:attribute name="source">
            <xsl:value-of select="/*/EXCHANGERATEINTERFACE/@source"/>
          </xsl:attribute>
          <xsl:attribute name="level">
            <xsl:value-of select="/*/EXCHANGERATEINTERFACE/@level"/>
          </xsl:attribute>
          <xsl:attribute name="loglevel">
            <xsl:value-of select="/*/EXCHANGERATEINTERFACE/@loglevel"/>
          </xsl:attribute>
          <EXCHANGERATES>
            <xsl:copy-of select="/../@* | ."/>
          </EXCHANGERATES>
        </EXCHANGERATEINTERFACE>
      </WSOXML>
      <!--/exsl:document-->
    </xsl:for-each>
  </xsl:template>
</xsl:stylesheet>
