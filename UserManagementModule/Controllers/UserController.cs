using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using UserManagementModule.Interfaces;

namespace UserManagementModule.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private IUserServices _userServices;

        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpGet("{userId}")]
        public async Task<Guid> GetUserIdAsync(Guid userId)
        {
            return await _userServices.GetUserId();
        }

        [HttpPost]
        public async Task<bool> CreateUserAsync(CreateUserModel createUserModel)
        {
            return await _userServices.CreateUser();
        }
    }

    public class CreateUserModel
    {
        [Required]
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
