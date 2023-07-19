namespace Exam.Models;

public class Product
{
    public int Id { get; set; }
    public double Price { get; set; }
    public List<Order> Orders { get; set; }
}
