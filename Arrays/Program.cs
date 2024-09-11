//#define ARRAYS_1
//#define ARRAYS_2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Random rand = new Random(0);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(50, 100);
            }


            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            } 
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
            Console.WriteLine($"Количество элементов в нулевом изм (кол строк): {i_arr_2.GetLength(1)}");
            for (int i = 0; i < i_arr_2.GetLength(0); i++)
            {
                for (int j = 0; j < i_arr_2.GetLength(1); j++)
                {
                    Console.Write(i_arr_2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            foreach (int i in i_arr_2)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine(); 
#endif

        }
    }
}
