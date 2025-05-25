// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;

Console.WriteLine("Hello, World!");
int[] sayilar = new int[5];
sayilar[0] = 22;
sayilar[1] = 35;
sayilar[3] = 36;
sayilar[4] = 17;
//sayilar[5] = 20;

//                                    0         1         2           3          4         5           6
string[] gunler = new string[] { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
string[] aylar = { "Ocak", "Şubat", "Mart","Nisan","Mayıs" };

System.Console.WriteLine(gunler[0]);
System.Console.WriteLine($"Günler array'inin eleman sayısı: {gunler.Length}");

System.Console.WriteLine(aylar[aylar.Length - 1]);

//Amaç: kullanıcının girdiği iki basamaklı sayıyı, yazıya çevirmemiz gerek:
//Örnek: 43 -> kırk üç
string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };

System.Console.WriteLine("İki basamaklı bir sayı girin:");
int sayi = Convert.ToInt32(Console.ReadLine());
int onlarBasamagi = sayi / 10;
int birlerBasamagi = sayi % 10;
System.Console.WriteLine(onlar[onlarBasamagi] + " " + birler[birlerBasamagi]);






