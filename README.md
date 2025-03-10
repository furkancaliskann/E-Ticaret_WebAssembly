# E-Ticaret_WebAssembly


Bu proje, **WebAssembly** kullanılarak geliştirilmiş bir **ön yüz** uygulamasıdır. Arka uç, **.NET Core Web API** kullanılarak geliştirilmiş ve farklı bir GitHub projesi olarak yer almaktadır. Bu ön yüz uygulaması, kullanıcıların ve adminlerin ürünleri görüntüleyebilmesini, sepetlerine ekleyebilmesini, sipariş oluşturabilmesini ve geçmiş siparişlerini inceleyebilmesini sağlar. Ayrıca, admin hesabı üzerinden ürün yönetimi ve kullanıcı siparişlerini görüntüleme işlemleri yapılabilir.

## Proje Özellikleri

### Admin Özellikleri:
- **Ürün Yönetimi:** Admin, yeni ürünler ekleyebilir, mevcut ürünleri güncelleyebilir veya silebilir.
- **Kullanıcı Sipariş Görüntüleme:** Admin, tüm kullanıcıların verdiği siparişleri görebilir.
- **Şifre Değiştirme:** Admin, şifresini değiştirebilir.

### Kullanıcı Özellikleri:
- **Ürün Listeleme:** Kullanıcılar, mevcut ürünleri listeleyebilir.
- **Sepet Yönetimi:** Kullanıcılar, istedikleri ürünleri sepetlerine ekleyebilir. Sepetlerinde bulunan ürünlerin miktarını değiştirebilir.
- **Sipariş Oluşturma:** Kullanıcılar, sepetlerindeki ürünlerle yeni bir sipariş oluşturabilir.
- **Geçmiş Siparişler:** Kullanıcılar, geçmişte yaptıkları alışverişleri görüntüleyebilir ve detaylarına göz atabilir.
- **Şifre Değiştirme:** Kullanıcılar, hesap şifrelerini değiştirebilir.

### Teknolojiler:
- **WebAssembly:** Uygulamanın ön yüzü WebAssembly ile geliştirilmiştir.
- **Bootstrap:** Görsel arayüzde Bootstrap framework’ü kullanılmıştır.
- **.NET Core Web API:** Arka uç API işlemleri için .NET Core Web API kullanılmıştır.
- **Modal:** Kullanıcılar geçmiş siparişlerinin detaylarına bakarken modal pencereler kullanılmıştır.

### **localStorage Kullanımı:**
- **Kullanıcı Giriş Bilgileri:** Kullanıcıların giriş bilgileri (kullanıcı adı, şifre vb.) `localStorage` içinde tutulur. Kullanıcı giriş yaptıktan sonra bilgileri tarayıcıda saklanarak, sayfalar arasında geçişlerde tekrar giriş yapmalarına gerek kalmaz.
- **Sepet Yönetimi:** Sepete eklenen ürünler, miktar değişiklikleri ve silme işlemleri `localStorage`'da saklanır. Böylece kullanıcı sayfayı yenilesa bile sepetindeki ürünler kaybolmaz.