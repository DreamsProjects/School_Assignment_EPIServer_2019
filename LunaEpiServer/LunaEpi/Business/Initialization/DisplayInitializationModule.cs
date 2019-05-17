using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.Web;

namespace LunaEpi.Business.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class DisplayInitializationModule : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            //Add initialization logic, this method is called once after CMS has been initialized

            var option = context.Locate.Advanced.GetInstance<DisplayOptions>();

            option.Add(id:SiteTags.Full, name:"full", tag: SiteTags.Full);
            option.Add(id: SiteTags.Wide, name: "wide", tag: SiteTags.Wide);
            option.Add(id: SiteTags.Narrow, name:"narrow", tag:SiteTags.Narrow);
        }

        public void Uninitialize(InitializationEngine context)
        {
        }
    }
}