using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemoo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Yeni Müşteri Eklendi: " + musteri.Adi + " " + musteri.SoyAdi + " " + "Müşteri No: " + musteri.MusteriNo);
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Yeni Müşteri Eklendi: " + musteri.Adi + " " + musteri.SoyAdi + " " + "Müşteri No: " + musteri.MusteriNo);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Yeni Müşteri Eklendi: " + musteri.Adi + " " + musteri.SoyAdi + " " + "Müşteri No: " + musteri.MusteriNo);
        }

    }
}
