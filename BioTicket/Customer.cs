using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioTicket
{
    internal class Customer
    {
        public string firstName;
        public string lastName;
        public int birthYear;

        public Customer(string first, string last, int birth)
        {
            firstName = first;
            lastName = last;    
            birthYear = birth;  
        }
    public void AgeCalculater(int birthYear)
        {
            int age=2023-birthYear;
            Console.WriteLine($"{firstName} {lastName}, is {age} years old.");
            
        }
    public  void AgeController (int age)
        {
            if (age > 20)
            {
                Console.WriteLine("youth discount is not possible");
            }
        }
    }
}
