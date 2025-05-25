// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
  Sayı bulmaca oyunu:
  --6. sorunun cevabı   "evet" olduğu sürece:
  1. 1 ile 100 arasında bir sayı tut.
    -- sonuc "EŞİT" olmadığı sürece:
  2. oyuncudan tahmin iste
  3. tahmin edilen tutulandan büyükse, "AŞAĞI" yaz ve 2. Adıma dön
  4. tahmin edilen tutulandan küçükse, "YUKARI" yaz ve 2. Adıma dön 
  5. tahmin edilen tutulana eşitse, "EŞİT" yaz.
  6. Bir daha oynamak ister misiniz diye sor.
      Evet ise 1. Adıma dön
      Hayır ise BİTİR


*/
//pseudo code
string cevap = "evet";
bool oyunDevamEdiyorMu = true;
while (oyunDevamEdiyorMu)
{
    // 1. 1 ile 100 arasında bir sayı tut
    Random rastgeleSayiUretici = new Random();
    int tutulanSayi = rastgeleSayiUretici.Next(1, 101);

    string sonuc = string.Empty;

    bool bilindiMi = false;
    while (!bilindiMi)
    {
        //2. oyuncudan tahmin iste
        Console.WriteLine("Lütfen 1-100 arası bir tahmin girin:");
        int tahmin = Convert.ToInt32(Console.ReadLine());
        // 3. tahmin edilen tutulandan büyükse, "AŞAĞI" yaz ve 2. Adıma dön
        if (tahmin > tutulanSayi)
        {
            sonuc = "AŞAĞI";
        }
        else if (tahmin<tutulanSayi)
        {
            // 4. tahmin edilen tutulandan küçükse, "YUKARI" yaz ve 2. Adıma dön 
            sonuc = "YUKARI";
        }
        else
        {
            // 5. tahmin edilen tutulana eşitse, "EŞİT" yaz.
            sonuc = "EŞİT";
            bilindiMi = true;
        }
        Console.WriteLine(sonuc);


    }

    Console.WriteLine("Tebrikler! Tekrar oynamak ister misiniz? (evet/hayır)");
    cevap = Console.ReadLine();
    // if (cevap == "evet")
    // {
    //    oyunDevamEdiyorMu = true;
    // }
    // else
    // {
    //     oyunDevamEdiyorMu = false;
    // }

    oyunDevamEdiyorMu = cevap == "evet";

}