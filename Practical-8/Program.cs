using System;

namespace Practical_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Conversion");
            Console.WriteLine("1 - CELSIUS TO FARENHITE ");
            Console.WriteLine("2 - FARENHITE TO CELSIUS ");

            int Choose = int.Parse(Console.ReadLine());

            switch(Choose)
            {
                case 1:  //CESLSIUS TO FARENHITE 

                    Console.WriteLine("Enter the value in CELSIUS");

                    double cel = double.Parse(Console.ReadLine());

                    double far = (cel * (9 / 5)) + 32;

                    Console.WriteLine($" °C {cel} = "+far +" FARENHITE ");
 
                break;

                case 2:  //FARENHITE TO CELSIUS 

                    Console.WriteLine("Enter the value in FARENHITE");

                    double fare = double.Parse(Console.ReadLine());

                    double cels = (fare * (5 / 9)) - 32;

                        Console.WriteLine($" FARENHITE {fare} = °C {cels} ");

                    break;


            }
        }
    }
}
