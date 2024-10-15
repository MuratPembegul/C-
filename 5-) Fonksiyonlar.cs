using System;

class FonksiyonDersi // Sınıf adı
{
    // Bu bir fonksiyon örneğidir. Toplama işlemi yapar.
    static int Topla(int a, int b) // Geri dönüş tipi int, iki parametre alıyor (a ve b)

    // Açıklama: Burada Topla adlı bir fonksiyon tanımlıyoruz.
    // Bu fonksiyon, iki tam sayı parametre (a ve b) alır ve onların toplamını geri döndürür.
    // int yazmamızın sebebi, bu fonksiyonun bir tamsayı değeri döndürmesidir.
    // Eğer fonksiyon herhangi bir şey döndürmüyorsa, geri dönüş tipi olarak void kullanırız.
    {
        return a + b; // a ve b değerlerini toplayıp sonucu geri döndürüyoruz.
    }

    static void Main() // Programın başladığı yer
    {
        // Topla fonksiyonunu çağırıyoruz ve sonucunu ekrana yazdırıyoruz.
        int sonuc = Topla(5, 10); // Topla(5, 10) fonksiyonunu çağırdık.

        // Açıklama: Topla(5, 10) fonksiyonunu çağırarak 5 ve 10 değerlerini fonksiyona gönderiyoruz.
        // Bu fonksiyon, bu iki değeri toplar ve sonucu sonuc adlı değişkene atar.

        Console.WriteLine("Toplam: " + sonuc); // Sonucu ekrana yazdırıyoruz.

        // Açıklama: Topla fonksiyonunun döndürdüğü sonucu ekrana yazdırıyoruz.
        // Örneğin, 5 ve 10'un toplamı 15 olduğu için ekrana "Toplam: 15" yazdırılır.

        // Başka bir örnek
        int sonuc2 = Topla(15, 25);
        Console.WriteLine("Toplam: " + sonuc2);

        // Açıklama: Bu sefer Topla fonksiyonunu 15 ve 25 değerleriyle çağırıyoruz.
        // Sonuç 40 olacak ve bu değeri sonuc2 değişkenine atıyoruz, ardından ekrana yazdırıyoruz.
    }
}

