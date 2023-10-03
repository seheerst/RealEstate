using Microsoft.AspNetCore.Mvc;

namespace RealEstate_UI.ViewComponents.HomePage
{
    public class _WhoWeAreComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
