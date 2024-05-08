using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //create new object instances using new operator
                Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);
                Book b2 = new Book("The grapes of wrath", "John stein beck", 925);

            //call a method on the object
           /* b1._name = "Cat in the hat";
            Console.WriteLine(b1.GetDescription());
*/
            //set data using functions instead of accessing fields directly
            b1.SetName("Grapes of wrath");
            b1.SetAuthor("John steinbeck");
            b1.Setpagecount(925);
            Console.WriteLine(b1.GetDescription());
           

                

            
        }
    }
    
}
