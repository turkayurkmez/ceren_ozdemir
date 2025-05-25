// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string[] katilimcilar = { "Roz", "Baran", "Türkay", "Mehmet" };

// System.Console.WriteLine(katilimcilar[0]);
// System.Console.WriteLine(katilimcilar[1]);
// System.Console.WriteLine(katilimcilar[2]);

for (int i = katilimcilar.Length - 1; i >= 0; i--)
{
    System.Console.WriteLine(katilimcilar[i]);
}
System.Console.WriteLine("Lütfen aradığıniz ismi giriniz:");
string arananIsim = Console.ReadLine();

bool bulunduMu = false;
int bulunanIndex = 0;
for (int i = 0; i < katilimcilar.Length; i++)
{
    if (katilimcilar[i] == arananIsim)
    {
        bulunduMu = true;
        bulunanIndex = i;
        break;
    }
}

if (bulunduMu)
{
    System.Console.WriteLine($"Evet, {arananIsim} array içinde var. Ve index değeri: {bulunanIndex}");

}
else
{
    System.Console.WriteLine($"Array içinde {arananIsim} ismi yok");
}

int x = 3;
System.Console.WriteLine($"x değeri: {++x}");
System.Console.WriteLine($"Şu an x değeri: {x}");

int[] ogrenciYaslari = new int[5];
int index = 0;
while (index < ogrenciYaslari.Length)
{
    System.Console.WriteLine($"{index}. Öğrencinin yaşını girin:");
    ogrenciYaslari[index++] = Convert.ToInt32(Console.ReadLine());


}

int toplam = 0;
for (int i = 0; i < ogrenciYaslari.Length; i++)
{
    toplam += ogrenciYaslari[i];
}

int ortalama = toplam / ogrenciYaslari.Length;
System.Console.WriteLine($" {ogrenciYaslari.Length} kişilik sınıfın yaş ortalaması: {ortalama}");


