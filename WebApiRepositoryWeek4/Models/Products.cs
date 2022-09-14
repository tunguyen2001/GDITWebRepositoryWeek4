using System.ComponentModel.DataAnnotations;

namespace WebApiRepositoryWeek4.Models
{
    public class Products
    {
        public Products()
        {
            Orders = new List<Orders>();
            Cart = new List<Cart>();
        }

        [Key]
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; }

        public double ProductPrice { get; set; }

        public string  Image { get; set; }

        public virtual Categories? Categories { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }

        public virtual ICollection<Cart> Cart { get; set; }

    }
}
