using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? Image { get; set; }

    public int? CategoryId { get; set; }

    public double? Price { get; set; }

    public int? Quantity { get; set; }

    public string? Size { get; set; }

    public string? Color { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
