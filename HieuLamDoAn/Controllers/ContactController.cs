using HieuLamDoAn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HieuLamDoAn.Controllers
{
    public class ContactController : Controller
    {
        private readonly DataContext _context;
        public ContactController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Contact mn)
        {
         
            if (ModelState.IsValid)
            {
                _context.Contacts.Add(mn);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mn);
        }
    }
}
