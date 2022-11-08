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
            if (Age > 64) return 90;
            if (Age <= 20) return 80;
            if (Age<=64 && Age>20) return 120;

            return 50;
        }

        public Customer(int id, int age)
        {
            Id = id;
            Age = age;
        }

        
    }
}
