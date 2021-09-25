using System;

public class Employee
{
	private string _lastname;
	private string _name;
	private double _exp;
	private string _pos;
	public double Exp
    {
        get
        {
            return _exp;
        }
        set
        {
            this._exp = value;
        }
    }
    public string Pos
    {
        get
        {
            return _pos;
        }
        set
        {
            this._pos = value;
        }
    }
    public Employee(string lastname, string name)
    {
		_lastname = lastname;
		_name = name;
    }

    
    public double Endpay(double basepay, Employee employee)
    {
        double endpay = basepay * (1 + (0.05 * employee.Exp));
        return endpay;
    }

    public double Pay(Employee employee)
    {
        double basepay;
        double endpay = 0;
        switch (employee.Pos)
        {
            case "worker":
                basepay = 10000;
                endpay = employee.Endpay(basepay, employee);
                break;
            case "manager":
                basepay = 20000;
                endpay = employee.Endpay(basepay, employee);
                break;
            case "director":
                basepay = 30000;
                endpay = employee.Endpay(basepay, employee);
                break;
        }
        return endpay;
        
    }
    public double Tax(Employee employee)
    {
        double tax = employee.Pay(employee) * 0.195;
        return tax;
    }
    public void PayData(Employee employee)
    {
        double pay = employee.Pay(employee);
        double tax = employee.Tax(employee);
        Console.WriteLine("The current pay is "+pay+" minus the tax of "+tax);
    }
    public void EmployeeInfo(Employee employee)
    {
        Console.WriteLine("Info: "+employee._name+" "+employee._lastname+ " " + employee.Pos);
        employee.PayData(employee);
    }
}
