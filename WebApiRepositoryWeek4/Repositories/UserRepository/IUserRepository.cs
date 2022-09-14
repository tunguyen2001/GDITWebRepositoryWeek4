using WebApiRepositoryWeek4.Repositories.RepositoryBase;
using WebApiRepositoryWeek4.Models;
using WebApiRepositoryWeek4.Dtos.UserDto;

namespace WebApiRepositoryWeek4.Repositories.UserRepository
{
    public interface IUserRepository : IRepositoryBase<Users>
    {
        IEnumerable<UserDetailDto> GetUserDetailDto();
    }
}
