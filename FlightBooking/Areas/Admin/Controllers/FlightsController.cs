using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.Areas.Admin.Controllers
{
    [Area("Admin")] // Neden Kullandık? - Uygulamayı daha küçük, yönetilebilir ve mantıksal gruplara ayırmak için kullanılır.
    // 1. Dosya ve Klasör düzenini Sağlamak: Büyük projelerde herşeyi tek bir Controllers ve viewse koyarsak karışır. Area kullanarak projeyi bölebilirsin.
    // 2. Yönlendirme Mekanizması: Şu mesaj verilir. "Eğer bu özniteliği yazmazsan, söstem admin klaörü altındaki bu Controller'ı bulamaz!"
    // 3. İsim Karışıklığı önlemek: Diyelimki hem kullanıcının göreceği FlightsController var hemde adminin yöneteceği FlightsController var. Controllers/FlightsController.cs (normal kullanıcı için), Areas/Admin/Controllers/FlightsController.cs (Admin paneli için)
    public class FlightsController : Controller
    {
        public IActionResult FlightList()
        {
            return View();
        }


        [HttpGet] // Bu şu demek: Bu action sadece GET isteği ile çalışır.
        public IActionResult CreateFlight ()
        {
            return View();
        }
    }

    // Nasıl Çalışır?
    // Program.cs dosyanızda genellikle Areas için özel bir rota tanımlanmıştır


    // app.UseEndpoints(endpoints =>
    // {
    // endpoints.MapControllerRoute(
    //      name: "areas",
    //     pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    //    );
    // });

}
