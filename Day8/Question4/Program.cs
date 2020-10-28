/* 
 Q4. Create a class swapdemo having method
 	Public void swap(int x, int y)
Job of this method is to swap two number. Create a entry point class  who’s job is to call this method and print swapped data.*/


using System;

namespace Day8_4
{
    class swapdemo
    {
        public void swap(int x, int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("Swapped Data is:");
            Console.WriteLine("x={0}", x);
            Console.WriteLine("y={0}", y);
        }
        static void Main(string[] args)
        {
            swapdemo s = new swapdemo();
            s.swap(2, 3);

            Console.ReadLine();
        }
    }
}
