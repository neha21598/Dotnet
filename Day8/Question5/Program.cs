/* Q5. Create class Animal having virtual method speak returning string” I don’t know how to speak”.
Create a child class dog having overridden speak method returning string “Bhow BHow”.
Create a child class cat having overridden speak method returning string “mewo mewo”
Create a child class donkey does not have any method.
Create class showpoly having method call who’s job is to call speak method using reference of Animal. 
 * Create object of all child class and then call showpoly’s class call method and pass child class object.*/

using System;

namespace Day8_5
{
    public class Animal
    {
        public virtual string speak()
        {
            return "I don’t know how to speak";
        }
    }
    public class Dog : Animal
    {
        public override string speak()
        {
            return "Bhow BHow";

        }
    }

    public class Cat : Animal
    {
        public override string speak()
        {
            return "Meow Meow";

        }
    }
    public class Donkey : Animal
    {
    }


    public class showpoly
    {
        public static void perform(Animal a)
        {
            Console.WriteLine(a.speak());
        }
    }
    class program
    {
        public static void Main(string[] args)
        {

            showpoly s = new showpoly();
            showpoly.perform(new Cat());
            showpoly.perform(new Dog());

            Console.ReadLine();

           
        }
    }
}

