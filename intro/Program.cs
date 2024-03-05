

DateTime bZamani = DateTime.Now;

List<int> karmaSayılar = new List<int>();
List<string> dortIslem = new List<string>() { "+", "-", "*", "/" };
List<string> islemAdımları = new List<string>();

Random rndm = new Random();

for (int i = 0; i < 4; i++)
{
    int sayi = rndm.Next(10);   ////////4 tek 1 çift basamaklı
    karmaSayılar.Add(sayi);
}

int sayi32 = rndm.Next(10, 50);
karmaSayılar.Add(sayi32);
int deger = rndm.Next(500, 1000);
int yDeger = 0;

foreach (var item in karmaSayılar)
{
    Console.Write($"{item}, ");
}

Console.WriteLine($"| {deger}");

while ((DateTime.Now - bZamani).TotalSeconds < 5)
{
    List<int> kopyakarmaSayilar = new List<int>();
    List<string> cislemAdımları = new List<string>();

    foreach (var item in karmaSayılar)
    {
        kopyakarmaSayilar.Add(item);
    }
    
    while (kopyakarmaSayilar.Count > 1)
    {

        
        int dSayiUret = rndm.Next(0, 4);
        int kSayiUret = rndm.Next(0, kopyakarmaSayilar.Count);
        int k1SayiUret = rndm.Next(0, kopyakarmaSayilar.Count);

        if (k1SayiUret == kSayiUret)
        {
            while (k1SayiUret == kSayiUret) 
            {
                int k2SayiUret = rndm.Next(0, kopyakarmaSayilar.Count);
                k1SayiUret = k2SayiUret;
            }
           
            
        }

        if (dortIslem[dSayiUret] == "+")
        {
            int sayi1 = kopyakarmaSayilar[kSayiUret];
            int sayi2 = kopyakarmaSayilar[k1SayiUret];
            int sonuc = sayi1 + sayi2;
           
                kopyakarmaSayilar.Add(sonuc);
            kopyakarmaSayilar.Remove(sayi1);
                kopyakarmaSayilar.Remove(sayi2);

            string metin = $"{sayi1} + {sayi2} = {sonuc}";
            cislemAdımları.Add(metin);      
        }
        if (dortIslem[dSayiUret] == "*")
        {
            int sayi1 = kopyakarmaSayilar[kSayiUret];
            int sayi2 = kopyakarmaSayilar[k1SayiUret];
            int sonuc = sayi1 * sayi2;
           
                kopyakarmaSayilar.Add(sonuc);
            kopyakarmaSayilar.Remove(sayi1);
                kopyakarmaSayilar.Remove(sayi2);





            string metin = $"{sayi1} * {sayi2} = {sonuc}";
            cislemAdımları.Add(metin);
        }
        if (dortIslem[dSayiUret] == "-")
        {
            int sayi1 = kopyakarmaSayilar[kSayiUret];
            int sayi2 = kopyakarmaSayilar[k1SayiUret];
            int sonuc = sayi1 - sayi2;
           
                kopyakarmaSayilar.Add(sonuc);
            kopyakarmaSayilar.Remove(sayi1);
                kopyakarmaSayilar.Remove(sayi2);


            string metin = $"{sayi1} - {sayi2} = {sonuc}";
            cislemAdımları.Add(metin);
        }
        if (dortIslem[dSayiUret] == "/")
        {
            int sayi1 = kopyakarmaSayilar[kSayiUret];
            int sayi2 = kopyakarmaSayilar[k1SayiUret];
            if (sayi2 != 0 && sayi1 % sayi2 == 0)
            {
                int sonuc = sayi1 / sayi2;
                    kopyakarmaSayilar.Add(sonuc);
                kopyakarmaSayilar.Remove(sayi1);
                    kopyakarmaSayilar.Remove(sayi2);


                string metin = $"{sayi1} / {sayi2} = {sonuc}";
                cislemAdımları.Add(metin);
            }
        }
    }
    
    int sDeger = kopyakarmaSayilar[0];
    if (Math.Abs(sDeger-deger)< Math.Abs(yDeger-deger))
    {
        yDeger = sDeger;
        islemAdımları = cislemAdımları;
    }
    
}

foreach (var item in islemAdımları)
{
    Console.WriteLine(item);
}

Console.WriteLine(yDeger);
Console.ReadKey();
