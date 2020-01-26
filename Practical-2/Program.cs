using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Practical_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String FirstName, CountryName;
            int flag = 0;
            Console.WriteLine("Enter your name ");             //Getting User Name
            FirstName = Console.ReadLine();

            Console.WriteLine("You are from which country ?"); //Getting User Country
            CountryName = Console.ReadLine();

                                                               //Validation useing Regex

            if (Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") && Regex.IsMatch(CountryName, @"^[a-zA-Z]+$"))
            {
                flag = 1;
                Console.WriteLine("Hello " + FirstName + " you are from " + CountryName);
                Console.Read();
            }

            if (flag == 0)
            {
                Console.WriteLine("Name Or Coutry Name does not match with constrains.");    //Error Message.
            }
        }
    }
}
