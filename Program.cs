using System;
using System.Collections;

/*
 Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
 her iki grubun kendi içerisinde 
 ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. 
 (Array sınıfını kullanarak yazınız.)
*/

namespace Koleksiyonlar_soru_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList sayilar = new ArrayList();
            ArrayList kucukSayilar = new ArrayList();
            ArrayList buyukSayilar = new ArrayList(); 

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz:",i+1);
                sayilar.Add(Convert.ToInt32(Console.ReadLine()));
            }
            sayilar.Sort();
                
            kucukSayilar.Add(sayilar[0]);
            kucukSayilar.Add(sayilar[1]);
            kucukSayilar.Add(sayilar[2]);

            buyukSayilar.Add(sayilar[17]);
            buyukSayilar.Add(sayilar[18]);
            buyukSayilar.Add(sayilar[19]);

            int kucukToplam=0;
            for (int i = 0; i < kucukSayilar.Count; i++)
            {
                kucukToplam += (int)kucukSayilar[i];
            }
            int kucukOrtalama =kucukToplam/kucukSayilar.Count;
            Console.WriteLine("Küçük sayıların ortalaması:"+ kucukOrtalama );
            
            int buyukToplam=0;
            for (int i = 0; i < buyukSayilar.Count; i++)
            {
                buyukToplam += (int)buyukSayilar[i];
            }
            int buyukOrtalama = buyukToplam/buyukSayilar.Count;
            Console.WriteLine("Büyük sayıların ortalaması:"+ buyukOrtalama );

            int ortalamaToplam = (int)kucukOrtalama+(int)buyukOrtalama;
            
            Console.WriteLine("Küçük ve büyük sayıların ortalama toplamları:"+ortalamaToplam);
        }   
    }
}