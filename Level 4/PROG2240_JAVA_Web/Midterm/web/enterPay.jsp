<html>
    <head>
        <title>Payroll</title>
    </head>
    <body>
        <h1>Payroll Calculator</h1>

        <form  action="Calculate" method="post">
            
            <input type="hidden" name="action" value="calcPay"/>
            <table border="1">
                <tr>
                    <td width="200">Employee Name: </td>
                    <td><input name="employeename" type="text" value="${employeename}" size="25"/></td>
                </tr>
                <tr>
                    <td width="200">Hours worked this week</td>
                    <td><input name="hours" type="text" value="${hours}" size="25"/></td>
                </tr>
                <tr>
                    <td colspan="2" align="center"><font color="red"/>${message}</td>
                </tr>
                <tr>
                    <td colspan="2" align="center"><input type="submit" value="Calculate"/></td>
                </tr>
            </table>
        </form>
    </body>
</html>
