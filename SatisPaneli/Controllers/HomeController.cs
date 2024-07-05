using Microsoft.AspNetCore.Mvc;
using SatisPaneli.Models;
using SatisPaneli.Models.MyModels;
using System.Diagnostics;

namespace SatisPaneli.Controllers
{
    [Route("SatisPaneli/[controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Task2EticaretContext _context;

        public HomeController(ILogger<HomeController> logger, Task2EticaretContext context)
        {
            _logger = logger;
            _context = context;
        }
        [Route("index")]
        public IActionResult Index()
        {
            var urunler = _context.Urunlers.Select(p => new Urun
            {
                KategoriAd = p.Kategori.KategoriAd,
                KategoriId = p.KategoriId,
                Miktar = p.Miktar,
                UrunAd = p.UrunAd,
                UrunId = p.UrunId
            }).ToList();
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
