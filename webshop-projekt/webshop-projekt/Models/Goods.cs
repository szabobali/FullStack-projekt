using System.ComponentModel.DataAnnotations.Schema;

namespace webshop_projekt.Models
{
    public class Goods
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string? Category { get; set; }
        public string? Description {  get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }
    }
}
