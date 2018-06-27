using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Directory.Models;
using Microsoft.Extensions.Options;

namespace Directory.Controllers
{
    public class HomeController : Controller
    {
        private readonly Links links;

        public HomeController(IOptions<Links> options)
        {
            this.links = options.Value;
        }

        public IActionResult Index()
        {
            return View(links);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
