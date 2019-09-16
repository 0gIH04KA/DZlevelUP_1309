using System;
using System.Collections.Specialized;
using System.Text;

namespace DZlevelUP_1309
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial();





            Console.ReadKey();


        }

        static void Factorial()
        {
            Console.Write("Введите число:");
            string s = Console.ReadLine();

            double nums;


            while (!double.TryParse(s, out nums))
            {
                Console.WriteLine("Введите число!");
                s = Console.ReadLine();
            }

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
                if (x == 0)
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

        




    }
}
