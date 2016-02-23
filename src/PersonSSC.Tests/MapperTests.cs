using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework.Internal;
using NUnit.Framework;
using PersonSSC.Contracts;
using PersonSSC.Model;
using Sitecore.Analytics.Tracking;

namespace PersonSSC.Tests
{
    [TestFixture]
    public class MapperTests
    {
        [Test]
        public void Mapper_Correctly_Maps_Identifier()
        {
            var contact = CreateContactMock();

            var person = new Person();

            var xdbFacetRepository = new Mock<IXdbFacetRepository>();
            xdbFacetRepository.Setup(x => x.GetPersonalInfo(contact.Object, ref person));

            var mapper = new Mapper(xdbFacetRepository.Object);
            person = mapper.MapPerson(contact.Object);

            Assert.AreEqual(person.Id, "MyId");
        }

        private Mock<Contact> CreateContactMock()
        {
            var contact = new Mock<Contact>();
            contact.Setup(x => x.Identifiers.Identifier).Returns("MyId");
            return contact;
        }
    }
}
