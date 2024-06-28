using Microsoft.AspNetCore.Mvc;

namespace Rent_A_Car.ViewComponents
{
    public class _LayoutSideBarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
