namespace webshop_projekt.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Goods> Goods { get; set; }
    }
}
