using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace LunaEpi.Models.Blocks
{
    [ContentType(DisplayName = "Teaser Block",
        GUID = "fec2d234-a4ad-4a40-b6ba-36a88197db9f",
        Description = "Use this for rich text with heading, image and page link that will be reused in multiple places.")]
    [SiteBlockIcon]
    public class TeaserBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Heading", Order = 10,
            GroupName = SystemTabNames.PageHeader)]
        public virtual string TeaserHeading { get; set; }

        [CultureSpecific]
        [Display(Name = "Rich Text", Order = 20,
            GroupName = SystemTabNames.PageHeader)]
        public virtual XhtmlString TeaserText { get; set; }

        [Display(Name = "Image", Order = 30,
            GroupName = SystemTabNames.PageHeader)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference TeaserImage { get; set; }

        [CultureSpecific]
        [Display(Name = "Link", Order = 40,
            GroupName = SystemTabNames.PageHeader)]
        public virtual PageReference TeaserLink { get; set; }
    }
}