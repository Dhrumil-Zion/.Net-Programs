using System;
using System.Collections.Generic;

namespace Practical_6
{
    class Program
    {
        public static string single(int x)
        {
            string reply = "";

            switch (x)
            {
                case 0:
                    reply = "Zero";
                    break;
                case 1:
                    reply = "One ";
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
                case 9:
                    reply = "nine";
                    break;
            }

            return reply;
        }

        public static string Dou(int[] x)
        {
            string reply = "";

            if (x[1] == 1 && x[0] == 0)
                return "Ten";

            if (x[0] <= 9 && x[1] == 1)
            {
                switch (x[0])
                {

                    case 1:
                        reply = "Eleven";
                        break;
                    case 2:
                        reply = "Twelve";
                        break;
                    case 3:
                        reply = "Therteen";
                        break;
                    case 4:
                        reply = "Fourteen";
                        break;
                    case 5:
                        reply = "Fifteen";
                        break;
                    case 6:
                        reply = "Sixteen";
                        break;
                    case 7:
                        reply = "Seventeen";
                        break;
                    case 8:
                        reply = "Eighteen";
                        break;
                    case 9:
                        reply = "nineteen";
                        break;
                }



            }
            else if (x[1] != 1)
            {
                switch (x[1])
                {
                    case 2:
                        reply = "Twenty";
                        if (x[0] == 0)
                            return reply;
                        break;
                    case 3:
                        reply = "Thirty";
                        if (x[0] == 0)
                            return reply;
                        break;
                    case 4:
                        reply = "Fourty";
                        if (x[0] == 0)
                            return reply;
                        break;
                    case 5:
                        reply = "Fifty";
                        if (x[0] == 0)
                            return reply;
                        break;
                    case 6:
                        reply = "Sixty";
                        if (x[0] == 0)
                            return reply;
                        break;
                    case 7:
                        reply = "Seventy";
                        if (x[0] == 0)
                            return reply;
                        break;
                    case 8:
                        reply = "Eighty";
                        if (x[0] == 0)
                            return reply;
                        break;
                    case 9:
                        reply = "ninety";
                        if (x[0] == 0)
                            return reply;
                        break;
                }
                reply = reply + "\t" + single(x[0]);
            }
        return reply;
        }
        public static string Thr(int[] x)
        {
            string reply = "";
            if (x[2] == 1 && x[1] == 0 && x[0] == 0)
            {
                return "One Hundred";
            }
            else
            {
                switch (x[2])
                {

                    
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
                    case 9:
                        reply = "NineHundred";
                        break;
                }

                reply = reply + "\t" + Dou(x);
            }

            return reply;
        }
        public static string Fou(int[] x)
        {
            string reply = "";

            if (x[3] == 1 && x[2] == 0 && x[1] == 0 && x[0] == 0)
            {
                return "OneThousand";
            }
            else
            {
                switch (x[3])
                {
                    case 2:
                        reply = "TwoThousand";
                        break;
                    case 3:
                        reply = "ThreeThousand";
                        break;
                    case 4:
                        reply = "FourThousand";
                        break;
                    case 5:
                        reply = "FiveThousand";
                        break;
                    case 6:
                        reply = "SixThousand";
                        break;
                    case 7:
                        reply = "SevenThousand";
                        break;
                    case 8:
                        reply = "EightThousand";
                        break;
                    case 9:
                        reply = "NineThousand";
                        break;
                }
                
                if(Thr(x).Trim().Equals("Zero"))
                        return reply;
                
                reply = reply + "\t" + Thr(x);
            }

            return reply;

        }
        public static string Fiv(int[] x)
        {
            string reply = "";

            if (x[4]==1 &&x[3] == 0 && x[2] == 0 && x[1] == 0 )
            {
                
                return "TenThousand "+single(x[0]);
            }
            else if(x[4] == 1 && x[3] == 0 && x[2] == 0 && x[1]>0)
            {
                return "TenThousand " + Dou(x);
            }
            else if(x[4] == 1 && x[3] == 0 && x[2] >= 1 )
            {
                return "TenThousand " + Thr(x);
            }
            else if(x[4]>=2 )
            {
                int temp = x[1];
                x[1] = x[4];
                reply = Dou(x);
                reply = reply + "\t Thousand";
                x[1] = temp;

                if (Thr(x).Trim().Equals("Zero"))
                    return reply;
                reply = reply + "\t" + Thr(x);
                return reply;


            }
            else if(x[4]==1)
            {
                switch (x[3])
                {

                    case 1:
                        reply = "ElevenThousand";
                        break;
                    case 2:
                        reply = "TwelveThousand";
                        break;
                    case 3:
                        reply = "TherteenThousand";
                        break;
                    case 4:
                        reply = "FourteenThousand";
                        break;
                    case 5:
                        reply = "FifteenThousand";
                        break;
                    case 6:
                        reply = "SixteenThousand";
                        break;
                    case 7:
                        reply = "SeventeenThousand";
                        break;
                    case 8:
                        reply = "EighteenThousand";
                        break;
                    case 9:
                        reply = "NineteenThousand";
                        break;
                }
                if (Thr(x).Trim().Equals("Zero"))
                    return reply;
                

                reply = reply + "\t" + Thr(x);
            }
            
            return reply;


        }
        static void Main(string[] args)
        {
            String fin;
            int i = 0,num;
            string p;
            p = Console.ReadLine();
            num = Convert.ToInt32(p);
            int temp = num;
            int[] arr = new int[7];
            
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
                fin = Dou(arr);
                Console.WriteLine(fin);
            }
            else if(temp.ToString().Length == 3)
            {
                fin = Thr(arr);
                Console.WriteLine(fin);
            }
            else if(temp.ToString().Length == 4)
            {
                fin = Fou(arr);
                Console.WriteLine(fin);
            }
            else if (temp.ToString().Length == 5)
            {
                fin = Fiv(arr);
                Console.WriteLine(fin);
            }
        }
    }
}