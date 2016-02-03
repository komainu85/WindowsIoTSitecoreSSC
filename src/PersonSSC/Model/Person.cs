using Sitecore.Services.Core.Model;

namespace PersonSSC.Model
{
    public class Person: EntityIdentity
    {
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }
    }
}