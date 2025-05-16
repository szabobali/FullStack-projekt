using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace webshop_projekt.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }
        [Display(Name = "Név")]
        public string? CustomerName { get; set; }
        public int? TotalPrice { get; set; }

        public Order() { }

    }
}
