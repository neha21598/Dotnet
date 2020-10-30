/*Q2.Create a class person having virtual method
 public virtual string  dojob(){ “doing job”}
create three child class programmer,dancer and singer.
In programmer class override virtual method
public override string  dojob(){ “doing coding”}
programmer class also has method public void testing{  “I am testing code also” }
In  singer class override virtual method
public override string  dojob(){ “singing”}
in dancer class no method available.
Create array of person class and call dojob() method.
Also call testing method of programmer class in a loop
*/

using System;

namespace Day9_2
{
    public class Person
    {
        public virtual string  dojob()
        { 
            return "doing job";
        }
       
    }

    public class Programmer : Person
    {
        public override string  dojob()
        { 
            return "doing coding";
        }

        public void testing()
        {  
            Console.WriteLine("I am testing code also");
        }
    }

    public class Dancer : Person
    {

    }

    public class Singer : Person
    {
        public override string  dojob()
        { 
            return "singing"; 
        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            Person[] p = new Person[3]{new Programmer(),new Singer(),new Dancer()};
            for (int i = 0; i<p.Length;i++ )
            {
                Console.WriteLine(p[i].dojob());
                if (p[i] is Programmer)
                {
                    Programmer prog = (Programmer)p[i];
                    prog.testing();
                }
            }
            Console.ReadLine();
        }
    }
}
