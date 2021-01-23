using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " Adında ki Müşteri Eklendi...");
        }

        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("-------------MÜŞTERİ LİSTESİ-----------");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyad);
            }
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " Adında ki Müşteri Silindi...");
            
        }
    }
}
