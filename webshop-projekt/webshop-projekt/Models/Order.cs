using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace webshop_projekt.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        [Display(Name = "Név")]
        [Required]
        public string? CustomerName { get; set; }

        [Display(Name = "Cím")]
        [Required]
        public string? Address { get; set; }

        [Display(Name = "Város")]
        [Required]
        public string? City { get; set; }

        [Display(Name = "Irányítószám")]
        [Required]
        public string? PostalCode { get; set; }

        [Display(Name = "Ország")]
        [Required]
        public string? Country { get; set; }

        [Display(Name = "Telefonszám")]
        [Required]
        [Phone]
        public string? Phone { get; set; }

        [Display(Name = "Email")]
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [BindNever]
        [Display(Name = "Rendelés dátuma")]
        public DateTime OrderDate { get; set; }

        [BindNever]
        public int? TotalPrice { get; set; }

        [BindNever]
        public List<Item>? Items { get; set; }

        public Order()
        {
            Items = new List<Item>();
            OrderDate = DateTime.Now;
        }
    }
}
