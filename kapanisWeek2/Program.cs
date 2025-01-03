using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        //1 - Aşağıdaki çıktıyı yazan bir program.
        Console.WriteLine("Merhaba");
        Console.WriteLine("Nasılsın?");
        Console.WriteLine("İyiyim");
        Console.WriteLine("Sen nasılsın?");

        //2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.
        string name = "Pelin";
        int number = 1;
        Console.WriteLine($"İsim {name}; {number} numara.");

        //3 - Rastgele bir sayı üretip , ekrana yazdırınız.
        Random rnd = new Random();
        int randomNumber = rnd.Next(1, 100);
        Console.WriteLine($"Rastgele sayı : {randomNumber}");

        //4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
        Console.WriteLine($"Rastgele sayı {randomNumber}'nin 3'e bölümünden kalan: {randomNumber % 3}");

        //5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
        Console.Write("Yaşınız:");
        int yas = Convert.ToInt32(Console.ReadLine());
        if (yas >= 18)
            Console.WriteLine("+");
        else
            Console.WriteLine("-");

        /*
                int yas;
                do
                {
                    Console.WriteLine("Yaşınız:");
                    string strYas = Console.ReadLine();
                    if (int.TryParse(strYas, out yas))
                    {
                        if (yas > 18)
                            Console.WriteLine("+");
                        else
                            Console.WriteLine("-");
                        break;
                    }
                    else
                        Console.WriteLine("Metinsel karakter.");

                } while (true);
           
         */

        //6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
        for (int i = 1; i < 11; i++)
        {
            Console.Write($"{i})");
            Console.WriteLine(" Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
        }

        //7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
        Console.WriteLine("Gülse Birsel yazın.");
        string userInput = Console.ReadLine();
        Console.WriteLine("Demet Evgar yazın");
        string userInput2 = Console.ReadLine();

        string temp = userInput;
        userInput = userInput2;
        userInput2 = temp;
        Console.WriteLine($"İlk metinsel değer= {userInput} ikincisi {userInput2}");

        //8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
        BenDegerDondurmem();

        //9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
        Console.WriteLine($"İki sayının toplamı {Toplama(3, 4)}");

        //10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
        Console.WriteLine(Metot(true));

        // 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
        Console.Write("1.Yaş:");
        int yas1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("2.Yaş:");
        int yas2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("3.Yaş:");
        int yas3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"En büyük yaş: {EnBuyukSayiyiBul(yas1, yas2, yas3)}");

        //12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
        EnBuyukSayiyiBul(3, 4, 5, 6, 7);

        //13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
        Console.WriteLine("Bir isim yazın.");
        string userInputName = Console.ReadLine();
        Console.WriteLine("Bir isim yazın.");
        string userInputName2 = Console.ReadLine();
        YerDegistirme(ref userInputName, ref userInputName2);
        Console.WriteLine($"İlk girilen isim: {userInputName}, ikinci girilen isim: {userInputName2} olarak yer değiştirilmiştir.");

        //14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
        do
        {
            Console.WriteLine("Bir sayı yazınız.");
            string a = Console.ReadLine();
            if (int.TryParse(a, out int yasInt))
            {
                if (TekMi(yasInt))
                {
                    Console.WriteLine($"{yasInt} sayısı tektir.");
                }
                else
                {
                    Console.WriteLine($"{yasInt} sayısı tek değildir.");
                }
                break;
            }
            else
            {
                Console.WriteLine("Metinsel değer.");
            }

        } while (true);

        //15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
        Console.Write("Hız(km/saat):");
        double hiz = Convert.ToDouble(Console.ReadLine());
        Console.Write("Zaman(saat):");
        double zaman = Convert.ToDouble(Console.ReadLine());
        double gidilenYol = GidilenYol(hiz, zaman);
        Console.WriteLine($"Gidilen yol: {gidilenYol}");

        //16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
        Console.WriteLine($"Dairenin alanı {DaireAlani(5)}");

        //17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.
        string metin = "Zaman bir GeRi SayIm";
        Console.WriteLine(metin.ToUpper());
        Console.WriteLine(metin.ToLower());

        //18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
        string greetings = " Selamlar ";
        Console.WriteLine(greetings.Trim());
    }

    //8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
    static void BenDegerDondurmem()
    {
        Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
    }

    //9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
    static int Toplama(int a, int b)
    {

        int toplam = a + b;
        return toplam;
    }

    //10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
    static string Metot(bool x)//kullanıcıdan true false alıp string gönderme
    {
        return "Program devam ediyor";
    }

    // 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
    static int EnYasliyiYaz(int yas1, int yas2, int yas3)
    {
        int enBuyuk = yas1;
        if (yas2 > enBuyuk)
            enBuyuk = yas2;
        if (yas3 > enBuyuk)
            enBuyuk = yas3;
        return enBuyuk;
    }

    //12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
    static int EnBuyukSayiyiBul(params int[] sayilar)
    {
        int enBuyukK = sayilar[0];
        for (int i = 1; i < sayilar.Length; i++)
        {
            if (sayilar[i] > enBuyukK)
            {
                enBuyukK = sayilar[i];
            }
        }
        Console.WriteLine(enBuyukK);
        return enBuyukK;
    }

    //13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
    static void YerDegistirme(ref string a, ref string b)
    {
        string temp = a;
        a = b;
        b = temp;
    }


    //14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
    static bool TekMi(int a)
    {
        int kalan = a % 2;
        if (kalan != 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
    static double GidilenYol(double v, double t)
    {
        double gidilenYol = v * t;
        return gidilenYol;

    }

    //16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
    static double DaireAlani(int r)
    {
        double piSayisi = Math.PI;
        double yariCapKaresi = r * r;
        double alan = yariCapKaresi * piSayisi;
        return alan;
    }

}
