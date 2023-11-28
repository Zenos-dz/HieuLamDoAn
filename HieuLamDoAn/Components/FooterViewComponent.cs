using Microsoft.AspNetCore.Mvc;
using HieuLamDoAn.Models;
namespace HieuLamDoAn.Components
{
	[ViewComponent(Name = "FooterView")]
	public class FooterViewComponent : ViewComponent
	{
		private readonly DataContext _context;
		public FooterViewComponent(DataContext context)
		{
			_context = context;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var lisofFooter = (from d in _context.Footer
							   select d).ToList();
			return await Task.FromResult((IViewComponentResult)View("Default", lisofFooter));
		}
	}
}
