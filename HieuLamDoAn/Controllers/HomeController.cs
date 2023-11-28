using HieuLamDoAn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace HieuLamDoAn.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;
        public HomeController(ILogger<HomeController> logger, DataContext context)
        {
            _logger = logger;

            _context = context;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult Index()
        {
            var typeFood = (from item in _context.TypeFood select item).ToList();

            ViewBag.typeFood = typeFood;
            return View(typeFood);
        }

        [Route("/test")]
        
        
        public IActionResult YourAction()
        {
            var typeFood = (from item in _context.TypeFood select item).ToList();

            ViewBag.typeFood = typeFood;
            ViewData["test"] = typeFood;
            return Ok(typeFood);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}