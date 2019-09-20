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
            int number;

            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Введите число!");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Введите число!");
                    return TryParseNums();
                }
               
            }
            return number;

            //while (!int.TryParse(Console.ReadLine(), out i))
            //{
            //    Console.WriteLine("Введите число!");
            //}
            //return i;
        }

        static void Factorial()
        {
            Console.WriteLine("Диапазон вычисления Факториала: 0 - 170!");
            Console.Write("Введите число: ");
            
            double number = TryParseNums();

            double result = GetFactorial(number);

            if (result > 0)
            {
                Console.WriteLine($"Факториал числа {number} равен {result}");
            }
            else
            {
                Console.WriteLine("Выход за пределы диапазона!");
            }

        }

        static double GetFactorial(double number)
        {
            if (number >= 0 && number <= 170)
            {
                if (number == 1 || number == 0)
                {
                    return 1;
                }
                else
                {
                    return number * GetFactorial(number - 1);
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

            if (AmountNumbers > 0)
            {
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
            else
            {
                Console.WriteLine("Введите чило больше НУЛЯ!");
            }

            
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
