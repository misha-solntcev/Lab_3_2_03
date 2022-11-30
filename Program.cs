using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*3. Составьте программу, которая выводит полную запись 
    десятичного числа 42?4?, в которой пропущены две 
    цифры (обозначены ?), если известно, что данное 
    число кратно 72. (Одно из таких чисел 42048). */

namespace Lab_3_2_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i =42000; i <= 42949; i++)
                if ((i % 100 / 10 == 4) && (i % 72 == 0))
                    Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
