using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    internal class Defining
    {
        //classes have a name, unique within the namespace
        public class Book
        {
            //classes have member variables or fields to hold data
            string _name;
            string _author;
            int _pagecount;

            //classes have one or more constructors
            public Book(string name, string author, int pages)
            {
                _name = name;
                _author = author;
                _pagecount = pages;
            }

            //Methods are used to operate in the class and data
            public string GetDescription()
            {
                return $"{_name} by {_author}";

            }


        }
    }
}
