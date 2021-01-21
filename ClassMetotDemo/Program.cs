using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.TcNo = 01234567891;
            musteri1.MusteriAdi = "Ömer";
            musteri1.MusteriSoyadi = "Bilen";
            musteri1.Yas = 23;
            musteri1.Bakiye = 250;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.TcNo = 11234567891;
            musteri2.MusteriAdi = "Engin";
            musteri2.MusteriSoyadi = "Demiroğ";
            musteri2.Yas = 34;
            musteri2.Bakiye = 25000;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.TcNo = 21234567891;
            musteri3.MusteriAdi = "Özge";
            musteri3.MusteriSoyadi = "Bilen";
            musteri3.Yas = 27;
            musteri3.Bakiye = 2500;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Listele(musteriler);

            musteriManager.Add(musteri2);

            musteriManager.Del(musteri3);
        }
    }
}
