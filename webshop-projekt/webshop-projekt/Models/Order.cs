namespace webshop_projekt.Models
{
    public class Order
    {
       
            public int OrderId { get; set; }
            public string? CustomerName { get; set; }
            public int? TotalPrice { get; set; }

            public Order() { }
    
    }
}
