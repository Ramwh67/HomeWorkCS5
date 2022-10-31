using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {
            void printArray(double[] array)
            {
                for(int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{Math.Round(array[i], 2)} ");
                }
                Console.WriteLine();
            }

            double[] createArray(int size)
            {
                double[] array = new double[size];
                for (int i=0; i<size; i++)
                {
                    array[i] = new Random().NextDouble() * 10; //Диапозон значений от 0 до 10
                }
                return array;
            }

            double findMaxElement(double[] array)
            {
                double maxElement = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > maxElement) maxElement = array[i];
                }
                return maxElement;
            }

            double findMinElement(double[] array)
            {
                double minElement = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < minElement) minElement = array[i];
                }
                return minElement;
            }
             
            Console.Write("Введите размерность массива ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            double[] numbers = createArray(arraySize);
            printArray(numbers);
            Console.WriteLine($"Разница между максимальным и минимальным элементом =: {Math.Round(findMaxElement(numbers) - findMinElement(numbers), 2)}");
        }
    }
}