using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cafe
{
    internal class Program
    {
        public string aktifmasa;
        public string masa1 = "boş", masa2 = "boş", masa3 = "boş", masa4 = "boş", masa5 = "boş", masa6 = "boş", masa7 = "boş";
        public int yemek1 = 3, yemek2 = 5, yemek3 = 4, pizza1 = 4, pizza2 = 5, pizza3 = 8, sicakIcecek1 = 1, sicakIcecek2 = 2, sicakIcecek3 = 1, sogukIcecek1 = 2, sogukIcecek2 = 1, sogukIcecek3 = 2, toplam = 0, masaToplam1 = 0, masaToplam2 = 0, masaToplam3 = 0, masaToplam4 = 0, masaToplam5 = 0, masaToplam6 = 0, masaToplam7 = 0, silinenUrun = 0, eklenenUrun = 0,bahsis = 0, bahsisgirdi = 0, toplamBahsis =0;
        double hasilat = 0, masa1ToplamHasilat = 0, masa2ToplamHasilat = 0, masa3ToplamHasilat = 0, masa4ToplamHasilat = 0, masa5ToplamHasilat = 0, masa6ToplamHasilat = 0, masa7ToplamHasilat = 0,masa1ToplamBahsis = 0, masa2ToplamBahsis = 0, masa3ToplamBahsis = 0, masa4ToplamBahsis = 0, masa5ToplamBahsis = 0, masa6ToplamBahsis = 0, masa7ToplamBahsis = 0;
        List<string> siparisListesi = new List<string>();
        List<string> siparisListesi1 = new List<string>();
        List<string> siparisListesi2 = new List<string>();
        List<string> siparisListesi3 = new List<string>();
        List<string> siparisListesi4 = new List<string>();
        List<string> siparisListesi5 = new List<string>();
        List<string> siparisListesi6 = new List<string>();
        List<string> siparisListesi7 = new List<string>();
        public void CafeAna()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("[1]    Masa Aç");
            Console.WriteLine("[2]    Masa İşlem");
            Console.WriteLine("[3]    Masa Hesap");
            Console.WriteLine("[4]    Kasa İşlemleri");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("[0]    ÇIKIŞ YAP");
            Console.WriteLine("--------------------------------------------");
            Console.Write("Seçiminiz : ");
        ERROR1:
            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            switch (KeyInfo.Key)
            {
                case ConsoleKey.NumPad0:
                    Environment.Exit(0);
                    break;
                case ConsoleKey.NumPad1:
                    MasaAc();
                    break;
                case ConsoleKey.NumPad2:
                    MasaIslem();
                    break;
                case ConsoleKey.NumPad3:
                    MasaHesap();
                    break;
                case ConsoleKey.NumPad4:
                    KasaIslemleri();
                    break;

                default:
                    Console.WriteLine("Sayı 0-4 arasında olmalıdır...");
                    goto ERROR1;
            }

        }
        public void MasaAc()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("MASA AÇ");
            Console.WriteLine("--------------------------------------------");
            if (masa1 == "boş")
                Console.WriteLine($"1.Masa [{masa1}]");
            if (masa2 == "boş")
                Console.WriteLine($"2.Masa [{masa2}]");
            if (masa3 == "boş")
                Console.WriteLine($"3.Masa [{masa3}]");
            if (masa4 == "boş")
                Console.WriteLine($"4.Masa [{masa4}]");
            if (masa5 == "boş")
                Console.WriteLine($"5.Masa [{masa5}]");
            if (masa6 == "boş")
                Console.WriteLine($"6.Masa [{masa6}]");
            if (masa7 == "boş")
                Console.WriteLine($"7.Masa [{masa7}]");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("AnaMenü       [ESC]");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Masa açmak için masa id giriniz.");
            error1:
            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            if (KeyInfo.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                CafeAna();
            }
            else if (masa1 == "boş" && KeyInfo.Key == ConsoleKey.NumPad1)
            {
                Console.Clear();
                aktifmasa = "1";
                Menu();
            }
            else if (masa2 == "boş" && KeyInfo.Key == ConsoleKey.NumPad2)
            {
                Console.Clear();
                aktifmasa = "2";
                Menu();
            }
            else if(masa3 == "boş" && KeyInfo.Key == ConsoleKey.NumPad3)
            {
                Console.Clear();
                aktifmasa = "3";
                Menu();
            }
            else if(masa4 == "boş" && KeyInfo.Key == ConsoleKey.NumPad4)
            {
                Console.Clear();
                aktifmasa = "4";
                Menu();
            }
            else if(masa5 == "boş" && KeyInfo.Key == ConsoleKey.NumPad5)
            {
                Console.Clear();
                aktifmasa = "5";
                Menu();
            }
            else if(masa6 == "boş" && KeyInfo.Key == ConsoleKey.NumPad6)
            {
                Console.Clear();
                aktifmasa = "6";
                Menu();
            }
            else if(masa7 == "boş" && KeyInfo.Key == ConsoleKey.NumPad7)
            {
                Console.Clear();
                aktifmasa = "7";
                Menu();
            }
            else
            {

                Console.WriteLine("Yanlış bir masa id'si girdiniz tekrar deneyiniz...");
                goto error1;
            }
        }
        public void Menu()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("                  MASA AÇ");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("   YEMEKLER                       İÇECEKLER");
            Console.WriteLine(" Et Yemekleri                   Sıcak İçecekler");
            Console.WriteLine($"1.Yemek - {yemek1}TL [1]        1.İçecek - {sicakIcecek1}TL [5] ");
            Console.WriteLine($"2.Yemek - {yemek2}TL [2]        2.İçecek - {sicakIcecek2}TL [6] ");
            Console.WriteLine("  Pizzalar                      Soğuk İçecekler");
            Console.WriteLine($"1.Pizza - {pizza1}TL [3]        1.İçecek - {sogukIcecek1}TL [7] ");
            Console.WriteLine($"2.Pizza - {pizza2}TL [4]        2.İçecek - {sogukIcecek2}TL [8] ");
            Console.WriteLine("----------------------------------------------------");
            if (aktifmasa == "1")
            {
                foreach (var item in siparisListesi1)
                {
                    Console.WriteLine(item);
                }
            }
            if (aktifmasa == "2")
            {
                foreach (var item in siparisListesi2)
                {
                    Console.WriteLine(item);
                }
            }
            if (aktifmasa == "3")
            {
                foreach (var item in siparisListesi3)
                {

                    Console.WriteLine(item);
                }
            }
            if (aktifmasa == "4")
            {
                foreach (var item in siparisListesi4)
                {
                    Console.WriteLine(item);
                }
            }
            if (aktifmasa == "5")
            {
                foreach (var item in siparisListesi5)
                {
                    Console.WriteLine(item);
                }
            }
            if (aktifmasa == "6")
            {
                foreach (var item in siparisListesi6)
                {
                    Console.WriteLine(item);
                }
            }
            if (aktifmasa == "7")
            {
                foreach (var item in siparisListesi7)
                {
                    Console.WriteLine(item);
                }
            }
            foreach (var item in siparisListesi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("ONAYLA    [SPACE]");
            Console.WriteLine("ANAMENU    [ESC]");
            Console.WriteLine("GERİ GİT    [SOL OK]");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Ürün eklemek için id giriniz:");
            error4:
            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            if (KeyInfo.Key == ConsoleKey.NumPad1)
            {
                Console.Clear();
                siparisListesi.Add($"1.Yemek {yemek1}TL");
                toplam += yemek1;
                Menu();
            }
            else if (KeyInfo.Key == ConsoleKey.NumPad2)
            {
                Console.Clear();
                siparisListesi.Add($"2.Yemek {yemek2}TL");
                toplam += yemek2;
                Menu();
            }
            else if(KeyInfo.Key == ConsoleKey.NumPad3)
            {
                Console.Clear();
                siparisListesi.Add($"1.Pizza {pizza1}TL");
                toplam += pizza1;
                Menu();
            }
            else if(KeyInfo.Key == ConsoleKey.NumPad4)
            {
                Console.Clear();
                siparisListesi.Add($"2.Pizza {pizza2}TL");
                toplam += pizza2;
                Menu();
            }
            else if(KeyInfo.Key == ConsoleKey.NumPad5)
            {
                Console.Clear();
                siparisListesi.Add($"1.Sıcak İçecek {sicakIcecek1}TL");
                toplam += sicakIcecek1;
                Menu();
            }
            else if(KeyInfo.Key == ConsoleKey.NumPad6)
            {
                Console.Clear();
                siparisListesi.Add($"2.Sıcak İçecek {sicakIcecek2}TL");
                toplam += sicakIcecek2;
                Menu();
            }
            else if(KeyInfo.Key == ConsoleKey.NumPad7)
            {
                Console.Clear();
                siparisListesi.Add($"1.Soğuk İçecek {sogukIcecek1}TL");
                toplam += sogukIcecek1;
                Menu();
            }
            else if(KeyInfo.Key == ConsoleKey.NumPad8)
            {
                Console.Clear();
                siparisListesi.Add($"2.Soğuk İçecek {sogukIcecek2}TL");
                toplam += sogukIcecek2;
                Menu();
            }
            
            else if (KeyInfo.Key == ConsoleKey.Spacebar)
            {
                if (aktifmasa == "1")
                {
                    masa1 = "dolu";
                    siparisListesi1.AddRange(siparisListesi);
                    masaToplam1 = toplam;
                    toplam = 0;
                    siparisListesi.Clear();
                }
                else if (aktifmasa == "2")
                {
                    masa2 = "dolu";
                    siparisListesi2.AddRange(siparisListesi);
                    masaToplam2 = toplam;
                    toplam = 0;
                    siparisListesi.Clear();
                }
                else if (aktifmasa == "3")
                {
                    masa3 = "dolu";
                    siparisListesi3.AddRange(siparisListesi);
                    masaToplam3 = toplam;
                    toplam = 0;
                    siparisListesi.Clear();
                }
                else if (aktifmasa == "4")
                {
                    masa4 = "dolu";
                    siparisListesi4.AddRange(siparisListesi);
                    masaToplam4 = toplam;
                    toplam = 0;
                    siparisListesi.Clear();
                }
                else if (aktifmasa == "5")
                {
                    masa5 = "dolu";
                    siparisListesi5.AddRange(siparisListesi);
                    masaToplam5 = toplam;
                    toplam = 0;
                    siparisListesi.Clear();
                }
                else if (aktifmasa == "6")
                {
                    masa6 = "dolu";
                    siparisListesi6.AddRange(siparisListesi);
                    masaToplam6 = toplam;
                    toplam = 0;
                    siparisListesi.Clear();
                }
                else if (aktifmasa == "7")
                {
                    masa7 = "dolu";
                    siparisListesi7.AddRange(siparisListesi);
                    masaToplam7 = toplam;
                    toplam = 0;
                    siparisListesi.Clear();
                }
                Console.Clear();
                CafeAna();
            }
            else if (KeyInfo.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                toplam = 0;
                siparisListesi.Clear();
                CafeAna();
            }
            else if (KeyInfo.Key == ConsoleKey.LeftArrow)
            {

                Console.Clear();
                toplam = 0;
                siparisListesi.Clear();
                MasaAc();
            }
            else
            {
                Console.WriteLine("Hatalı girdi tekrar deneyiniz...");
                goto error4;
            }
        }
        public void MasaIslem()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("                  MASA İŞLEM");
            Console.WriteLine("----------------------------------------------------");
            if (masa1 == "dolu")
                Console.WriteLine($"1.Masa    [{masa1}]");
            if (masa2 == "dolu")
                Console.WriteLine($"2.Masa    [{masa2}]");
            if (masa3 == "dolu")
                Console.WriteLine($"3.Masa    [{masa3}]");
            if (masa4 == "dolu")
                Console.WriteLine($"4.Masa    [{masa4}]");
            if (masa5 == "dolu")
                Console.WriteLine($"5.Masa    [{masa5}]");
            if (masa6 == "dolu")
                Console.WriteLine($"6.Masa    [{masa6}]");
            if (masa7 == "dolu")
                Console.WriteLine($"7.Masa    [{masa7}]");
            if (masa1 == "boş" && masa2 == "boş" && masa3 == "boş" && masa4 == "boş" && masa5 == "boş" && masa6 == "boş" && masa7 == "boş" )
            {
                Console.WriteLine("Tüm Masalar Boş Lütfen Masa Ekleyiniz...");
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("ANA MENÜ [ESC]");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("İşlem yapmak istediğiniz masa id giriniz:");
            error2:
            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            if (KeyInfo.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                CafeAna();
            }
            if (KeyInfo.Key == ConsoleKey.NumPad1 && masa1 == "dolu")
            {
                aktifmasa = "1";
                Masa(siparisListesi1);
            }
            else if (KeyInfo.Key == ConsoleKey.NumPad2 && masa2 == "dolu")
            {
                aktifmasa = "2";
                Masa(siparisListesi2);
            }
            else if (KeyInfo.Key == ConsoleKey.NumPad3 && masa3 == "dolu")
            {
                aktifmasa = "3";
                Masa(siparisListesi3);
            }
            else if (KeyInfo.Key == ConsoleKey.NumPad4 && masa4 == "dolu")
            {
                aktifmasa = "4";
                Masa(siparisListesi4);
            }
            else if (KeyInfo.Key == ConsoleKey.NumPad5 && masa5 == "dolu")
            {
                aktifmasa = "5";
                Masa(siparisListesi5);
            }
            else if (KeyInfo.Key == ConsoleKey.NumPad6 && masa6 == "dolu")
            {
                aktifmasa = "6";
                Masa(siparisListesi6);
            }
            else if (KeyInfo.Key == ConsoleKey.NumPad7 && masa7 == "dolu")
            {
                aktifmasa = "7";
                Masa(siparisListesi7);
            }
           
            else
            {
                Console.WriteLine("Geçerli bir id giriniz.");
                goto error2;
            }
        }
        List<string> aktifMasaListe = new List<string>();
        public void Masa(List<string> name)
        {
            Console.Clear();
            aktifMasaListe.Clear();
            aktifMasaListe.AddRange(name);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"               {aktifmasa}.Masa   ");
            Console.WriteLine("----------------------------------------------------");
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Sipariş Ekle  [1]");
            Console.WriteLine("Sipariş Sil   [2]");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("ANA MENÜ  [ESC]");
            Console.WriteLine("GERİ GİT [Sol Ok]");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("İşleminiz:");
            error10:
            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            if (KeyInfo.Key == ConsoleKey.NumPad1)
            {
                Console.Clear();
                SiparisEkle();
            }
            else if (KeyInfo.Key == ConsoleKey.NumPad2)
            {
                Console.Clear();
                SiparisSil();
            }
            else if(KeyInfo.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                CafeAna();
            }
            else if(KeyInfo.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
                MasaIslem();
            }
            else
            {
                Console.WriteLine("Yanlış bir tuşa bastınız.");
                goto error10;
            }
        }
        public void SiparisEkle()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"       {aktifmasa} - SİPARİŞ EKLE");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("                         MENÜ");
            Console.WriteLine("   YEMEKLER                       İÇECEKLER");
            Console.WriteLine(" Et Yemekleri                   Sıcak İçecekler");
            Console.WriteLine($"1.Yemek - {yemek1}TL [1]        1.İçecek - {sicakIcecek1}TL [5] ");
            Console.WriteLine($"2.Yemek - {yemek2}TL [2]        2.İçecek - {sicakIcecek2}TL [6] ");
            Console.WriteLine("  Pizzalar                      Soğuk İçecekler");
            Console.WriteLine($"1.Pizza - {pizza1}TL [3]        1.İçecek - {sogukIcecek1}TL [7] ");
            Console.WriteLine($"2.Pizza - {pizza2}TL [4]        2.İçecek - {sogukIcecek2}TL [8] ");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("                      SİPARİŞLER");
            Console.WriteLine("----------------------------------------------------");
            if (aktifmasa == "1")
            {
                foreach (var item in siparisListesi1)
                {
                    Console.WriteLine(item);
                }
            }
            if (aktifmasa == "2")
            {
                foreach (var item in siparisListesi2)
                {
                    Console.WriteLine(item);
                }
            }
            if (aktifmasa == "3")
            {
                foreach (var item in siparisListesi3)
                {
                    Console.WriteLine(item);
                }
            }
            if (aktifmasa == "4")
            {
                foreach (var item in siparisListesi4)
                {
                    Console.WriteLine(item);
                }
            }
            if (aktifmasa == "5")
            {
                foreach (var item in siparisListesi5)
                {
                    Console.WriteLine(item);
                }
            }
            if (aktifmasa == "6")
            {
                foreach (var item in siparisListesi6)
                {
                    Console.WriteLine(item);
                }
            }
            if (aktifmasa == "7")
            {
                foreach (var item in siparisListesi7)
                {
                    Console.WriteLine(item);
                }
            }
            foreach (var item in siparisListesi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("ONAYLA    [SPACE]");
            Console.WriteLine("GERİ GİT    [SOL OK]");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Ürün eklemek için id giriniz:");
            error9:
            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            if (KeyInfo.Key == ConsoleKey.NumPad1)
            {
                Console.Clear();
                siparisListesi.Add($"1.Yemek {yemek1}TL");
                toplam += yemek1;
                Menu();
            }
            else if (KeyInfo.Key == ConsoleKey.NumPad2)
            {
                Console.Clear();
                siparisListesi.Add($"2.Yemek {yemek2}TL");
                toplam += yemek2;
                Menu();
            }
            else if(KeyInfo.Key == ConsoleKey.NumPad3)
            {
                Console.Clear();
                siparisListesi.Add($"1.Pizza {pizza1}TL");
                toplam += pizza1;
                Menu();
            }
            else if(KeyInfo.Key == ConsoleKey.NumPad4)
            {
                Console.Clear();
                siparisListesi.Add($"2.Pizza {pizza2}TL");
                toplam += pizza2;
                Menu();
            }
            else if(KeyInfo.Key == ConsoleKey.NumPad5)
            {
                Console.Clear();
                siparisListesi.Add($"1.Sıcak İçecek {sicakIcecek1}TL");
                toplam += sicakIcecek1;
                Menu();
            }
            else if(KeyInfo.Key == ConsoleKey.NumPad6)
            {
                Console.Clear();
                siparisListesi.Add($"2.Sıcak İçecek {sicakIcecek2}TL");
                toplam += sicakIcecek2;
                Menu();
            }
            else if(KeyInfo.Key == ConsoleKey.NumPad7)
            {
                Console.Clear();
                siparisListesi.Add($"1.Soğuk İçecek {sogukIcecek1}TL");
                toplam += sogukIcecek1;
                Menu();
            }
            else if(KeyInfo.Key == ConsoleKey.NumPad8)
            {
                Console.Clear();
                siparisListesi.Add($"2.Soğuk İçecek {sogukIcecek2}TL");
                toplam += sogukIcecek2;
                Menu();
            }
            else if(KeyInfo.Key == ConsoleKey.Spacebar)
            {
                if (aktifmasa == "1")
                {
                    masa1 = "dolu";
                    siparisListesi1.AddRange(siparisListesi);
                    masaToplam1 += toplam;
                    toplam = 0;
                    siparisListesi.Clear();
                }
                else if (aktifmasa == "2")
                {
                    masa2 = "dolu";
                    siparisListesi2.AddRange(siparisListesi);
                    masaToplam2 += toplam;
                    toplam = 0;
                    siparisListesi.Clear();
                }
                else if (aktifmasa == "3")
                {
                    masa3 = "dolu";
                    siparisListesi3.AddRange(siparisListesi);
                    masaToplam3 += toplam;
                    toplam = 0;
                    siparisListesi.Clear();
                }
                else if (aktifmasa == "4")
                {
                    masa4 = "dolu";
                    siparisListesi4.AddRange(siparisListesi);
                    masaToplam4 += toplam;
                    toplam = 0;
                    siparisListesi.Clear();
                }
                else if (aktifmasa == "5")
                {
                    masa5 = "dolu";
                    siparisListesi5.AddRange(siparisListesi);
                    masaToplam5 += toplam;
                    toplam = 0;
                    siparisListesi.Clear();
                }
                else if (aktifmasa == "6")
                {
                    masa6 = "dolu";
                    siparisListesi6.AddRange(siparisListesi);
                    masaToplam6 += toplam;
                    toplam = 0;
                    siparisListesi.Clear();
                }
                else if (aktifmasa == "7")
                {
                    masa7 = "dolu";
                    siparisListesi7.AddRange(siparisListesi);
                    masaToplam7 += toplam;
                    toplam = 0;
                    siparisListesi.Clear();
                }
                Console.Clear();
                CafeAna();
            }
            else if (KeyInfo.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
                MasaIslem();
            }
            else
            {
                Console.WriteLine("Yanlış bir işlem yaptınız tekrar deneyin.");
                goto error9;
            }
        }
        public void SiparisSil()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"      MASA {aktifmasa} - SİPARİŞ SİL");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("                  SİPARİŞLER");
            Console.WriteLine("----------------------------------------------------");
            int sayac = 1;
            foreach (var item in aktifMasaListe)
            {
                Console.WriteLine($"{item}  [{sayac}]");
                sayac++;
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("ONAYLA   [Space]");
            Console.WriteLine("GERİ GİT [Sol Ok]");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Ürün silmek için id giriniz:");
            error3:
            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            if (aktifMasaListe.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("---------------Ürün Kalmadı----------------------");
                Console.WriteLine("İşlemi onaylamak ister misiniz? [1]");
                Console.WriteLine("Geri çıkmak ister misiniz?      [2]");
                ConsoleKeyInfo KeyInfo2 = Console.ReadKey(true);
                if (KeyInfo.Key == ConsoleKey.NumPad1)
                {
                    if (aktifMasaListe.Count == 0)
                    {
                        if (aktifmasa == "1")
                        {
                            masa1 = "boş";
                        }
                        if (aktifmasa == "2")
                        {
                            masa2 = "boş";
                        }
                        if (aktifmasa == "3")
                        {
                            masa3 = "boş";
                        }
                        if (aktifmasa == "4")
                        {
                            masa4 = "boş";
                        }
                        if (aktifmasa == "5")
                        {
                            masa5 = "boş";
                        }
                        if (aktifmasa == "6")
                        {
                            masa6 = "boş";
                        }
                        if (aktifmasa == "7")
                        {
                            masa7 = "boş";
                        }
                    }
                    if (aktifmasa == "1")
                    {
                        siparisListesi1.Clear();
                        masaToplam1 -= silinenUrun;
                        Console.WriteLine(masaToplam1);
                        siparisListesi1.AddRange(aktifMasaListe);
                    }
                    if (aktifmasa == "2")
                    {
                        siparisListesi2.Clear();
                        masaToplam2 -= silinenUrun;
                        siparisListesi2.AddRange(aktifMasaListe);
                    }
                    if (aktifmasa == "3")
                    {
                        siparisListesi3.Clear();
                        masaToplam3 -= silinenUrun;
                        siparisListesi3.AddRange(aktifMasaListe);
                    }
                    if (aktifmasa == "4")
                    {
                        siparisListesi4.Clear();
                        masaToplam4 -= silinenUrun;
                        siparisListesi4.AddRange(aktifMasaListe);
                    }
                    if (aktifmasa == "5")
                    {
                        siparisListesi5.Clear();
                        masaToplam5 -= silinenUrun;
                        siparisListesi5.AddRange(aktifMasaListe);
                    }
                    if (aktifmasa == "6")
                    {
                        siparisListesi6.Clear();
                        masaToplam6 -= silinenUrun;
                        siparisListesi6.AddRange(aktifMasaListe);
                    }
                    if (aktifmasa == "7")
                    {
                        siparisListesi7.Clear();
                        masaToplam7 -= silinenUrun;
                        siparisListesi7.AddRange(aktifMasaListe);
                    }
                    Console.Clear();
                    CafeAna();
                }
                else if (KeyInfo.Key == ConsoleKey.NumPad2)
                {
                    Console.Clear();
                    MasaIslem();
                }

            }
            else if (KeyInfo.Key == ConsoleKey.NumPad1 && aktifMasaListe.Count > 0 && aktifMasaListe[0] != null)
            {
                Console.Clear();
                silinenUrun += int.Parse(Regex.Match(aktifMasaListe[0].Remove(0,1),@"\d+").Value);
                aktifMasaListe.RemoveAt(0);
                SiparisSil();
            }
            else if(KeyInfo.Key == ConsoleKey.NumPad2 && aktifMasaListe.Count > 1 && aktifMasaListe[1] != null)
            {
                Console.Clear();
                silinenUrun += int.Parse(Regex.Match(aktifMasaListe[1].Remove(0, 1), @"\d+").Value);
                aktifMasaListe.RemoveAt(1);
                SiparisSil();
            }
            else if(KeyInfo.Key == ConsoleKey.NumPad3 && aktifMasaListe.Count > 2 && aktifMasaListe[2] != null)
            {
                Console.Clear();
                silinenUrun += int.Parse(Regex.Match(aktifMasaListe[2].Remove(0, 1), @"\d+").Value);
                aktifMasaListe.RemoveAt(2);
                SiparisSil();
            }
            else if(KeyInfo.Key == ConsoleKey.NumPad4 && aktifMasaListe.Count > 3 && aktifMasaListe[3] != null)
            {
                Console.Clear();
                silinenUrun += int.Parse(Regex.Match(aktifMasaListe[3].Remove(0, 1), @"\d+").Value);
                aktifMasaListe.RemoveAt(3);
                SiparisSil();
            }
            else if (KeyInfo.Key == ConsoleKey.NumPad5 && aktifMasaListe.Count > 4 && aktifMasaListe[4] != null)
            {
                Console.Clear();
                silinenUrun += int.Parse(Regex.Match(aktifMasaListe[4].Remove(0, 1), @"\d+").Value);
                aktifMasaListe.RemoveAt(4);
                SiparisSil();
            }
            else if(KeyInfo.Key == ConsoleKey.NumPad6 && aktifMasaListe.Count > 5 && aktifMasaListe[5] != null)
            {
                Console.Clear();
                silinenUrun += int.Parse(Regex.Match(aktifMasaListe[5].Remove(0, 1), @"\d+").Value);
                aktifMasaListe.RemoveAt(5);
                SiparisSil();
            }
            else if (KeyInfo.Key == ConsoleKey.NumPad7 && aktifMasaListe.Count > 6 && aktifMasaListe[6] != null)
            {
                Console.Clear();
                silinenUrun += int.Parse(Regex.Match(aktifMasaListe[6].Remove(0, 1), @"\d+").Value);
                aktifMasaListe.RemoveAt(6);
                SiparisSil();
            }
            else if(KeyInfo.Key == ConsoleKey.NumPad8 && aktifMasaListe.Count > 7 && aktifMasaListe[7] != null)
            {
                Console.Clear();
                silinenUrun += int.Parse(Regex.Match(aktifMasaListe[7].Remove(0, 1), @"\d+").Value);
                aktifMasaListe.RemoveAt(7);
                SiparisSil();
            }
            else if(KeyInfo.Key == ConsoleKey.NumPad9 && aktifMasaListe.Count > 8 && aktifMasaListe[8] != null)
            {
                Console.Clear();
                silinenUrun += int.Parse(Regex.Match(aktifMasaListe[8].Remove(0, 1), @"\d+").Value);
                aktifMasaListe.RemoveAt(8);
                SiparisSil();
            }
         
            else if (KeyInfo.Key == ConsoleKey.Spacebar)
            {
                if (aktifMasaListe.Count == 0)
                {
                    if (aktifmasa == "1")
                    {
                        masa1 = "boş";
                    }
                    if (aktifmasa == "2")
                    {
                        masa2 = "boş";
                    }
                    if (aktifmasa == "3")
                    {
                        masa3 = "boş";
                    }
                    if (aktifmasa == "4")
                    {
                        masa4 = "boş";
                    }
                    if (aktifmasa == "5")
                    {
                        masa5 = "boş";
                    }
                    if (aktifmasa == "6")
                    {
                        masa6 = "boş";
                    }
                    if (aktifmasa == "7")
                    {
                        masa7 = "boş";
                    }
                }
                if (aktifmasa == "1")
                {
                    siparisListesi1.Clear();
                    masaToplam1 -= silinenUrun;
                    Console.WriteLine(masaToplam1);
                    siparisListesi1.AddRange(aktifMasaListe);
                }
                if (aktifmasa == "2")
                {
                    siparisListesi2.Clear();
                    masaToplam2 -= silinenUrun;
                    siparisListesi2.AddRange(aktifMasaListe);
                }
                if (aktifmasa == "3")
                {
                    siparisListesi3.Clear();
                    masaToplam3 -= silinenUrun;
                    siparisListesi3.AddRange(aktifMasaListe);
                }
                if (aktifmasa == "4")
                {
                    siparisListesi4.Clear();
                    masaToplam4 -= silinenUrun;
                    siparisListesi4.AddRange(aktifMasaListe);
                }
                if (aktifmasa == "5")
                {
                    siparisListesi5.Clear();
                    masaToplam5 -= silinenUrun;
                    siparisListesi5.AddRange(aktifMasaListe);
                }
                if (aktifmasa == "6")
                {
                    siparisListesi6.Clear();
                    masaToplam6 -= silinenUrun;
                    siparisListesi6.AddRange(aktifMasaListe);
                }
                if (aktifmasa == "7")
                {
                    siparisListesi7.Clear();
                    masaToplam7 -= silinenUrun;
                    siparisListesi7.AddRange(aktifMasaListe);
                }
                Console.Clear();
                CafeAna();
            }
            else if (KeyInfo.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
                MasaIslem();
            }
            else
            {
                Console.WriteLine("Geçerli bir sayı giriniz...");
                goto error3;
            }
        }
        public void MasaHesapX()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"                MASA{aktifmasa}");
            Console.WriteLine("--------------------------------------------");
            if (aktifmasa == "1")
            {
                foreach (var item in siparisListesi1)
                {
                    Console.WriteLine(item);
                }
            }
            else if (aktifmasa == "2")
            {
                foreach (var item in siparisListesi2)
                {
                    Console.WriteLine(item);
                }
            }
            else if (aktifmasa == "3")
            {
                foreach (var item in siparisListesi3)
                {
                    Console.WriteLine(item);
                }
            }
            else if(aktifmasa == "4")
            {
                foreach (var item in siparisListesi4)
                {
                    Console.WriteLine(item);
                }
            }
            else if(aktifmasa == "5")
            {
                foreach (var item in siparisListesi5)
                {
                    Console.WriteLine(item);
                }
            }
            else if(aktifmasa == "6")
            {
                foreach (var item in siparisListesi6)
                {
                    Console.WriteLine(item);
                }
            }
            else if(aktifmasa == "7")
            {
                foreach (var item in siparisListesi7)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Tüm Masalar Boş");
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("İndirimli Öde [1]");
            Console.WriteLine("Normal Öde    [2]");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("ANA MENÜ [ESC]");
            Console.WriteLine("GERİ GİT [Sol Ok]");


            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("İşlem Seç:");
            error5:
            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            if (KeyInfo.Key == ConsoleKey.NumPad1)
            {
                Console.Clear();
                IndirimliHesap();
            }
            else if (KeyInfo.Key == ConsoleKey.NumPad2)
            {
                if (aktifmasa == "1")
                {
                    siparisListesi1.Clear();
                    hasilat += masaToplam1;
                    masa1ToplamHasilat += masaToplam1;
                    masa1 = "boş";
                    masaToplam1 = 0;
                }
                if (aktifmasa == "2")
                {
                    siparisListesi2.Clear();
                    masa2ToplamHasilat += masaToplam2;
                    hasilat += masaToplam2;
                    masa2 = "boş";
                    masaToplam2 = 0;
                }
                if (aktifmasa == "3")
                {
                    siparisListesi3.Clear();
                    masa3ToplamHasilat += masaToplam3;
                    masa3 = "boş";
                    hasilat += masaToplam3;
                    masaToplam3 = 0;
                }
                if (aktifmasa == "4")
                {
                    siparisListesi4.Clear();
                    masa4ToplamHasilat += masaToplam4;
                    hasilat += masaToplam4;
                    masa4 = "boş";
                    masaToplam4 = 0;
                }
                if (aktifmasa == "5")
                {
                    siparisListesi5.Clear();
                    masa5ToplamHasilat += masaToplam5;
                    masa5 = "boş";
                    hasilat += masaToplam5;
                    masaToplam5 = 0;
                }
                if (aktifmasa == "6")
                {
                    siparisListesi6.Clear();
                    masa6ToplamHasilat += masaToplam6;
                    masa6 = "boş";
                    hasilat += masaToplam6;
                    masaToplam6 = 0;
                }
                if (aktifmasa == "7")
                {
                    siparisListesi7.Clear();
                    masa7ToplamHasilat += masaToplam7;
                    masa7 = "boş";
                    hasilat += masaToplam7;
                    masaToplam7 = 0;
                }
                Console.Clear();
                CafeAna();
            }
            else if (KeyInfo.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                CafeAna();
            }
            else if (KeyInfo.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
                MasaHesap();
            }
            else
            {
                Console.WriteLine("Hatalı girdi tekrar deneyiniz...");
                goto error5;
            }

        }
        
        public void IndirimliHesap()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"    MASA {aktifmasa} - İNDİRİMLİ ÖDEME  ");
            Console.WriteLine("--------------------------------------------");
            if (aktifmasa == "1")
            {
                Console.WriteLine($"Toplam Tutar :    {masaToplam1} TL");
                Console.WriteLine($"İndirimli Tutar : {masaToplam1 * 0.75} TL");
            }
            else if (aktifmasa == "2")
            {
                Console.WriteLine($"Toplam Tutar :    {masaToplam2} TL");
                Console.WriteLine($"İndirimli Tutar : {masaToplam2 * 0.75} TL");
            }
            else if (aktifmasa == "3")
            {
                Console.WriteLine($"Toplam Tutar :    {masaToplam3} TL");
                Console.WriteLine($"İndirimli Tutar : {masaToplam3 * 0.75} TL");
            }
            else if (aktifmasa == "4")
            {
                Console.WriteLine($"Toplam Tutar :    {masaToplam4} TL");
                Console.WriteLine($"İndirimli Tutar : {masaToplam4 * 0.75} TL");
            }
            else if (aktifmasa == "5")
            {
                Console.WriteLine($"Toplam Tutar :    {masaToplam5} TL");
                Console.WriteLine($"İndirimli Tutar : {masaToplam5 * 0.75} TL");
            }
            else if (aktifmasa == "6")
            {
                Console.WriteLine($"Toplam Tutar :    {masaToplam6} TL");
                Console.WriteLine($"İndirimli Tutar : {masaToplam6 * 0.75} TL");
            }
            else if (aktifmasa == "7")
            {
                Console.WriteLine($"Toplam Tutar :    {masaToplam7} TL");
                Console.WriteLine($"İndirimli Tutar : {masaToplam7 * 0.75} TL");
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Bahşiş  {toplamBahsis} TL");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Bahşiş Girmek İçin [1]");
            Console.WriteLine("ONAYLA           [Space]");
            Console.WriteLine("GERİ GİT         [Sol Ok]");
            Console.WriteLine("--------------------------------------------");
           error6:
            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            if (KeyInfo.Key == ConsoleKey.NumPad1)
            {
                Console.WriteLine("Bahşiş eklemek için miktar girip entera bas:");
                error8:
                try
                {
                    bahsisgirdi = int.Parse(Console.ReadLine());
                    toplamBahsis += bahsisgirdi;
                    IndirimliHesap();
                }
                catch (Exception)
                {
                    Console.WriteLine("Hatalı tuşlama yaptınız tekrar giriniz...");
                    goto error8;
                }
               
            }
            else if (KeyInfo.Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                bahsis += toplamBahsis;
                if (aktifmasa == "1")
                {
                    siparisListesi1.Clear();
                    hasilat += (masaToplam1 * 0.75);
                    masa1ToplamHasilat +=(masaToplam1 * 0.75);
                    masa1ToplamBahsis += toplamBahsis;
                    masa1 = "boş";
                    masaToplam1 = 0;
                }
                if (aktifmasa == "2")
                {
                    siparisListesi2.Clear();
                    masa2ToplamHasilat += (masaToplam2 * 0.75);
                    hasilat += masaToplam2 * 0.75;
                    masa2ToplamBahsis += toplamBahsis;
                    masa2 = "boş";
                    masaToplam2 = 0;
                }
                if (aktifmasa == "3")
                {
                    siparisListesi3.Clear();
                    masa3ToplamHasilat += (masaToplam3 * 0.75);
                    masa3ToplamBahsis += toplamBahsis;
                    hasilat += masaToplam3 * 0.75;
                    masa3 = "boş";
                    masaToplam3 = 0;
                }
                if (aktifmasa == "4")
                {
                    siparisListesi4.Clear();
                    masa4ToplamHasilat += (masaToplam4 * 0.75);
                    hasilat += masaToplam4 * 0.75;
                    masa4ToplamBahsis += toplamBahsis;
                    masa4 = "boş";
                    masaToplam4 = 0;
                }
                if (aktifmasa == "5")
                {
                    siparisListesi5.Clear();
                    masa5ToplamHasilat += (masaToplam5 * 0.75);
                    masa5ToplamBahsis += toplamBahsis;
                    hasilat += masaToplam5 * 0.75;
                    masa5 = "boş";
                    masaToplam5 = 0;
                }
                if (aktifmasa == "6")
                {
                    siparisListesi6.Clear();
                    masa6ToplamHasilat += (masaToplam6 * 0.75);
                    masa6ToplamBahsis += toplamBahsis;
                    hasilat += masaToplam6 * 0.75;
                    masa6 = "boş";
                    masaToplam6 = 0;
                }
                if (aktifmasa == "7")
                {
                    siparisListesi7.Clear();
                    masa7ToplamHasilat += (masaToplam7 * 0.75);
                    masa7ToplamBahsis += toplamBahsis;
                    hasilat += masaToplam7 * 0.75;
                    masa7 = "boş";
                    masaToplam7 = 0;
                }
                Console.Clear();
                toplamBahsis = 0;
                CafeAna();
            }
            else if (KeyInfo.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
                toplamBahsis = 0;
                MasaHesap();
            }
            else
            {
                Console.WriteLine("Hatalı girdi yeniden deneyiniz...");
                goto error6;
            }

        }
        public void MasaHesap()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("               MASA HESAP");
            Console.WriteLine("--------------------------------------------");
            if (masa1 == "dolu")
                Console.WriteLine($"1.Masa    [{masa1}]");
            if (masa2 == "dolu")
                Console.WriteLine($"2.Masa    [{masa2}]");
            if (masa3 == "dolu")
                Console.WriteLine($"3.Masa    [{masa3}]");
            if (masa4 == "dolu")
                Console.WriteLine($"4.Masa    [{masa4}]");
            if (masa5 == "dolu")
                Console.WriteLine($"5.Masa    [{masa5}]");
            if (masa6 == "dolu")
                Console.WriteLine($"6.Masa    [{masa6}]");
            if (masa7 == "dolu")
                Console.WriteLine($"7.Masa    [{masa7}]");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("ANA MENÜ [ESC]");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("İşlem yapmak istediğiniz masa id giriniz:");
            error7:
            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            if (KeyInfo.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                CafeAna();
            }
            if (KeyInfo.Key == ConsoleKey.NumPad1 && masa1 == "dolu")
            {
                aktifmasa = "1";
                MasaHesapX();
            }
            else if (KeyInfo.Key == ConsoleKey.NumPad2 && masa2 == "dolu")
            {
                aktifmasa = "2";
                MasaHesapX();

            }
            else if (KeyInfo.Key == ConsoleKey.NumPad3 && masa3 == "dolu")
            {
                aktifmasa = "3";
                MasaHesapX();
            }
            else if (KeyInfo.Key == ConsoleKey.NumPad4 && masa4 == "dolu")
            {
                aktifmasa = "4";
                MasaHesapX();
            }
            else if (KeyInfo.Key == ConsoleKey.NumPad5 && masa5 == "dolu")
            {
                aktifmasa = "5";
                MasaHesapX();
            }
            else if (KeyInfo.Key == ConsoleKey.NumPad6 && masa6 == "dolu")
            {
                aktifmasa = "6";
                MasaHesapX();
            }
            else if (KeyInfo.Key == ConsoleKey.NumPad7 && masa7 == "dolu")
            {
                aktifmasa = "7";
                MasaHesapX();
            }

            else
            {
                Console.WriteLine("Geçerli bir id giriniz.");
                goto error7;
            }
        }
        public void KasaIslemleri()
        {
            Console.Clear();
            Console.WriteLine("                  KASA İŞLEMLERİ");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Toplam Kazanç = {hasilat} TL");
            Console.WriteLine($"Toplam Bahşiş = {bahsis} TL");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("            MASALARA GÖRE KAZANÇ");
            if (masa1ToplamHasilat > 0)
            {
                Console.WriteLine($"1.Masa : Kazanç {masa1ToplamHasilat}  -- Bahşiş {masa1ToplamBahsis} TL");
            }
            if (masa2ToplamHasilat > 0)
            {
                Console.WriteLine($"2.Masa : Kazanç {masa2ToplamHasilat}  -- Bahşiş {masa2ToplamBahsis} TL");
            }
            if (masa3ToplamHasilat > 0)
            {
                Console.WriteLine($"3.Masa : Kazanç {masa3ToplamHasilat}  -- Bahşiş {masa3ToplamBahsis} TL");
            }
            if (masa4ToplamHasilat > 0)
            {
                Console.WriteLine($"4.Masa : Kazanç {masa4ToplamHasilat}  -- Bahşiş {masa4ToplamBahsis} TL");
            }
            if (masa5ToplamHasilat > 0)
            {
                Console.WriteLine($"5.Masa : Kazanç {masa5ToplamHasilat}  -- Bahşiş {masa5ToplamBahsis} TL");
            }
            if (masa6ToplamHasilat > 0)
            {
                Console.WriteLine($"6.Masa : Kazanç {masa6ToplamHasilat}  -- Bahşiş {masa6ToplamBahsis} TL");
            }
            if (masa7ToplamHasilat > 0)
            {
                Console.WriteLine($"7.Masa : Kazanç {masa7ToplamHasilat}  -- Bahşiş {masa7ToplamBahsis} TL");
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("ANA MENÜ [ESC]");
            Console.WriteLine("----------------------------------------------------");
            error8:
            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            if (KeyInfo.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                CafeAna();
            }
            else
            {
                Console.WriteLine("Yanlış girdi tekrar deneyiniz...");
                goto error8;
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.CafeAna();
            Console.ReadLine();
        }
    }
}
