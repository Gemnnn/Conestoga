<html>
    <head>
        <title>Regular Pay Result</title>
    </head>
    <body>
        <h1>Regular Pay Calculation</h1>
        <table width="400" border="1">
            <tr>
                <td width="300">Employee Name: </td>
                <td>${payInfo.employeename}</td>
            </tr>
            <tr>
                <td width="300">Hours Worked This Week: </td>
                <td>${payInfo.hours}</td>
            </tr>
            <tr>
                <td width="300">Gross Pay Amount: </td>
                <td>${payInfo.getGrosspay()}</td>
            </tr>
        </table>
    </body>
</html>