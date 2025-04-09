// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lütfen 1 ile 10 arasında bir sayı giriniz:");
int sayi = Convert.ToInt32(Console.ReadLine());

//girilen sayı 5'den küçükse "5'in altında" yazsın
if (sayi <= 5)
{
   Console.WriteLine("5'in altında veya 5");
}
else{
  
    Console.WriteLine("5'in üstünde");
}

Console.WriteLine("Uygulama çalışmaya devam ediyor...");