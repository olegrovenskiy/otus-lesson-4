using ConsoleApp1;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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

    // 4. Добавить в программу возможность добавления в таблицу на выбор.

    Console.WriteLine("Будете добавлять клиентов? Если да, то наберите yes");
string? choise = Console.ReadLine();

    if (choise == "yes")
    {
        Console.WriteLine("Введите Имя");
        var FirstName = Console.ReadLine();

        Console.WriteLine("Введите Фамилию");
        var LastName = Console.ReadLine();

        Console.WriteLine("Введите e-mail");
        var Email = Console.ReadLine();

        Console.WriteLine("Введите возраст");
        int Age;
        bool parce = int.TryParse(Console.ReadLine(), out Age);


    //    var ListId = from cust in db.Customers
    //                 orderby cust.Id
    //                 select cust.Id;
    //    var LastId = ListId.Last();

        var lastId = db.Customers.OrderBy(p => p.Id).Last().Id;

        Customer NewCustomer = new Customer { Id = lastId + 1, Firstname = FirstName, Lastname = LastName, Email = Email, Age = Age };

        db.Customers.Add(NewCustomer);        
        db.SaveChanges();
        Console.WriteLine("Запись в БД успешно добавлено");   

    }


}


    Console.ReadKey();
