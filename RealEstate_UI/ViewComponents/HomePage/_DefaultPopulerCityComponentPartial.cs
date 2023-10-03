using Microsoft.AspNetCore.Mvc;

namespace RealEstate_UI.ViewComponents.HomePage
{
    public class _DefaultPopulerCityComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
