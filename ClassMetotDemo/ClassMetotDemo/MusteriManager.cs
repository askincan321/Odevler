using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle (Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi :"+ musteri.Ad+""+ musteri.Soyad +""+ musteri.Sehir);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + "Müşteri Silindi:" + musteri.Ad + "" + musteri.Soyad);
        }

        public void guncelle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id +" Müşteri Güncellendi:" + musteri.Ad +" " + musteri.Soyad);
        }

        
    }
}
