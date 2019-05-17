using System.Web.Mvc;
using LunaEpi.Models.Pages;
using EPiServer.Web.Mvc;
using LunaEpi.Models.ViewModels;

namespace LunaEpi.Controllers
{
    public class StartPageController : PageController<StartPage>
    {

        public ActionResult Index(StartPage currentPage)
        {
            var viewModel = PageViewModel.Create(currentPage);

            return View(viewModel);
        }
    }
}