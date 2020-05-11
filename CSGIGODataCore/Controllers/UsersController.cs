using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSGIGUserServer;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CSGIGODataCore.Controllers
{
    //[ApiController]
    [Route("odata/[controller]")]
    public class UsersController : ODataController
    {

        [HttpGet]
        [EnableQuery]
        public IEnumerable<User> Get()
        {

            return new Context().Userek;
        }
        /*
        [HttpDelete]
        public IActionResult Delete([FromODataUri] int id)
        {
            return Ok(id);
        }


        /*/
        public IActionResult Delete([FromBody] DeleteUserByIdRequest request)
        {
            return Ok(new UserServerObjectService().DeleteUserById(request));
        }


        [HttpPatch]
        public IActionResult Patch([FromBody] UpdateUserByIdRequest request)
        {
            return Ok(new UserServerObjectService().UpdateUserById(request));
        }

        [HttpPost]
        public IActionResult AddNewUser([FromBody] InsertNewUserRequest request)
        {
            new UserServerObjectService().InsertNewUser(request);
            return Ok(request.User);
        }



    }
}
