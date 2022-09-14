namespace WebApiRepositoryWeek4.Dtos.UserDto
{
    public class UserDetailDto
    {
        public string UserName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        // contact
        public string ContactMessage { get; set; }
        public DateTime ContactDate { get; set; }

        // order
        public DateTime OrderDate { get; set; }
        public int ProductNumber { get; set; }
        public int TotalPrice { get; set; }

        // cart
        public int CartNumber { get; set; }

    }
}
