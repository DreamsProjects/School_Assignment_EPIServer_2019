using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using LunaEpi.Models.Blocks;

namespace LunaEpi.Models.Pages
{
    [ContentType(DisplayName = "Start",
        GUID = "d90c31d6-889e-4589-afb7-11cef8abc7f8",
        GroupName = SiteGroupNames.Specialized, Order = 10,
        Description = "The home page for a website with an area for blocks and partial pages.")]
    [SiteStartIcon]
    [AvailableContentTypes(Include = new[] { typeof(StandardPage) })]
    public class StartPage : SitePageData
    {
        [CultureSpecific]
        [Display(Name = "Heading",
            Description = "If the Heading is not set, the page falls back to showing the Name.",
            GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content, Order = 20)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(Name = "Sidebar content area",
    Description = "Drag and drop images, blocks, folders, and pages with partial templates. This bar is going to the left side on the page",
    GroupName = SystemTabNames.Content, Order = 30)]
        [AllowedTypes(typeof(StandardPage), typeof(BlockData), typeof(ImageData), typeof(ContentFolder), typeof(EmployeeBlock))]
        public virtual ContentArea SideBarContentArea { get; set; }


        [CultureSpecific]
        [Display(Name = "Main content area",
            Description = "Drag and drop images, blocks, folders, and pages with partial templates.",
            GroupName = SystemTabNames.Content, Order = 40)]
        [AllowedTypes(typeof(StandardPage), typeof(BlockData), typeof(ImageData), typeof(ContentFolder), typeof(EmployeeBlock))]
        public virtual ContentArea MainContentArea { get; set; }

    }
}