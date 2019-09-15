using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Buyer
    {
        string firstname;
        string lastname;
        string fullName;
        public string FullName{ get { return fullName;} }
        public Buyer(string firstName,string lastName)
        {
            firstname = firstName;
            lastname = lastName;
            fullName = firstname +" "+ lastname;
        }
    }
}
