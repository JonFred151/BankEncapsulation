using System;
namespace BankEncapsulation 
{
    class Program
    {
        static void Main(string[] args)
        {
            //set up variables and calls the other class
            int Choice;
            var myBank = new BankAccount();
            do
            {
                //menu for bank app
                Console.WriteLine("Please select the action you wish to do. \n1: Withdraw \n2: Desposit \n3: Balance \n4: Exit");
                if (int.TryParse(Console.ReadLine(), out Choice))
                {
                    switch (Choice)
                    {
                        case 1:
                            // withdraw user money and clears
                            Console.Clear();
                            double amount;
                            Console.WriteLine("Enter the amount you wish to withdraw.");
                            amount = Convert.ToDouble(Console.ReadLine());
                            myBank.Withdraw(amount);
                            Console.WriteLine($"You withdraw:${amount} \nPress any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 2:
                            // Desposit user money and clears
                            Console.Clear();    
                            Console.WriteLine("Enter the Amount that you want to desposit.");
                            amount = Convert.ToDouble(Console.ReadLine());
                            myBank.Deposit(amount);
                            Console.WriteLine($"You deposit:${amount} \nPress any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                         case 3:
                            // gets user balance and clears
                            Console.Clear();
                            amount =  myBank.GetBalance();
                            Console.WriteLine($"You balance:${amount} \nPress any key to continue");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                            case 4:
                            //exit program
                            Console.Clear();
                            Console.WriteLine("Exiting Program!! \nThank you for using your [Enter your bank name here]");
                            break;
                            default:
                            // Clear and loops when user input wrong number
                            Console.Clear() ;
                            Console.WriteLine("Invalid Choice. Please select the given option!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
                else
                {
                    // Clears the screen and loop when user input a letter
                    Console.Clear();
                    Console.WriteLine("Invalid input try again!");
                    Console.ReadKey(); 
                    Console.Clear();
                }
            } while (Choice != 4);







        }
    }

}
