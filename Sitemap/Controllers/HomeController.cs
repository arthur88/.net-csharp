using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Sitemap.Models;
using AspNetCore.SEOHelper.Sitemap;

namespace Sitemap.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _env;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment env)
        {
            _logger = logger;
            _env = env;
        }

        public string CreateSitemapInRootDirectory()
        {
            var list = new List<SitemapNode>();
            list.Add(new SitemapNode { LastModified = DateTime.UtcNow, Priority = 0.8, Url = "https://www.example.com/asp-dot-net-turotial-part1", Frequency = SitemapFrequency.Daily });
            list.Add(new SitemapNode { LastModified = DateTime.UtcNow, Priority = 0.8, Url = "https://www.example.com/asp-dot-net-turotial-part2", Frequency = SitemapFrequency.Yearly });
            list.Add(new SitemapNode { LastModified = DateTime.UtcNow, Priority = 0.7, Url = "https://www.example.com/asp-dot-net-turotial-part3", Frequency = SitemapFrequency.Monthly });
            list.Add(new SitemapNode { LastModified = DateTime.UtcNow, Priority = 0.6, Url = "https://example.com/another-learning", Frequency = SitemapFrequency.Yearly });

            new SitemapDocument().CreateSitemapXML(list, _env.ContentRootPath);
            return "sitemap.xml file should be create in root directory";
        }

        public IActionResult Index()
        {
            CreateSitemapInRootDirectory();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
