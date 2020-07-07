using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace XMLWebAPI.Controllers
{
    public class WebController : ApiController
    {
        public string Get()
        {
            return "Welcome to Web API";
        }

        public List<string> Get(int id)
        {
            return new List<string>
            {
                "Data1",
                "Data2"
            };
        }
    }
}
