using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1= new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAdi = "Ahmet";
            musteri1.MusteriSoyadi = "Sarı";

            Musteri musteri2= new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAdi = "Ayşe";
            musteri2.MusteriSoyadi = "Kırık";

            MusteriManager musteriManager= new MusteriManager();
            musteriManager.Ekleme(musteri1);
            musteriManager.Ekleme(musteri2);
            Console.WriteLine("--------------------");
            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
            Console.WriteLine("--------------------");
            musteriManager.Listeleme(musteri1);
            musteriManager.Listeleme(musteri2);
            Console.WriteLine("--------------------");


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Id:" + musteri.Id + "Adı:" + musteri.MusteriAdi + "Soyadi:" + musteri.MusteriSoyadi);
            }


        }
    }
}
