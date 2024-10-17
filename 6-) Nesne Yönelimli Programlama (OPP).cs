using System;

class Araba
{
    // Özellikler (Properties)
    public string Marka; // Arabanın markası
    public string Model; // Arabanın modeli
    public int Yil; // Arabanın üretim yılı

    // Yapıcı Metot (Constructor) - Bu metot nesne oluşturulurken otomatik olarak çağrılır.
    public Araba(string marka, string model, int yil)
    {
        Marka = marka;
        Model = model;
        Yil = yil;
    }

    // Davranışlar (Methods)
    public void BilgiGoster()
    {
        // Arabanın bilgilerini ekrana yazdıran metot
        Console.WriteLine("Araba Bilgileri: " + Marka + " " + Model + ", Yıl: " + Yil);
    }

    public void HareketeGec()
    {
        // Arabanın hareket etmesini sağlayan metot
        Console.WriteLine(Marka + " " + Model + " harekete geçti.");
    }
}

class Program
{
    static void Main()
    {
        // Nesne Oluşturma (Creating Objects)
        Araba araba1 = new Araba("Toyota", "Corolla", 2022); // İlk araba nesnesi
        Araba araba2 = new Araba("Honda", "Civic", 2020);    // İkinci araba nesnesi

        // Nesnelerin metodlarını kullanma
        araba1.BilgiGoster(); // Toyota Corolla'nın bilgilerini gösterir.
        araba1.HareketeGec(); // Toyota Corolla harekete geçti mesajı verir.

        araba2.BilgiGoster(); // Honda Civic'in bilgilerini gösterir.
        araba2.HareketeGec(); // Honda Civic harekete geçti mesajı verir.
    }
}

