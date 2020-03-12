using System;
using System.Globalization;

namespace Practical_7
{
    class Program
    {
        static void Main(string[] args)
        {

            //coversion of currency

            Console.WriteLine("Choose Which Conversion You Wnted To Execute :");
            Console.WriteLine("1 - INR TO DOLLERS");
            Console.WriteLine("2 - INR TO YEN");
            Console.WriteLine("3 - INR TO EURO");


            int choose = int.Parse(Console.ReadLine());

            switch(choose)
            {
                case 1: //INR TO DOLLER

                    Console.WriteLine("Enter Amount In INR");

                    double inr = double.Parse(Console.ReadLine());

                    double doller = inr * 74.32;

                    Console.WriteLine($"INR {inr} = "+doller.ToString("C",new CultureInfo("en-us")));


                    break;

                case 2: //INR TO YEN

                    Console.WriteLine("Enter Amount In INR");

                    double inrf = double.Parse(Console.ReadLine());

                    double yen = inrf * 0.72;

                    Console.WriteLine($"INR {inrf} = "+ yen.ToString("C",new CultureInfo("ja-JP")));

                    break;

                case 3:  //INR TO EURO

                    Console.WriteLine("Enter Amount In INR");

                    double inrd = double.Parse(Console.ReadLine());

                    double euro = inrd * 83.07;

                    Console.WriteLine($"INR {inrd} = "+euro.ToString("C",new CultureInfo("en-150")));

                    break;

            }


        }
    }
}
