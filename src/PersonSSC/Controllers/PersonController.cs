using PersonSSC.Model;
using Sitecore.Services.Core;
using Sitecore.Services.Infrastructure.Services;

namespace PersonSSC.Controllers
{
    [ServicesController]
    public class PersonController : EntityService<Person>
    {
        public PersonController(IRepository<Person> repository) : base(repository)
        {
        }
    }
}