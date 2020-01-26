using System;
namespace Pattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            pattern1();
            pattern2();
            pattern3();
            pattern4();
        }

                                                //pattern 1 function
        static void pattern1()
        {
            Console.WriteLine("\nPattern - 1\n");
            int i, j, k;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
                                                //pattern 2 function
        static void pattern2()
        {
            Console.WriteLine("\nPattern - 2");
            Console.WriteLine();
            int i, j, k;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
                                                //pattern 3 function
        static void pattern3()
        {
            Console.WriteLine("\nPattern - 3");
            Console.WriteLine();
            int i, j, k;
            for (i = 5; i > 0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
                                                //pattern 4 function
        static void pattern4()
        {
            Console.WriteLine("\nPattern - 4");
            Console.WriteLine();
            int i, j, k;
            for (i = 0; i < 5; i++)
            {
                for (k = 0; k < 4 - i; k++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
    }
}