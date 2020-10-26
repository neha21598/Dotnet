using System;

namespace Day_4_3_lib
{
    public class Customer
    {
        int id;
        string name;
        double bill_amount;

        public Customer()
        { }

        public void display()
        {
            Console.WriteLine("Default values are:");
            Console.WriteLine("Id is: {0} \n Name is: {1} \n Bill Amount is: {2}", id, name, bill_amount);
            Console.ReadLine();
        }

    }
}
