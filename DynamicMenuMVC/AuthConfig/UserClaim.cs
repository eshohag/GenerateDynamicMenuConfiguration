using Microsoft.AspNet.Identity.EntityFramework;

namespace DynamicMenuMvc.AuthConfig
{
    public class UserClaim : IdentityUserClaim
    {
        public bool IsActive { get; set; }
    }
}