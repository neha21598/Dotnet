/* . Create a interface Itaxtogov with method void paytax(double amt) create a class myindia, myeurope let this class implement this interface.
 * In class myindia  paytax method will print tax amount which is 40% of the data passed in method. In class myeurope  paytax method will print tax amount 
 * which is 30% of the data passed in method */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_5
{
    interface Itaxtogov
    {
        void paytax(double amt);
    }

    class myindia:Itaxtogov
    {
        public void paytax(double amt)
        {
            Console.WriteLine("Tax of India is:{0}",amt*0.4);
        }
    }

    class myeurope : Itaxtogov
    {
        public void paytax(double amt)
        {
            Console.WriteLine("Tax of europe is:{0}",amt * 0.3);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            myindia india = new myindia();
            india.paytax(10000);

            myeurope e = new myeurope();
            e.paytax(10000);

            

            Console.ReadLine();

        }
    }
}
