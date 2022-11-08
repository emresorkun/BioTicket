

using BioTicket;
using System;
using System.Transactions;
using static System.Net.Mime.MediaTypeNames;

bool myBool = false;



do
{
    ShowMenu();

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
                    Console.WriteLine("-----------------\n");
                }
                if (age<=20)
                {
                    Console.WriteLine("You are young! You pay 80 SEK");
                    Console.WriteLine("-----------------\n");
                }
                if (age<=64 && age>20)
                {
                    Console.WriteLine("the price is 120 SEK");
                    Console.WriteLine("-----------------\n");
                }
            }
            break;
        case "3":
            {
                Console.WriteLine("Want to learn your total ticket cost?");
                Console.WriteLine("How many are you?");
                int groupCount = Convert.ToInt32(Console.ReadLine());
                

                GroupCal cal = new GroupCal();
                
                for (int i = 0; i < groupCount; i++)
                {
                    
                    Console.WriteLine($"enter age of the customer number {i+1}");
                    string input = Console.ReadLine();
                    //Convert to int  with int.TryParse

                    int age = 0;
                    if(!int.TryParse(input, out age))
                    {
                        //Couldent parse
                        Console.WriteLine($"Only numbers are allowed in this program. You are being directed to exit. Run the programme again");
                        Environment.Exit(0);
                        //HOW TO Direck to the main menu?
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
                Console.WriteLine($"-----------------\n");
                Console.WriteLine($"Your movie theater visit will cost {total} Unit money today");

                //TRY ANOTHER WAY TO CREATE INSTANSES


                // I can add a loop here to learn each persons age?
                //create a class here field can be price in the custormer
                //customer class will have a methofs (properties cover fields?)
            }
            break;
        case "4":
            {
                Console.WriteLine("please enter a value so we can loop");
                string userLoop= Console.ReadLine();
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(userLoop+" ");
                }
            }
            break;
        case "5":
            {
                Console.WriteLine("please enter a sentence");
                string sentence= Console.ReadLine();
                string[] result = sentence.Split(" ");
                if (result.Length > 3)
                {
                    Console.WriteLine("wel done");
                    Console.WriteLine($"this is the third word in your sentence {result[2]}");
                }  
                else
                {
                    Console.WriteLine("please write more then 3 words!!!");

                }
                
            }
            break;

    }

} while (!myBool);

void ShowMenu()
{
    Console.WriteLine("-----------------\n");
    Console.WriteLine("Welcome to the main menu");
    Console.WriteLine("-----------------\n");
    Console.WriteLine("In order to test different functions");
    Console.WriteLine("0 Will end this programme");
    Console.WriteLine("1 Will suprise you");
    Console.WriteLine("2 Give you the price and discount list");
    Console.WriteLine("3 Will calculate the total amount of your bio group tickets!");
    Console.WriteLine("4 Will loop for you");
    Console.WriteLine("5 Will Find the third word of your sentence for you");
    Console.WriteLine("-----------------\n");
}