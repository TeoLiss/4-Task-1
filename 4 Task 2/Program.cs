using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выведи матрицу из случайных чисел");
           
            Console.WriteLine("Введи число строк:");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введи число столбцов:");
            int j = int.Parse(Console.ReadLine());
            int[,] matrixOne;
            int[,] matrixTwo;
            matrixOne = new int[k, j];
            matrixTwo = new int[k, j];  
            Random rand = new Random();
            Console.WriteLine("Матрицы А \t\t\t\t Матрица В");
            Console.Write($"\n\n");
            for (int i = 0; i < k; i++)
            {
                for (int n = 0; n < j; n++)
                {
                    matrixOne[i, n] = rand.Next(0, 1000);
                    Console.Write($"{matrixOne[i, n]}\t");
                }
                Console.Write($"\t\t");
             for (int n = 0; n < k; n++)
             {
                    matrixTwo[i,n] = rand.Next(1, 1000);   
                    Console.Write($"{matrixTwo[i,n]}\t");
              }
                Console.WriteLine();
            }
            int[,] matrixSum;
            matrixSum = new int[k, j];
            Console.Write($"\n\n");
            Console.WriteLine("Матрица С (Сумма А и В)");
            Console.Write($"\n\n");
            for (int i = 0; i < k; i++)
            {
                for (int n = 0;n < j; n++)
                {
                    matrixSum[i, n] = matrixOne[i,n] + matrixTwo[i,n];
                    Console.Write($"{matrixSum[i, n]}\t");
                }
                Console.Write($"\t\t");
                Console.WriteLine();    
            }
            Console.ReadKey();  
        }
        }
    }


