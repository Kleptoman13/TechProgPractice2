using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            /*8. Заполнить массив:
                а) десятью первыми членами арифметической прогрессии(первый член прогрессии — а, её разность — р);
                б) двадцатью первыми членами геометрической прогрессии(первый член прогрессии — а, её знаменатель — z);
                в) двенадцатью первыми членами последовательности Фибоначчи(последовательности, 
                в которой первые два члена равны 1, а каждый следующий равен сумме двух предыдущих).*/

            Task8_1();
            Task8_2();
            Task8_3();

            /*45. Задана последовательность из N вещественных чисел. Определить, сколько среди них чисел, 
             * меньших К, равных К и больших К.*/

            Task45();

            /*106. Удалить последний элемент массива вещественных чисел.*/

            Task106();

            /*192. Дан целочисленный массив А[n], среди элементов есть одинаковые.Создать массив из различных элементов А[n].*/

            Task192();

            /*199. Известно, что в массиве имеются элементы, большие 65 Определить:
            а) номер первого;
            б) номер последнего.
            В обеих задачах условную инструкцию не использовать.*/

            Task199();

            Console.ReadKey();
        }

        static void Task8_1()
        {
            Console.WriteLine("Задание 8 (a)\n ");

            const int n = 10;
            int[] arr = new int[n];
            int a = 0;
            int p = 0;

            Console.WriteLine("Введите первый член арифметической прогресии");

            int k = 0;
            while (k == 0)
            {
                (int res1, int res2) = CheckFormatTask8();
                k = res1;
                a = res2;
            }
            
            Console.WriteLine("Введите разность арифметической прогресии");

            k = 0;
            while (k == 0)
            {
                (int res1, int res2) = CheckFormatTask8();
                k = res1;
                p = res2;
            }


            int sum = a;
            arr[0] = a;

            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = sum + p;
                sum += p;
            }
   
            Console.WriteLine("Арифметическая прогрессия: ");
            PrintArray(arr);


        }

        static void Task8_2()
        {
            Console.WriteLine("Задание 8 (б)\n ");

            const int n = 20;
            int[] arr = new int[n];
            int a = 0;
            int z = 0;

            Console.WriteLine("Введите первый член геометрической прогресии");

            int k = 0;
            while (k == 0)
            {
                (int res1, int res2) = CheckFormatTask8();
                k = res1;
                a = res2;
            }
            Console.WriteLine(a);

            Console.WriteLine("Введите знаменатель геометрической прогресии");

            k = 0;
            while (k == 0)
            {
                (int res1, int res2) = CheckFormatTask8();
                k = res1;
                z = res2;
            }

            Console.WriteLine(z);

            int mult = a;
            arr[0] = a;

            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = mult * (int)Math.Pow(z, i + 1 - 1);
            };

            Console.WriteLine("Геометрическая прогрессия: ");
            PrintArray(arr);
        }

        static void Task8_3()
        {
            Console.WriteLine("Задание 8 (в)\n ");

            const int n = 12;
            int[] arr = new int[n];
            int a = 1;

            arr[0] = a;
            arr[1] = a;

            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = arr[i - 2] + arr[i - 1];
            };

            Console.WriteLine("Последовательность Фибоначчи: ");
            PrintArray(arr);
        }

        static void PrintArray(int[] arr)
        {
            Console.WriteLine(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }

        static void PrintArray(float[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }

        static (int, int) CheckFormatTask8()
        {
            int n;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                return (1, n);
            }
            catch
            {
                Console.WriteLine("Неправильный формат");
                return (0, 0);
            }
        }

        static void Task45()
        {
            Console.WriteLine("Задание 45\n ");

            const int n = 10;
            float[] arr = new float[n];
            Random r = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (float)(r.NextDouble() * 20 - 10);
            }

            PrintArray(arr);

            float k = 0;
            int m = 0;

            Console.WriteLine("Введите К: ");

            while (m == 0)
            {
                try
                {
                    k = Convert.ToSingle(Console.ReadLine());
                    m = 1;
                }
                catch
                {
                    Console.WriteLine("Неправильный формат");
                    m = 0;
                }
            }

            int countOfLess = 0;
            int countOfEquel = 0;
            int countOfMore = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (k < arr[i])
                {
                    countOfMore++;
                }
                else if (k == arr[i])
                {
                    countOfEquel++;
                }
                else
                {
                    countOfLess++;
                }
            }

            Console.WriteLine("Количество чисел менше К:" + countOfLess + "\nКоличество чисел равных К:" + countOfEquel + "\nКоличество чисел больше К:" + countOfMore);

        }

        static void Task106()
        {
            Console.WriteLine("Задание 106\n ");

            const int n = 10;
            float[] arr = new float[n];
            Random r = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (float)(r.NextDouble() * 20 - 10);
            }

            Console.WriteLine("Исходный массив");
            PrintArray(arr);



            float[] newArr = new float[n - 1];

            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            Console.WriteLine("Массив с удаленным последним числом");
            PrintArray(newArr);

        }

        static void Task192()
        {
            Console.WriteLine("Задание 192\n ");

            const int n = 10;
            int[] arr = new int[n];
            Random r = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(1, 20);
            }

            Console.WriteLine("Исходный массив: ");
            PrintArray(arr);

            HashSet<int> uniqueArr = new HashSet<int>();
            List<int> result = new List<int>();

            foreach (int item in arr)
            {
                if (uniqueArr.Add(item))
                {
                    result.Add(item);
                }
            }

            int[] newArr = result.ToArray();

            Console.WriteLine("Отфильтрованый массив: ");
            PrintArray(newArr);
        }

        static void Task199()
        {
            Console.WriteLine("Задание 199\n ");

            const int n = 10;
            int[] arr = new int[n];
            Random r = new Random();

            int number = 65;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(50, 70);
            }

            PrintArray(arr);

            int lastNumber = 0;
            int firstNumber = 0;

            int k = 0;

            while (firstNumber < number)
            {
                firstNumber = arr[k];
                k++;
            }

            int m = arr.Length;

            while (lastNumber < number)
            {
                lastNumber = arr[m - 1];
                m--;
            }

            Console.WriteLine("First number: " + firstNumber + "\nLast number: " + lastNumber);
        }

    }
}
