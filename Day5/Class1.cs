

using System;

namespace Day5_2_lib
{
    public class Account
    {
        string name;
        int id;
        static int getid;
        double balance;
        const int maxcapacity = 2;


        public Account(string name, double balance)
        {
           
            if (getid < maxcapacity)
            {

                id = ++getid;
                this.name = name;
                this.balance = balance;
                Console.WriteLine("Hiii " + this.id + this.name);
                Console.WriteLine("Your current Balance is:" + this.balance);
            }
            else
            {
                    throw new Exception("Error");
                    Console.WriteLine("U can open only 2 Accounts");
                }
            
        }

        static Account()
        {
            Console.WriteLine("******************WELCOME TO YOUR BANK APPLICATION ********************** ");
        }

        public void deposit(int amount)
        {
            balance += amount;
            Console.WriteLine("{0} After deposit Your current Balance is:{1}", this.name, balance);
        }

        public void withdraw(int amount)
        {
            const int min_balance = 500;

            if (balance < min_balance && amount > balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                balance = balance - amount;
                Console.WriteLine("{0} After Withdraw Your current Balance is:{1}", this.name, balance);
            }
        }

        public void display()
        {
            Console.WriteLine("{0}{1}", name, balance);
        }


    }
}
