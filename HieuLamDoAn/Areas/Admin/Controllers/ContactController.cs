using HieuLamDoAn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HieuLamDoAn.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class ContactController : Controller
	{
		private readonly DataContext _context;
		public ContactController(DataContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			var tmlist = _context.Contacts.OrderBy(m => m.ContactID).ToList();
			return View(tmlist);

		}
		[HttpGet]
		public IActionResult Delete(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}
			var mn = _context.Contacts.Find(id);
			if (mn == null)
			{
				return NotFound();
			}
			return View(mn);
		}

		[Route("/Admin/Contact/Delete/{id}")]
		public IActionResult Delete(int id)
		{
			var deleContact = _context.Contacts.Find(id); 
			if (deleContact == null)
			{
				return NotFound();
			}
			_context.Contacts.Remove(deleContact);
			_context.SaveChanges();
			return RedirectToAction("index","contact");
		}
	}
}
