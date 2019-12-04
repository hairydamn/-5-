using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ПРАКТИЧЕСКАЯ РАБОТА 5*/

            /*1. Напишите программу печати таблицы перевода расстояний из дюймов в сантиметры для значений длин от 1 до 20 дюймов. 1 дюйм = 2,54 см. */

            /*for (double i = 1; i < 21; i++)
            {
                Console.WriteLine(i +" "+i*2.54);
            }
            Console.ReadKey();*/


            /*2. Напишите программу вывода всех четных чисел от 2 до 100 включительно.*/

            /*for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(i+1);
            }
            Console.ReadKey();*/

            /*3. Напишите программу, определяющую сумму всех нечетных чисел от 1 до 99.*/
            /*int sum = 0;
            for (int i = 0; i <100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("Число: "+i + " Сумма: " + sum);
                    sum += i;
                }
            }
            
            Console.WriteLine();
            Console.WriteLine(sum);

            Console.ReadKey();*/


            /*4. Составьте программу получения в порядке убывания всех делителей данного числа.  */


            /*Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите до какого числа будет идти проверка делителей");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = b; i > 0; i--)
            {
                if (a % i == 0)
                    Console.WriteLine(i);
            }
            Console.ReadKey();*/

            /*5.Составьте программу определения наибольшего общего делителя двух натуральных чисел*/

            /*Console.WriteLine("Введите 1 число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2 число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите делитель");
            int c = Convert.ToInt32(Console.ReadLine());
            for (int i = c; i > 0; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
                
            }
            Console.ReadKey();*/


            /*6.Найти наибольшее и наименьшее значение функции y=3x2+x-4, если на заданном интервале [a,b] Х изменяется с шагом 0,1.*/

            /*Console.WriteLine("Vvedite number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vvedite number 2");
            int b = Convert.ToInt32(Console.ReadLine());
            double h = 0.1;
            double max = 0;
            double min = 0;
            double y = 0;
            for (double i = a; i < b; i+=h)
            {
                y=3 * Math.Pow(i, 2) + i - 4;
                if (max < y) { max=y;}
                if (min > y) { min = y; }
                Console.WriteLine(y);
                
            }
            Console.WriteLine("Max:");
            Console.WriteLine(max);
            Console.WriteLine("Min:");
            Console.WriteLine(min);
            Console.ReadKey();*/


            /*7.Вычислите сумму квадратов N четных натуральных чисел.*/

            /*int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 2; i <= a * 2; i += 2)
            {
                
                sum += i ^ 2;
                Console.WriteLine("число:" + i + " Sum:" + sum);
            }
            Console.WriteLine();
            Console.WriteLine("Sum:");
            Console.WriteLine(sum);
            Console.ReadKey();*/


            /*8. Вычислить:  1+2+4+8+…+210 */
            /*int sum = 0;
            for (int i = 0; i <= 210; i += 1)
            {
                if (i == 1 || i % 2 == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();*/


            /*9. Вычислить:  (1+2)*(1+2+3)*…*(1+2+…+10)  */

            /*int sum = 0;
            double pr = 1;
            for (int l = 1; l < 10; l++)
            {
                sum = 0;
                for (int i = 1; i <= l + 1; i++)
                {
                    sum += i;
                }
                Console.WriteLine(sum);
                pr *= sum;
            }
            
            Console.WriteLine(pr);
            Console.ReadKey();*/


            /*10. В бригаде, работающей на уборке сена, имеется N косилок.
            Первая из них работала M часов, а каждая следующая на 10 минут больше, чем предыдущая.
            Сколько часов проработала вся бригада? */


            /*double sumh=0;
            int a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            double bb = (b * 60) - 10;
            for (int i = 1; i <= a; i++)
            {
                bb += 10;
                sumh += bb;
            }
            Console.WriteLine(sumh + " Минут или ");
            Console.WriteLine(Math.Round(sumh/60,1) + " Часов");
            Console.ReadKey();*/
        }
    }
}
