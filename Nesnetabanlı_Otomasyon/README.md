# 📦 Nesne Tabanlı Otomasyon Sistemi

![C#](https://img.shields.io/badge/Dil-C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET Console](https://img.shields.io/badge/Platform-Console%20App-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![OOP](https://img.shields.io/badge/Mimari-OOP%20%2F%2F%20CSV-FF9900?style=for-the-badge&logo=codeigniter&logoColor=white)

Bu proje, **Nesne Yönelimli Programlama (OOP - Object-Oriented Programming)** prensipleri (Kapsülleme, Kalıtım, Çok Biçimlilik ve Soyutlama) tam anlamıyla benimsenerek C# dilinde geliştirilmiş bir Mağaza ve POS (Point of Sale) Otomasyonu konsol uygulamasıdır. 

Sistem, harici bir SQL veritabanına ihtiyaç duymadan, veri kalıcılığını (persistence) yerel **CSV dosyaları** üzerinden sağlayarak hızlı, taşınabilir ve hafif bir mimari sunar.

---

## 🏗️ Proje Mimarisi ve Sınıf Yapısı (OOP Sınıfları)

Proje, sorumlulukların (SoC - Separation of Concerns) doğru paylaştırıldığı modüler sınıflardan oluşmaktadır:

### 🏷️ `Urun.cs` (Ürün Modeli)
* Mağazadaki ürünlerin temel niteliklerini (ID, Ürün Adı, Kategori, Fiyat, Stok Miktarı vb.) barındıran veri modelidir.
* Ürün stoklarının güncellenmesi ve fiyatlandırma hesaplamaları gibi iş mantıklarını kapsüller.

### 👤 `Personel.cs` (Personel Yönetimi)
* Sistemi kullanan çalışanların ve yöneticilerin kimlik bilgilerini, yetki seviyelerini ve giriş doğrulama (login) işlemlerini yöneten sınıftır.
* Çalışanların gerçekleştirdiği satışların takibini ve performans kayıtlarını tutar.

### 🛒 `Sepet.cs` (Sepet ve Satış İşlemleri)
* Müşterinin alışveriş sürecinde seçtiği ürünlerin sepete eklenmesi, çıkarılması ve listelenmesi işlemlerini yürütür.
* Toplam tutar hesaplaması, indirim/kampanya denetimleri ve ödeme sonlandırma (satış onayı) adımlarını gerçekleştirir.

### 📂 `DosyaYonetimi.cs` (Veri Erişim Katmanı / File I/O)
Sistemin can damarı olan bu sınıf, tüm kalıcı veri saklama operasyonlarını üstlenir. CSV tabanlı veritabanı tabloları gibi çalışarak şu dosyalarla çift yönlü veri akışı sağlar:
* 📁 `urunler.csv`: Mağazada kayıtlı tüm ürünlerin güncel stok ve fiyat listesi.
* 📁 `personeller.csv`: Sistemde aktif olan çalışanların kimlik ve yetki tablosu.
* 📁 `satislar.csv`: Gerçekleştirilen tüm başarılı satışların geçmiş kayıtları (fiş/fatura dökümleri).
* 📁 `alimlar.csv`: Mağazaya yapılan mal alımlarının ve stok girişlerinin dökümü.

### 🖥️ `Program.cs` (Ana Kontrol Merkezi)
* Kullanıcı etkileşimini sağlayan konsol menülerinin, yönlendirmelerin ve iş akışlarının yönetildiği ana giriş noktasıdır (Main method).

---

## 🌟 Öne Çıkan Özellikler

* **Stok ve Envanter Yönetimi:** Ürün ekleme, silme, güncelleme ve kritik stok uyarıları.
* **Alım-Satım Döngüsü:** Tedarikçiden ürün alımı (`alimlar.csv`) ve müşteriye ürün satışı (`satislar.csv`) süreçlerinin tam entegrasyonu.
* **Raporlama ve Muhasebe:** Günlük ve genel ciro analizi, en çok satan ürünler ve personel bazlı satış performansı raporları.
* **Bağımsız Çalışabilme:** Kurulum gerektirmeyen, taşınabilir CSV veri dosyaları sayesinde her ortamda anında çalışabilme yeteneği.

---

## 🚀 Kurulum ve Çalıştırma

1. Projeyi bilgisayarınıza indirin veya klonlayın.
2. `ConsoleApp2.sln` dosyasını **Visual Studio** ile açın.
3. Projeyi derlemek ve konsol ekranını başlatmak için `F5` tuşuna basın.
4. Açılan konsol menüsündeki yönlendirmeleri (sayısal seçimleri) kullanarak sistemi deneyimleyebilirsiniz.

---

## 🛠️ Kullanılan Teknolojiler

* **Programlama Dili:** C#
* **Uygulama Türü:** .NET Console Application
* **Veri Saklama Yöntemi:** File I/O (CSV Dosya İşleme)

---

## 📜 Lisans

Bu proje, C# dilinde Nesne Yönelimli Programlama ve Dosya Yönetimi mimarilerini kavramak adına geliştirilmiş açık kaynaklı bir uygulamadır.
