﻿using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] createArray(int size)
            {
                int[] array = new int[size];
                for (int i=0; i<size; i++)
                {
                    array[i] = new Random().Next(100,1000);
                }
                return array;
            }
            
            int countEvenNumbers(int[] array)
            {
                int count = 0;
                for (int i=0; i<array.Length; i++)
                {
                    if (array[i] % 2 == 0) count++;
                }
                return count;
            }

            void printArray(int[] array)
            {
                for(int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
            }

            Console.Write("Введите размерность массива ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] numbers = createArray(arraySize);
            printArray(numbers);
            Console.WriteLine($"Количество чётных чисел в массиве =: {countEvenNumbers(numbers)}");
            

        }
    }
}