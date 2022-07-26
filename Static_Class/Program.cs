using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class
{
    static class Product                           //creating static class
    {
        static int ProductId;                       // creating static members
        static string ProductName;
        static int ProductPrice;

        static Product()                                 //creating static constructors to initialize static members
        {

            ProductId = 111;
            Console.WriteLine("Please enter the product name:");
            ProductName = Console.ReadLine();

            Console.WriteLine("Please enter the product Price:");
            ProductPrice = int.Parse(Console.ReadLine());


        }

       public static void getDetails()                                          //creating static methods
        {
            Console.WriteLine("ProductId is:{0}",ProductId);
            Console.WriteLine("ProductName is:{0}", ProductName);
            Console.WriteLine("ProductPrice is:{0}", ProductPrice);
        }
        
        public static void getDiscount()
        {

            int prd_price = ProductPrice / 10;
            Console.WriteLine("Your discount is:{0}",prd_price);
            Console.WriteLine("Total amount is:{0}",ProductPrice-prd_price);

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Product.getDetails();                                        //accessing the static methods using static class name
            Product.getDiscount();
            Console.ReadLine();
        }
    }
}
