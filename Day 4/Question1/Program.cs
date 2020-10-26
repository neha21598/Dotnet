using System;
using Day4_1_Lib;

namespace Day4_1_console
{
    class Program
    {
        static void Main(string[] args)
        {
            int f;
            Account a1 = new Account("Neha", 50000);
            Account a2 = new Account("Dev", 20000);
            do
            {

                string amount;
                Console.WriteLine("\n1.Deposit \n2.Withdraw \n0.Exit");
                Console.WriteLine("\nEnter Your Choice:");
                string ch = Console.ReadLine();
                bool a = int.TryParse(ch, out f);
                switch (f)
                {
                    case 1:
                        Console.WriteLine("Enter Amount to be deposited:");
                        amount = Console.ReadLine();
                        bool b = int.TryParse(amount, out f);
                        a1.deposit(f);
                        break;

                    case 2:
                        Console.WriteLine("Enter Amount to withdraw from your account:");
                        amount = Console.ReadLine();
                        bool c = int.TryParse(amount, out f);
                        a1.withdraw(f);
                        break;

                    case 0:
                        Console.WriteLine("Exiting");
                        break;
                }
            } while (f != 0);
        }
    }   
 }
 