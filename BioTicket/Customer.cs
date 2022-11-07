using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioTicket
{
    // ASK!!! WHY CANT I DO THIS ONE PUBLIC? GIVES AN ERROR! 
    internal class Customer
     {
        public int age;
        public   int id;
        public  int ticketPrice;

        //private int length;


        //WHAT LENGHT??? WHY WE DECIDED TO BE LENGHT HERE?
        // TO VALIDATE! TO CHECK IF THERE IS VALUE ENTERED!!!!
        //public int MyProperty 
        //{
        //    get { return length; }
        //    set { length = value; }
        //}

        //SAME AS ABOVE
        public int Lenght { get; set; }







        const int standartTicketPrice = 120;
        //constructor for the custormer class

        public CustomerType customerType;

        public Customer(int ageValue, int idValue, int ticketValue=120)
        {
            age= ageValue; 
            id= idValue;
            ticketPrice= ticketValue;
        }

        public Customer(int ageValue, int idValue, int ticketValue, CustomerType custType)
        {
            age = ageValue;
            id = idValue;
            ticketPrice = ticketValue;
            customerType = custType;
        }



        public int AgeController (int age, int ticketPrice)
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


        // We created these to understand get and set methods. 
        public void SetID(int newId)
        {
            id = newId;
        }

        public int GetId()
        {
            return id;
        }

        // using agecontroller I can develop another method that calculates total price?
    }
}
