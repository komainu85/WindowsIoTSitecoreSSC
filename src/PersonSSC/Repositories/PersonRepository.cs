using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WindowsIoTSitecoreSSC.Model;
using Sitecore.Services.Core;

namespace WindowsIoTSitecoreSSC.Repositories
{
    public class PersonRepository : IRepository<Person>
    {
        public IQueryable<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public Person FindById(string id)
        {
            throw new NotImplementedException();
        }

        public void Add(Person entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Person entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Person entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}