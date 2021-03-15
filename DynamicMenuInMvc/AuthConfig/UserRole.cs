using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMenuInMvc.AuthConfig
{
    public class UserRole : IdentityUserRole
    {
        public bool IsActive { get; set; }
    }
}