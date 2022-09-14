using System.ComponentModel.DataAnnotations;

namespace WebApiRepositoryWeek4.Models
{
    public class Contacts
    {
        [Key]
        public int ContactId { get; set; }

        public int  UserId { get; set; }

        public string  Message { get; set; }

        public DateTime ContactDate { get; set; }
        public virtual Users? Users { get; set; }
    }
}
