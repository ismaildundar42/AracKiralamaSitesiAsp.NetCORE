# 🚗 Gazi Rent a Car - Araç Kiralama Otomasyon Sistemi

Modern ve kullanıcı dostu bir **Araç Kiralama Otomasyonu** arıyorsanız doğru yerdesiniz!  
Bu proje, ASP.NET Core MVC kullanılarak geliştirilmiş, hem yönetici hem de müşteri rolleri için işlevsel bir kiralama platformudur.

---

## 🧩 Proje Hakkında

> “Aracınızı kiralayın, süreci dijitalleştirin.”

Bu sistem; araç ekleme, güncelleme, silme, kiralama ve iade gibi işlemleri merkezi bir panelden yönetmenizi sağlar.  
Aynı zamanda müşteriler, yalnızca kendi kiralama bilgilerine erişerek güvenli bir arayüz üzerinden bilgilerini görebilir.

---

## 📌 Öne Çıkan Özellikler

- 🛡️ Admin Girişi ve Panel Yönetimi  
- 👥 Müşteri Girişi ve Kişiye Özel Panel  
- 📸 Araçlara Fotoğraf Yükleme & Görüntüleme  
- 🗓️ Tarihe Bağlı Kiralama İşlemleri  
- 🔁 Kiralama İptali & Durum Güncellemeleri  
- 📱 Responsive ve Modern Arayüz Tasarımı  

---

## 🔧 Kullanılan Teknolojiler

| Teknoloji               | Açıklama                                       |
|------------------------|------------------------------------------------|
| **ASP.NET Core MVC**   | Web uygulaması çatısı                          |
| **Entity Framework Core** | ORM ve veri tabanı yönetimi (Code First)     |
| **SQL Server**         | Veritabanı saklama ve yönetim sistemi          |
| **Bootstrap 5**        | Responsive ve modern arayüz tasarımı           |
| **Razor View Engine**  | HTML + C# tabanlı view yapısı                  |
| **LINQ**               | Koleksiyonlar üzerinde veri sorgulama          |
| **TempData / ViewBag** | Giriş & mesajlaşma işlemleri                   |
| **Visual Studio 2022** | Geliştirme ortamı                              |

---

## 🧭 Sistem Mimarisi

MVC yapısına göre düzenlenmiş 3 ana katmanlı yapı:

- **Model**: Veritabanı nesneleri & Repository sınıfları  
- **View**: Razor tabanlı dinamik sayfalar  
- **Controller**: İş mantığı & sayfa yönlendirmeleri  

Ayrıca her role özel sayfa yapıları (`/Arac`, `/Musteri`, `/Login`, `/Admin`, `/AracKiralama`) düzenli şekilde yapılandırılmıştır.

---

## 🔐 Giriş Bilgileri (Test Amaçlı)

| Rol     | Giriş          | Açıklama                    |
|---------|----------------|-----------------------------|
| Admin   | Kullanıcı Adı + Şifre | Yönetici panel erişimi    |
| Müşteri | TC No + Şifre          | Kiralama bilgisi görüntüleme |

---

## 🖼️ Örnek Ekranlar

> Projenin ekran görüntülerini `wwwroot/docs/screenshots` klasörüne ekleyin veya GitHub’a yükleyin.

- Giriş ekranı (Login)
- Araç Listeleme ve Fotoğraflı Görüntüleme
- Kiralama Formu (Tarihli)
- Müşteri Paneli
- Admin Panel İşlemleri

---

## 📁 Proje Yapısı
📦 AracKiralamaSitesiCoreProje/
├── Controllers/
├── Models/
├── Views/
│ ├── Arac/
│ ├── Musteri/
│ ├── Admin/
│ ├── Login/
│ └── Shared/
├── wwwroot/
│ └── uploads/ # Fotoğraflar
├── Data/
│ └── ApplicationDbContext.cs


---

## 📌 Notlar

- Geliştirme dili: **C# (.NET 7)**
- Kod mimarisi: **Temiz, ölçeklenebilir ve test edilebilir yapı**
- Eğitim / Dönem Sonu Web Programlama Dersi Bitirme projesi amaçlı hazırlanmıştır
- Kodlar Visual Studio 2022 üzerinde yazılmıştır

---

## 📞 İletişim

> Proje sahibi: **İsmail Dündar**  
> Gazi Üniversitesi - Bilgisayar Mühendisliği

Proje hakkında detaylı bilgi almak ya da destek sağlamak isterseniz iletişime geçebilirsiniz.

---
## 🖼️ Ekran Görüntüleri
![1](https://github.com/user-attachments/assets/eef1208f-6f5c-45ca-8a4b-4ed5df971f2c)
![2](https://github.com/user-attachments/assets/a9556c7c-f6ec-4383-ba30-307261fa2dc4)
![3](https://github.com/user-attachments/assets/5f7f0071-4f3c-4314-b482-95ea8470eea8)
![4](https://github.com/user-attachments/assets/d9bd2c09-3e43-4001-8e61-9220ee4b220f)
![5](https://github.com/user-attachments/assets/c2f0cf12-4cc1-42ff-8dc4-8733bb97d159)


**⭐ GitHub üzerinde beğendiyseniz repo’yu yıldızlamayı unutmayın!**

