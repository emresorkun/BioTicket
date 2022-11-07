

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
                int age = Convert.ToInt32(Console.ReadLine()); //int.TryParse
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
                //let cal = new String("Hej");
                //let cal = 'Hej';

                //function GroupCal(){
                //this.groupCall = [];
                //this.AddCustomer = function(){.....}
            
                //}

                //let cal = new GroupCall();
                //cal.AddPerson()
                //let cal2 = new GroupCall();
               

                GroupCal cal = new GroupCal();
               // Console.WriteLine(cal.GetType().Name);
                //cal.AddCustomer(1,50);
                //ASK ASK ASK WHERE SHOULD BE THE LIST PLACED????
                
                //Instead of declaring prices here I can write a function in utilities??
                //int standartPrice = 120;
                //int ticketTotal = Utilities.CalculateTotal(groupCount, standartPrice);
                //Console.WriteLine($"total price: {ticketTotal}");
                for (int i = 0; i < groupCount; i++)
                {
                    //GroupCal cal = new GroupCal();

                    ////Customer newCustomer = new Customer(0, i, 120);
                    Console.WriteLine($"enter age of the customer number {i+1}");
                    string input = Console.ReadLine();
                    //Convert to int  with int.TryParse()
                    int age = 0;
                    if(!int.TryParse(input, out age))
                    {
                        //Couldent parse
                        Console.WriteLine($"Couldent parse {input} to int, {input} is set to 0"); //Do better?
                    }

                    cal.AddCustomer(i+1, age);

                    //Get input
                    //Call call.AddCustomer with id and age

                    //newCustomer.age= Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine($"customer id={newCustomer.id} and age={newCustomer.age}");

                    //Console.WriteLine($"ID: {newCustomer.id}+AGE: {newCustomer.age}"); 
                }
                int total = 0;
                foreach(Customer customer in cal.GetCustomers())
                {
                    total = total + customer.GetPrice();
                }

                Console.WriteLine(total);

                //TRY ANOTHER WAY TO CREATE INSTANSES


                // I can add a loop here to learn each persons age?
                //create a class here field can be price in the custormer
                //customer class will have a methofs (properties cover fields?)
            }
            break;

    }
    ////Execise to undertand encapsulation
    //Customer customer2 = new Customer(66, 6666, 129);
    //Console.WriteLine(customer2.GetId());
    //customer2.SetID(3);
    //customer2.Lenght = 45;
    //Console.WriteLine(customer2.Lenght);
    //Console.WriteLine("customer 2 new id "+customer2.id);
    ////this never ending loop 3 menu option? 
    //never ending loop
} while (!myBool);


//Customer cust2 = new Customer("Test", "Testsson", 1980);
//Customer emre = new Customer("emre", "sorkun", 1979);
//Console.WriteLine(emre);
//emre.DisplayCustomerDetails();

//emre.AgeCalculater();


//emre.AgeCalculater2(cust2, 5);