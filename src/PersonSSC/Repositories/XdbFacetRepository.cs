using PersonSSC.Contracts;
using PersonSSC.Model;
using Sitecore.Analytics.Model.Entities;
using Sitecore.Analytics.Model.Framework;
using Sitecore.Analytics.Tracking;

namespace PersonSSC.Repositories
{
    public class XdbFacetRepository : IXdbFacetRepository
    {
        public T GetFacet<T>(Contact contact, string name) where T : class, IFacet
        {
            return contact.GetFacet<T>(name);
        }

        public void UpdatePersonalInfo(Person person, ref Contact contact)
        {
            var facet = GetFacet<IContactPersonalInfo>(contact, "Personal");

            facet.FirstName = person.FirstName;
            facet.Surname = person.Surname;
        }

        public void GetPersonalInfo(Contact contact, ref Person person)
        {
            var facet = GetFacet<IContactPersonalInfo>(contact, "Personal");

            person.FirstName = facet.FirstName;
            person.Surname = facet.Surname;
        }


    }
}