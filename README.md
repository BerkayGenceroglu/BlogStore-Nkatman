
# BlogStore 📝

**BlogStore**, ASP.NET Core MVC ile geliştirilen, kullanıcıların makaleler oluşturup okuyabildiği, yorum yapabildiği, yazarlara özel profillerin bulunduğu, yönetici paneli ile içeriklerin kolayca takip edilebildiği çok katmanlı bir blog uygulamasıdır.

Bu proje; gerçek bir blog sistemi geliştirmek isteyen yazılımcılar için hem frontend hem de backend alanında kapsamlı örnekler sunar. Aynı zamanda modern yazılım mimarisi olan katmanlı mimari (Layered Architecture) ile kodun sürdürülebilirliği artırılmıştır.

---

## 🚀 Proje Özellikleri

- ✅ Kullanıcı girişi ve kaydı (ASP.NET Core Identity ile)
- ✅ Makale ekleme, silme, güncelleme ve detaylı görüntüleme
- ✅ Makalelere kategori atama ve kategori bazlı listeleme
- ✅ Kullanıcı yorumları (AJAX + ViewComponent destekli)
- ✅ SweetAlert2 ile interaktif bildirim sistemi
- ✅ HuggingFace ToxicBERT ile toksik yorum kontrolü
- ✅ HuggingFace çeviri API ile yorum çevirisi (TR-EN)
- ✅ Gelişmiş yönetici paneli: İstatistikler, içerik ve yorum kontrolü
- ✅ Responsive tasarım (mobil ve tablet uyumu)
- ✅ Kullanıcı profili düzenleme ve görsel güncelleme
- ✅ ViewComponent, jQuery AJAX, Partial View yapıları ile modern yaklaşım

---

## 🛠️ Kullanılan Teknolojiler

| Katman / Katkı         | Teknolojiler / Kütüphaneler                            |
|------------------------|--------------------------------------------------------|
| Backend (Sunucu)       | ASP.NET Core MVC 6.0, Entity Framework Core            |
| Frontend (Arayüz)      | Razor View Engine, HTML, CSS, Bootstrap 5, jQuery      |
| Veritabanı             | Microsoft SQL Server                                   |
| Güvenlik               | ASP.NET Core Identity                                  |
| API / NLP Servisleri   | Hugging Face (ToxicBERT, Çeviri API)                   |
| Bildirim Sistemi       | SweetAlert2                                            |
| Grafik & Dashboard     | Chart.js (kategori analizleri için)                    |

---

## 📁 Proje Yapısı

Proje, katmanlı mimari (Layered Architecture) yapısı ile geliştirilmiştir:

- **`BlogStore.PresentationLayer`**  
  Kullanıcı arayüzü, controller sınıfları, ViewComponent’ler, Razor view’lar ve `Program.cs` gibi başlangıç ayarlarını içerir.

- **`BlogStore.BusinessLayer`**  
  Servis ve iş mantığı katmanı. `Manager` sınıfları ve interface tanımlamaları burada yer alır. SOLID prensipleriyle yazılmıştır.

- **`BlogStore.DataAccessLayer`**  
  Entity Framework Core ile veritabanı işlemlerinin gerçekleştiği katman. `EfRepository`, `Context` ve migration işlemleri bu katmanda yapılır.

- **`BlogStore.EntityLayer`**  
  Projede kullanılan temel varlık sınıfları (Entity’ler). `Article`, `Comment`, `AppUser`, `Category` gibi domain modellerini içerir.

---

## 📸 Ekran Görüntüleri

### 📌 Ana Sayfa - Blog Listeleme

![Ana Sayfa - Blog Listeleme](./screenshots/d690b93d-9c82-4039-8011-156ad5a9b1dd.png)

---

### 📌 Makale Detay Sayfası

![Makale Detay Sayfası](./screenshots/6bbc1678-ac18-4f7b-9c22-5e09d55f5658.png)

---

### 📌 Yorumlar Bölümü

![Yorumlar Bölümü](./screenshots/277f43c9-a18d-4e8d-8fca-63003bc7686e.png)

---

### 📌 Yazarlar Sayfası

![Yazarlar Sayfası](./screenshots/11543c55-7fb5-4260-888e-e3b970d17ba2.png)

---

### 📌 Kategoriye Göre Makale Filtreleme

![Kategoriye Göre Makale Filtreleme](./screenshots/1e58b3c9-c648-4812-bc03-e1158a2be92c.png)

---

### 📌 Kayıt Ol Sayfası

![Kayıt Ol Sayfası](./screenshots/6a91705c-25b2-4cc5-bba9-396ea23fd9ca.png)

---

### 📌 Giriş Yap Sayfası

![Giriş Yap Sayfası](./screenshots/024c6c67-3cb5-4baf-9d58-c459b83be1ec.png)

---

### 📌 Yazar Profili

![Yazar Profili](./screenshots/de274368-5419-4378-908c-7adb9da61b73.png)

---

### 📌 Profil Güncelleme

![Profil Güncelleme](./screenshots/6ca933b8-352b-4e7f-bfc8-4fb041a39bf7.png)

---

### 📌 Yeni Makale Oluşturma

![Yeni Makale Oluşturma](./screenshots/508fa96a-c791-436f-90f1-9abbdf5790e7.png)

---

### 📌 Makale Listeleme (Yazara Özel)

![Makale Listeleme (Yazara Özel)](./screenshots/3c40c3d6-8ec2-408a-a97d-51a1459cd305.png)

---

### 📌 Yazar Paneli Dashboard - İstatistik

![Yazar Paneli Dashboard - İstatistik](./screenshots/bf681cc4-0c6c-45b2-a03d-158830645e7f.png)

---

### 📌 Yazar Paneli Dashboard - Son İçerikler ve Yorumlar

![Yazar Paneli Dashboard - Son İçerikler ve Yorumlar](./screenshots/72b1b0ef-be7f-4f01-865e-4626039b29c5.png)

---
