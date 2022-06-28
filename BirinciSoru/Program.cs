/*
Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

Negatif ve numeric olmayan girişleri engelleyin.
Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
*/

using System.Collections;

ArrayList arrayList = new ArrayList();
List<int> asallar = new List<int>();
List<int> naAsal = new List<int>();
Console.WriteLine("20 adet sayı giriniz...");

try
{
    for (int i = 0; i < 20; i++)
    {
        arrayList.Add(Convert.ToInt32(Console.ReadLine()));
    }
    foreach (int arr in arrayList)
    {
        int a = 0;
        for (int j = 2; j < arr; j++)
        {
            if (arr % j == 0)
            {
                a = 1;
                break;
            }
        }
        if (a == 1)
        {
            naAsal.Add(arr);
        }
        else
        {
            asallar.Add(arr);
        }
    }
    Console.WriteLine("************Asal Sayılar*****************");
    foreach (int asall in asallar)
    {
        Console.WriteLine(asall);
    }
    Console.WriteLine("***********Asal Olmayan Sayılar**************");
    foreach (int nasal in naAsal)
    {
        Console.WriteLine(nasal);
    }
}
catch(FormatException ex)
{
    Console.WriteLine("Lütfen bir sayı giriniz...");
}
