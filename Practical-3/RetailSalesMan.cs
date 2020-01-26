using System;

namespace Practical_3
{
    class RetailSalesMan 
    {

        private String FirstName, Lastname;
        public void Sell_sell(String F, String L)
        {
            this.FirstName = F;
            this.Lastname = L;
            Console.WriteLine("(Different File) My FirstName is " + F + " and LastName is " + L+ " and i request you to visit Shop for Product service.\n");
        }
    }
}
