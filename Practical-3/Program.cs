using System;
namespace Practical_3
{
    abstract class SalesMan      //Base Class 
    {
        public string FirstName, LastName;
        public abstract void Sell(string fname, string lname);

    }
    class CarSaleMan : SalesMan  //Inherited by SalesMan
    {
        public override void Sell(string fname, string lname)
        {
            base.FirstName = fname;
            base.LastName = lname;
            Console.WriteLine("(Abstract) My FirstName is " + FirstName + " and LastName is " + LastName + " and i request you to visit Showroom for CAR service.");
        }
    }
    class RetailSaleMan : SalesMan  //Inherited by SalesMan
    {
        public override void Sell(string fname, string lname)
        {
            base.FirstName = fname;
            base.LastName = lname;
            Console.WriteLine("(Abstract) My FirstName is " + FirstName + " and LastName is " + LastName + " and i request you to visit Shop for PRODUCT service.\n");
        }
    }

    class Program                   
    {
        static void Main(string[] args)
        {


            CarSalesMan car = new CarSalesMan();             //Using different class in same Namespace 
            car.Sell_sell("Dhrumil", "Gohel");

            RetailSalesMan retail = new RetailSalesMan();    //Using different class in same Namespace
            retail.Sell_sell("Jahnvee", "Joshi");               



            CarSaleMan car_2 = new CarSaleMan();             //Using Abstract classs Named SalesMan
            car_2.Sell("Mihir", "Joshi");

            RetailSaleMan retail_2 = new RetailSaleMan();    //Using Abstract classs Named SalesMan
            retail_2.Sell("Rahul", "Ghetia");

            
            
            CarSale car_3 = new CarSale();                   //Using Interface Named ISalesMan
            car_3.sell("Mihir", "Joshi");

            RetailSale retail_3 = new RetailSale();          //Using Interface Named ISalesMan
            retail_3.sell("Rahul", "Ghetia");
        }
    }
}