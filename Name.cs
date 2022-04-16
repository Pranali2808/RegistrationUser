using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Name
    {
        public void First()
        {
            string firstName;
            var regex = "^[A-Z][a-z]{2,}$";
            Console.WriteLine("Enter First Name: ");
            firstName = Console.ReadLine();
            var match = Regex.Match(firstName, regex);
            if (match.Success)
            {
                Console.WriteLine("Valid First Name");
            }
            else
            {
                Console.WriteLine("Invalid First Name");
            }
        }
    }
}
    

