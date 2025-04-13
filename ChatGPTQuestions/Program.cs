/*
13. Object Initialization Syntax
Question: Create a class Product with properties Name, Price, and Quantity. 
Use object initialization syntax to create an instance of Product and assign values to its properties. 
 */

Product p1 = new() { Name = "Shower in a can", Price = 15.00m, Quantity = 10 };
Product2 p2 = new Product2("Hat", 0.00m, 100);


public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

public class Product2(string name, decimal price, int quantity)
{
    public string Name { get; set; } = name;
    public decimal Price { get; set; } = price;
    public int Quantity { get; set; } = quantity;
}
