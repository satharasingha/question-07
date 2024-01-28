using System;

namespace question07
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int balance = 1000;

            
            while (true)
            {
                Console.WriteLine("\nATM Menu:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");

              
                int choice;
                if (Int32.TryParse(Console.ReadLine(), out choice))
                {
                   
                    switch (choice)
                    {
                        case 1:
                           
                            CheckBalance(balance);
                            break;
                        case 2:
                            
                            DepositMoney(ref balance);
                            break;
                        case 3:
                            
                            WithdrawMoney(ref balance);
                            break;
                        case 4:
                            
                            Console.WriteLine("Thank you for using the ATM!");
                            return;
                        default:
                           
                            Console.WriteLine("Invalid choice. Please choose a valid option.");
                            break;
                    }
                }
                else
                {
                  
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
        }

        
        static void CheckBalance(int balance)
        {
            Console.WriteLine("Your current balance is: " + balance);
        }

        
        static void DepositMoney(ref int balance)
        {
            
            Console.Write("Enter the amount to deposit: ");

            
            int amount;
            if (Int32.TryParse(Console.ReadLine(), out amount))
            {
               
                if (amount > 0)
                {
                  
                    balance += amount;
                    Console.WriteLine("Deposit successful. Your new balance is: " + balance);
                }
                else
                {
                    
                    Console.WriteLine("Invalid deposit amount Please enter a positive value.");
                }
            }
            else
            {
                
                Console.WriteLine("Invalid input Please enter a valid integer.");
            }
        }

       
        static void WithdrawMoney(ref int balance)
        {
          
            Console.Write("Enter the amount to withdraw: ");

            
            int amount;
            if (Int32.TryParse(Console.ReadLine(), out amount))
            {
                if (amount > 0)
                {
                    
                    if (balance == 0)
                    {
                       
                        Console.WriteLine("Insufficient balance to complete the withdrawal.");
                    }
                    else if (amount <= balance)
                    {
                        
                        balance -= amount;
                        Console.WriteLine("Withdrawal successful. Your new balance is: " + balance);
                    }
                    else
                    {
                        
                        Console.WriteLine("Insufficient balance to complete the withdrawal.");
                    }
                }
                else
                {
                   
                    Console.WriteLine("Invalid withdrawal amount. Please enter a positive value.");
                }
            }
            else
            {
                
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}