using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HieuLamDoAn.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
    }
}
