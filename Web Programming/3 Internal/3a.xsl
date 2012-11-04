<!-- Author : SkyKOG -->

<?xml version="1.0" encoding="utf-8" ?>

<xsl:stylesheet version="1.0" xmlns:xsl = "http://www.w3.org/1999/XSL/Transform" xmlns="http://www.w3.org/1999/xhtml">
<xsl:template match="cars">
<html>
	<head><title>Question 3a</title></head>
<body>
	<table border="1">
	<tr><td align="center">Used Cars Sale</td></tr>
	<xsl:for-each select="number">
		<tr>
			<td><xsl:value-of select="year" /></td>
			<td><xsl:value-of select="model" /></td>
			<td><xsl:value-of select="make" /></td>
			<td><xsl:value-of select="price" /></td>
		</tr>
	</xsl:for-each>
	</table>
</body>
</html>
</xsl:template>
</xsl:stylesheet>
