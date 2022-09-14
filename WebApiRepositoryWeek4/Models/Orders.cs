using System.ComponentModel.DataAnnotations;

namespace WebApiRepositoryWeek4.Models
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }

        public int  ProductID { get; set; }

        public int UserId { get; set; }

        public DateTime OrderDate { get; set; }

        public int ProductNumber { get; set; }

        public int TotalPrice { get; set; }

        public virtual Products? Products { get; set; }

        public virtual Users? Users { get; set; }   

    }
}
