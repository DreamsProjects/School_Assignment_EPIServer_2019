using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using LunaEpi.Models.Blocks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LunaEpi.Models.Pages
{
    [ContentType(DisplayName = "Standard",
        GroupName = SiteGroupNames.Common,
        Description = "Use this page type unless you need a more specialized one.")]
    [SitePageIcon]
    public class StandardPage : SitePageData
    {
        [CultureSpecific]
        [Display(Name = "Heading",
        Description = "If the Heading is not set, the page falls back to showing the Name.",
        GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 150)]
        public virtual XhtmlString MainBody { get; set; }


        [CultureSpecific]
        [Display(Name = "Sidebar content area",
Description = "Drag and drop images, blocks, folders, and pages with partial templates. This bar is going to the left side on the page",
GroupName = SystemTabNames.Content, Order = 30)]
        [AllowedTypes(typeof(StandardPage), typeof(BlockData), typeof(ImageData), typeof(ContentFolder), typeof(EmployeeBlock))]
        public virtual ContentArea SideBarContentArea { get; set; }

        [CultureSpecific] //Behövs för att skriva ut lista med artiklar
        [Display(Name = "Main content area",
        Description = "Drag and drop images, blocks, folders, and pages with partial templates.",
        GroupName = SystemTabNames.Content, Order = 160)]
        [AllowedTypes(typeof(StandardPage), typeof(BlockData), typeof(ImageData), typeof(ContentFolder), typeof(EmployeeBlock))]
        public virtual ContentArea MainContentArea { get; set; }
    }
}