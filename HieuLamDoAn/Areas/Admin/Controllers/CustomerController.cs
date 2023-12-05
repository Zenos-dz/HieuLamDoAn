using HieuLamDoAn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HieuLamDoAn.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class CustomerController : Controller
	{
		private readonly DataContext _context;
		public CustomerController(DataContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			var tmlist = _context.Customer.OrderBy(m => m.CustomerID).ToList();
			return View(tmlist);

		}
		[HttpGet]
		public IActionResult Delete(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}
			var mn = _context.Customer.Find(id);
			if (mn == null)
			{
				return NotFound();
			}
			return View(mn);
		}
		[HttpPost]
		public IActionResult Delete(int id)
		{
			var deleCustomer = _context.Customer.Find(id); if (deleCustomer == null)
			{
				return NotFound();
			}
			_context.Customer.Remove(deleCustomer);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult Create()
		{
			var mnList = (from m in _context.Customer
						  select new SelectListItem()
						  {
							  Text = m.Name,
							  Value = m.CustomerID.ToString(),
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
		public IActionResult Create(Customer mn)
		{
			if (ModelState.IsValid)
			{
				_context.Customer.Add(mn);
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
			var mn = _context.Customer.Find(id);
			if (mn == null)
			{
				return NotFound();
			}

			var mnList = (from m in _context.Customer
						  select new SelectListItem()
						  {
							  Text = m.Name,
							  Value = m.CustomerID.ToString(),
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
		public IActionResult Edit(Customer mn)
		{
			if (ModelState.IsValid)
			{
				_context.Customer.Update(mn);
				_context.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(mn);
		}
	}
}
