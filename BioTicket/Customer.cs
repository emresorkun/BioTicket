using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioTicket
{
  public class Customer
     {
        public int Id { get; set; }
        public int Age { get; set; }

        public int GetPrice()
        {
            if (Age > 50) return 100;
            if (Age < 50) return 200;
            return 50;
        }

        public Customer(int id, int age)
        {
            Id = id;
            Age = age;
        }

        //Customer customer1 = new Customer(21, 1);
        //Customer customer2 = new Customer(16, 2);
        //Customer customer3 = new Customer(36, 3);
        //Customer customer4 = new Customer(96, 4);
        //Customer customer5 = new Customer(6, 5);
        //Customer customer6 = new Customer(18, 6);
        



        //public int AgeController (int age, int ticketPrice)
        //{
        //    if (age > 20||age<65)
        //    {
        //        ticketPrice= standartTicketPrice; 
                
        //    }
        //    if (age < 20)
        //    {
        //        ticketPrice = 80;
        //    }
        //    if (age>65)
        //    {
        //        ticketPrice = 90;
        //    };
        //    Console.WriteLine($"Customer number {id+1} will pay {ticketPrice}");
            

        //    return ticketPrice;
        //}


        //// We created these to understand get and set methods. 
        //public void SetID(int newId)
        //{
        //    id = newId;
        //}

        //public int GetId()
        //{
        //    return id;
        //}

        //// using agecontroller I can develop another method that calculates total price?
    }
}
