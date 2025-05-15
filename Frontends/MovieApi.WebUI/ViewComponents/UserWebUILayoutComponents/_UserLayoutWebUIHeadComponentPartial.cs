using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponents.UserWebUILayoutComponents
{
    public class _UserLayoutWebUIHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
