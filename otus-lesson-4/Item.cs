using System;
using System.Collections.Generic;

namespace otus_lesson_4;

public partial class Item
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
