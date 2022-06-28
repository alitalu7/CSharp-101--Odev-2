/*
 Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız.
(Array sınıfını kullanarak yazınız.)
 */

int[] dizi1 = new int[20];
int[] dizi2 = new int[3];
int[] dizi3 = new int[3];

int toplam1 = 0;
int toplam2 = 0;

Console.WriteLine("20 tane doğal sayı giriniz...");
for (int i = 0; i < 20; i++)
{
    dizi1[i] = Convert.ToInt32(Console.ReadLine());
}

Array.Sort(dizi1);

for (int i = 0; i < 3; i++)
{
    dizi2[i] = dizi1[i];
}

Array.Reverse(dizi1);

for (int i = 0; i < 3; i++)
{
    dizi3[i] = dizi1[i];
}

Console.WriteLine("*****************");
Console.WriteLine("Küçük dizinin ortalaması:");
for (int i = 0; i < 3; i++)
{
    toplam1 = toplam1 + dizi2[i];
}
Console.WriteLine(toplam1 / 3);

Console.WriteLine("*****************");
Console.WriteLine("Büyük dizinin ortalaması:");
for (int i = 0; i < 3; i++)
{
    toplam2 = toplam2 + dizi3[i];
}
Console.WriteLine(toplam2 / 3);
