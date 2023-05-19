using System;
using System.Collections.Generic;

namespace otus_lesson_4;

public partial class Customer
{
    public int Id { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Email { get; set; }

    public int? Age { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
