using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_5
{
    class Class1
    {
        public static void Main(string[] args)
        {
            string infix = "a+b-c/d";
            string postfix;
            Program p = new Program();
            p.InfixToPostfix(ref infix, out postfix);

             
        }

    }
}
