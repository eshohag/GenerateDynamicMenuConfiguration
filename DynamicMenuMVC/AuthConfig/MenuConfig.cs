using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMenuMVC.AuthConfig
{
    public class MenuConfig
    {
        public MenuConfig()
        {
            IsParent = false;
            HasChild = false;
            IsActive = true;
        }
        public int Id { get; set; }
        public string DisplayText { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public string Area { get; set; }
        public bool IsParent { get; set; }
        public int ParentId { get; set; }
        public bool HasChild { get; set; }
        public string Icon { get; set; }
        public bool IsActive { get; set; }
    }
}