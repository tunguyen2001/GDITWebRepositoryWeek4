using System.ComponentModel.DataAnnotations;

namespace WebApiRepositoryWeek4.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }

        public int ProductId { get; set; }

        public int UserId { get; set; }

        public int CartNumber { get; set; }

        public virtual Products? Products { get; set; }

        public virtual Users? Users { get; set; }
    }
}
