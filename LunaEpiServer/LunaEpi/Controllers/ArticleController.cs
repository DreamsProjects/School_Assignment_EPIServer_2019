using System.Web.Mvc;
using EPiServer.Core;
using EPiServer.Web.Mvc;
using LunaEpi.Data;
using LunaEpi.Models.Pages;
using LunaEpi.Models.ViewModels;

namespace LunaEpi.Controllers
{
    public class ArticleController : PageController<ArticlePage>
    {
        public ActionResult Index(ArticlePage currentPage)
        {
            var viewModel = PageViewModel.Create(currentPage);

            var data = Meta.MetaDataArticle(viewModel);

            viewModel = PageViewModel.Create(data);

            return View(viewModel);
        }
    }
}