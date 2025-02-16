using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Text.Json;
using WebApiRepositoryWeek4.Models;
using WebApiRepositoryWeek4.Repositories.Interface;

namespace WebApiRepositoryWeek4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository ;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public JsonResult GetUserDetailDto()
        {
            return new JsonResult(_userRepository.GetUserDetailDto()) ;
        }

        [HttpGet("GroupBy")]
        public IEnumerable GetGroupBy()
        {
            return _userRepository.GetGroupBy();
        }

    }
}
