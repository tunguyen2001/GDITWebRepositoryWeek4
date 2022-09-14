using System.ComponentModel.DataAnnotations;

namespace WebApiRepositoryWeek4.Models
{
    public class Users
    {
        public Users()
        {
            Orders = new List<Orders>();
            Cart = new List<Cart>();
            Contacts = new List<Contacts>();
        }

        [Key]
        public int UserId { get; set; }

        public string Address { get; set; }

        public string UserName  { get; set; }

        public string Password { get; set; }

        public string  Email { get; set; }

        public string  Phone { get; set; }

        public string  roles { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }

        public virtual ICollection<Cart> Cart { get; set; }

        public virtual ICollection<Contacts> Contacts { get; set; }
    }
}
