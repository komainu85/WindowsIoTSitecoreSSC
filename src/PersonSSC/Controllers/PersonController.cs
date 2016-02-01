using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WindowsIoTSitecoreSSC.Model;
using Sitecore.Services.Infrastructure.Services;
using Sitecore.Services.Core;

namespace WindowsIoTSitecoreSSC.Controllers
{
    public class PersonController : EntityService<Person>
    {
        protected PersonController(IRepository<Person> repository) : base(repository)
        {
        }
    }
}