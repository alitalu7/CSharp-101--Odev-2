/*
Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
*/

using System.Collections;
using System.Linq;

char[] sesliler = {'a', 'e' , 'ı' , 'i' , 'o' , 'ö' , 'u' , 'ü'};
ArrayList liste = new ArrayList();

Console.WriteLine("Bir metin giriniz...");
string gelen = Console.ReadLine().ToLower();

char[] harfler = gelen.ToCharArray();

for (int i = 0; i < harfler.Length; i++)
{
    if (sesliler.Contains(harfler[i]))
    {
        liste.Add(harfler[i]);
    }
}

Console.WriteLine("Metin içinde geçen sesli harfler:");

liste.Sort();
foreach (var item in liste)
{
    Console.WriteLine(item);
}




