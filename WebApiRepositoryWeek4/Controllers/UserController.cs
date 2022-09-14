using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiRepositoryWeek4.Services;
using WebApiRepositoryWeek4.Models;

namespace WebApiRepositoryWeek4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public JsonResult GetUserDetailDto()
        {
            return new JsonResult(_userService.GetUserDetailDto()) ;
        }

    }
}
