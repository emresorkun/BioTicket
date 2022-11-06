using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioTicket
{
    internal class Customer
     {
        public int age;
        public int id;
        public int ticketPrice;


        const int standartTicketPrice = 120;
        //constructor for the custormer class
        public Customer(int ageValue, int idValue, int ticketValue)
        {
            age= ageValue; 
            id= idValue;
            ticketPrice= ticketValue;
        }

        
        public int AgeController (int age, int ticketPrice=120)
        {
            if (age > 20||age<65)
            {
                ticketPrice= standartTicketPrice; 
                
            }
            if (age < 20)
            {
                ticketPrice = 80;
            }
            if (age>65)
            {
                ticketPrice = 90;
            };
            Console.WriteLine($"Customer number {id+1} will pay {ticketPrice}");
 

            return ticketPrice;
        }
        
        // using agecontroller I can develop another method that calculates total price?
    }
}
