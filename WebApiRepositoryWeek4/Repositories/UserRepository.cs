using WebApiRepositoryWeek4.Models;
using WebApiRepositoryWeek4.Dtos.UserDto;
using WebApiRepositoryWeek4.Data;
using WebApiRepositoryWeek4.Repositories.Interface;
using System.Collections;
using System.Linq;

namespace WebApiRepositoryWeek4.Repositories
{
    public class UserRepository :  IUserRepository
    {
        private readonly Context _context;

        public UserRepository(Context context)
        {
            _context = context;
        }


        public IEnumerable GetGroupBy()
        {
            var result = from u in _context.Users
                         join o in _context.Orders on u.UserId equals o.UserId
                         group o by o.UserId into g
                         select new
                         {
                             user = g.Key,
                             countOrder = g.Sum(o => o.OrderId)                     
                         };

            return result;
        }


        public IEnumerable<UserDetailDto> GetUserDetailDto()
        {
            return from u in _context.Users

                    join o in _context.Orders on u.UserId equals o.UserId
                    into UserOrder
                    from o in UserOrder.DefaultIfEmpty()

                    join p in _context.Products on o.ProductID equals p.ProductId
                    into ProductOrder 
                    from p in ProductOrder.DefaultIfEmpty()

                    join category in _context.Categories on p.CategoryId equals category.CategoryId
                    into ProCategory
                    from category in ProCategory.DefaultIfEmpty()

                    //join cart in _context.Cart on u.UserId equals cart.UserId

                    //join contact in _context.Contacts on u.UserId equals contact.UserId

                    where (u.UserId == 10) 

                   select new UserDetailDto
                    {
                        UserName = u.UserName,
                        Address = u.Address,
                        Email = u.Email,
                        Phone = u.Phone,

                        //ContactMessage = contact.Message,
                        //ContactDate = contact != null ? DateTime.UtcNow : contact.ContactDate,

                        OrderDate = o == null ? DateTime.UtcNow : o.OrderDate,
                        ProductNumber = o == null ? 0 : o.ProductNumber,
                        TotalPrice = o == null ? 0 : o.TotalPrice,

                        ProductName = p.ProductName,

                        CategoryName = category == null ? "---" : category.CategoryName,

                        //CartNumber = cart == null ? 0 : cart.CartNumber
                    };
        }

    }
}
