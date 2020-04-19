using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{
    delegate int Operation(int a, int b,int c);

    delegate int Oper(int x, int y);
    public delegate int Number();
    public delegate int Srednee( Number[] arrayX);

    class Program
    {
        public static int Randomizer()
        {
            Random rand = new Random();
            return rand.Next(1, 50);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
           
            Operation operation = delegate (int a, int b,int c)
            {
                return (a + b + c) / 3;
            };
            int result = operation(4, 5, 9);
            Console.WriteLine("Среднее арифметическое:");
            Console.WriteLine(result);     

          

            Console.WriteLine("Задание 2");
         
            Oper Add = (x, y) => x + y;
            Oper Sub = (x, y) => x - y;
            Oper Mul = (x, y) => x * y;
            Oper Div = (x, y) => x == 0 ? 0 : x / y;
           


            int k;
            do
            {
                Console.WriteLine("МЕНЮ\n" +
               "1.Сложение\n" +
               "2.Вычитание\n" +
               "3.Умножение\n" +
               "4.Деление\n" +
               "5.Выход\n");
                k = Convert.ToInt32(Console.ReadLine());

                switch (k)
                {

                    case 1:
                        Console.WriteLine("Сумма: ");
                        Console.WriteLine(Add(10, 5));
                        break;
                    case 2:
                        Console.WriteLine("Разность: ");
                        Console.WriteLine(Sub(10, 5));
                        break;
                    case 3:
                        Console.WriteLine("Произведение: ");
                        Console.WriteLine(Mul(10, 5));
                        break;
                    case 4:
                        Console.WriteLine("Частное: ");
                        Console.WriteLine(Div(10, 5));
                       
                        break;
                    case 5:
                        Console.WriteLine("Выход из программы!");

                        break;

                    default:
                        break;


                }
            } while (k != 5);
           
            Console.WriteLine("Задание 3");
           
            Number[] num = new Number[6];
            Console.WriteLine("Массив:");
            Random rand = new Random();
            for (int i = 0; i < num.Length; i++)
            {

                num[i] = Randomizer;

                Console.Write(" " + num[i].Invoke() + " ");
            }
            Console.WriteLine();

            Srednee srednee = delegate (Number[] arrayX)
            {
                int sum = 0;
                for (int i = 0; i < arrayX.Length; i++)
                {
                  
                    sum += arrayX[i]();
                }
                return ((sum) / (arrayX.Length));
            };
            Console.WriteLine("Среднее значение:");
            Console.WriteLine(srednee(num));










            Console.Read();

        }
    }
}
