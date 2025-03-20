using Microsoft.AspNetCore.Identity;

namespace WaPropiedadIntelectual.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PasswordText { get; set; }
    }
}
