using Microsoft.AspNetCore.Identity;
using WaPropiedadIntelectual.Models;

namespace WaPropiedadIntelectual.Service
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<bool> AddUserAsync(ApplicationUser user, string password)
        {
            user.PasswordText = password; // Almacena la contraseña en texto plano (¡solo para fines demostrativos!)
            var result = await _userManager.CreateAsync(user, password);
            return result.Succeeded;
        }

        public async Task<bool> ChangePasswordAsync(string userId, string currentPassword, string newPassword)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) return false;

            var result = await _userManager.ChangePasswordAsync(user, currentPassword, newPassword);
            if (result.Succeeded)
            {
                user.PasswordText = newPassword; // Actualiza el campo adicional
                await _userManager.UpdateAsync(user);
            }
            return result.Succeeded;
        }

        public async Task<bool> DeleteUserAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) return false;

            var result = await _userManager.DeleteAsync(user);
            return result.Succeeded;
        }

        public async Task<bool> EditUserAsync(string userId, ApplicationUser updatedUser)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) return false;

            user.UserName = updatedUser.UserName;
            user.Email = updatedUser.Email;
            user.PasswordText = updatedUser.PasswordText; // Actualiza el campo adicional

            var result = await _userManager.UpdateAsync(user);
            return result.Succeeded;
        }
    }
}
