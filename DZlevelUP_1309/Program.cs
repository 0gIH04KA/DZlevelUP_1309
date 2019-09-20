using System;
using System.Collections.Specialized;
using System.Text;

namespace DZlevelUP_1309
{
    class Program
    {
        static void Main(string[] args)
        {
            Print();





            Console.ReadKey();
        }

        static int TryParseNums()
        {
            int i;
            while (!int.TryParse(Console.ReadLine(), out i))
            {
                Console.WriteLine("Введите число!");
            }
            return i;
        }

        static void Factorial()
        {
            Console.WriteLine("Диапазон вычисления Факториала: 0 - 170!");
            Console.Write("Введите число: ");
            
            double nums = TryParseNums();

            double res = GetFactorial(nums);

            if (res > 0)
            {
                Console.WriteLine($"Факториал числа {nums} равен {res}");
            }
            else
            {
                Console.WriteLine("Выход за пределы диапазона!");
            }

        }

        static double GetFactorial(double x)
        {
            if (x >= 0 && x <= 170)
            {
                if (x == 1 || x == 0)
                {
                    return 1;
                }
                else
                {
                    return x * GetFactorial(x - 1);
                }
            }
            else
            {
                return -1;
            }
        }

        static void ComparisonOfNumbers()
        {
            Console.WriteLine("Сколько чисел хотите сравнить?");

            int AmountNumbers = TryParseNums();
            int[] arrayNums = new int[AmountNumbers];

            for (int i = 0; i < arrayNums.Length; i++)
            {
                Console.Write("{0}-е число: ", i + 1);
                arrayNums[i] = TryParseNums();
            }

            int count = arrayNums.Length,
            number = arrayNums[arrayNums.Length - 1];

            Console.WriteLine("Min: " + GetFindingMinNumber(arrayNums, count, number));
            Console.WriteLine("Max: " + GetFindingMaxNumber(arrayNums, count, number));
        }

        static int GetFindingMinNumber(int[] mass, int count, int number) //
        {
            int min = number;
            if (count < 1)
            {
                return min;
            }

            if (min > mass[count - 1])
            {
                min = mass[count - 1];
            }

            GetFindingMinNumber(mass, count - 1, min);
            return GetFindingMinNumber(mass, count - 1, min); ;
        }

        static int GetFindingMaxNumber(int[] mass, int count, int number)
        {
            int max = number;
            if (count < 1)
            {
                return max;
            }

            if (max < mass[count - 1])
            {
                max = mass[count - 1];
            }

            GetFindingMaxNumber(mass, count - 1, max);
            return GetFindingMaxNumber(mass, count - 1, max); ;
        }

        static void CleaningMethod()
        {
            Console.WriteLine("Для продолжения нажмите любую кнопку (:");
            Console.ReadKey();
            Console.Clear();
        }

        static void Print()
        {
            Console.WriteLine("Первое задание\nВычисление факториала");
            Factorial();
            CleaningMethod();

            Console.WriteLine("Второе задание\nНахождение Min и Max чисел рекурсией");
            ComparisonOfNumbers();
            CleaningMethod();



        }
                       
    }
}
