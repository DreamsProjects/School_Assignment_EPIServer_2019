using System.Web.Mvc;
using EPiServer.Web.Mvc;
using LunaEpi.Data;
using LunaEpi.Models.Pages;
using LunaEpi.Models.ViewModels;

namespace LunaEpi.Controllers
{
    public class StandardPageController : PageController<StandardPage>
    {

        public ActionResult Index(StandardPage currentPage)
        {
            var viewModel = PageViewModel.Create(currentPage);

            var data = Meta.MetaDataStandard(viewModel);

            viewModel = PageViewModel.Create(data);

            return View(viewModel);
        }
    }
}