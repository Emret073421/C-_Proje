using System;
using System.Diagnostics;
using System.Linq;

namespace PuzzleOyunu
{
    class Program
    {

        //Burada Oyun Tahtasının kaça kaçlık olduğu ve doğru tahtanın dizilişi giriliyor
        static int[,] oyunTahtasi = new int[3, 3];
        static int[,] dogruTahta = {
            { 1, 2, 3 },
            { 8, 0, 4 },
            { 7, 6, 5 }
        };

        //Puzzle'ı çözmek için harcadığı süreyi kullanmak için bir sayaç
        static Stopwatch stopwatch = new Stopwatch();

        //Giriş Ekranı
        static void Main(string[] args)
        {
            RastgeleTahtaOlustur();
            Console.WriteLine("+-------------------------------------------------------------+");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                       Hoş geldiniz!                         |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|     9'lu Puzzle oyununa başlamak için bir tuşa basınız.     |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("+-------------------------------------------------------------+");
            Console.ReadKey();

            //!!!Bir tuşa basıldıktan sonra zamanlayıcı başlatılır.
            stopwatch.Start();
            
           
            while (true)
            {
                Console.Clear(); //!!!Oyunlarda veya Döngülerde Güncel Durumu Göstermek İçin böylece yabloyu tekrar tekrar göstermemeyi sağladık
                TahtayiYazdir();

                if (TahtaDogruMu())
                {
                    //Oyun sonu ekranı
                    stopwatch.Stop();
                    Console.WriteLine("+-------------------------------------------------------------+");
                    Console.WriteLine("|                                                             |");
                    Console.WriteLine($" TEBRİKLER! Puzzle'ı tamamladınız. Süre: {stopwatch.Elapsed} ");
                    Console.WriteLine("|                                                             |");
                    Console.WriteLine("+-------------------------------------------------------------+");
                    break;
                    //$ !!! işareti sayesinde stopwatch gösterme bakımından çalışıyor
                }

                var tus = Console.ReadKey().Key; // !!! Kullanıcıdan Tuş Girdisi Almak
                Hareket(tus);// !!! Hareket Fonksiyonunu Çağırmak
            }
        }

        //Tahta Oluşturuluyor
        static void RastgeleTahtaOlustur()
        {
            Random rnd = new Random(); // Rastgele sayı üreteci
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 0 };
            sayilar = sayilar.OrderBy(x => rnd.Next()).ToArray();// Sayıları rastgele karıştır

            int sayac = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    oyunTahtasi[i, j] = sayilar[sayac];
                    sayac++;
                }
            }
        }

        //Oluşturulan Tahta Yazılıyor
        static void TahtayiYazdir()
        {
            string bosluk = "                        ";
            Console.WriteLine(bosluk + "+---+---+---+");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(bosluk + "| ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(oyunTahtasi[i, j] + " | ");
                }
                Console.WriteLine();
                Console.WriteLine(bosluk + "+---+---+---+");
            }
        }

        //Sıfırı hareket ettirebilmemiz için sıfırın matristeki konumunu bulduğumuz bölüm
        static void Hareket(ConsoleKey tus)
        {
            int bosSatir = 0, bosSutun = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (oyunTahtasi[i, j] == 0)
                    {
                        bosSatir = i;
                        bosSutun = j;
                    }
                }
            }

            switch (tus) //hangi tusa basıldığını kontrol eder switch
            {
                case ConsoleKey.UpArrow:
                    if (bosSatir > 0) Degistir(bosSatir, bosSutun, bosSatir - 1, bosSutun);
                    break;
                case ConsoleKey.DownArrow:
                    if (bosSatir < 2) Degistir(bosSatir, bosSutun, bosSatir + 1, bosSutun);
                    break;
                case ConsoleKey.LeftArrow:
                    if (bosSutun > 0) Degistir(bosSatir, bosSutun, bosSatir, bosSutun - 1);
                    break;
                case ConsoleKey.RightArrow:
                    if (bosSutun < 2) Degistir(bosSatir, bosSutun, bosSatir, bosSutun + 1);
                    break;
            }
        }

        //temp değeri ile bir gcc değer oluşturulur ve 0 ile herhangi bir değer yer dğiştirir
        static void Degistir(int satir1, int sutun1, int satir2, int sutun2)
        {
            int temp = oyunTahtasi[satir1, sutun1];
            oyunTahtasi[satir1, sutun1] = oyunTahtasi[satir2, sutun2];
            oyunTahtasi[satir2, sutun2] = temp;
        }

        //Her Hareket Sonrası Tahtanın Kontrol Edildiği Bölüm
        static bool TahtaDogruMu()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (oyunTahtasi[i, j] != dogruTahta[i, j])
        
                        return false;
                }
            }
            return true;
        }
    }
}




