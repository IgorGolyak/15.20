using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cezst
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4.104
            Console.WriteLine("Введите день недельки");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    {
                        Console.WriteLine("Пнидельник");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Вторник");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Среда");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Четверг");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Пятница");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Суббота");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Воскресенье");
                        break;
                    }



                default:
                    {
                        Console.WriteLine("Ошибка данных");
                        break;
                    }


            }
            Console.ReadKey();
        }
    }
}
