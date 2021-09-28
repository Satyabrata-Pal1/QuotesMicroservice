using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuotesMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesMaster.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class QuotesController : ControllerBase
    {
        [HttpGet("GetQuote/{businessValue}/{propertyValue}/{propertyType}")]
        public int Get(int businessValue, int propertyValue, PropertyType propertyType)
        {
            try
            {
                Quotes quote = new Quotes();
                quote.calculateQuote(businessValue, propertyValue, propertyType);
                return quote.quoteAmount;
            }
            catch (Exception msg)
            {
                throw (msg);
            }

        }
    }
}
