using System.Runtime.InteropServices;

int[] sayilar = new int[10];
for (int  i = 0;  i <sayilar.Length;i++)
{
    Console.Write($"{i + 1}. sayıyı giriniz:");
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("-------- GİRİLEN 10 SAYI ---------");
foreach (var sayi in sayilar)
{
    Console.WriteLine(sayi);
}
Console.Write("11. sayıyı giriniz:");
int newNumber = Convert.ToInt32(Console.ReadLine());
int[] yeniSayilar = new int[11];
for (int i = 0; i < sayilar.Length; i++)
{
    yeniSayilar[i] = sayilar[i];
}
yeniSayilar[10] = newNumber;
Console.WriteLine("-------- YENİ DİZİ (SIRALANMIŞ) ---------");
Array.Sort(yeniSayilar);
Array.Reverse(yeniSayilar);
foreach (var sayi in yeniSayilar)
{
    Console.WriteLine(sayi);
}