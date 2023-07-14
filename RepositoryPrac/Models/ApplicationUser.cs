using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Build.Framework;

namespace RepositoryPrac.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required]
        public string UserName { get; set; }
        public string City { get; set; }
    }
}
