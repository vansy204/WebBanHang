﻿using WebsiteBanHang.Models;
using System.ComponentModel.DataAnnotations.Schema;

public class OrderDetail
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }

    public Order Order { get; set; }
    public Product Product { get; set; }
}