// Bir uçak bileti sitelerinde her sayfada değişen ama aslında kendi içinde bağımsız çalışan bölümler vardır. 

// Senaryo: Müşteri önce uçuşu seçer, sonra koltuk seçer sonra yemek seçer... Her adımda ekranın sağ tarafında
// "Seçtiğiniz Uçuşlar ve Toplam Tutar" bilgisini gösteren bir panel vardır.

// 1- Neden Partial View Değil? 
// Eğer bu sağ paneli Partial View ile yaparsan; uçuş seçim sayfasını yöneten FlightController, koltuk seçimini yöneten
// SeatController ve ödemeyi yöneten PaymentController 'ın her birinin içine "sepeti hesapla ve modele ekle" kodunu
// yazman gerekir. Bu tam bir "kod tekrarı" felaketidir.

// 2- ViewComponent Çözümü 
// Biz bir CartSummaryViewComponent oluştururuz. Bu arkadaş, session'da veya veritabanında o anki rezervasyona ait ne varsa
// kendisi gider çeker, tutarı hesaplar ve ekrana basar. Controller'ların ruhu duymaz!

// Kod Örneği: Bu sınıf sadece sepeti hesaplamaktan sorumludur.

// public class CartSummaryViewComponent : ViewComponent
// {
//     private readonly ICartService _cartService;
//
//     public CartSummaryViewComponent(ICartService cartService)
//     {
//          _cartService = cartService;
//     }
//
//     public async Task<IViewComponentResult> InvokeAsync()
//     {
//          // Kullanıcının o anki seçimlerini (uçuş, bagaj, yemek) servisten alıyoruz!
//          var cart = await _cartService.GetCurrentCartAsync();
//
//          // Veriyi View'a (Default.cshtml) gönderiyoruz.
//          rerurn View(cart);
//     }
// }

// Görünüm Tarafı: Default.cshtml - Sağ taraftaki o şık özet paneli:

// <div class="booking-summary-card">
//     <h3>Rezervasyon Özetiniz</h3>
//     <ul>
//          <li>Uçuş: @Model.FlightNumber</li>
//          <li>Koltuk: @Model.SeatNo</li>
//          <li>Ekstra Bagaj: @Model.ExtraBaggage kg</li>
//     </ul>
//     <hr />
//     <strong> Toplam: @Model.TotalPrice.ToString("C")</strong>
// </div>

// Nerelerde Kullanabiliriz? - Uçak bileti projesinde şu alanların her biri mükemmel birer ViewComponent adayıdır:

//  - Döviz Çevirici: Sayfanın üst kısmında bilet fiyatlarını USD, EUR veya TRY cinsinden gösteren küçük araç.
//  - Üye Giriş Paneli: Sağ üst köşede "Giriş Yap" butonu veya giriş yapılmışsa "Merhaba Ahmet, 500 mil puanın var" yazan kısım.
//  - Kampanya Duyuruları: Sadece uçuş arama sonuçları sayfasında görünen, gidilecek şehre özel otel fırsatları.

// Eğitmen NOTU: "ViewComponent" kullanmak, projedeki Controller'lara "Sen sadece kendi işine odaklan, yandaki sepetle veya
// veya döviz kuruyla ben ilgilenirim" demektir. Bu sayede kodun modüler olur; yarın öbür gün sepetin hesaplanma mantığı değişirse, sadece tek bir 
// component dosyasını değiştirmen yeterli olur.
