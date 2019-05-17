using System.Web.Mvc;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using LunaEpi.Models.Blocks;
using LunaEpi.Models.ViewModels;

namespace LunaEpi.Controllers
{
    [TemplateDescriptor(Tags = new[] { SiteTags.Full }, AvailableWithoutTag = true)]
    public class TeaserBlockController : BlockController<TeaserBlock>
    {
        public override ActionResult Index(TeaserBlock currentBlock)
        {
            var viewmodel = new TeaserBlockViewModel
            {
                CurrentBlock = currentBlock
            };

            return PartialView(viewmodel);
        }
    }

    [TemplateDescriptor(Tags = new[] { SiteTags.Wide })]
    public class TeaserBlockWideController : BlockController<TeaserBlock>
    {
        public override ActionResult Index(TeaserBlock currentBlock)
        {
            var viewmodel = new TeaserBlockViewModel
            {
                CurrentBlock = currentBlock
            };

            return PartialView(viewmodel);
        }
    }

    [TemplateDescriptor(Tags = new[] { SiteTags.Narrow })]
    public class TeaserBlockNarrowController : BlockController<TeaserBlock>
    {
        public override ActionResult Index(TeaserBlock currentBlock)
        {
            var viewmodel = new TeaserBlockViewModel
            {
                CurrentBlock = currentBlock
            };

            return PartialView(viewmodel);
        }
    }
}