using Microsoft.AspNetCore.Mvc;
using HieuLamDoAn.Models;

namespace HieuLamDoAn.Components
{
    [ViewComponent(Name = "FoodMenu")]
    public class FoodMenuComponent : ViewComponent
    {
        private readonly DataContext _context;
        public FoodMenuComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofFoodMenu = (from p in _context.FoodMenus
                                 select p).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", listofFoodMenu));
        }
    }
}
