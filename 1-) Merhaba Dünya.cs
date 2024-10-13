// Using burada kullanmak olarak çevirebiliriz.
// Programlama dilin de ise (anahtar)
// Yani kısacası system`in anahtarını kullanmak diyebiliriz.
// using System;: C# programlarında, using anahtar kelimesi belirli bir isim alanını (namespace) kullanmak için kullanılır.
// Burada System, C#'ın standart kütüphanesine ait bir isim alanıdır. System isim alanı, konsol girişi/çıkışı,
// veri türleri gibi temel işlemleri yapabilmek için gerekli sınıfları ve yöntemleri içerir.
// Bu satırı ekleyerek, programda System içindeki sınıfları doğrudan kullanabilirsin.
using System;

// class ConsoleDerslerim: Bu satır, yeni bir sınıf (class) tanımlar.
// C# dilinde, her şey sınıflar etrafında döner.
// ConsoleDerslerim, bu sınıfın adıdır ve bu sınıf içerisinde çeşitli yöntemler (metotlar) tanımlayabiliriz.
// Sınıflar, nesne yönelimli programlamanın temel taşlarından biridir.
class ConsoleDerslerim

{
    
    // Main metodu, C# uygulamalarında programın başlangıç noktasıdır.
    // Program çalıştığında, ilk olarak Main metodu çalıştırılır.
    // static anahtar kelimesi, bu metodun sınıfın bir örneği (instance) oluşturulmadan çağrılabileceğini belirtir.
    // void, bu metodun bir değer döndürmediğini ifade eder.
    static void Main()

    {

       
         
        Console.WriteLine("Merhaba Dünya");

        // Console.WriteLine("Merhaba Dünya");: Bu satır, konsol ekranına "Merhaba Dünya" yazdırır.
        // Console sınıfı, sistemin konsoluna (terminal) yazma ve okuma işlemleri için kullanılır.
        // WriteLine metodu, belirtilen metni ekrana yazdıktan sonra yeni bir satıra geçer.
    }
}