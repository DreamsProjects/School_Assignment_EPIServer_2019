using LunaEpi.Models.Media;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EPiServer.Web;

namespace LunaEpi.Models.Blocks
{
    [ContentType(DisplayName = "Employee",
        GroupName = SiteGroupNames.Specialized,
        Description = "Use this to store information about an employee.")]
    [SiteBlockIcon]
    public class EmployeeBlock : BlockData
    {
        [Display(Name = "First name",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string FirstName { get; set; }

        [Display(Name = "Last name",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string LastName { get; set; }

        [Display(Name = "Email",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual string EmailAddress { get; set; }

        [Display(Name = "Phone number",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual string PhoneNumber { get; set; }

        [Display(Name = "Picture",
            GroupName = SystemTabNames.Content,
            Order = 40)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Picture { get; set; }
    }
}