/*
Problem Statement:
You are given a list of items added to a shopping cart. Each item includes:

The product name (Apple or Orange)

The quantity of that product added to the cart

You are also given the following pricing rules:

Cost of 1 Apple =  Rs 10
Cost of 2 Apple =  Rs 16
Cost of 3 Apple = Rs 25

Cost of 1 Orange =  Rs 5
Cost of 2 Orange = Rs 6
Cost of 3 Orange =  Rs 12

Note: Pricing is available only for groups of 1, 2, or 3 units. If someone buys more than 3 units, break it into smaller valid groups. For example:

Buying 5 apples = (3 apples) + (2 apples)

Based on this calculate the total cost of cart.
*/
using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<Item> products = new List<Item>()
        {
            new Item {name = "A", qty = 3},
            new Item {name = "B", qty = 5}
        };
        
        double total = 0 ;
        foreach(var item in products)
        {
            total = total + Calculate(item.name,item.qty);
        }
        Console.WriteLine(total);
    }
    
static double Calculate(string name,int qty)
{
    if(name == "A")
    {
    if(qty>=3)
    {
        return 3 * 25 + Calculate(name,qty-3);
    }
    else if(qty>=2)
    {
        return 2 * 16 +Calculate(name,qty-2);
    }
    else if(qty >= 1)
    {
        
        return 1 * 10 + Calculate(name,qty-1);
    }
    else
     return 0;
    }
    else if(name == "B")
    {
    if(qty>=3)
    {
        return 3 * 12 + Calculate(name,qty-3);
    }
    else if(qty>=2)
    {
        return 2 * 6 +Calculate(name,qty-2);
    }
    else if(qty >= 1)
    {
        
        return 1 * 5 + Calculate(name,qty-1);
    }
    else
     return 0;
    }
    else
        return 0;
    
}
}

public class Item
{
    public string name {get;set;}
    public int qty {get;set;}
}

