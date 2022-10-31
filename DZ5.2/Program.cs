using System;

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
                    array[i] = new Random().Next(-100,101);
                }
                return array;
            }

            void printArray(int[] array)
            {
                for(int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
            }

            //Программа считает сумму элементов, стоящих на нечетных позициях
            //(для нас 1 3 5 элемент, а для машины - 0 2 4)
            
            int sumOddPositions(int[] array)
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i = i + 2)
                {
                    sum = sum + array[i];
                }
                return sum;
            }

            Console.Write("Введите размерность массива ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] numbers = createArray(arraySize);
            printArray(numbers);
            Console.WriteLine($"Сумма элементов на нечётных позициях : {sumOddPositions(numbers)}");
        }
    }
}