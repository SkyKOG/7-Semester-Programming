// Author : SkyKOG

import java.io.*;
import javax.servlet.*;
import javax.servlet.http.*;

public class calcServlet extends HttpServlet {

	public void doGet(HttpServletRequest request,HttpServletResponse response)
	throws ServletException, IOException {
		
		Double number1 = Double.parseDouble(request.getParameter("value1"));
		Double number2 = Double.parseDouble(request.getParameter("value2"));
		Double sum = number1 + number2;
		
		response.setContentType("text/html");
		
		PrintWriter pw = response.getWriter();
		pw.println("The Sum is: ");
		pw.println((String)sum);
		pw.close();
	}
}