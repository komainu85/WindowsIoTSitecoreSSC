using PersonSSC.Model;
using Sitecore.Analytics.DataAccess;
using Sitecore.Analytics.Tracking;

namespace PersonSSC.Contracts
{
    public interface IXdbContactRepository
    {
        Contact CreateContact(Person person);
        void UpdateContact(Contact contact, Person person);
        Contact FindContact(string identifier, out LockAttemptStatus lockAttemptStatus);
    }
}