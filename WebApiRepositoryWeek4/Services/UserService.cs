using WebApiRepositoryWeek4.Dtos.UserDto;
using WebApiRepositoryWeek4.Models;
using WebApiRepositoryWeek4.Repositories.UserRepository;

namespace WebApiRepositoryWeek4.Services
{
    public class UserService : IUserRepository
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Delete(Users obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Users> GetAll()
        {
            throw new NotImplementedException();
        }

        public Users GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDetailDto> GetUserDetailDto()
        {
            return _userRepository.GetUserDetailDto();
        }

        public void Insert(Users obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Users obj)
        {
            throw new NotImplementedException();
        }
    }
}
