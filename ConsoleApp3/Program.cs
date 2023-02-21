using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1
            //int[] numbers = { 3, 7, 2, 1, 8, 4, 5, 9, 6 };
            //int maxNumber = numbers[0];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxNumber)
            //    {
            //        maxNumber = numbers[i];
            //    }
            //}

            //Console.WriteLine("Максимальное значение: " + maxNumber);

            //Задача 2
            //int[] numbers = { 3, 7, 2, 1, 8, 4, 5, 9, 6 };
            //int maxNumber = numbers[0];
            //int minNumber = numbers[0];
            //int maxIndex = 0;
            //int minIndex = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxNumber)
            //    {
            //        maxNumber = numbers[i];
            //        maxIndex = i;
            //    }
            //    if (numbers[i] < minNumber)
            //    {
            //        minNumber = numbers[i];
            //        minIndex = i;
            //    }
            //}

            //Console.WriteLine("Максимальное значение: " + maxNumber);
            //Console.WriteLine("Индекс максимального значения: " + maxIndex);
            //Console.WriteLine("Минимальное значение: " + minNumber);
            //Console.WriteLine("Индекс минимального значения: " + minIndex);

            //// Обмен максимального и минимального значений
            //int temp = numbers[maxIndex];
            //numbers[maxIndex] = numbers[minIndex];
            //numbers[minIndex] = temp;

            //Console.WriteLine("Массив после замены максимального и минимального значений:");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}

            //Задача 3
            //int[] numbers = { 3, 7, 2, 1, 8, 4, 5, 9, 6 };
            //int maxNumber = numbers[0];
            //int minNumber = numbers[0];
            //int maxIndex = 0;
            //int minIndex = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxNumber)
            //    {
            //        maxNumber = numbers[i];
            //        maxIndex = i;
            //    }
            //    if (numbers[i] < minNumber)
            //    {
            //        minNumber = numbers[i];
            //        minIndex = i;
            //    }
            //}

            //Console.WriteLine("Максимальное значение: " + maxNumber);
            //Console.WriteLine("Минимальное значение: " + minNumber);

            //int startIndex = Math.Min(maxIndex, minIndex) + 1;
            //int endIndex = Math.Max(maxIndex, minIndex) - 1;
            //int count = 0;

            //for (int i = startIndex; i <= endIndex; i++)
            //{
            //    count++;
            //}

            //Console.WriteLine("Количество элементов между максимальным и минимальным значениями: " + count);

            //Задача 4
            int[] numbers = { 3, 7, 2, 1, 8, 4, 5, 9, 6 };
            int maxNumber = numbers[0];
            int minNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }

            Console.WriteLine("Максимальное значение: " + maxNumber);
            Console.WriteLine("Минимальное значение: " + minNumber);

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] += Math.Abs(maxNumber) + Math.Abs(minNumber);
            }

            Console.WriteLine("Измененный массив: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
