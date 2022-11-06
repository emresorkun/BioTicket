

using BioTicket;
using System.Transactions;
bool myBool = false;
do
{
    Console.WriteLine("Welcome to the main menu");
    Console.WriteLine("In order to test different functions");
    Console.WriteLine("0 will end this programme");
    Console.WriteLine("1 will suprise you");
    Console.WriteLine("-----------------\n");
    string userInput = Console.ReadLine()!;
    switch (userInput)
    {
        case "0":
            {
                Console.WriteLine("the programme is shutting down");
                myBool = true;
            }
            break;
        case "1":
            Console.WriteLine("WRONG INPUT");
            break;
        case "2":
            {
                Console.WriteLine("please enter the age of the custormer");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age>64)
                {
                    Console.WriteLine("Thank you for your service! You pay 90 SEK");
                }
                if (age<=20)
                {
                    Console.WriteLine("You are young! You pay 80 SEK");
                }
                if (age<=64 && age>20)
                {
                    Console.WriteLine("the price is 120 SEK");
                }
            }
            break;
        case "3":
            {
                Console.WriteLine("Want to learn your total ticket cost?");
                Console.WriteLine("How many are you?");
                int groupCount = Convert.ToInt32(Console.ReadLine());
                //Instead of declaring prices here I can write a function in utilities??
                //int standartPrice = 120;
                //int ticketTotal = Utilities.CalculateTotal(groupCount, standartPrice);
                //Console.WriteLine($"total price: {ticketTotal}");
                for (int i = 0; i < groupCount; i++)
                {
                    Customer newCustomer = new Customer(0, i, 120);
                    Console.WriteLine($"enter age of the customer number {i+1}");
                    newCustomer.age= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"customer id={newCustomer.id} and age={newCustomer.age}");
                    newCustomer.AgeController(newCustomer.age);
                    Console.WriteLine($"ID: {newCustomer.id}+AGE: {newCustomer.age}"); 
                }

                //TRY ANOTHER WAY TO CREATE INSTANSES

                
                // I can add a loop here to learn each persons age?
                //create a class here field can be price in the custormer
                //customer class will have a methofs (properties cover fields?)
            }
            break;

    }


    //this never ending loop 3 menu option? 
    //never ending loop
} while (!myBool);


//Customer cust2 = new Customer("Test", "Testsson", 1980);
//Customer emre = new Customer("emre", "sorkun", 1979);
//Console.WriteLine(emre);
//emre.DisplayCustomerDetails();

//emre.AgeCalculater();


//emre.AgeCalculater2(cust2, 5);