

using BioTicket;

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

            break;
        default:
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