using ConsoleApp1;

Console.WriteLine("Hello, World!");


using (Hwlesson4Context db = new Hwlesson4Context())
{



var customers = db.Customers.ToList();
    Console.WriteLine("Customers list:");

    
    
    foreach (Customer c in customers)
    {
        Console.WriteLine($"{c.Id}. {c.Firstname}, {c.Lastname}, {c.Email} - {c.Age}");
    }

var items = db.Items.ToList();
    Console.WriteLine("Items list:");

    foreach (var item in items)
    {
        Console.WriteLine($"{item.Id}. {item.Name}, {item.Type}, {item.Description}, {item.Price}");
    }

var orders = db.Orders.ToList();
    Console.WriteLine("Orders:");

    foreach (var order in orders)
    {
        Console.WriteLine($"{order.Id}. {order.Customerid}, {order.Itemid}, {order.Quantity}");
        Console.WriteLine($"{order.Id}. {order.Customer?.Lastname}, {order.Item?.Name}, {order.Quantity}");
    }



}


    Console.ReadKey();
