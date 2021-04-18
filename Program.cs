using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.musteriId = 1;
            musteri1.musteriAd = "Furkan";
            musteri1.musteriSoyad = "Yücel";
            musteri1.musteriYas = 20;
            musteri1.musteriAdres = "Paris";


            Musteri musteri2 = new Musteri();
            musteri2.musteriId = 2;
            musteri2.musteriAd = "Gökhan";
            musteri2.musteriSoyad = "Oğuz";
            musteri2.musteriYas = 15;
            musteri2.musteriAdres = "Kars";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            MusteriManager musterimanager = new MusteriManager();
            Console.WriteLine("----MÜŞTERİLER EKLENİYOR---- \n");
            musterimanager.musteriEkle(musteri1);
            musterimanager.musteriEkle(musteri2);
            Console.WriteLine("----MÜŞTERİLER LİSTELENİYOR---- \n");
            musterimanager.musteriListele(musteri1);
            musterimanager.musteriListele(musteri2);
            Console.WriteLine("----MÜŞTERİLER SİLİNİYOR---- \n");
            musterimanager.musteriSil(musteri1);
            musterimanager.musteriSil(musteri2);

        }
    }
}
