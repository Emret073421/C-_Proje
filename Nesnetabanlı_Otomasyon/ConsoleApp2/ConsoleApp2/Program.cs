using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        // Global nesnelerimiz: Program çalıştığı sürece aktif kalırlar
        static List<Urun> envanter = new List<Urun>();
        static Sepet mevcutSepet = new Sepet();
        static List<Personel> personeller = new List<Personel>();

        static void Main(string[] args)
        {
            // Program başlarken CSV'den verileri yükle
            envanter = DosyaYonetimi.VerileriYukle();
            personeller = DosyaYonetimi.PersonelleriYukle();

            bool anaDevam = true;
            while (anaDevam)
            {
                Console.Clear();
                Console.WriteLine("**************************************************");
                Console.WriteLine("* MARKET OTOMASYON SİSTEMİ GİRİŞ EKRANI          *");
                Console.WriteLine("**************************************************");
                Console.WriteLine("[1] Yönetici Girişi");
                Console.WriteLine("[2] Personel Girişi");
                Console.WriteLine("[0] Çıkış");
                Console.WriteLine("**************************************************");
                Console.Write("Seçiminiz: ");

                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        YoneticiGiris();
                        break;
                    case "2":
                        PersonelGiris();
                        break;
                    case "0":
                        Console.WriteLine("Veriler kaydediliyor... Hoşça kalın!");
                        DosyaYonetimi.VerileriKaydet(envanter);
                        DosyaYonetimi.PersonelleriKaydet(personeller);
                        anaDevam = false;
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim! Devam etmek için bir tuşa basın...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void YoneticiGiris()
        {
            Console.Clear();
            Console.WriteLine("--- YÖNETİCİ GİRİŞİ ---");
            Console.Write("Kullanıcı Adı: "); string kAd = Console.ReadLine();
            Console.Write("Şifre: "); string sifre = Console.ReadLine();

            Personel aktifYonetici = personeller.Find(p => p.KullaniciAdi == kAd && p.Sifre == sifre && p.Yetki == "Admin");

            if (aktifYonetici != null)
            {
                bool devamEt = true;
                while (devamEt)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("**************************************************");
                    Console.WriteLine($"  YÖNETİCİ MENÜSÜ ");
                    Console.WriteLine($"  Hoşgeldin {aktifYonetici.Ad} {aktifYonetici.Soyad} ({aktifYonetici.Yetki})");
                    Console.WriteLine("**************************************************");
                    Console.ResetColor();
                    Console.WriteLine("[1] Ürünleri Listele (Stok Durumu)");
                    Console.WriteLine("[2] Yeni Ürün Tanımla (Sisteme Kayıt)");
                    Console.WriteLine("[3] Ürün Güncelle / Stok Yenile");
                    Console.WriteLine("[4] Ürün Sil");
                    Console.WriteLine("[5] Satış Yap (Sepet Sistemi)");
                    Console.WriteLine("[6] Günlük Satış Raporu");
                    Console.WriteLine("[7] Personel İşlemleri");
                    Console.WriteLine("[0] Çıkış Yap (Ana Ekrana Dön)");
                    Console.WriteLine("**************************************************");
                    Console.Write("Seçiminiz: ");

                    string secim = Console.ReadLine();

                    switch (secim)
                    {
                        case "1": UrunListele(); break;
                        case "2": YeniUrunEkle(); break;
                        case "3": StokGuncelle(); break;
                        case "4": UrunSil(); break;
                        case "5": SatisEkrani(); break;
                        case "6": RaporGoster(); break;
                        case "7": PersonelIslemleri(); break;
                        case "0": devamEt = false; break;
                        default:
                            Console.WriteLine("Geçersiz seçim!");
                            Console.ReadKey();
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Hatalı yönetici bilgileri!");
                Console.ReadKey();
            }
        }

        static void PersonelGiris()
        {
            Console.Clear();
            Console.WriteLine("--- PERSONEL GİRİŞİ ---");
            Console.Write("Kullanıcı Adı: "); string kAd = Console.ReadLine();
            Console.Write("Şifre: "); string sifre = Console.ReadLine();

            Personel aktifPersonel = personeller.Find(p => p.KullaniciAdi == kAd && p.Sifre == sifre && p.Yetki == "Personel");

            if (aktifPersonel != null)
            {
                bool devamEt = true;
                while (devamEt)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("**************************************************");
                    Console.WriteLine($"  PERSONEL MENÜSÜ ");
                    Console.WriteLine($"  Hoşgeldin {aktifPersonel.Ad} {aktifPersonel.Soyad} ({aktifPersonel.Yetki})");
                    Console.WriteLine("**************************************************");
                    Console.ResetColor();
                    Console.WriteLine("Personel yetkisine sahipsiniz. Sadece aşağıdaki işlemleri yapabilirsiniz.");
                    Console.WriteLine("[1] Ürünleri Listele (Stok Durumu)");
                    Console.WriteLine("[2] Satış Yap (Sepet Sistemi)");
                    Console.WriteLine("[0] Çıkış Yap (Ana Ekrana Dön)");
                    Console.WriteLine("**************************************************");
                    Console.Write("Seçiminiz: ");

                    string secim = Console.ReadLine();

                    switch (secim)
                    {
                        case "1": UrunListele(); break;
                        case "2": SatisEkrani(); break;
                        case "0": devamEt = false; break;
                        default:
                            Console.WriteLine("Geçersiz seçim!");
                            Console.ReadKey();
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Hatalı kullanıcı adı veya şifre!");
                Console.ReadKey();
            }
        }

        static void PersonelIslemleri()
        {
            bool devamEt = true;
            while(devamEt)
            {
                Console.Clear();
                Console.WriteLine("--- PERSONEL İŞLEMLERİ ---");
                Console.WriteLine("[1] Personel Ekle");
                Console.WriteLine("[2] Personel Çıkar");
                Console.WriteLine("[3] Personel Bilgisi Güncelle");
                Console.WriteLine("[4] Personelleri Listele");
                Console.WriteLine("[0] Geri Dön");
                Console.Write("Seçiminiz: ");
                
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1": PersonelEkle(); break;
                    case "2": PersonelCikar(); break;
                    case "3": PersonelGuncelle(); break;
                    case "4": PersonelListele(); break;
                    case "0": devamEt = false; break;
                    default: Console.WriteLine("Geçersiz seçim!"); Console.ReadKey(); break;
                }
            }
        }

        static void PersonelEkle()
        {
            Console.Clear();
            Console.WriteLine("--- PERSONEL EKLE ---");
            Console.Write("TC Kimlik No (İptal etmek için boş bırakıp Enter'a basın): "); 
            string tc = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(tc))
            {
                Console.WriteLine("\nİşlem iptal edildi.");
                return;
            }
            else
            {
                if(personeller.Exists(p => p.Tc == tc))
                {
                    Console.WriteLine("Bu TC'ye sahip bir personel zaten var!");
                }
                else
                {
                    Console.Write("Ad: "); string ad = Console.ReadLine();
                    Console.Write("Soyad: "); string soyad = Console.ReadLine();
                    Console.Write("Kullanıcı Adı: "); string kad = Console.ReadLine();
                    Console.Write("Şifre: "); string sifre = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n[ Yetki Seçimi ]");
                    Console.ResetColor();
                    Console.WriteLine("1. Admin (Tam Yetki)");
                    Console.WriteLine("2. Personel (Sınırlı Yetki)");
                    Console.Write("Seçiminiz (Varsayılan Personel): ");
                    string yetkiSecim = Console.ReadLine();
                    string yetki = (yetkiSecim == "1") ? "Admin" : "Personel";

                    Personel yeniPersonel = new Personel(tc, ad, soyad, kad, sifre, yetki);
                    personeller.Add(yeniPersonel);
                    DosyaYonetimi.PersonelleriKaydet(personeller);
                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nPersonel başarıyla eklendi.");
                    Console.ResetColor();
                }
            }
            Console.ReadKey();
        }

        static void PersonelCikar()
        {
            Console.Clear();
            Console.WriteLine("--- PERSONEL ÇIKAR ---");
            Console.Write("Çıkarılacak Personel TC (İptal etmek için boş bırakıp Enter'a basın): ");
            string tc = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(tc)) return;

            Personel p = personeller.Find(x => x.Tc == tc);
            if (p != null)
            {
                personeller.Remove(p);
                DosyaYonetimi.PersonelleriKaydet(personeller);
                Console.WriteLine("Personel başarıyla çıkarıldı.");
            }
            else
            {
                Console.WriteLine("Personel bulunamadı!");
            }
            
            Console.ReadKey();
        }

        static void PersonelGuncelle()
        {
            Console.Clear();
            Console.WriteLine("--- PERSONEL GÜNCELLE ---");
            Console.Write("Güncellenecek Personel TC (İptal etmek için boş bırakıp Enter'a basın): ");
            string tc = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(tc)) return;

            Personel p = personeller.Find(x => x.Tc == tc);
            if (p != null)
            {
                Console.WriteLine($"Eski Ad ({p.Ad}) - Yeni Ad (Bırakmak için Enter):");
                string yeniAd = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(yeniAd)) p.Ad = yeniAd;

                Console.WriteLine($"Eski Soyad ({p.Soyad}) - Yeni Soyad (Bırakmak için Enter):");
                string yeniSoyad = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(yeniSoyad)) p.Soyad = yeniSoyad;

                Console.WriteLine($"Eski Kullanıcı Adı ({p.KullaniciAdi}) - Yeni K.Adı (Bırakmak için Enter):");
                string yeniKad = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(yeniKad)) p.KullaniciAdi = yeniKad;

                Console.WriteLine($"Eski Şifre ({p.Sifre}) - Yeni Şifre (Bırakmak için Enter):");
                string yeniSifre = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(yeniSifre)) p.Sifre = yeniSifre;
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nEski Yetki ({p.Yetki}) - Yeni Yetki Seçin:");
                Console.ResetColor();
                Console.WriteLine("[1] Admin");
                Console.WriteLine("[2] Personel");
                Console.WriteLine("(Değiştirmemek için boş bırakıp Enter'a basın)");
                Console.Write("Seçiminiz: ");
                string yetkiSecim = Console.ReadLine();
                if (yetkiSecim == "1") p.Yetki = "Admin";
                else if (yetkiSecim == "2") p.Yetki = "Personel";

                DosyaYonetimi.PersonelleriKaydet(personeller);
                Console.WriteLine("Personel bilgileri güncellendi.");
            }
            else
            {
                Console.WriteLine("Personel bulunamadı!");
            }
            
            Console.ReadKey();
        }

        static void PersonelListele()
        {
            Console.Clear();
            Console.WriteLine("--- PERSONEL LİSTESİ ---");
            if(personeller.Count == 0)
            {
                Console.WriteLine("Kayıtlı personel yok.");
            }
            foreach(var p in personeller)
            {
                Console.WriteLine($"TC: {p.Tc} | Ad: {p.Ad} | Soyad: {p.Soyad} | K.Adı: {p.KullaniciAdi} | Yetki: {p.Yetki}");
            }
            Console.ReadKey();
        }

        // --- MENÜ FONKSİYONLARI ---

        static void UrunleriTabloCiz(string turFiltresi = "Tümü")
        {
            var listelenecek = envanter;
            if (turFiltresi != "Tümü")
            {
                listelenecek = envanter.FindAll(x => x.UrunTurunuGetir() == turFiltresi);
            }

            Console.WriteLine(new string('=', 98));
            Console.WriteLine($"| {"Barkod",-12} | {"Ürün Adı",-25} | {"Türü",-10} | {"Stok",-6} | {"A.Fiyat",-10} | {"S.Fiyat",-10} |");
            Console.WriteLine(new string('=', 98));
            if (listelenecek.Count == 0)
            {
                Console.WriteLine("| İlgili türde kayıtlı ürün bulunmamaktadır.".PadRight(97) + "|");
            }
            else
            {
                foreach (var urun in listelenecek)
                {
                    Console.WriteLine($"| {urun.Barkod,-12} | {urun.Ad,-25} | {urun.UrunTurunuGetir(),-10} | {urun.Stok,-6} | {urun.AlisFiyati + " TL",-10} | {urun.SatisFiyati + " TL",-10} |");
                }
            }
            Console.WriteLine(new string('=', 98));
        }

        static void UrunSil()
        {
            Console.Clear();
            Console.WriteLine("--- ÜRÜN SİLME EKRANI ---");
            UrunleriTabloCiz();
            Console.Write("\nSilinecek ürünün barkodunu girin (İptal için boş bırakıp Enter'a basın): ");
            string barkod = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(barkod)) return;

            Urun urun = envanter.Find(u => u.Barkod == barkod);
            
            if (urun != null)
            {
                Console.Write($"'{urun.Ad}' isimli ürünü silmek istediğinize emin misiniz? (E/H): ");
                string onay = Console.ReadLine();
                if (onay.ToUpper() == "E")
                {
                    envanter.Remove(urun);
                    DosyaYonetimi.VerileriKaydet(envanter);
                    Console.WriteLine("\n[BİLGİ] Ürün başarıyla silindi!");
                }
                else
                {
                    Console.WriteLine("\n[BİLGİ] Silme işlemi iptal edildi.");
                }
            }
            else
            {
                Console.WriteLine("\n[HATA] Bu barkoda ait bir ürün bulunamadı!");
            }
            
            Console.WriteLine("\nMenüye dönmek için bir tuşa basın...");
            Console.ReadKey();
        }

        static void UrunListele()
        {
            Console.Clear();
            Console.WriteLine("--- MEVCUT ÜRÜNLER DÖKÜMÜ ---");
            Console.WriteLine("Görüntülemek istediğiniz filtreyi seçin:");
            Console.WriteLine("[1] Tümü (Filtresiz)");
            Console.WriteLine("[2] Sadece Gıda Ürünleri");
            Console.WriteLine("[3] Sadece Teknoloji Ürünleri");
            Console.WriteLine("[4] Sadece Temizlik Ürünleri");
            Console.WriteLine("[5] Sadece Standart Ürünler");
            Console.Write("Seçiminiz: ");
            string secim = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("--- ÜRÜN LİSTESİ ---");
            if (secim == "2") UrunleriTabloCiz("Gıda");
            else if (secim == "3") UrunleriTabloCiz("Teknoloji");
            else if (secim == "4") UrunleriTabloCiz("Temizlik");
            else if (secim == "5") UrunleriTabloCiz("Standart");
            else UrunleriTabloCiz();

            Console.WriteLine("\nMenüye dönmek için bir tuşa basın...");
            Console.ReadKey();
        }

        static void SatisEkrani()
        {
            bool satisDevam = true;

            while (satisDevam)
            {
                Console.Clear();
                Console.WriteLine("--- SATIŞ / SEPET EKRANI ---");
                Console.WriteLine("\n[MEVCUT ÜRÜNLER]");
                UrunleriTabloCiz();

                // 1. Sepetin Güncel Durumunu Göster
                if (mevcutSepet.GetUrunler().Count > 0)
                {
                    Console.WriteLine("\n[Mevcut Sepetiniz]");
                    Console.WriteLine("{0,-20} {1,-10} {2,-15}", "Ürün", "Adet", "Ara Toplam");
                    Console.WriteLine("--------------------------------------------------");
                    double genelToplam = 0;
                    foreach (var item in mevcutSepet.GetUrunler())
                    {
                        Console.WriteLine("{0,-20} {1,-10} {2,-15} TL", item.Urun.Ad, item.Adet, item.AraToplam);
                        genelToplam += item.AraToplam;
                    }
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine($"GENEL TOPLAM: {genelToplam} TL\n");
                }
                else
                {
                    Console.WriteLine("\nSepetiniz şu an boş.\n");
                }

                // 2. Kullanıcıdan Komut Al
                Console.WriteLine("İşlemler: [Barkod Okut] | [B] Satışı Bitir | [İ] İptal Et ve Çık | [C] Sepetten Ürün Çıkar");
                Console.Write("Barkod veya İşlem Seçimi: ");
                string giris = Console.ReadLine();

                // 3. Komutları Yorumla
                if (giris.ToUpper() == "B") // Satışı Tamamla
                {
                    if (mevcutSepet.GetUrunler().Count > 0)
                    {
                        DosyaYonetimi.SatisKaydet(mevcutSepet); // CSV'ye raporla
                        DosyaYonetimi.VerileriKaydet(envanter); // Stokların son halini dosyaya işle
                        mevcutSepet.Temizle();
                        Console.WriteLine("\nSatış başarıyla tamamlandı, fiş kesildi ve stoklar güncellendi!");
                    }
                    else
                    {
                        Console.WriteLine("\nSepet boş olduğu için satış yapılmadı.");
                    }
                    satisDevam = false; // Döngüden ve satış ekranından çık
                    Console.ReadKey();
                }
                else if (giris.ToUpper() == "İ" || giris.ToUpper() == "I") // Satışı İptal Et
                {
                    // İptal durumunda sepetteki ürünleri rafa (stoğa) geri koymamız lazım! (OOP Gücü)
                    foreach (var item in mevcutSepet.GetUrunler())
                    {
                        item.Urun.StokEkle(item.Adet);
                    }
                    mevcutSepet.Temizle();
                    Console.WriteLine("\nSatış iptal edildi. Ürünler rafa geri konuldu.");
                    satisDevam = false;
                    Console.ReadKey();
                }
                else if (giris.ToUpper() == "C") // Sepetten Ürün Çıkar
                {
                    if (mevcutSepet.GetUrunler().Count == 0)
                    {
                        Console.WriteLine("\nSepetiniz zaten boş!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("Çıkarmak istediğiniz ürünün barkodunu girin: ");
                        string cikarBarkod = Console.ReadLine();
                        var sepetItem = mevcutSepet.GetUrunler().Find(x => x.Urun.Barkod == cikarBarkod);
                        if (sepetItem != null)
                        {
                            sepetItem.Urun.StokEkle(sepetItem.Adet);
                            mevcutSepet.GetUrunler().Remove(sepetItem);
                            Console.WriteLine($"\n'{sepetItem.Urun.Ad}' sepetten çıkarıldı ve {sepetItem.Adet} adet stok geri yüklendi!");
                        }
                        else
                        {
                            Console.WriteLine("\n[HATA] Sepette bu barkoda ait ürün bulunamadı!");
                        }
                        Console.ReadKey();
                    }
                }
                else // Komut değilse Barkod girilmiştir
                {
                    Urun urun = envanter.Find(u => u.Barkod == giris);

                    if (urun != null)
                    {
                        Console.Write($"{urun.Ad} (Stok: {urun.Stok}) - Kaç adet eklenecek?: ");

                        // Kullanıcı yanlışlıkla harf girerse program çökmesin diye TryParse kullanıyoruz
                        if (int.TryParse(Console.ReadLine(), out int adet) && adet > 0)
                        {
                            if (urun.SatisYap(adet)) // Stok yeterliyse düş
                            {
                                mevcutSepet.Ekle(urun, adet);
                                // İşlem başarılı, döngü başa dönecek ve sepeti güncelleyecek
                            }
                            else
                            {
                                Console.WriteLine("\n[HATA] Yetersiz stok! Lütfen bir tuşa basıp tekrar deneyin.");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n[HATA] Lütfen geçerli bir adet girin!");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n[HATA] Ürün bulunamadı! Lütfen bir tuşa basıp tekrar deneyin.");
                        Console.ReadKey();
                    }
                }
            }
        }

        static void YeniUrunEkle()
        {
            Console.Clear();
            Console.WriteLine("--- YENİ ÜRÜN TANIMLA ---");

            Console.Write("Barkod (İptal etmek için boş bırakıp Enter'a basın): ");
            string barkod = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(barkod)) return;

            // 1. AYNI BARKOD KONTROLÜ (Mükerrer kaydı önler)
            // Envanter listesinde bu barkoda sahip herhangi bir ürün var mı diye bakıyoruz
            if (envanter.Exists(u => u.Barkod == barkod))
            {
                Console.WriteLine("\n[HATA] Bu barkoda sahip bir ürün zaten sistemde kayıtlı!");
                Console.WriteLine("Mevcut ürüne stok eklemek için lütfen ana menüden '3- Stok Yenile' seçeneğini kullanın.");
                Console.WriteLine("\nMenüye dönmek için bir tuşa basın...");
                Console.ReadKey();
                return; // Metodu burada sonlandırır ve yeni ürün eklemeye devam etmez (Ana menüye döner)
            }

            // Barkod sistemde yoksa, diğer bilgileri sormaya devam et
            Console.Write("Ürün Adı: "); string ad = Console.ReadLine();
            Console.Write("Alış Fiyatı: "); double alis = double.Parse(Console.ReadLine());
            Console.Write("Satış Fiyatı: "); double satis = double.Parse(Console.ReadLine());
            Console.Write("İlk Stok Adedi: "); int stok = int.Parse(Console.ReadLine());

            Console.WriteLine("\nÜrün Kategorisini Seçin:");
            Console.WriteLine("1. Standart Ürün");
            Console.WriteLine("2. Gıda Ürünü");
            Console.WriteLine("3. Teknoloji Ürünü");
            Console.WriteLine("4. Temizlik Ürünü");
            Console.Write("Seçiminiz: ");
            string turSecim = Console.ReadLine();

            Urun yeniUrun;
            if (turSecim == "2")
                yeniUrun = new GidaUrunu(barkod, ad, stok, alis, satis);
            else if (turSecim == "3")
                yeniUrun = new TeknolojiUrunu(barkod, ad, stok, alis, satis);
            else if (turSecim == "4")
                yeniUrun = new TemizlikUrunu(barkod, ad, stok, alis, satis);
            else
                yeniUrun = new Urun(barkod, ad, stok, alis, satis);

            envanter.Add(yeniUrun);

            // İLK ALIMI RAPORLA 
            if (stok > 0)
            {
                DosyaYonetimi.AlimKaydet(ad, stok, alis);
            }

            // ENVANTERİ KAYDET
            DosyaYonetimi.VerileriKaydet(envanter);

            Console.WriteLine("\n**************************************************");
            Console.WriteLine("İşlem Başarılı!");
            Console.WriteLine($"'{ad}' başarıyla sisteme kaydedildi.");
            if (stok > 0) Console.WriteLine("İlk stok girişi 'alimlar.csv' dosyasına işlendi.");
            Console.WriteLine("**************************************************");

            Console.WriteLine("\nMenüye dönmek için bir tuşa basın...");
            Console.ReadKey();
        }
        static void StokGuncelle()
        {
            Console.Clear();
            Console.WriteLine("--- ÜRÜN GÜNCELLEME VE STOK GİRİŞİ ---");
            UrunleriTabloCiz();
            Console.Write("\nİşlem yapılacak ürünün barkodu (İptal için boş bırakıp Enter'a basın): ");
            string barkod = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(barkod)) return;

            Urun urun = envanter.Find(u => u.Barkod == barkod);

            if (urun != null)
            {
                Console.WriteLine($"\nBulunan Ürün: {urun.Ad} | Mevcut Stok: {urun.Stok} | Alış: {urun.AlisFiyati} TL | Satış: {urun.SatisFiyati} TL\n");

                // 1. İsim Güncelleme (Boş bırakılırsa eski isim kalır)
                Console.Write($"Yeni Ürün Adı (Değişmeyecekse boş bırakıp Enter'a basın): ");
                string yeniAd = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(yeniAd)) // Eğer kullanıcı bir şey yazdıysa ismi değiştir
                {
                    urun.Ad = yeniAd;
                }

                // 2. Stok Ekleme
                Console.Write("Eklenecek Stok Adedi (Sadece sayı girin, ekleme yoksa 0): ");
                int ekStok = int.Parse(Console.ReadLine());

                // 3. Alış Fiyatı Güncelleme
                Console.Write($"Yeni Alış Fiyatı (Mevcut: {urun.AlisFiyati} TL - Değişmeyecekse 0 yazın): ");
                double yeniAlis = double.Parse(Console.ReadLine());
                if (yeniAlis == 0) yeniAlis = urun.AlisFiyati;

                // 4. Satış Fiyatı Güncelleme
                Console.Write($"Yeni Satış Fiyatı (Mevcut: {urun.SatisFiyati} TL - Değişmeyecekse 0 yazın): ");
                double yeniSatis = double.Parse(Console.ReadLine());
                if (yeniSatis == 0) yeniSatis = urun.SatisFiyati;

                // Nesne Verilerini Güncelle
                urun.StokEkle(ekStok);
                urun.AlisFiyati = yeniAlis;
                urun.SatisFiyati = yeniSatis;

                // Alım Geçmişine Kaydet (Eğer stok girdisi yapıldıysa)
                if (ekStok > 0)
                {
                    DosyaYonetimi.AlimKaydet(urun.Ad, ekStok, yeniAlis);
                }

                // Dosyaları Güncelle (Veri Kalıcılığı)
                DosyaYonetimi.VerileriKaydet(envanter);

                Console.WriteLine("\n**************************************************");
                Console.WriteLine("İşlem Başarılı! Ürün bilgileri güncellendi.");
                Console.WriteLine($"Son Durum -> Ürün: {urun.Ad} | Toplam Stok: {urun.Stok}");
                if (ekStok > 0) Console.WriteLine("Alım geçmişi 'alimlar.csv' dosyasına işlendi.");
                Console.WriteLine("**************************************************");
            }
            else
            {
                Console.WriteLine("\n[HATA] Bu barkoda ait bir ürün bulunamadı!");
            }

            Console.WriteLine("\nMenüye dönmek için bir tuşa basın...");
            Console.ReadKey();
        }
        static void RaporGoster()
        {
            Console.Clear();
            Console.WriteLine("--- DETAYLI GÜN SONU RAPORU ---");

            List<string> mevcutTarihler = new List<string>();

            // 1. SATIŞLAR DOSYASINDAKİ TARİHLERİ TOPLA
            if (File.Exists(DosyaYonetimi.SatisDosyaYolu))
            {
                foreach (string satir in File.ReadAllLines(DosyaYonetimi.SatisDosyaYolu))
                {
                    string[] veriler = satir.Split(';');
                    if (veriler.Length >= 6 && !mevcutTarihler.Contains(veriler[0]))
                    {
                        mevcutTarihler.Add(veriler[0]);
                    }
                }
            }

            // 2. ALIMLAR DOSYASINDAKİ TARİHLERİ TOPLA
            if (File.Exists(DosyaYonetimi.AlimDosyaYolu))
            {
                foreach (string satir in File.ReadAllLines(DosyaYonetimi.AlimDosyaYolu))
                {
                    string[] veriler = satir.Split(';');
                    if (veriler.Length >= 6 && !mevcutTarihler.Contains(veriler[0]))
                    {
                        mevcutTarihler.Add(veriler[0]);
                    }
                }
            }

            // Tarih yoksa çık
            if (mevcutTarihler.Count == 0)
            {
                Console.WriteLine("Sistemde henüz raporlanacak hiçbir alım veya satış kaydı bulunmamaktadır.");
                Console.WriteLine("\nMenüye dönmek için bir tuşa basın...");
                Console.ReadKey();
                return;
            }

            // Tarihleri sırala
            mevcutTarihler.Sort();

            // 3. EKRANA TARİH MENÜSÜNÜ YAZDIR
            Console.WriteLine("Lütfen detaylarını görmek istediğiniz tarihi seçin:\n");
            for (int i = 0; i < mevcutTarihler.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {mevcutTarihler[i]}");
            }
            Console.WriteLine("[0] İptal (Ana Menüye Dön)");

            Console.Write("\nSeçiminiz: ");

            // Seçim Kontrolü
            if (!int.TryParse(Console.ReadLine(), out int secim) || secim < 0 || secim > mevcutTarihler.Count)
            {
                Console.WriteLine("Geçersiz seçim! Menüye dönülüyor...");
                Console.ReadKey();
                return;
            }

            if (secim == 0) return;

            string arananTarih = mevcutTarihler[secim - 1];
            Console.Clear();
            Console.WriteLine($"================ {arananTarih} TARİHLİ GÜN SONU RAPORU ================\n");

            double gunlukToplamGider = 0;
            double gunlukToplamGelir = 0;

            // 4. ALIMLARI (GİDERLERİ) LİSTELE
            Console.WriteLine(">>> YAPILAN ALIMLAR (GİDER / MALİYET) <<<");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("{0,-10} {1,-20} {2,-10} {3,-10} {4,-10}", "Saat", "Ürün", "Adet", "B.Alış", "Tutar");
            Console.WriteLine("-----------------------------------------------------------------");

            bool alimVarMi = false;
            if (File.Exists(DosyaYonetimi.AlimDosyaYolu))
            {
                foreach (string satir in File.ReadAllLines(DosyaYonetimi.AlimDosyaYolu))
                {
                    string[] veriler = satir.Split(';');
                    if (veriler.Length >= 6 && veriler[0] == arananTarih)
                    {
                        Console.WriteLine("{0,-10} {1,-20} {2,-10} {3,-10} {4,-10} TL",
                            veriler[1], veriler[2], veriler[3], veriler[4], veriler[5]);
                        gunlukToplamGider += double.Parse(veriler[5]);
                        alimVarMi = true;
                    }
                }
            }
            if (!alimVarMi) Console.WriteLine("Bu tarihte herhangi bir mal alımı (stok girişi) yapılmamış.");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine($"Toplam Gider: {gunlukToplamGider} TL\n\n");

            // 5. SATIŞLARI (GELİRLERİ) LİSTELE
            Console.WriteLine(">>> YAPILAN SATIŞLAR (GELİR / CİRO) <<<");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("{0,-10} {1,-20} {2,-10} {3,-10} {4,-10}", "Saat", "Ürün", "Adet", "B.Satış", "Tutar");
            Console.WriteLine("-----------------------------------------------------------------");

            bool satisVarMi = false;
            if (File.Exists(DosyaYonetimi.SatisDosyaYolu))
            {
                foreach (string satir in File.ReadAllLines(DosyaYonetimi.SatisDosyaYolu))
                {
                    string[] veriler = satir.Split(';');
                    if (veriler.Length >= 6 && veriler[0] == arananTarih)
                    {
                        Console.WriteLine("{0,-10} {1,-20} {2,-10} {3,-10} {4,-10} TL",
                            veriler[1], veriler[2], veriler[3], veriler[4], veriler[5]);
                        gunlukToplamGelir += double.Parse(veriler[5]);
                        satisVarMi = true;
                    }
                }
            }
            if (!satisVarMi) Console.WriteLine("Bu tarihte herhangi bir ürün satışı yapılmamış.");
            Console.WriteLine("-----------------------------------------------------------------\n");

            // 6. GÜN SONU ÖZETİ (FİNANSAL DURUM)
            Console.WriteLine("================ FİNANSAL ÖZET ================");
            Console.WriteLine($"Toplam Gelir (Kasa Girişi) : + {gunlukToplamGelir} TL");
            Console.WriteLine($"Toplam Gider (Mal Alımı)   : - {gunlukToplamGider} TL");
            Console.WriteLine("-----------------------------------------------");

            double netDurum = gunlukToplamGelir - gunlukToplamGider;
            if (netDurum > 0)
            {
                Console.WriteLine($"GÜNÜN NET DURUMU           : KÂR ({netDurum} TL)");
            }
            else if (netDurum < 0)
            {
                Console.WriteLine($"GÜNÜN NET DURUMU           : ZARAR ({netDurum} TL)");
            }
            else
            {
                Console.WriteLine("GÜNÜN NET DURUMU           : NÖTR (0 TL)");
            }
            Console.WriteLine("===============================================");

            Console.WriteLine("\nMenüye dönmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }

}