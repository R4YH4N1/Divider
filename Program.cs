using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divider
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Input the number to be divided");
            x = Convert.ToInt32(Console.ReadLine());

            int y;
            Console.WriteLine("Input the number to divide by");
            y = Convert.ToInt32(Console.ReadLine());

            int z = x/y;
			      int zMod = x%y; 

            Console.WriteLine("Your answer is {0}r{1}", z,zMod);
            Console.ReadLine();

        }
    }
}
