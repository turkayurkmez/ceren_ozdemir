// See https://aka.ms/new-console-template for more information

//Eğer kullanıcının girdiği değer Türkay ise hoşgeldin yazsın.
//değilse tanınmayan kullanıcı yazsın
Console.WriteLine("Lütfen adınızı girin:");
string isim = Console.ReadLine();
Console.WriteLine("Şifrenizi giriniz");
string sifre = Console.ReadLine();

if (isim == "Türkay" && sifre=="123456" )
{
    Console.WriteLine("Hoşgeldin PATRON");
}
else if(isim == "Baran" && sifre == "98765" ){
    Console.WriteLine("Hoşgeldin Bro...");
}
else
{
    Console.WriteLine("Tanınmayan kullanıcı");
}     

Console.WriteLine("İçinde bulunduğunuz ayı giriniz");
string ay = Console.ReadLine();

if (ay == "Mart" || ay == "Nisan" || ay == "Mayıs")
{
    Console.WriteLine("İlk bahar");
}
else if (ay == "Haziran" || ay == "Temmuz" || ay =="Ağustos")
{
    Console.WriteLine("Yaz");

}


