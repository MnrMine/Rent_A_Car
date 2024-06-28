using Microsoft.AspNetCore.Mvc;

namespace Rent_A_Car.ViewComponents
{
    public class _LayoutNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
