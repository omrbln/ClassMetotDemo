using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " Kaydı Eklendi.");
        }

        public void Del(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " Kaydı Silindi.");
        }

        public void Listele(Musteri[] musteri)
        {
            Console.WriteLine("Müşteriler");

            foreach (Musteri item in musteri)
            {
                Console.WriteLine(item.Id + " : " + item.TcNo + " : " + item.MusteriAdi + " " + item.MusteriSoyadi + " : " + item.Yas + " : " + item.Bakiye);
            }
        }
    }
}
