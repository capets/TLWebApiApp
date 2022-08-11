using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TLWebApi.Models;

namespace TLWebApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return RedirectPermanent("swagger/index.html");            
        }  
    }
}