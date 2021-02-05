using System;

namespace ClassMetotDemoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Aysu";
            musteri1.SoyAdi = "Deliahmetoğlu";
            musteri1.MusteriNo = 12345;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Hasan";
            musteri2.SoyAdi = "Deliahmetoğlu";
            musteri2.MusteriNo = 23651;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Selma"; ;
            musteri3.SoyAdi = "Deliahmetoğlu";
            musteri3.MusteriNo = 24567;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            foreach (Musteri musteri in musteriler)
            {

                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.SoyAdi);
                Console.WriteLine(musteri.MusteriNo);
            }
            Console.WriteLine();
            Console.WriteLine("Müşteri Ekleme");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri2);
            Console.WriteLine("MÜŞTERİ EKLENDİ!");

            Console.WriteLine();
            Console.WriteLine("Müşteri Silme");
            MusteriManager musteriManager1 = new MusteriManager();
            musteriManager.Silme(musteri1);
            Console.WriteLine("MÜŞTERİ SİLİNDİ!");

        }
    }
}
        
    

