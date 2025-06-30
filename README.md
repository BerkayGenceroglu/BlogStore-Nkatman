
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
![image](https://github.com/user-attachments/assets/cb53e93e-7723-48b4-8177-41e7d2fbd7af)
![image](https://github.com/user-attachments/assets/eff670b7-a145-40a7-9211-64c97b1d9033)
![image](https://github.com/user-attachments/assets/b2138feb-28b3-4e1f-a51e-07a4e4f45d2a)
![image](https://github.com/user-attachments/assets/a9231aad-7878-432e-ab54-ed2722c23146)
📄 Kullanıcılar tarafından yazılan tüm makalelerin tarih, kategori ve görsel ile birlikte listelendiği sayfa.
!

---

### 📌 Makale Detay Sayfası

![image](https://github.com/user-attachments/assets/41bb0896-7ed5-44c5-b737-98267620d978)
![image](https://github.com/user-attachments/assets/0aa56e60-fb66-4cfa-858f-0cf7cb8e2460)
📝 Bir makalenin tam içeriğinin, yazara ait bilgilerle birlikte detaylı olarak gösterildiği ekran.



---

### 📌 Yorumlar Bölümü

![image](https://github.com/user-attachments/assets/19b5aaf7-f32d-4a16-80e1-3392b1d97d45)
📝 Bir makalenin tam içeriğinin, yazara ait bilgilerle birlikte detaylı olarak gösterildiği ekran.



---

### 📌 Yazarlar Sayfası

![image](https://github.com/user-attachments/assets/e1f10dae-6868-4fbd-afd3-b8d963e06d26)
👤 Tüm yazarların görselleriyle birlikte listelendiği, her bir yazarın profiline erişim sağlayan tanıtım ekranı.


---

### 📌 Kategoriye Göre Makale Filtreleme

![image](https://github.com/user-attachments/assets/e0fdfae3-a842-4cbc-8273-f18c51eae442)
📚 Kullanıcıların belirli bir kategori seçerek sadece o kategoriye ait makaleleri görüntüleyebildiği filtreleme ekranı.

---

### 📌 Kayıt Ol Sayfası

![image](https://github.com/user-attachments/assets/7926346e-3720-4789-8fc8-56003f16d294)
🧾 Yeni kullanıcıların ad, soyad, e-posta ve şifre bilgileriyle sisteme kayıt olduğu form ekranı.

---

### 📌 Giriş Yap Sayfası
![image](https://github.com/user-attachments/assets/acb3ad04-7f1b-424c-a3ac-69f8ce93fa9a)
🔐 Sisteme daha önce kayıtlı kullanıcıların giriş yaptığı kullanıcı adı ve şifre formu.



---

### 📌 Yazar Profili

![image](https://github.com/user-attachments/assets/075a5b56-d26e-4fd9-aa29-c013a2f9159d)
👨‍💼 Yazarın fotoğrafı, adı, e-posta adresi ve hakkında açıklamalarla birlikte profilinin görüntülendiği sayfa.




---

### 📌 Profil Güncelleme

![image](https://github.com/user-attachments/assets/5857b71c-4daf-45a1-b1b5-007bb39aba4f)
🛠️ Yazarların profil fotoğrafı, açıklama ve kişisel bilgilerini düzenleyebildiği sayfa.


---

### 📌 Yeni Makale Oluşturma

![image](https://github.com/user-attachments/assets/b26cdb00-0bd9-43a8-84ef-e6c8d7931933)
🖊️ Yazarların başlık, görsel, kategori ve içerik belirleyerek yeni bir makale oluşturduğu form sayfası.




---

### 📌 Makale Listeleme (Yazara Özel)

![image](https://github.com/user-attachments/assets/7deb693d-00d0-43bd-b103-c673267d7467)
📑 Sadece oturum açmış yazarın kendi oluşturduğu makaleleri görüntüleyebildiği özel liste ekranı.



---

### 📌 Yazar Paneli Dashboard - İstatistik

![image](https://github.com/user-attachments/assets/d2677242-3ff3-4a88-a52d-2958f5eed2bf)
📊 Yazara özel gösterge panelinde, kategorilere göre makale sayılarını ve dağılımını gösteren grafikler.



---

### 📌 Yazar Paneli Dashboard - Son İçerikler ve Yorumlar

![image](https://github.com/user-attachments/assets/7938bd41-522f-41ff-bdb2-51b5b1e1fbbd)
📊 Yazara özel gösterge panelinde, kategorilere göre makale sayılarını ve dağılımını gösteren grafikler.

---
