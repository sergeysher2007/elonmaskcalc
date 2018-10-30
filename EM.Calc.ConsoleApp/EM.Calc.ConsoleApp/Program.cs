using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace EM.Calc.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Core.Calc();

            int[] nums = new int[3];
            Console.WriteLine("Введите через Enter 3 числа a,b,c:");
            for (int i = 0; i < nums.Length; i++)
            {
                  nums[i] = Int32.Parse(Console.ReadLine());
            }
            var result1 = calc.Sum(nums);
            var result2 = calc.Raz(nums);
            var result3 = calc.Stp(nums);
            Console.WriteLine("Операция сложения a+b+c: " + result1);
            Console.WriteLine("Операция вычитания a-b-c: " + result2);
            Console.WriteLine("Операция возведения в степень a^b^c: " + result3);
            Console.ReadLine();
        }
    }
}
