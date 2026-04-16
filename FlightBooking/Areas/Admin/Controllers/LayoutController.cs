using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.Areas.Admin.Controllers
{
    public class LayoutController : Controller
    {
        [Area("Admin")]
        public IActionResult AdminLayout()
        {
            return View();
        }
    }
}
