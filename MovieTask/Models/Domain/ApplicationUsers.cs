using Microsoft.AspNetCore.Identity;

namespace MovieTask.Models.Domain
{
    public class ApplicationUsers :IdentityUser
    {
        public string Name { get; set; }

    }
}
