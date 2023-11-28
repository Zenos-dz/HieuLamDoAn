using Microsoft.AspNetCore.Mvc;
using HieuLamDoAn.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HieuLamDoAn.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class FoodMenuController : Controller
    {
        private readonly DataContext _context;
        public FoodMenuController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var mnList = _context.FoodMenus.OrderBy(n => n.FoodID).ToList();
            return View(mnList);
        }
		[HttpGet]
        
        public IActionResult Delete(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}
			var mn = _context.FoodMenus.Find(id);
			if (mn == null)
			{
				return NotFound();
			}
			return View(mn);
		}
		[HttpPost]
		public IActionResult Delete(int id)
		{
			var deleFoodMenus = _context.FoodMenus.Find(id); if (deleFoodMenus == null)
			{
				return NotFound();
			}
			_context.FoodMenus.Remove(deleFoodMenus);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult Create()
		{
			var mnList = (from m in _context.FoodMenus
						  select new SelectListItem()
						  {
							  Text = m.Title,
							  Value = m.FoodID.ToString(),
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
		public IActionResult Create(FoodMenu mn)
		{
			if (ModelState.IsValid)
			{
				_context.FoodMenus.Add(mn);
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
			var mn = _context.FoodMenus.Find(id);
			if (mn == null)
			{
				return NotFound();
			}

			var mnList = (from m in _context.FoodMenus
						  select new SelectListItem()
						  {
							  Text = m.Title,
							  Value = m.FoodID.ToString(),
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
		public IActionResult Edit(FoodMenu mn)
		{
			if (ModelState.IsValid)
			{
				_context.FoodMenus.Update(mn);
				_context.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(mn);
		}
	}
}
