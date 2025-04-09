// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
 BMI hesaplama algoritması:

  kullanıcıdan kilo bilgisini iste.
 Girilen veriyi,  kilo bilgisini tam sayı değişkeninde tut.
  boy bilgisini ondalıklı sayı değişkeninde tut.
  kilo değişkeninin değerini, boy değişkeninin değerinin karesine böl.
   Sonucu ekrana yazdır.
 */

 //kilo bilgisini al:
Console.WriteLine("Lütfen kilonuzu giriniz: ");
string kiloString = Console.ReadLine();
int kilo = Convert.ToInt32(kiloString);
//boy bilgisini al:
Console.WriteLine("Lütfen boyunuzu giriniz: ");
string boyString = Console.ReadLine();
double boy = double.Parse(boyString);

double bmi = kilo / (boy * boy);
Console.WriteLine("BMI: " + bmi);

