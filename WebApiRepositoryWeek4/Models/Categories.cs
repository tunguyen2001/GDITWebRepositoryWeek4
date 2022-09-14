using System.ComponentModel.DataAnnotations;

namespace WebApiRepositoryWeek4.Models
{
    public class Categories
    {
        public Categories()
        {
            Products = new List<Products>();
        }

        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public virtual ICollection<Products> Products { get; set; }

    }
}
