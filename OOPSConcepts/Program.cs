using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOPSConcepts.Defining;

namespace OOPSConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create new object instances using new operator
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);
            Book b2 = new Book("The grapes of wrath", "John stein beck", 925);

            //call a method on the object
            Console.WriteLine(b1.GetDescription());
            Console.WriteLine(b2.GetDescription());

            //try to set one of the properties 
            //this will result in an error

        }
    }
}
