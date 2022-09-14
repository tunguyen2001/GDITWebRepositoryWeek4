using WebApiRepositoryWeek4.Repositories.RepositoryBase;
using WebApiRepositoryWeek4.Repositories.UserRepository;
using WebApiRepositoryWeek4.Models;
using WebApiRepositoryWeek4.Dtos.UserDto;
using WebApiRepositoryWeek4.Data;

namespace WebApiRepositoryWeek4.Repositories.UserRepository
{
    public class UserRepository : RepositoryBase<Users>, IUserRepository
    {
        public UserRepository(Context context) : base(context)
        {
        }

        public IEnumerable<UserDetailDto> GetUserDetailDto()
        {
            var query = from u in _context.Users
                        join o in _context.Orders on u.UserId equals o.UserId
                        join cart in _context.Cart on u.UserId equals cart.UserId
                        join contact in _context.Contacts on u.UserId equals contact.UserId
                        select new UserDetailDto
                        {
                            UserName = u.UserName,
                            Address = u.Address,
                            Email = u.Email,
                            Phone = u.Phone,

                            ContactMessage = contact.Message,
                            ContactDate = contact.ContactDate,

                            OrderDate = o.OrderDate,
                            ProductNumber = o.ProductNumber,
                            TotalPrice = o.TotalPrice,

                            CartNumber = cart.CartNumber
                        };

            return query;
        }
    }
}
