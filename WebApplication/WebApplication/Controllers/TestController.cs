using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class TestController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Post([FromBody]BoardRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var board = ModelFactory.CreateBoard(model);

            return Ok(board);
        }
    }
}
