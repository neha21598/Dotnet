using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_5_Console
{
    class Program    {        public static void Cuber(int[] array)        {            for (int i = 0; i < array.Length; i++)            {                array[i] = (array[i]) * (array[i]) * (array[i]);            }            Console.WriteLine("The Modified array is:");            for (int i = 0; i < array.Length; i++)            {                Console.Write(array[i]+" ");            }        }        static void Main(string[] args)        {            Console.WriteLine("Enter Size of Array");            int size = int.Parse(Console.ReadLine());            int[] arr = new int[size];            Console.WriteLine("Enter The Elements of an Array:");            for (int i = 0; i < size; i++)            {                arr[i] = int.Parse(Console.ReadLine());            }            Cuber(arr);            Console.ReadLine();        }    }}

 