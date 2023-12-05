using Microsoft.AspNetCore.Mvc;
using HieuLamDoAn.Models;

namespace HieuLamDoAn.Components
{
    [ViewComponent(Name = "Customer")]
    public class CustomerComponent : ViewComponent
    {
        private readonly DataContext _context;
        public CustomerComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofCustomer = (from n in _context.Customer
                                        select n).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", listofCustomer));
        }

    }
}