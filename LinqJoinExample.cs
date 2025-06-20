// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Linq;
using System.Collections.Generic;
public class Customer
{
    public int Id;
    public string Name;
}
public class Order
{
    public int Id;
    public int CustomerId;
    public double Total;
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<Customer> customers = new List<Customer> 
        { 
            new Customer { Id = 1, Name = "John Doe" }, 
            new Customer { Id = 2, Name = "Jane Smith" } 

        }; 
        List<Order> orders = new List<Order> 
        { 
            new Order { Id = 1, CustomerId = 1, Total = 100.00 }, 
            new Order { Id = 2, CustomerId = 2, Total = 50.00 }, 
            new Order { Id = 3, CustomerId = 1, Total = 200.00 } 
        }; 
        
        var result = customers.Join(orders,
        c=> c.Id,
        o=>o.CustomerId,
        (c,o)=> new {CustomerId = c.Id,CustomerName = c.Name, OrderId = o.Id,Total = o.Total}
        );
        
        foreach(var item in result)
        {
            Console.WriteLine($"Customer Id : {item.CustomerId}  Customer Name : {item.CustomerName} OrderId : {item.OrderId} - Total : {item.Total} ");
        }
    }
}





