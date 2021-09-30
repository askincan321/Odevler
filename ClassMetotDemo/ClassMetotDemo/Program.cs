using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ebru";
            musteri1.Soyad = "Terzioğlu";
            musteri1.Sehir = "İzmir";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Kuzey";
            musteri2.Soyad = " Saygılı";
            musteri2.Sehir = "Kocaeli";

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Aşkın Can";
            musteri3.Soyad = "Gül";
            musteri3.Sehir = "İstanbul";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();
            foreach (var musteri in musteriler)
            {
                musteriManager.Ekle(musteri);
                musteriManager.guncelle(musteri);
                musteriManager.Sil(musteri);

                Console.Write("###");
            }
           



        }
    }
}
