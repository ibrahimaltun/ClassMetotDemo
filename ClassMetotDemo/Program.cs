using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 101;
            musteri1.MusteriAdi = "İbrahim";
            musteri1.MusteriSoyad = "ALTUN";
            musteri1.MusteriBakiye = 1396.44;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 102;
            musteri2.MusteriAdi = "Engin";
            musteri2.MusteriSoyad = "Demiroğ";
            musteri2.MusteriBakiye = 9534.50;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 103;
            musteri3.MusteriAdi = "Dilek";
            musteri3.MusteriSoyad = "Erarslantek";
            musteri3.MusteriBakiye = 3045.65;

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3};

            MusteriManager musteriManger = new MusteriManager();
            Console.WriteLine("*********************************************");

            //Müşterileri Listeleme
            musteriManger.Listele(musteriler);
            Console.WriteLine("*********************************************");

            //Müşteri Ekleme
            musteriManger.Ekle(musteri1);
            musteriManger.Ekle(musteri2);
            musteriManger.Ekle(musteri3);
            Console.WriteLine("*********************************************");

            //Müşteri Sİlme
            musteriManger.Sil(musteri1);

        }
    }
}
