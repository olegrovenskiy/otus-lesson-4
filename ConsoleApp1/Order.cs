using System;
using System.Collections.Generic;

namespace ConsoleApp1;

public partial class Order
{
    public int Id { get; set; }

    public int? Customerid { get; set; }

    public int? Itemid { get; set; }

    public int Quantity { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Item? Item { get; set; }
}
