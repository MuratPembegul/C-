using System; // System kütüphanesini kullanarak temel fonksiyonları ekledik.

class DegiskenDersleri // Yeni bir sınıf oluşturduk. Adı "DegiskenDersleri".
{
    static void Main() // Programın başladığı yer, Main metodu.
    {
        // Değişken tanımlama
        int yas = 25; // "int" veri tipi tam sayı anlamına gelir. Burada yaş değişkeni 25 olarak tanımlandı.
        double boy = 1.58; // "double" ondalıklı sayılar için kullanılır. Boy değişkeni 1.58 olarak tanımlandı.
        string isim = "Murat"; // "string" metin verilerini tutar. İsim değişkeni "Murat" olarak belirlendi.
        bool sigaraKullaniyorMu = false; // "bool" mantıksal değer tutar: true (doğru) ya da false (yanlış).

        // Değişkenleri kullanarak ekrana mesaj yazdırma
        Console.WriteLine("İsim: " + isim); // + operatörüyle string ve değişken birleştirildi.
        Console.WriteLine("Yaş: " + yas);
        Console.WriteLine("Boy: " + boy);
        Console.WriteLine("Sigara kullanıyor mu? " + sigaraKullaniyorMu); // Mantıksal değeri de ekrana yazdırır.
    }
}
//int yas = 25;

//Açıklama: int veri tipi tam sayıları ifade eder. Burada yas adlı bir değişken tanımlanıyor ve değeri 25 olarak belirleniyor. Tam sayılar için int kullanılır.

//double boy = 1.58;

//Açıklama: double veri tipi ondalıklı sayıları ifade eder. 
//Bu örnekte boy adlı bir değişken tanımlanıyor ve değeri 1.58 olarak belirleniyor. Ondalık sayılar için double kullanılır.

//string isim = "Murat";

//Açıklama: string, metin verilerini saklamak için kullanılır. Burada isim değişkenine "Murat" değeri atanmıştır. Metinler çift tırnak içinde yazılır.

//bool sigaraKullaniyorMu = false;

//Açıklama: bool(boolean), sadece iki değer alabilir: true(doğru) ya da false (yanlış). 
//Burada sigaraKullaniyorMu adlı bir değişken tanımlandı ve değeri false olarak ayarlandı (yani sigara kullanmıyor).
//
//Console.WriteLine(...)

  //  Açıklama: Console.WriteLine, ekrana bir şey yazdırmak için kullanılır. Burada + operatörüyle metin ve değişkenler birleştirilerek çıktı oluşturuluyor.
