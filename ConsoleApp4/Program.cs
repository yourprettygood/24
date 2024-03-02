using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Определить, имеется ли в массиве случайных чисел элемент,
            //значение которого равно значению первого элемента одномерного массива.
            //Если такой элемент имеется, вывести на экран его порядковый номер. Массив состоит из шести элементов.

            /*
            int[] omas = new int [6];
            Random rnd = new Random();
            for(int i = 0; i < omas.Length;i++)
            {
                omas[i] = rnd.Next(1,100);
            }
            Console.WriteLine("Массив случайных чисел:");
            foreach (byte number in omas)
            {
                Console.WriteLine(number);
            }
            int first = omas[0];
            for(int i = 1; i < 6; i++)
            {
                if (omas[i] == first)
                {
                    Console.WriteLine($"Число, совпадающее с первым числом: {omas[i]}");
                }
            }
            */

            //Задача 2. Дан одномерный массив. Вывести:

            //а) все неотрицательные элементы;

            //б) все элементы, не превышающие число 100;

            //в) все четные элементы.

            /*
            int[] omas = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < omas.Length; i++)
            {
                omas[i] = rnd.Next(-1000, 1000);
                if (omas[i] %2== 0)
                {
                    Console.WriteLine($"Число {omas[i]} - четное");
                }

                if (omas[i] < 0)
                {
                    Console.WriteLine($"{omas[i]} - отрицательное число");
                }

                if (omas[i] < 100)
                {
                    Console.WriteLine($"Число {omas[i]} - меньше 100");
                }
            }
            */

            //Задача 3.Заполнить одномерный массив без использования клавиатуры следующими значениями:
            //5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2.Подсчитать количество отрицательных элементов.

            /*
            int[] omas = { 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2 };
            int negativeCount = 0;
            foreach (int numb in omas)
            {
                if(numb < 0)
                {
                    negativeCount++;
                }
            }
            Console.WriteLine($"Число отрицательных чисел: {negativeCount}");
            */

            //Задача 4. Составьте программу вычисления среднего арифметического элементов с нечетными номерами.
            /*
            int[] omas = new int[10];
            Random rnd = new Random();
            int quantity = 0;
            int summ = 0;
            for (int i = 0; i < omas.Length; i++)
            {
                omas[i] = rnd.Next(-1000, 1000);
                if (omas[i] % 2 == 0)
                {
                    Console.WriteLine($"Число {omas[i]} - четное");
                }
                else
                {
                    Console.WriteLine($"Число {omas[i]} - нечетное");
                    summ += omas[i];
                    quantity++;                   
                }
            }
            Console.WriteLine($"Среднее арифметическое нечетных чисел: {summ / quantity}");
            */

            //Задача 5. Составьте программу увеличения всех элементов массива в 5 раз.

            int[] omas = new int[5];
            Random rnd = new Random();
            for (int i = 0; i < omas.Length; i++)
            {
                omas[i] = rnd.Next(-100, 100);
                Console.WriteLine($"Число из массива - {omas[i]}\tЭто же число увеличенное в 5 раз - {omas[i]*5}");
            }





            Console.ReadLine();

        }
    }
}
