using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuotesMaster.Controllers;


namespace QuotesMaster.Tests

{
    [TestFixture]
    public class Tests
    {

        [TestCase(2, 2, PropertyType.Building, 80000)]
        [TestCase(5, 8, PropertyType.ColdStorage, 28000)]
        [TestCase(3, 10, PropertyType.FactoryEquipment, 55000)]
        public void GetQuoteForPolicy(int businessValue, int propertyValue, PropertyType propertyType, int expectecdQuote)
        {
            var controller = new QuotesController();
            int actualQuote = controller.Get(businessValue, propertyValue, propertyType);
            Assert.AreEqual(expectecdQuote, actualQuote);
        }
    }
}
