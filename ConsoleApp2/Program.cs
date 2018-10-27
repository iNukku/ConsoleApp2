using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int p = 1; p < 11; p++)
                {
                    int number = i * p;

                    Console.Write(number + "  ");
                }
                Console.WriteLine(Environment.NewLine + "_____________________________________________" + Environment.NewLine);
            }

            Console.ReadKey();
        }
    }
}
