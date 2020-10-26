/*Create a class Account having private instance member Id, Name Balanceamt. Create method deposit who’s job is to increase 
 * Balanceamtby the amout deposited buy account holder. Create method withdraw who’s job is to decrease Balanceamtby the amout 
 * withdrwan buy account holder. Write method display which will display name and Balanceamt. This application will be
 * classlibrary.Create console application and use this class library. Create at least two object of account class and deposit 
 * and withdraw money.
*/

using System;

namespace Day4_1_Lib
{
    public class Account
    {
                string name;
        int id;
        static int getid;
        double balance;

        public Account(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
            Console.WriteLine("Hiii " + this.name + "\n");
            Console.WriteLine("Your current Balance is:" + this.balance);
        }

        static Account()
        {
            Console.WriteLine("******************WELCOME TO YOUR BANK APPLICATION ********************** ");
        }

        public void deposit(int amount)
        {
            balance += amount;
            Console.WriteLine("Your current Balance is:{0}", balance);
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
                Console.WriteLine("Your current Balance is:{0}", balance);
            }
        }

        public void display()
        {
            Console.WriteLine("{0}{1}", name, balance);
        }


    }
}

