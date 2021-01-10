using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxAvgValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 32, -10, 50, 27, 15, -89, -12 };


            //minimum
            //İlk elemanı en küçük sayı kabul edeceğim, 2.elemandan itibaren sonuncu elemana kadar bakacağım 
            //ve daha küçük bir sayı bulursam, bu sefer en küçük eleman olarak onu kabul edeceğim.
            int min = sayilar[0];
            for (int i = 1;i<sayilar.Length ;i++)
            {
                if (sayilar[i] < min) min = sayilar[i];
            }
            //maximum
            //İlk elemanı en büyük sayı kabul edeceğim, 2.elemandan itibaren sonuncu elemana kadar bakacağım 
            //ve daha büyük bir sayı bulursam, bu sefer en büyük eleman olarak onu kabul edeceğim.
            int max = sayilar[0];
            for (int i = 1; i < sayilar.Length; i++)
            {
                if (sayilar[i] > max) max = sayilar[i];
            }
            //average
            //Tüm sayıları toplayıp listede ne kadar eleman varsa ona bölüp ortalama alacağım.
            int sum = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                sum += sayilar[i];
            }
            double avg = (double)sum / sayilar.Length;
            Console.WriteLine("En kucuk deger:" + min);
            Console.WriteLine("En buyuk deger:" + max);
            Console.WriteLine("Ortalama deger:" + avg);
            Console.ReadLine();

        }
    }
}
