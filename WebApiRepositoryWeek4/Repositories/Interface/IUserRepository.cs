using WebApiRepositoryWeek4.Models;
using WebApiRepositoryWeek4.Dtos.UserDto;
using System.Collections;

namespace WebApiRepositoryWeek4.Repositories.Interface
{
    public interface IUserRepository 
    {
        IEnumerable<UserDetailDto> GetUserDetailDto();
        IEnumerable GetGroupBy();
        
    }
}
