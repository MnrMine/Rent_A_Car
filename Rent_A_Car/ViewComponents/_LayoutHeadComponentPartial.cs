using Microsoft.AspNetCore.Mvc;

namespace Rent_A_Car.ViewComponents
{
    public class _LayoutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
