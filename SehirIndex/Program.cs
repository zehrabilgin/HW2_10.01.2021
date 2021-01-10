using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SehirIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = { "Ankara", "Kayseri", "Eskisehir", "Trabzon", "Gaziantep", "Mugla", "Erzurum", "Kutahya" };
            Console.WriteLine("Bir sehir giriniz:");
            string input = Console.ReadLine();
            bool var = false;

            for (int i = 0; i < sehirler.Length; i++)
            {
                if (sehirler[i].Equals(input))
                {
                    Console.WriteLine(input + " listede var.");
                    Console.WriteLine("Listede bulunduğu konum: " + i);
                    var = true;
                }
            }

            if (var == false) Console.WriteLine("Sehir listede bulunamadı.");
            Console.ReadLine();

        }
    }
}
