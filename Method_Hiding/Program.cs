using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Hiding
{

    class parent                                                         //parent class with show method
    {
        
        public void show()
        {
            
            Console.WriteLine("This is the Parent class method");
        }
    }
    class child:parent                                                 // child class inheriting parent class with the same method name in parent class
    {
        public new void show()
        {
            Console.WriteLine("This is the child class method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            child c = new child();                              //creating object of child class 
            c.show();                                           //calls the method of child class only hiding the method of parent class


            parent p = new child();                           // but if u want to call the hiden method use this
            p.show();
            
        }
    }
}
