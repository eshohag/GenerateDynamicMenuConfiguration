using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMenuInMvc.AuthConfig
{
    public class Role : IdentityRole
    {
        public bool IsActive { get; set; }
    }
}