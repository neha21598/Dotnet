using System;
using Day5_2_lib;

namespace Day5_2_console
{
    class Program
    {
        static void Main(string[] args)
        {
            int f;

            try
            {
                Account a1 = new Account("Neha", 50000);
                Account a2 = new Account("Dev", 60000);
             //   Account a3 = new Account("Piyush", 70000);

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
                            a2.deposit(f);
                    //        a3.deposit(f);
                            break;

                        case 2:
                            Console.WriteLine("Enter Amount to withdraw from your account:");
                            amount = Console.ReadLine();
                            bool c = int.TryParse(amount, out f);
                            a1.withdraw(f);
                            a2.withdraw(f);
                      //      a3.deposit(f);
                            break;

                        case 0:
                            Console.WriteLine("Exiting");
                            break;
                    }
                } while (f != 0);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }
            Console.ReadLine();
        }
       
    }
}
