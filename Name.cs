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

        public void LastName()
        {
            string lastname;
            var regex = "^[A-Z][a-z]{2,}$";
            Console.WriteLine("Enter the last name : ");
            lastname = Console.ReadLine();
            var match = Regex.Match(lastname, regex);
            if (match.Success)
            {
                Console.WriteLine("Valid Last Name");
            }
            else
            {
                Console.WriteLine("Invalid Last Name");
            }
        }
        public void EmailId()
        {
            string emailPattern;
            var regex = (@"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$");
            Console.WriteLine("Enter email Id");
            string email = Console.ReadLine();
            var match = Regex.Match(email, regex);
            if (match.Success)
            {
                Console.WriteLine("valid email address");
            }
            else
            {
                Console.WriteLine("Please enter a Valid Email!");
            }
        }
        public void PhoneNumber()
        {
            string phoneNumberPattern;
            var regex = @"^[0-9]+[\s]+[0-9]{10}$";
            Console.WriteLine("Enter valid Phone Number");
            string phoneNumber = Console.ReadLine();
            var match = Regex.Match(phoneNumber, regex);
            if (match.Success)
            {
                Console.WriteLine("valid Phone Number");
            }
            else
            {
                Console.WriteLine("Please enter a Valid phone number!");
            }
        }
    }
}





