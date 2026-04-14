//1. Invoke() Nedir?

//Invoke kelimesinin Türkçe karşılığı "çağırmak" veya **"yürütmek"**tir.

//Sen ana sayfanın (Index.cshtml) bir köşesine @await Component.InvokeAsync("_DefaultHeadComponentPartial") yazdığında, 
//ASP.NET Core motoru gidip bu sınıfın içindeki Invoke (veya InvokeAsync) metodunu bulur ve çalıştırır.

//- Uçak Bileti Örneği: Diyelim ki bu Component uçuş listesini getiriyor. Invoke metodunun içi, 
//    "Veritabanına git, İstanbul-Londra uçuşlarını bul ve getir" talimatının yazıldığı yerdir.

//- Neden ismi Invoke? Çünkü bu bir standarttır. Sistem, sınıfın içine girince hangi metodun "ana giriş kapısı" 
//    olduğunu bu isim sayesinde anlar.

//3. return View(); Ne Yapar? (Paket Servis)

//Bu satır, hazırlanan verileri (eğer varsa) alır ve ilgili .cshtml dosyasına (görünüme) gönderir.

//    Sen return View(); dediğinde, sistem gidip otomatik olarak Default.cshtml dosyasını arar.

//    Bu, mutfakta hazırlanan yemeğin (veri) tabağa (view) konulup garsona (tarayıcıya) teslim edilmesidir.

//Eğitmen Özeti: Benim adım _DefaultHeadComponentPartial. Birisi beni sayfada çağırdığında (Invoke), hiçbir karmaşık işlem yapma (içi boş),
//    sadece git benim kendi View dosyamı (Default.cshtml) bul ve olduğu gibi ekrana bas.