using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_6_console
{
    class Program    {        static void Main(string[] args)        {            int sum = 0;            Console.WriteLine("Enter Size of Array");            int size=int.Parse(Console.ReadLine());            int[] arr = new int[size];            Console.WriteLine("Enter The Elements of an Array:");            for (int i = 0; i < size; i++)            {                arr[i] = int.Parse(Console.ReadLine());            }            for (int i = 0; i < size; i++)            {                sum = sum + arr[i];            }            int average = sum / (size);            Console.WriteLine("The Average of Each Element of Array is :{0}",average);                                    Console.ReadLine();        }    }}

