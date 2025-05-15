using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponents.UserWebUILayoutComponents
{
    public class _UserLayoutWebUINavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
