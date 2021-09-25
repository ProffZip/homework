using System;

public class Invoice
{
	private int _account;
	private string _customer;
	private string _provider;
	private string _article;
	private int _quantity;
    public int Account
    {
        get
        {
            return _account;
        }
    }
    public string Customer
    {
        get
        {
            return _customer;
        }
    }
    public string Provider
    {
        get
        {
            return _provider;
        }
    }
    public string Article
    {
        get
        {
            return _article;
        }
        set
        {
            this._article = value;
        }
    }
    public int Quantity
    {
        get
        {
            return _quantity;
        }
        set
        {
            this._quantity = value;
        }

    }
    public Invoice(int account, string customer, string provider)
    {
        _account = account;
        _customer = customer;
        _provider = provider;
    }
    public double Cost(Invoice invoice)
    {
        double basecost;
        double cost = 0;
        switch (invoice._article)
        {
            case "car":
                basecost = 300000;
                cost = invoice._quantity * basecost;
                break;
            case "phone":
                basecost = 20000;
                cost = invoice._quantity * basecost;
                break;
            case "bike":
                basecost = 50000;
                cost = invoice._quantity * basecost;
                break;
        }
        return cost;

    }
    public double CostNDS(Invoice invoice)
    {
        double costnds = invoice.Cost(invoice)*1.2;

        return costnds;
    }
    public void InvoiceInfo(Invoice invoice)
    {
        Console.WriteLine("Order info:\nAccount:"+invoice.Account+"\nOrdered by: "+invoice.Customer+"\nGoods provided by: "+invoice.Provider);
        Console.WriteLine("You've ordered "+invoice.Quantity+" "+invoice.Article+"s");
        Console.WriteLine("You'll be charged "+Cost(invoice)+" and including VAT(20%) - "+invoice.CostNDS(invoice));
    }
}
