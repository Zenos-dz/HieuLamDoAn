using Microsoft.AspNetCore.Mvc;
using HieuLamDoAn.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HieuLamDoAn.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MemberController : Controller
    {
        private readonly DataContext _context;
        public MemberController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var tmlist = _context.TeamMembers.OrderBy(m => m.MemberID).ToList();
            return View(tmlist);

        }
		[HttpGet]
		public IActionResult Delete(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}
			var mn = _context.TeamMembers.Find(id);
			if (mn == null)
			{
				return NotFound();
			}
			return View(mn);
		}
		[HttpPost]
		public IActionResult Delete(int id)
		{
			var deleMember = _context.TeamMembers.Find(id); if (deleMember == null)
			{
				return NotFound();
			}
			_context.TeamMembers.Remove(deleMember);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult Create()
		{
			var mnList = (from m in _context.TeamMembers
						  select new SelectListItem()
						  {
							  Text = m.MemberName,
							  Value = m.MemberID.ToString(),
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
		public IActionResult Create(TeamMembers mn)
		{
			if (ModelState.IsValid)
			{
				_context.TeamMembers.Add(mn);
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
            var mn = _context.TeamMembers.Find(id);
            if (mn == null)
            {
                return NotFound();
            }

            var mnList = (from m in _context.TeamMembers
                          select new SelectListItem()
                          {
                              Text = m.MemberName,
                              Value = m.MemberID.ToString(),
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
        public IActionResult Edit(TeamMembers mn)
        {
            if (ModelState.IsValid)
            {
                _context.TeamMembers.Update(mn);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mn);
        }
    }
}
