using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using technical_test_bungasari.Models;
using technical_test_bungasari.Services;

namespace technical_test_bungasari.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private readonly ConsumeApiServices _consumeApi;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration, ConsumeApiServices consumeApi)
        {
            _logger = logger;
            _configuration = configuration;
            _consumeApi = consumeApi;   
        }

        public async Task<IActionResult> Index()
        {
            var data = await _consumeApi.GetApiData();
            return View(data);
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
