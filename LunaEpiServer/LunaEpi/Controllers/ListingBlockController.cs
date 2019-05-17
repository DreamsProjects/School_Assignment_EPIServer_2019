using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using LunaEpi.Models.Blocks;
using LunaEpi.Models.ViewModels;

namespace LunaEpi.Controllers
{
    public class ListingBlockController : BlockController<ListingBlock>
    {
        //Describes  a service that can be used to read content data objects from a repository!

        public override ActionResult Index(ListingBlock currentBlock)
        {
            var contentRepository = ServiceLocator.Current.GetInstance<IContentLoader>();

            var viewModel = new ListingBlockViewModel
            {
                Heading = currentBlock.Heading
            };

            if (currentBlock.ShowChildrenOfThisPage != null)
            {
                IEnumerable<PageData> children = contentRepository.GetChildren<PageData>(currentBlock.ShowChildrenOfThisPage);

                IEnumerable<IContent> filtered = FilterForVisitor.Filter(children);

                viewModel.Pages = filtered.Cast<PageData>().Where(x => x.VisibleInMenu);
            }

            return PartialView(viewModel);
        }
    }
}