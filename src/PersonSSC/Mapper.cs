using PersonSSC.Contracts;
using PersonSSC.Model;
using Sitecore.Analytics.Tracking;

namespace PersonSSC
{
    public class Mapper : IMapper
    {
        private readonly IXdbFacetRepository _xdbFacetRepository;

        public Mapper(IXdbFacetRepository iXdbFacetRepository)
        {
            _xdbFacetRepository = iXdbFacetRepository;
        }

        public Person MapPerson(Contact contact)
        {
            Person person = new Person();

            _xdbFacetRepository.GetPersonalInfo(contact, ref person);

            person.Id = contact.Identifiers.Identifier;

            return person;
        }

    }
}