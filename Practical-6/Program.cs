using System;
using System.Collections.Generic;

namespace Practical_6
{
    class Program
    {
        public static string single(int x)
        {
            string reply = "";
                
            switch(x)
            {
                case 0: reply = "Zero";
                    break;
                case 1:reply = "One ";
                    break;
                case 2:
                    reply = "Two ";
                    break;
                case 3:
                    reply = "Three";
                    break;
                case 4:
                    reply = "Four";
                    break;
                case 5:
                    reply = "Five";
                    break;
                case 6:
                    reply = "Six";
                    break;
                case 7:
                    reply = "Seven";
                    break;
                case 8:
                    reply = "Eight";
                    break;
            }

            return reply;
        }

        public static string dou(int[] x)
        {
            string reply = "";
            

            switch (x[1])
            {
                
                case 1:
                    reply = "OneHundred";
                    break;
                case 2:
                    reply = "TwoHundred";
                    break;
                case 3:
                    reply = "ThreeHundred";
                    break;
                case 4:
                    reply = "FourHundred";
                    break;
                case 5:
                    reply = "FiveHundred";
                    break;
                case 6:
                    reply = "SixHundred";
                    break;
                case 7:
                    reply = "SevenHundred";
                    break;
                case 8:
                    reply = "EightHundred";
                    break;
            }

            reply = reply +"\t"+ single(x[0]);
            return reply ;
        }


        static void Main(string[] args)
        {
            String fin;
            int i = 0,num = 82;
            int temp = num;
            int[] arr = new int[5];
            
            while (num > 0)
            {
                arr[i] = num % 10;
                
                num = num / 10;
                i++;
            }
            if(temp.ToString().Length == 1)
            {
                fin = single(arr[0]);
                Console.WriteLine(fin);
            }
            else if(temp.ToString().Length==2)
            {
                fin = dou(arr);
                Console.WriteLine(fin);
            }
            



        }

        
    }
}
