using EPiServer.Core;
using System.ComponentModel.DataAnnotations;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace LunaEpi.Models.Blocks
{
    [ContentType(DisplayName = "Listing",
        GUID = "5a2319f4-d770-4c01-9b5f-0abfa7542669",
        GroupName = SiteGroupNames.Common,
        Description = "Choose a page in the tree, and its children will be listed, with a heading.")]
    [SiteBlockIcon]
    public class ListingBlock : BlockData
    {
        [Display(Name = "Heading", Order = 10)]
        public virtual string Heading { get; set; }

        [Display(Name = "Show children of this page", Order = 20)]
        public virtual PageReference ShowChildrenOfThisPage { get; set; }
    }
}