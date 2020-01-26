using System;

namespace Converter
{
    class Program
    {

        void DeciToBinary()                          //Decimal To Binary 
        {
            Console.WriteLine("\nDecimal To Binary\n");
            int Deci = 15;
            int t = Deci;
            int[] Bin = new int[5];
            int i;
            for (i = 0; i < 4; i++)
            {
                if (Deci > 0)
                {
                    Bin[i] = Deci % 2;

                    Deci = Deci / 2;
                }
            }
            Console.Write(t+" To Binary : ");
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(Bin[j] + " ");
            }
            Console.WriteLine("\n\n");
        }

        void DeciToOctal()                              //Decimal To Octal
        {
            Console.WriteLine("Decimal To Octal\n");
            int Deci = 15;
            int t = Deci;
            int[] Octal = new int[20];
            int i;
            for (i = 0; i < 20; i++)
            {
                if (Deci > 0)
                {
                    Octal[i] = Deci % 8;
                    if (Deci < 7)
                    {
                        break;
                    }
                    Deci = Deci / 8;
                }
            }

            Console.Write(t + " To Octal : ");
            for (int j = i; j >= 0; j--)
            {
                Console.Write(Octal[j] + "");
            }
            Console.WriteLine("\n\n");
        }

        public void DeciToHexa()                        //Decimal to Hexadecimal
        {
            Console.WriteLine("Decimal To Hexadecimal\n");
            int i,Deci = 15;
            int t = Deci;
            char[] hexaNum = new char[100];
            
            int temp = 0;
            for (i = 0;i<100; i++)
            {
                if (Deci > 0)
                {
                    temp = Deci % 16;

                    if (temp < 10)
                        hexaNum[i] = (char)(temp + 48);
                    else
                        hexaNum[i] = (char)(temp + 55);
                     
                    Deci = Deci / 16;
                }
                else
                    break;
            }
            Console.Write(t + " To Hexadecimal : ");
            for (int j = i - 1; j >= 0; j--)
                Console.Write(hexaNum[j]);
            Console.WriteLine("\n\n");
        }

        public void BinToDecimal()                      //Binary To Decimal
        {
            Console.WriteLine("Binary To Decimal\n");
            int Deci = 10101010;
            int t = Deci;
            int end_digit , ba = 1 , deci = 0;
            while (Deci > 0)
            {
                end_digit = Deci % 10;
                Deci = Deci / 10;
                deci += end_digit * ba;
                ba = ba * 2;
            }
            Console.Write(t + " To Hexadecimal : ");
            Console.WriteLine(deci);
        }

        static void Main(string[] args)                 //Main Function
        {
            Program p = new Program();

            p.DeciToBinary();                          //Calling Decimal to Binary function

            p.DeciToOctal();                           //Calling Decimal to Octal function 

            p.DeciToHexa();                            //Calling Decimal to Hexadecimal function 

            p.BinToDecimal();                          //Calling Binary to Decimal function 

        }
    }
}
