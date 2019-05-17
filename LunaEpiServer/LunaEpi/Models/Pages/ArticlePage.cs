using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using LunaEpi.Models.Blocks;

namespace LunaEpi.Models.Pages
{
    [ContentType(DisplayName = "Article",
    GUID = "33d4a416-83b4-47ea-854d-5e9c353ffdc1",
    GroupName = SiteGroupNames.News,
    Description = "Use this as a landing page for a list of news articles.")]
    [SitePageIcon]
    public class ArticlePage : StandardPage
    {
        //[Display(Name = "Article", Order = 315)]
        //public virtual ListingBlock NewsListing { get; set; }

    }
}