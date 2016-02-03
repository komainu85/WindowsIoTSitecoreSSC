using PersonSSC.Model;
using PersonSSC.Repositories;
using Sitecore.Services.Core;

namespace PersonSSC.IoC
{
    public class Registry: StructureMap.Registry
    {
        public Registry()
        {
            For<Contracts.IMapper>().Use<Mapper>();
            For<Contracts.IXdbContactRepository>().Use<XdbContactRepository>();
            For<Contracts.IXdbFacetRepository>().Use<XdbFacetRepository>();
            For(typeof(IRepository<Person>)).Use(typeof(PersonRepository));
        }
    }
}