using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekleme(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " "+ musteri.Id+ " Müşteri Eklendi!");

        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " " + musteri.Id + " Müşteri Silindi!");

        }

        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine("Id:"+musteri.Id+"\nAdı:"+musteri.MusteriAdi+"\nSoyadi:"+musteri.MusteriSoyadi);
        }
    }
}
