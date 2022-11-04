using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioTicket
{
    internal class Customer
    {

        //fields should not be public! they are private! Properties shoud be public! not 
        private string lastName;
        private string firstName;
        private int birthYear;

        public int BirthYear { get; set; }

        public string FirstName { get; set; }

        public Customer(string first, string last, int birth)
        {
            //firstName = first;
            firstName = first;
            lastName = last;    
            BirthYear = birth;
        }

        //this can go to another class!!!
    public void AgeCalculater()
        {
            int age=2022-BirthYear;
            Console.WriteLine($"{firstName} {lastName}, is {age} years old.");
            
        }

        public void AgeCalculater2(Customer customer, int test = 2)
        {
            
            int age = 2022 - customer.BirthYear;
            Console.WriteLine($"{customer.firstName} {customer.lastName}, is {age} years old.");

        }
        //this can go to another class!!!
        public void AgeController (int age)
        {
            if (age > 20)
            {
                Console.WriteLine("youth discount is not possible");
            }
        }

        public void DisplayCustomerDetails()
        {
            Console.WriteLine($"\nFirst name: \t{firstName}\nLast name: \t{lastName}\nBirthyear: \t{birthYear}"); 
        }
    }
}
