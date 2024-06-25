using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace MvcIdentity.Models
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string FullName {get; set; }
    }
    
}