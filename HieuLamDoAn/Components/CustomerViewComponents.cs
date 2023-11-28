using Microsoft.AspNetCore.Mvc;
using HieuLamDoAn.Models;

namespace HieuLamDoAn.Components
{
    [ViewComponent(Name = "CustomerView")]
    public class CustomerViewComponent : ViewComponent
    {
        private readonly DataContext _context;
        public CustomerViewComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofCustomerView = (from n in _context.Customer
                                        select n).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", listofCustomerView));
        }

    }
}