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


        const int standartTicketPrice = 120;
        //constructor for the custormer class
        public Customer(int ageValue, int idValue)
        {
            age= ageValue; 
            id= idValue;
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
            else ticketPrice = 90;
            Console.WriteLine($"Customer number {id} will pay {ticketPrice}");
            return ticketPrice;
        }
        
      
    }
}
