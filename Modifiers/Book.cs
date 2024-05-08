using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiers
{
    //access modifiers control how properties and methods are accessed
    class Book
    {
        //public members and methods can be accessed by any other code
        public string _name;

        //protected members can only be accessed by the class or a derived class  
        protected string _author;

        //private is the default and can only be accessed by the code
        private int _pagecount;

        public Book (string name, string author, int pages)
        {
            _name = name;
            _author = author;   
            _pagecount = pages;

        }

        public string GetDescription()
        {
            return $"{_name} by {_author} and {_pagecount}";

        }

        /*protected string GetDescription()
        {
            return $"{_name} by {_author}";

        }*/
        /* private string GetDescription()
         {
             return $"{_name} by {_author}";

         }
 */
        //member variables can be accessedvia methods
        public string GetName()
        {
            return _name ;
        }
        
        public void SetName(string s)
        {
            _name = s ; 
        }
        public void SetAuthor(string s)
        {
            _author = s ;
        }
        public void Setpagecount (int c)
        {
            _pagecount = c ;
        }

    }
}
