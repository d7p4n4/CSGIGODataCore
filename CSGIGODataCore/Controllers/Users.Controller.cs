using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CSGIGODataCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Users : ODataController
    {


        [HttpGet]
        [EnableQuery()]
        public IEnumerable<User> Get()
        {
            return new Context().Userek;
        }
    }
}
