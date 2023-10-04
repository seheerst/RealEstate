using Microsoft.AspNetCore.Mvc;

namespace RealEstate_UI.ViewComponents.HomePage
{
    public class _DefaultStepsComponentPartial: ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
