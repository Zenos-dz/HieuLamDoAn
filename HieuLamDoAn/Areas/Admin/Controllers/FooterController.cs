using Microsoft.AspNetCore.Mvc;
using HieuLamDoAn.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace HieuLamDoAn.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class FooterController : Controller
    {
        
        private readonly DataContext _context;
        public FooterController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var tmlist = _context.Footer.OrderBy(m => m.FooterID).ToList();
            return View(tmlist);

        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var mn = _context.Footer.Find(id);
            if (mn == null)
            {
                return NotFound();
            }
            return View(mn);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var deleFooter = _context.Footer.Find(id); if (deleFooter == null)
            {
                return NotFound();
            }
            _context.Footer.Remove(deleFooter);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            var mnList = (from m in _context.Footer
                          select new SelectListItem()
                          {
                              Text = m.Company,
                              Value = m.FooterID.ToString(),
                          }).ToList();
            mnList.Insert(0, new SelectListItem()
            {
                Text = "----Select----",
                Value = "0"
            });
            ViewBag.mnList = mnList;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Footer mn)
        {
            if (ModelState.IsValid)
            {
                _context.Footer.Add(mn);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mn);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var mn = _context.Footer.Find(id);
            if (mn == null)
            {
                return NotFound();
            }

            var mnList = (from m in _context.Footer
                          select new SelectListItem()
                          {
                              Text = m.Company,
                              Value = m.FooterID.ToString(),
                          }).ToList();
            mnList.Insert(0, new SelectListItem()
            {
                Text = "----Select----",
                Value = String.Empty
            });
            ViewBag.mnList = mnList;

            return View(mn);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Footer mn)
        {
            if (ModelState.IsValid)
            {
                _context.Footer.Update(mn);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mn);
        }
    }
}
