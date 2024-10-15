using System; // System kütüphanesini kullanıyoruz.

class DonguVeDiziler // Sınıf adı: DonguVeDiziler
{
    static void Main() // Programın başladığı yer
    {
        // Bir dizi tanımlıyoruz. Diziler aynı türden birden fazla veriyi tutar.
        int[] sayilar = { 10, 20, 30, 40, 50 }; // 5 elemanlı bir tam sayı dizisi oluşturduk.

        // Açıklama: Burada int türünden bir dizi tanımlıyoruz.
        // sayilar adlı dizi içinde beş eleman var: 10, 20, 30, 40 ve 50.
        // Diziler, aynı türden birden fazla veriyi saklamak için kullanılır.

        // For döngüsü: Dizideki her bir elemanı ekrana yazdırmak için kullanıyoruz.
        for (int i = 0; i < sayilar.Length; i++) // i, dizinin indeksini temsil eder.

        // Açıklama: for döngüsü, dizinin her elemanını teker teker işler.
        // i burada dizinin indeksini temsil eder. sayilar.Length ise dizinin uzunluğunu gösterir (bu örnekte 5).
        // Döngü, dizinin her elemanını ekrana yazdırır. 
        {
            Console.WriteLine("Eleman: " + sayilar[i]); // Her elemanı ekrana yazdırıyoruz.
        }

        // Bir de foreach döngüsüne bakalım. Bu da dizi elemanlarını teker teker işler.
        Console.WriteLine("Foreach Döngüsü ile:");
        foreach (int sayi in sayilar)

        // Açıklama: foreach döngüsü, dizinin tüm elemanlarını otomatik olarak işler.
        // Bu döngü, dizinin her bir elemanını alır ve ekrana yazdırır.
        // foreach döngüsü, dizilerle çalışırken daha sade ve kullanışlıdır.
        {
            Console.WriteLine("Eleman: " + sayi); // Foreach ile her elemanı yazdırıyoruz.
        }
    }
}
// 
