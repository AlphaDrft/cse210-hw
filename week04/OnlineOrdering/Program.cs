using System;
using System.Collections.Generic;

class Product
{
    private string name;
    private string productId;
    private decimal pricePerUnit;
    private int quantity;

    public Product(string name, string productId, decimal pricePerUnit, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return pricePerUnit * quantity;
    }

    public string GetName() => name;
    public string GetProductId() => productId;
    public decimal GetPricePerUnit() => pricePerUnit;
    public int GetQuantity() => quantity;
}

class Address
{
    private string street;
    private string city;
    private string stateOrProvince;
    private string country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        this.street = street;
        this.city = city;
        this.stateOrProvince = stateOrProvince;
        this.country = country;
    }

    public bool IsInUSA()
    {
        return country.Trim().ToUpper() == "USA" || country.Trim().ToUpper() == "UNITED STATES";
    }

    public override string ToString()
    {
        return $"{street}, {city}, {stateOrProvince}, {country}";
    }
}

class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool IsInUSA()
    {
        return address.IsInUSA();
    }
    public string GetName() => name;
    public Address GetAddress() => address;
}

class Order
{
    private Customer customer;
    private List<Product> products = new List<Product>();

    public Order(Customer customer)
    {
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal GetTotalPrice()
    {
        decimal total = 0;
        foreach (var p in products)
        {
            total += p.GetTotalCost();
        }

        decimal shipping = customer.IsInUSA() ? 5.0m : 35.0m;
        return total + shipping;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var p in products)
        {
            label += $"{p.GetName()} (ID: {p.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().ToString()}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer cust1 = new Customer("John Doe", addr1);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "LP1001", 799.99m, 1));
        order1.AddProduct(new Product("Mouse", "MS2002", 19.99m, 2));

        Address addr2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Bobby Bob", addr2);

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Smartphone", "SP3003", 499.99m, 1));
        order2.AddProduct(new Product("Charger", "CH4004", 29.99m, 3));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}");
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");
    }
}