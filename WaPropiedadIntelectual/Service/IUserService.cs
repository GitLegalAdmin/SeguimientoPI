using WaPropiedadIntelectual.Models;

namespace WaPropiedadIntelectual.Service
{
    public interface IUserService
    {
        Task<bool> AddUserAsync(ApplicationUser user, string password);
        Task<bool> EditUserAsync(string userId, ApplicationUser updatedUser);
        Task<bool> ChangePasswordAsync(string userId, string currentPassword, string newPassword);
        Task<bool> DeleteUserAsync(string userId);
        Task<ApplicationUser> GetUserAsync(string userName);
    }
}
