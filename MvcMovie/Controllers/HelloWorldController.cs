using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld
       public IActionResult Index()
       {
            return View();
       }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["numTimes"] = numTimes;

            return View();
        }

        // GET: /HelloWorld/Welcome
        /* public string Welcome(string name, int numTimes = 0)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}"); //HtmlEncoder.Default.Encode to protect the app from malicious inpu
        } */

        public string Goodbye(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}
