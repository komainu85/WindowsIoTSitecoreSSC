using PersonSSC.Model;
using Sitecore.Analytics.Tracking;

namespace PersonSSC.Contracts
{
    public interface IMapper
    {
        Person MapPerson(Contact contact);
    }
}