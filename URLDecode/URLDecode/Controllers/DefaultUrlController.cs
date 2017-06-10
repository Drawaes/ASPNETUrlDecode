using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace URLDecode.Controllers
{
    [Route("api/[controller]")]
    public class DefaultUrlController:Controller
    {
        [HttpGet("{someInput}")]
        public string Get(string someInput)
        {
            return someInput;
        }
    }
}
