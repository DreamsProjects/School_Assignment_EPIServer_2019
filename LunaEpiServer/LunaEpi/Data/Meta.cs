using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using LunaEpi.Models.Pages;
using LunaEpi.Models.ViewModels;
namespace LunaEpi.Data
{
    public static class Meta
    {
        /// <summary>
        /// Skapar en kopia av Article och Standard-Page för att kunna modifiera meta title och metadata
        /// </summary>
        /// <param name="site"></param>
        /// <returns></returns>

        public static ArticlePage MetaDataArticle(PageViewModel<ArticlePage> site)
        {
            // Get object used to load Episerver content
            var contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();

            // Some content reference
            var contentLink = new ContentReference(6);

            // Get content of a specific type
            var somePage = contentLoader.Get<StartPage>(contentLink);

            var cloneStart = somePage.CreateWritableClone() as StartPage;

            var cloneArticle = site.CurrentPage.CreateWritableClone() as ArticlePage;

            cloneArticle.MetaTitle = cloneStart.MetaTitle;
            cloneArticle.MetaDescription = cloneStart.MetaDescription;

            // Strongly typed access to content property
            return cloneArticle;
        }

        public static StandardPage MetaDataStandard(PageViewModel<StandardPage> site)
        {
            // Get object used to load Episerver content
            var contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();

            // Some content reference
            var contentLink = new ContentReference(6);

            // Get content of a specific type
            var somePage = contentLoader.Get<StartPage>(contentLink);

            var cloneStart = somePage.CreateWritableClone() as StartPage;

            var cloneStandard = site.CurrentPage.CreateWritableClone() as StandardPage;

            cloneStandard.MetaTitle = cloneStart.MetaTitle;
            cloneStandard.MetaDescription = cloneStart.MetaDescription;

            // Strongly typed access to content property
            return cloneStandard;
        }
    }
}