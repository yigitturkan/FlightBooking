using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.ViewComponents.DefaultViewComponents.BookingViewComponents
{
    public class _BookingAreaComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            return View();
        }
    }
}
