using System.Web.Http;
using PersonSSC.IoC;
using Sitecore.Pipelines;
using StructureMap;

namespace PersonSSC.Pipelines.Initialize
{
    public class RegisterIoC
    {
        public void Process(PipelineArgs args)
        {
            var servicesConfig =  GlobalConfiguration.Configuration;

            var container = new Container(new IoC.Registry());
            servicesConfig.DependencyResolver = new StructureMapDependencyResolver(container);
        }
    }
}