/* . In your account application add functionality of sort which will display data name wise ascending order.
 * */

using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_1
{
    class Account
    {
        int id;
        static int getid;
        public string name;
        public double balance;

        static Account()
        {
            Console.WriteLine("*******Bank Of India*********");
        }
        
        public Account(String name, double balance)
        {
         
          
                id = ++getid;
                this.name = name;
                this.balance = balance;
                Console.WriteLine("Hiii {0} Your Current Balance is {1}", this.name, this.balance);
            
        }

        
        public void deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("After depositing money your currnet balance is:{0}", balance);
        }

        public void withdraw(double amount)
        {
            
            if (balance < 0 || balance < amount)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else {
                balance -= amount;
                Console.WriteLine("After Withdrawing money your currnet balance is:{0}", balance);
            }
        }

     
    }

    class Data_sort : IComparer
    {
        // Test the pet name of each object.
        public int Compare(object x, object y)
        {

            Account t1 = x as Account;
            Account t2 = y as Account;
            if (t1 != null && t2 != null)
                return String.Compare(t1.name, t2.name);
            else
                throw new ArgumentException("Parameter is not a emp!");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account[] a1 = new Account[3] ;
            a1[0]= new Account( "Neha", 50000 );
            a1[1]= new Account( "Tejal", 10000 );
            a1[2]=new Account("Devendra",60000);


             Array.Sort(a1,new Data_sort());

             Console.WriteLine("\nSorted Names are:");
             foreach (Account a in a1)
             {
                 Console.WriteLine("{0}               {1} ", a.name,a.balance);
             }
            


            Console.ReadLine();


        }
    }
}
