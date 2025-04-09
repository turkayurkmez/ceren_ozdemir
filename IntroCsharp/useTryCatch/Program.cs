// See https://aka.ms/new-console-template for more information

try
{
    Console.WriteLine("İlk sayıyı giriniz:");
    int sayi1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("İkinci sayıyı giriniz:");
    int sayi2 = Convert.ToInt32(Console.ReadLine());

    int bolum = sayi1 / sayi2;
    Console.WriteLine("Sonuç:" + bolum);

}
catch (FormatException ex) 
{
    Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
   
}
catch (DivideByZeroException ex2){
    Console.WriteLine("Bir tam sayıyı sıfıra bölemezsiniz.");
}
catch (Exception ex){
    Console.WriteLine("Bilinmeyen bir hata oluştu: " + ex.Message);
}


