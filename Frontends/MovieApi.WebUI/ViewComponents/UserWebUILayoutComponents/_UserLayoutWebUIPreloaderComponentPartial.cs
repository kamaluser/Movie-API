using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponents.UserWebUILayoutComponents
{
    public class _UserLayoutWebUIPreloaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
