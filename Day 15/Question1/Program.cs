/* Create a class Student having member rollno, name, maths, sci, eng,total
Create 5 object and store in sorted list class and display detail name wise ascending order
 * */


using System;
using System.Collections.Generic;

namespace Day15_1
{
    class Student
    {
       public  int Rollno { get; set; }
       public int Maths { get; set; }
       public int Sci { get; set; }
       public int Eng { get; set; }

       public  Student(int rollno,int maths,int sci,int eng)
        {
           Rollno = rollno;
           Maths = maths;
           Sci = sci;
           Eng = eng;

        }

       public override string ToString()
       {
           return String.Format("ROll No is: {0} \n Subjects:\n Maths:{1} \n Science {2} \n English :{3}\n", Rollno, Maths,Sci,Eng);
       }

        static void Main(string[] args)
        {
            Student[] s = new Student[2];
            s[0] = new Student(1, 23, 65, 98);
            s[1] = new Student(2, 25, 69, 95);

            SortedList<String, Student> mylist = new SortedList<string, Student>();
            mylist.Add("Neha", s[0]);
            mylist.Add("Devendraa", s[1]);

        

            foreach (KeyValuePair<string, Student> x in mylist)
                Console.WriteLine(x);

            Console.ReadLine();
           

             
        }

        
    }
}
