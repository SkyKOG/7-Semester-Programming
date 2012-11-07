// Author : SkyKOG

import java.io.*;
import javax.servlet.*;
import javax.servlet.http.*;

public class getExample extends HttpServlet {
	
	public void doGet(HttpServletRequest request,HttpServletResponse response)
	throws ServletException, IOException {
		
		String theName = request.getParameter("name");
		
		response.setContentType("text/html");
		
		PrintWriter pw = response.getWriter();
		
		pw.println("<B>Have a Good Day : ");
		pw.println(theName);
		pw.close();
	}
}