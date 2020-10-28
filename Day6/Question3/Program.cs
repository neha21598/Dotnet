/* Accept data in 3*3matrix and print row wise sum*/

using System;

namespace Day6_3_console
{
    class Row_Sum
    {
        static void Main(string[] args)
        {
          
           
            int[,] matrix = new int[3, 3];
            int[] row_sum = new int[10];

           
            Console.WriteLine("Enter elemnts in matrix:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3 ; j++)
                {
                    matrix[i,j] = int.Parse(Console.ReadLine());
                   

                }
            }

            Console.WriteLine("*********************The Matrix is:****************");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.Write("\n");
            }


            Console.WriteLine("\n *************Rowwise Sum****************:");
            for (int i = 0; i < 3; i++)
            {
                row_sum[i] = 0;
                for (int j = 0; j < 3; j++)
                {
                    row_sum[i] = row_sum[i] + matrix[i, j];

                }
                Console.WriteLine("Sum of row {0} of Matrix is:{1} ",i,row_sum[i]);
            }
            

           
            Console.ReadLine();
            
        }
    }
}
