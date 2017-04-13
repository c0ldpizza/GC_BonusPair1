using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPair1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintA(6);
            //PrintB(6);
            //PrintC(6);
            PrintD(6);
        }

        public static void PrintA(int input)
        {
            for (int i = input; i >= 1; i--)
            {
                for (int j = i; j <= input; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }

        public static void PrintB(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                for (int j = i; j <= input; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        public static void PrintC(int input)
        {
            for (int i = input + 1; i >= 1; i--)
            {
                for (int j = 0; j <= input - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }

        public static void PrintD(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                for (int j = input - i; j >= 1; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
