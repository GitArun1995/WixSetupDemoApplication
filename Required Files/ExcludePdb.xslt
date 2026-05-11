<?xml version="1.0" encoding="utf-8"?>

<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:wix="http://schemas.microsoft.com/wix/2006/wi">

    <xsl:output method="xml" indent="yes"/>

    <!-- Default: copy everything -->
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>

    <!-- EXCLUDE .pdb FILES -->
    	<xsl:template match="wix:File[contains(@Source, '.pdb')]"/>

    <!-- Replace SourceDir with absolute path -->

     <xsl:template match="@Source">
        <xsl:attribute name="Source">
            <xsl:value-of select="concat('D:\source\repos\WixDemo\SampleProject\ShellProject\bin\Release\', substring-after(., 'SourceDir\'))"/>
        </xsl:attribute>
    </xsl:template>

<!-- Add Win64="yes" to every Component -->
<xsl:template match="wix:Component">
    <xsl:copy>
        <xsl:attribute name="Win64">yes</xsl:attribute>

        <!-- copy existing attributes except we still preserve them -->
        <xsl:apply-templates select="@*"/>
        <xsl:apply-templates select="node()"/>
    </xsl:copy>
</xsl:template>

</xsl:stylesheet>