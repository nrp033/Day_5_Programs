using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_BasicCorePrograms
{
    internal class Even_Odd
    {
        public static void show_evenodd()
        {
            Console.WriteLine("Enter the Number =");
            int Num = Convert.ToInt32(Console.ReadLine());
            if (Num % 2 == 0)
            {
                Console.WriteLine("Given Number is Even !");
            }
            else
            {
                Console.WriteLine("Given Number is Odd !");
            }
            Console.ReadLine();

        }
    }
}
