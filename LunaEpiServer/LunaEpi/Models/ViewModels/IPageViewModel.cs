using EPiServer.Core;
using LunaEpi.Models.Pages;
using System.Collections.Generic;

namespace LunaEpi.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : SitePageData
    {
        T CurrentPage { get; }
        StartPage StartPage { get; }
        IEnumerable<SitePageData> MenuPages { get; }
        IContent Section { get; }
    }
}