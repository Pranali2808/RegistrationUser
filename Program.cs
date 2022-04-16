using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User registration problem");
            Name first = new Name();
            //first.First();
            //first.LastName();
            //first.EmailId();
            //first.PhoneNumber();
            // first.MinimumChar();
            //first.UpperCase();
            first.NumericValue();

            Console.ReadLine();
        }
       
    }
}
