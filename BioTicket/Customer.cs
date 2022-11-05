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
        //private string lastName;
        //private string firstName;
        //private int birthYear;
        private int age;

        public int Age { get; set; }

        //public string FirstName { get; set; }

        public Customer(int age)
        {
            //firstName = first;
            //firstName = first;
            //lastName = last;    
            Age= age;
        }


        public void AgeCalculater2(Customer customer, int test = 2)
        {
            
            int age = customer.age;
            Console.WriteLine($"Customer is {age} years old.");

        }
        //this can go to another class!!!
        public void AgeController (int age)
        {
            if (age > 20)
            {
                Console.WriteLine("youth discount is not possible");
            }
        }

    }
}
