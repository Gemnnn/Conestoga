<%-- 
    Document   : AddNewVehicle
    Created on : 29-Mar-2022, 11:06:48 PM
    Author     : User
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<jsp:include page="Banner.jsp" />
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>QA Assignment3 Test Website</title>
    </head>
    <body>
        <section id="register">
            <div class="container">
                <h1>Add New Vehicle</h1>
                <div class="content">
                    <form action="AddNewVehicle" method="post">
                        <h2>Information</h2>
                        <div class="form-control">
                            <label for="txtFirstName">First Name</label>
                            <input type="text" id="txtFirstName" name="txtFirstName" style="width:200px" />
                        </div>
                        <div class="form-control">
                            <label for="txtLastName">Last Name</label>
                            <input type="text" id="txtLastName" name="txtLastName" style="width:200px" />
                        </div>
                        <div class="form-control">
                            <label for="txtAddress">Address</label>
                            <input type="text" id="txtAddress" name="txtAddress" style="width:200px" />
                        </div>
                        <div class="form-control">
                            <label for="txtCity">City</label>
                            <input type="text" id="txtCity" name="txtCity" style="width:200px" />
                        </div>
                        <div class="form-control">
                            <label for="txtProvince">Province</label>
                            <select name="txtProvince" id="txtProvince" style="width:200px">
                                <option value="AB">AB</option>
                                <option value="BC">BC</option>
                                <option value="MB">MB</option>
                                <option value="NB">NB</option>
                                <option value="NL">NL</option>
                                <option value="NT">NT</option>
                                <option value="NS">NS</option>
                                <option value="NU">NU</option>
                                <option value="ON" selected>ON</option>
                                <option value="PE">PE</option>
                                <option value="QC">QC</option>
                                <option value="SK">SK</option>
                                <option value="YT">YT</option>
                            </select>
                        </div>
                        <div class="form-control">
                            <label for="txtPostalCode">Postal Code</label>
                            <input type="text" id="txtPostalCode" name="txtPostalCode" style="width:200px" />
                        </div>
                        <div class="form-control">
                            <label for="txtPhone">Phone</label>
                            <input type="text" id="txtPhone" name="txtPhone" style="width:200px" />
                        </div>
                        <div class="form-control">
                            <label for="txtEmail">Email</label>
                            <input type="text" id="txtEmail" name="txtEmail" style="width:200px" />
                        </div>

                        <h2>Vehicle Information</h2>
                        <div class="form-control">
                            <label for="txtMake">Make</label>
                            <input type="text" id="txtMake" name="txtMake" style="width:200px" />
                        </div>
                        <div class="form-control">
                            <label for="txtModel">Model</label>
                            <input type="text" id="txtModel" name="txtModel" style="width:200px" />
                        </div>
                        <div class="form-control">
                            <label for="txtYear">Year</label>
                            <input type="text" id="txtYear" name="txtYear" style="width:200px" />
                        </div>

                        <label> </label>
                        <input type="submit" name="Submit" value="Submit">
                        <%
                            if (null != request.getAttribute("message")) {
                                out.println(request.getAttribute("message"));
                            }
                        %>
                    </form>
                </div>
            </div>
        </section>
    </body>
</html>
<jsp:include page="Footer.jsp" />