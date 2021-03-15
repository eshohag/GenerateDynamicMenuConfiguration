using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMenuMvc.AuthConfig
{
    public class UserRole : IdentityUserRole
    {
        public bool IsActive { get; set; }
    }
}