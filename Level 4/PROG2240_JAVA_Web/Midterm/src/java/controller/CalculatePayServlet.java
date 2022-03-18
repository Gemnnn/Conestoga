package controller;

import com.abc.Pay;
import java.io.IOException;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class CalculatePayServlet extends HttpServlet {

    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {

        Pay payinfo = new Pay();
        String errorMessage = "";
        String hourString = "";
        String employeeName = "";
        double hours = 0;
        String url = "/enterPay.jsp";


        
        // process action input parameter 
        String action = request.getParameter("action");

        if (action == null) { // Add code here
            action = "";
        }

        if (action.equals("calcPay")) { // Add code here

            // get parameters of input form
            employeeName = request.getParameter("employeename");
            hourString = request.getParameter("hours");

            //  hours worked is null or blank, assign a default of zero.
            if (hourString == null || hourString.isEmpty()) { // Add Code here
                hourString = "0";
            }

            // convert employee hours to numeric value
            hours = Double.parseDouble(hourString);

            // validate employee name 
            if (employeeName == null || employeeName.isEmpty()) { // Add Code here
                    errorMessage = "Employee name is blank. Please enter again.";
                // Add Code Here
                url = "/enterPay.jsp";
            } else {
                // validate hours worked 
                if (hours < 0) { // Add Code Here
                    errorMessage = "Hours cannot be negative. Please enter again.";
                    // Add Code Here
                    url = "/enterPay.jsp";
                }

                // Check hours worked is less than 40 or overtime hours 
                if (hours >= 0 && hours <= 40) { // Add Code Here
                    url = "/regular.jsp";
                }

                if (hours > 40) { // Add Code Here
                    url = "/overtime.jsp";
                }

            }
        }

        // prepare Pay object and error message 
        // Add Code Here
        payinfo.setEmployeename(employeeName);
        // Add Code Here
        payinfo.setHours(hours);
        // Add Code Here
        request.setAttribute("payInfo", payinfo);
        // Add Code Here
        request.setAttribute("message", errorMessage);
        
        // forward to JSP page 
        // Add Code Here
        // Add Code Here
        getServletContext().getRequestDispatcher(url).forward(request, response);


    }

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }


}
