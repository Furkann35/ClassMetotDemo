using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void musteriEkle(Musteri Ekle)
        {
            Console.WriteLine("Müşteri başarıyla eklendi \nMüşteri Id: " + Ekle.musteriId + "\n Müşteri Ad:" + Ekle.musteriAd + "\n Müşteri Soyad:" + Ekle.musteriSoyad + "\n Müşteri Adres:" + Ekle.musteriAdres + "\n Müşteri Yaşı:" + Ekle.musteriYas + "\n");
        }

        public void musteriListele(Musteri Listele)
        {
            Console.WriteLine("Müşteriler başarıyla listelendi \nMüşteri Id: " + Listele.musteriId + "\n Müşteri Ad:" + Listele.musteriAd + "\n Müşteri Soyad:" + Listele.musteriSoyad + "\n Müşteri Adres:" + Listele.musteriAdres + "\n Müşteri Yaşı:" + Listele.musteriYas);

        }

        public void musteriSil(Musteri Sil)
        {
            Console.WriteLine("Müşteriler başarıyla silindi \nMüşteri Id: " + Sil.musteriId + "\n Müşteri Ad:" + Sil.musteriAd + "\n Müşteri Soyad:" + Sil.musteriSoyad + "\n Müşteri Adres:" + Sil.musteriAdres + "\n Müşteri Yaşı:" + Sil.musteriYas);

        }


    }
}