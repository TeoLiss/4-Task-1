using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выведи матрицу из случайных чисел:");
            Console.WriteLine("Введи число строк:");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введи число столбцов:");
            int j = int.Parse(Console.ReadLine());
            int[,] matrix;
            matrix = new int[k, j];
            int sum = 0;

            Random r = new Random();

            for (int i = 0; i < k; i++)
            {
                
                for (int n = 0; n < j; n++)
                {
                    matrix[i,n] = r.Next(0,999);
                    Console.Write($"{matrix[i,n]} ");

                    sum += matrix[i, n];
                }
                Console.WriteLine();
                
            }
            Console.WriteLine($"Сумма элементов = {sum} ");
            Console.ReadKey();

        }
    }
}
