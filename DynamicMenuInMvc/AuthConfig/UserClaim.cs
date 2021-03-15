using Microsoft.AspNet.Identity.EntityFramework;

namespace DynamicMenuInMvc.AuthConfig
{
    public class UserClaim : IdentityUserClaim
    {
        public bool IsActive { get; set; }
    }
}