using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                Random uretici = new Random();
                int randomNumber = uretici.Next(1, 100);
                bool matched = false;
                
                while (!matched)
                {
                    Console.WriteLine("Tahmininiz nedir?");
                    try
                    {
                        int tahmin = Convert.ToInt32(Console.ReadLine());
                        if (tahmin > randomNumber)
                        {
                            Console.WriteLine("Daha aşağıda!");
                        }
                        else if (tahmin < randomNumber)
                        {
                            Console.WriteLine("Daha yukarıda!");
                        }
                        else
                        {
                            Console.WriteLine("Buldunuz!");
                            Console.WriteLine("Tekrar oynamak ister misiniz? (Evet/Hayır)");
                            if (Convert.ToString(Console.ReadLine()).Equals("Evet")) playAgain = true;
                            else playAgain = false;
                            matched = true;
                        }

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Lütfen doğru düzgün bir sayı giriniz.");
                    }


                }
            }
            Console.WriteLine("Oyun bitti...");


        }
    }
}
