<!-- Author : SkyKOG -->

<!-- Writing Cookie -->
<html>
<head>
	<title>Question 7a(Writing)</title>
</head>
<body>
	<%! String CookieName = "userid";
		String CookieValue = "JB0007"
		response.addCookie(new Cookie(CookieName,CookieValue));
	%>
</body>
</html>

<!-- Reading Cookie -->
<html>
<head>
	<title>Question 7a(Reading)</title>
</head>
<body>
	<%! String CookieName = "userid";
		String CookieValue;
		String CName, CValue;
		int found = 0;
		Cookie[] cookies = request.getCookies();
		for (int i = 0; i <cookies.length ; i++) {
			CName = cookies[i].getName();
			CValue = cookies[i].getValue();			
			if(CookieName.equals(CName)) {
				found = 1;
				CookieValue = CValue;
			}
		}
		if(found ==1) { %>
			<P> Cookie Name = <%= CookieName %> </P>
			<P> Cookie Value = <%= CookieValue %> </P>
	<%}%>
</body>
</html>