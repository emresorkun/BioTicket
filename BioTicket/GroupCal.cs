using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioTicket
{
    public class GroupCal
    {
        private List<Customer> groupCall; 

        public GroupCal()
        {
            groupCall = new List<Customer>();
        }

        //public void AddCustomer(Customer);
        public void AddCustomer(int id, int age)
        {
            Customer customer = new Customer(id, age);
            //Console.WriteLine($"enter age of the customer number");
            //customer.Age= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"The Customer is {customer.Age} years old");
            //CALL ANOTHER METHOD AND CALCULATE PRICE
            //CALL YET ANOTHER METHOD AND PRINT TOTAL PRICE AND ASK IF THE 
            //USER WANTS TO ADD ANOTHER customer (do, while?)
            groupCall.Add(customer);  
            
        }

        public List<Customer> GetCustomers()
        {
            return groupCall.ToList();
        }
    } 
}
