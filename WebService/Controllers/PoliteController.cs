using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebService.Controllers
{
    public class PoliteController : ApiController
    {

        // GET: api/Polite/5
        public string SayHi()
        {
            return "Hello World";
        }

    }
}
