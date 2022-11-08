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
            groupCall.Add(customer);  
            
        }

        public List<Customer> GetCustomers()
        {
            return groupCall.ToList();
        }
    } 
}
