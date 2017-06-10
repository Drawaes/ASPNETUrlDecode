using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace URLDecode.Controllers
{
    [Route("api/[controller]")]
    public class ExpectedUrlController:Controller
    {
        [HttpGet]
        public string Get(string someValue)
        {
            return WebUtility.UrlDecode(someValue);
        }
    }
}
