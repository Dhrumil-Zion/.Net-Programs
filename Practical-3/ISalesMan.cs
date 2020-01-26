using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_3
{
    interface ISalesMan                               //Interface
    {
        public void sell(String fname,String lname);
    }
    class CarSale : ISalesMan                         //implementing interface named ISalesMan   
    {
        private string FirstName,LastName;

        public void sell(string fname, string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;
            Console.WriteLine("(Interface) Hi i am "+FirstName+" "+LastName+" and i request you to visit for Car Services");
        }
    }
    class RetailSale : ISalesMan                     //implementing interface named ISalesMan
    {
        private string FirstName, LastName;

        public void sell(string fname, string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;
            Console.WriteLine("(Interface) Hi i am " + FirstName + " " + LastName + " and i request you to visit for Product Services\n");
        }
    }
}
