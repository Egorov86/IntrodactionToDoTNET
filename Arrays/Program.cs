//#define ARRAYS_1
//#define ARRAYS_2
#define JAGGED_ARRAYS
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//1) Single dimensional;
//2) Multi dimensional;
//3) Jagged;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if ARRAYS_1
            //int[] arr = { 3, 5, 8, 13, 21 };
            //int[] arr = new int[] { 3, 5, 8, 13, 21 };
            Console.Write("Введите кол-во элементов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            //Заполняем массив случ числами
            Random rand = new Random(0); // 0 - seed
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(50, 100);
            }


            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }

            //Среднее-арифметическое
            double sred = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sred += arr[i];
            }
            sred /= arr.Length;
            Console.WriteLine();
            Console.WriteLine("Среднее-арифметическое равно: " + sred);

            //Минимальное и максимальное
            double max = arr[0];
            double min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Минимальое равно: " + min);
            Console.WriteLine();
            Console.WriteLine("Максимальое равно: " + max);
#endif

#if ARRAYS_2
            //int[,] i_arr_2 = new int[3, 4];
            int[,] i_arr_2 = new int[,]
            {
                { 3, 5, 8, 13},
                { 21, 34, 55, 89},
                { 144, 233, 377, 610}
            };
            //Console.WriteLine(new int[5].Rank);
            //Console.WriteLine(i_arr_2.Rank);
            //Console.WriteLine(new int[2,3,4].Rank);
            //Console.WriteLine(new int[2,3,4,5].Rank);
            Console.WriteLine($"Количество измерений массива: {i_arr_2.Rank}");
            Console.WriteLine($"Количество элементов в нулевом изм (кол строк): {i_arr_2.GetLength(0)}");
            Console.WriteLine($"Количество элементов в нулевом изм (кол столбов): {i_arr_2.GetLength(1)}");
            for (int i = 0; i < i_arr_2.GetLength(0); i++)
            {
                for (int j = 0; j < i_arr_2.GetLength(1); j++)
                {
                    Console.Write(i_arr_2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            /* Cast = преобразует многомерный массив в одномерный массив
            Console.WriteLine($"Сумма элементов массива: {i_arr_2.Cast<int>().Sum()}");
            Console.WriteLine($"Сред-ариф элементов массива: {i_arr_2.Cast<int>().Average()}");
            Console.WriteLine($"Минимальное массива: {i_arr_2.Cast<int>().Min()}");
            Console.WriteLine($"Максимальное массива: {i_arr_2.Cast<int>().Max()}"); */
            /*foreach (int i in i_arr_2)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();*/

            //Среднее-арифметическое
            double sred = 0;
            int count = 0;   // колич.элементов массива
            for (int i = 0; i < i_arr_2.GetLength(0); i++) 
            {
                for (int j = 0; j < i_arr_2.GetLength(1); j++)
                {
                    sred = i_arr_2[i, j];
                    count++;
                }
            }
            sred /= count;
            Console.WriteLine();
            Console.WriteLine("Среднее-арифметическое равно: " + sred);

            // Минимальное и Максимальное
            double max = i_arr_2[0, 0];
            double min = i_arr_2[0, 0];
            for (int i = 0; i < i_arr_2.GetLength(0); i++)
            {
                for (int j = 0; j < i_arr_2.GetLength(1); j++)
                {
                    if (i_arr_2[i, j] < min)
                    {
                        min = i_arr_2[i, j];
                    }
                    if (i_arr_2[i, j] > max)
                    {
                        max = i_arr_2[i, j];
                    }
                }
            }
            Console.WriteLine("Минимальное равно: " + min);
            Console.WriteLine("Максимальное равно: " + max);
#endif

#if JAGGED_ARRAYS
            int[][] j_arr = new int[][]
            {
                new int[]{ 0, 1, 1, 2},
                new int[]{ 3, 5, 8, 13, 21},
                new int[]{ 34, 55, 89},
                new int[]{ 144, 233, 377, 610},
            };
            for (int i = 0; i < j_arr.Length; i++)
            {
                for (int j = 0; j < j_arr[i].Length; j++)
                {
                    Console.Write(j_arr[i][j] + "\t");
                }
                Console.WriteLine();
            }
            double sred = 0;
            int sum = 0;
            int count = 0;
            int min = j_arr[0][0];
            int max = j_arr[0][0];
            /*
            for (int i = 0; i < j_arr.Length; i++)
            {
                sum +=j_arr[i].Sum();
                count +=j_arr[i].Length;
                if (j_arr[i][j] < min) min = j_arr[i].Min();
                if (j_arr[i][j] > max) max = j_arr[i].Max();
            }
             */
            for (int i = 0; i < j_arr.Length; i++)
            {
                for (int j = 0; j < j_arr[i].Length; j++)
                {
                    sum +=j_arr[i][j];
                    count++;
                    if (j_arr[i][j] < min)
                    {
                        min = j_arr[i][j];
                    }
                    if (j_arr[i][j] > max)
                    {
                        max = j_arr[i][j];
                    }
                }
            }
            sred = (double)sum/count;
            //Console.WriteLine($"Сумма элементов массива: {j_arr.Cast<int>().Sum()}"); НЕ РАБОТАЕТ
            Console.WriteLine("Сумма: " + sum);
            Console.WriteLine("Среднее арифметическое: " + sred);
            Console.WriteLine("Минимальное: " + min);
            Console.WriteLine("Максимальное: " + max);

#endif
        }
    }
}
