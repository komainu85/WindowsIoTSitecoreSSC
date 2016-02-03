using PersonSSC.Model;
using Sitecore.Analytics.Model.Framework;
using Sitecore.Analytics.Tracking;

namespace PersonSSC.Contracts
{
    public interface IXdbFacetRepository
    {
        T GetFacet<T>(Contact contact, string name) where T : class, IFacet;
        void UpdatePersonalInfo(Person person, ref Contact contact);
        void GetPersonalInfo(Contact contact, ref Person person);
    }
}