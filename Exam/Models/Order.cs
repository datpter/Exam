﻿namespace Exam.Models;

public class Order
{
    public int Id { get; set; }
    public Customer Customer { get; set; }
    public double Price { get; set; }
    public List<Product> Products { get; set; }
}
