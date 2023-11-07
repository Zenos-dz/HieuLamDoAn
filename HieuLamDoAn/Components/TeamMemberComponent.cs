using Microsoft.AspNetCore.Mvc;
using HieuLamDoAn.Models;
namespace HieuLamDoAn.Components
{
    [ViewComponent(Name = "TeamMemberView")]
    public class TeamMemberComponent : ViewComponent
    {
        private readonly DataContext _context;
        public TeamMemberComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofTeamMemberView = (from m in _context.TeamMembers
                             select m).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", listofTeamMemberView));
        }
    }
}
