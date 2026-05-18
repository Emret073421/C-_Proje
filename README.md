# 🎮 C# Mini Oyunlar ve Uygulamalar Paketi

![C#](https://img.shields.io/badge/Dil-C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET Framework](https://img.shields.io/badge/Platform-.NET%20Forms-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Visual Studio](https://img.shields.io/badge/IDE-Visual%20Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)

Bu proje dizini, C# programlama dili ve **Windows Forms** altyapısı kullanılarak geliştirilmiş, çeşitli popüler mini oyunları ve pratik masaüstü uygulamalarını barındıran bir arşivdir. Hem algoritmik düşünce yapısını güçlendirmek hem de olay yönelimli programlama (event-driven programming), GUI kontrol yönetimi ve oyun döngülerini (game loop) anlamak amacıyla tasarlanmıştır.

---

## 📂 İçerideki Projeler ve Özellikleri

### 1. 🧮 HesapMakinesiDeneme
* Standart matematiksel işlemleri (toplama, çıkarma, çarpma, bölme) gerçekleştirebilen masaüstü hesap makinesi.
* Temiz ve kullanıcı dostu arayüz tasarımı.
* Hatalı tuşlamalara ve sıfıra bölme hatalarına karşı koruma algoritmaları.

### 2. 💣 Mayın_Tarlası_2 (Minesweeper)
* Efsanevi Mayın Tarlası oyununun Windows Forms uyarlaması.
* **Dinamik Buton Üretimi:** Matris şeklinde butonların kod tarafında dinamik olarak oluşturulması.
* **Mayın Algoritması:** Rastgele mayın yerleştirme ve etraftaki mayın sayısını hesaplayan komşuluk algoritmaları.
* Sağ tık ile bayrak ekleme/kaldırma ve oyun sonu (kazanma/kaybetme) denetimleri.

### 3. 🤖 XOX2Bilgisayar (Tic-Tac-Toe vs Yapay Zeka)
* Tek başınıza bilgisayara (yapay zekaya) karşı oynayabileceğiniz XOX (Tic-Tac-Toe) oyunu.
* Bilgisayarın hamle yapmasını sağlayan yapay zeka karar algoritmaları (savunma ve saldırı hamleleri).

### 4. 👥 XOX2KİŞİLİK (Tic-Tac-Toe İki Oyuncu)
* İki oyuncunun aynı bilgisayar üzerinde karşılıklı olarak oynayabileceği XOX versiyonu.
* Oyuncu sırası takibi (X ve O geçişleri), görsel bildirimler ve skor tablosu.
* Satır, sütun ve çapraz kontrol algoritmaları ile anında galibiyet tespiti.

### 5. 🐍 YılanOyunu (Snake Game)
* Klasik Yılan oyununun masaüstü versiyonu.
* `Timer` bileşeni kullanılarak akıcı hareket döngüsü ve hız yönetimi.
* Yön tuşları (Ok tuşları) ile anlık klavye dinleme (KeyEvents).
* Rastgele konumlarda elma (`Elma.cs`) üretimi, yılanın kuyruk uzaması (`Yilan.cs`) ve duvara/kendi kuyruğuna çarpma kontrolleri.

---

## 🚀 Kurulum ve Çalıştırma

1. Projeleri çalıştırmak için bilgisayarınızda **Visual Studio** (2019, 2022 vb.) kurulu olmalıdır.
2. Oynamak veya incelemek istediğiniz projenin klasörüne girin.
3. Klasör içerisindeki `.sln` (Solution) dosyasını Visual Studio ile açın.
4. Üst menüden **Başlat (Start)** butonuna basarak veya `F5` tuşuna basarak projeyi derleyip anında çalıştırabilirsiniz.

---

## 🛠️ Kullanılan Teknolojiler

* **Programlama Dili:** C#
* **Arayüz (GUI):** Windows Forms (.NET Framework)
* **Geliştirme Ortamı:** Microsoft Visual Studio

---

## 📜 Lisans ve Katkı

Bu projeler eğitim ve kişisel gelişim amacıyla oluşturulmuştur. Kodları dilediğiniz gibi inceleyebilir, geliştirebilir ve kendi projelerinizde referans olarak kullanabilirsiniz.
