using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 ile 10.000 arasındaki asal sayılar:");
            for (int input = 2; input < 10000; input++)
            { 
                bool asal = true;
                for(int bolen = 2; bolen < input; bolen++)
                {
                    if(input % bolen == 0)
                    {
                        asal = false;
                        break;
                    }


                }
                if (asal)
                {
                    Console.WriteLine(input);
                }
            }

            Console.ReadLine();
            
        }
    }
}
