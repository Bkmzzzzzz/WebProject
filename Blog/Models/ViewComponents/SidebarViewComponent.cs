using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Blog.Domain;

namespace Blog.Models.ViewComponents
{
    public class SidebarViewComponent : ViewComponent
    {
        private readonly DataManager dataManager;

        public SidebarViewComponent(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult((IViewComponentResult) View("Default", dataManager.NewsItems.GetSideBarNewsItems()));
        }
    }
}
