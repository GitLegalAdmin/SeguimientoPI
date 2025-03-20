using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using WaPropiedadIntelectual.Models;
using WaPropiedadIntelectual.Service;

namespace WaPropiedadIntelectual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddUser([FromBody] UserObject user)
        {
            var userObj = new ApplicationUser
            {
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PasswordText = user.Password // Almacena la contraseña en texto plano (¡solo para fines demostrativos!)
            };

            var result = await _userService.AddUserAsync(userObj, user.Password);

            return result ? Ok() : BadRequest();
        }

        [HttpPut("edit/{userId}")]
        public async Task<IActionResult> EditUser(string userId, [FromBody] ApplicationUser updatedUser)
        {
            var result = await _userService.EditUserAsync(userId, updatedUser); 
            return result ? Ok() : BadRequest();
        }

        [HttpPost("change-password/{userId}")]
        public async Task<IActionResult> ChangePassword(string userId, [FromBody] ChangePasswordObject changePassword)
        {
            var result = await _userService.ChangePasswordAsync(userId, changePassword.CurrentPassword, changePassword.NewPassword);
            return result ? Ok() : BadRequest();
        }

        [HttpDelete("delete/{userId}")]
        public async Task<IActionResult> DeleteUser(string userId)
        {
            var result = await _userService.DeleteUserAsync(userId);
            return result ? Ok() : BadRequest();
        }

        //[HttpGet("getByUserName/{userName}")]
        //public async Task<IActionResult> getByUserName(string userName)
        //{
        //    var result = await _userService.get(userId);
        //    return result ? Ok() : BadRequest();
        //}
    }
}
