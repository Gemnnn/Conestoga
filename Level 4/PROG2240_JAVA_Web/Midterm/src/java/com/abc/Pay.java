package com.abc;

public class Pay implements java.io.Serializable {
    
    private String employeename;
    private double hours;
    private double grosspay;
    private double overtimepay;
    final static double PAY_RATE = 10.0;
    final static double OVERTIME_RATE = 15.0;
    
    /** Creates a new instance of Pay */
    public Pay() {
    }

    public String getEmployeename() {
        if (employeename == null)
            employeename = new String();
        
        return employeename;
    }

    public void setEmployeename(String employeename) {
        this.employeename = employeename;
    }

    public double getHours() {
        return hours;
    }

    public void setHours(double hours) {
        this.hours = hours;
    }

    public double getGrosspay() {
        if (hours <= 40)
            grosspay = hours * PAY_RATE;
        else
            grosspay = 40 * PAY_RATE + (hours-40) * OVERTIME_RATE;
        
        return grosspay;
    }

    public double getOvertimepay() {
        if ((getGrosspay() - 40 * PAY_RATE) > 0)
            overtimepay = getGrosspay() - 40 * PAY_RATE;
        return overtimepay;
    }

}
