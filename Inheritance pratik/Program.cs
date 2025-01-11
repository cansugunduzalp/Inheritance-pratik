using System;

namespace KisiOrnegi
{
    // Base sınıf: BaseKisi
    public class BaseKisi
    {
        // Propertyler
        public string Ad { get; set; }
        public string Soyad { get; set; }

        // Konsola ad ve soyad yazdıran metot
        public void YazdirAdSoyad()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
        }
    }

    // Ogrenci sınıfı, BaseKisi'den miras alır
    public class Ogrenci : BaseKisi
    {
        // Ogrenci'ye özel property
        public string OgrenciNo { get; set; }

        // Konsola öğrenci numarası, ad ve soyad yazdıran metot
        public void YazdirOgrenciBilgileri()
        {
            Console.WriteLine($"Öğrenci No: {OgrenciNo}, Ad: {Ad}, Soyad: {Soyad}");
        }
    }

    // Ogretmen sınıfı, BaseKisi'den miras alır
    public class Ogretmen : BaseKisi
    {
        // Ogretmen'e özel property
        public decimal Maas { get; set; }

        // Konsola maaş bilgisi, ad ve soyad yazdıran metot
        public void YazdirOgretmenBilgileri()
        {
            Console.WriteLine($"Maaş: {Maas} TL, Ad: {Ad}, Soyad: {Soyad}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Ogrenci nesnesi oluşturuluyor
            Ogrenci ogrenci1 = new Ogrenci
            {
                Ad = "Ali",
                Soyad = "Veli",
                OgrenciNo = "12345"
            };

            // Ogretmen nesnesi oluşturuluyor
            Ogretmen ogretmen1 = new Ogretmen
            {
                Ad = "Ahmet",
                Soyad = "Yılmaz",
                Maas = 5000
            };

            // Öğrenci bilgilerini yazdırma
            Console.WriteLine("Öğrenci Bilgileri:");
            ogrenci1.YazdirOgrenciBilgileri();

            // Öğretmen bilgilerini yazdırma
            Console.WriteLine("\nÖğretmen Bilgileri:");
            ogretmen1.YazdirOgretmenBilgileri();
        }
    }
}


