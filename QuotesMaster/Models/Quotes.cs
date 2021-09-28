using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesMaster.Models
{
    public class Quotes
    {

        public int quoteAmount { get; set; }



        public int calculateQuote(int businessValue, int propertyValue, PropertyType propertyType)
        {
            if (propertyType.Equals(PropertyType.Building))
            {
                quoteAmount =  50000 + GetBusinessValueAmount(businessValue) + GetPropertyValueAmount(propertyValue);
            }
            else if (propertyType.Equals(PropertyType.FactoryEquipment))
            {
                quoteAmount =  40000 + GetBusinessValueAmount(businessValue) + GetPropertyValueAmount(propertyValue);
            }
            else if (propertyType.Equals(PropertyType.PropertyInTransit))
            {
                quoteAmount = 30000 + GetBusinessValueAmount(businessValue) + GetPropertyValueAmount(propertyValue);
            }
            else if (propertyType.Equals(PropertyType.ColdStorage))
            {
                quoteAmount = 20000 + GetBusinessValueAmount(businessValue) + GetPropertyValueAmount(propertyValue);
            }
           
            return quoteAmount;
        }

        public int GetBusinessValueAmount(int businessValue)
        {
            int businessValueAmount;

            if ( 0 <= businessValue && businessValue <= 2)
            {
                businessValueAmount = 15000;
            }
            else if(3 <= businessValue && businessValue <= 5)
            {
                businessValueAmount = 10000;
            }
            else if(6 <= businessValue && businessValue <=8)
            {
                businessValueAmount = 8000;
            }
            else if(9 <= businessValue && businessValue <=10)
            {
                businessValueAmount = 5000;
            }
            else
            {
                businessValueAmount = 0;
            }
            return businessValueAmount;
        }

        public int GetPropertyValueAmount(int propertyValue)
        {
            int propertyValueAmount;

            if (0 <= propertyValue && propertyValue <= 2)
            {
                propertyValueAmount = 15000;
            }
            else if (3 <= propertyValue && propertyValue <= 5)
            {
                propertyValueAmount = 10000;
            }
            else if (6 <= propertyValue && propertyValue <= 8)
            {
                propertyValueAmount = 8000;
            }
            else if (9 <= propertyValue && propertyValue <= 10)
            {
                propertyValueAmount = 5000;
            }
            else
            {
                propertyValueAmount = 0;
            }
            return propertyValueAmount;
        }
    }
}
