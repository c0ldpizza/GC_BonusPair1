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
            //PrintD(6);
            //PrintE(12);
            //PrintF(10);
            //PrintG(10);
            //PrintH(11);
            //PrintI(11);
            //PrintJ(11);
            //Armstrong();
            int result = Fibonacci(3);
            Console.WriteLine(result);

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

        public static void PrintE(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    if (i == 1 || i == input)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("#" + String.Concat(Enumerable.Repeat(" ", input -2)) + "#");
                        break;
                    }
                    
                }
                Console.WriteLine();
            }
        }

        public static void PrintF(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                for (int j = 1; j <= input; j++)
                {
                    if (i == 1 || i == input)
                    {
                        Console.Write("#");
                    }
                    else if (i == j)
                    {
                        Console.Write("#");
                        break;
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }

        public static void PrintG(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                for (int j = 1; j <= input; j++)
                {
                    if (i == 1 || i == input)
                    {
                        Console.Write("#");
                    }
                    else if (i + j - 1 == input)
                    {
                        Console.Write("#");
                        break;
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }

        public static void PrintH(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                for (int j = 1; j <= input; j++)
                {
                    if (i == 1 || i == input)
                    {
                        Console.Write("#");
                    }
                    else if (i + j - 1 == input || i == j)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }

        public static void PrintI(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                for (int j = 1; j <= input; j++)
                {
                    if (i == 1 || i == input || j == 1 || j == input)
                    {
                        Console.Write("#");
                    }
                    else if (i + j - 1 == input || i == j)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }

        public static void PrintJ(int input)
        {
            if (input % 2 == 1) //odd
            {
                for (int i = input; i >= 1; i-=2)
                {
                    for (int j = i; j <= input; j++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
                for (int i = 1; i < input; i += 2)
                {
                    for (int j = i; j <= input; j++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }

            }
            else //even
            {
                for (int i = input; i >= 1; i -= 2)
                {
                    for (int j = i - 1; j <= input; j++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
                for (int i = 1; i < input; i += 2)
                {
                    for (int j = i ; j <= input; j++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
            }
        }

        public static void Armstrong()
        {
            Console.WriteLine("Input a 3-digit integer");

            string input = Console.ReadLine();
            int total = 0;
            
            Char[] number = input.ToCharArray();

            for (int i = 0; i <= 2; i++)
            {
                total = total + Cube(int.Parse(number[i].ToString()));
            }

            Console.WriteLine(total);

            if (int.Parse(input) == total)
            {
                Console.WriteLine("Success");
            }
        }

        public static int Fibonacci(int input)
        {
            //stuff
        }

        public static int Cube(int input)
        {
            int result = input * input * input;
            return result;
        }
    }
}
