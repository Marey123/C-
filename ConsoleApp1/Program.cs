using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       public static void First()
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Большее число = {0}", a);

            }
            else
            {
                Console.WriteLine("Большее число = {0}", b);
            }


            Console.ReadLine();
           
    }
        public static void Second()
        {
            Console.WriteLine("Введите первое гав или мяу");
            string c = Console.ReadLine();
            string n = "мяу";
            string f = "гав";
           if(c == n)
            {
                Console.WriteLine("Покормите кота!");
            }
            if(c==f)
            {
                Console.WriteLine("Покормите пса!");
            }
            Console.ReadLine();
        }
        public static void Third()
        {
            Console.WriteLine("Введите номер месяца");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a == 1&&a==2&&a==12)
            {
                Console.WriteLine("Зима");
            }
         
           else if (2<a&&a<6)
            {
                Console.WriteLine("Весна");
            }
          else  if (5 < a && a < 9)
            {
                Console.WriteLine("Лето");
            }
          else  if (8 < a && a < 12)
            {
                Console.WriteLine("Осень");
            }
            else
            {
                Console.WriteLine("На этой планете такого месяца нет ");
            }

            Console.ReadLine();


        }

        public static void Forth() {
           

            Console.WriteLine("Введите 1 или 0");
            int condition = Convert.ToInt32(Console.ReadLine());

            if (condition == 0)
            {
                Console.WriteLine("Плохо");
            }
            else if(condition == 1)
            {
                Console.WriteLine("Хорошо");
               
            }
            Console.ReadLine();
        }
        public static void Fifth()
        {
            Console.WriteLine("Введите номер дня от 1 до 7");
            int g = Convert.ToInt32(Console.ReadLine());
            if (g == 1)
            {
                Console.WriteLine("Понедельник");
            }
            else if (g == 2)
            {
                Console.WriteLine("Вторник");
            }
            else if (g == 3)
            {
                Console.WriteLine("Среда");
            }
            else if (g == 4)
            {
                Console.WriteLine("Четверг");
            }
            else if (g == 5)
            {
                Console.WriteLine("Пятница");
            }
            else if (g == 6)
            {
                Console.WriteLine("Суббота");
            }
            else if (g == 7)
            {
                Console.WriteLine("Воскресенье");
            }
            Console.ReadLine();
        }

        public static void Six()
        {
            Console.WriteLine("Введите кол-во км");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите время простоя");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum;
            int sum2;
            if(a<= 5)
            {
                sum = 20;
            }
            else
            {
                sum = 20 + (3 * (a - 5));
            }
            sum2 = sum + b;
            Console.WriteLine("Общая сумма = {0}", sum2);
            Console.ReadLine();

        }
        public static void Seven()
        {
            Console.WriteLine("Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());
            var result = true;

            if (a > 1)
            {
                for (var i = 2u; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = true;
            }

            Console.WriteLine(result);
            Console.ReadLine();

        }
        public static void Eight()
        {
            var rand = new Random();
            Console.WriteLine("Сделайте вашу ставку!");
            int a = Convert.ToInt32(Console.ReadLine());
          int b = rand.Next(1, 12);
            Console.WriteLine("На кубике выпало:");
            Console.WriteLine(b);
            if (0<b&&b<6)
            {
                a = 0;
                Console.WriteLine("Вы проиграли");
            }
           else if(5<b&&b<9)
            {
                Console.WriteLine("Вы получаете ставку обратно:{0}",a);
            }
           else if(8<b&&b<12)
            {
                Console.WriteLine("Вы получаете двойную ставку:{0}",a*2);
            }
           else if(b ==12)
            {
                Console.WriteLine("Вы выйграли джекпот:{0}", a * 10);
            }
            Console.ReadLine();
        }

        public static void Nine()
        { double k;
            Console.WriteLine("Введите первую букву валюты ($-доллар, е-евро, г-гривна) ");
            string a = Console.ReadLine();
           
            Console.WriteLine( "Введите сумму ");
            int b = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите первую букву  валюты ($-доллар, е-евро, г-гривна) ");
            string c = Console.ReadLine();
          
            if ((a == "$") && (c == "$"))
            {
                Console.WriteLine("Долларов {0}",b);
                
            }
            else
            {
                if ((a == "e") && (c == "$"))
                {
                    k = b * 1.11;
                    Console.WriteLine("Долларов {0}", k);
                }
                else
                {
                    if ((a == "$") && (c == "е"))
                    {
                        k = b / 1.11;
                        Console.WriteLine(k);
                    }
                    else
                    {
                        if ((a == "е") && (c == "г"))
                        {
                            k = b * 26.23;
                            Console.WriteLine("Гривен:{0}", k);
                        }
                        else
                        {
                            if ((a == "$") && (c == "г"))
                            {
                                k = b * 23.72;
                                Console.WriteLine("Гривен:{0}", k);
                            }
                            else
                            {
                                if ((a == "г") && (c == "е"))
                                {
                                    k = b / 26.23;
                                    Console.WriteLine("Евро:{0}", k);
                                }
                                else
                                {
                                    if ((a == "г") && (c == "$"))
                                    {
                                        k = b / 23.72;
                                        Console.WriteLine("Долларов:{0}", k);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.ReadLine();
        }
        public static void Ten()
        {
            Console.WriteLine("Введите число");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 20; i++)
            {
                int r = N * i;
                Console.WriteLine(r);
            }

            Console.ReadLine();
        }
        public static void Eleven()
        {
            var rand = new Random();
            Console.WriteLine("Программа загадывает число..");
            int b = rand.Next(1, 146);
            Console.WriteLine("Введите свой ответ");
            int a = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (a < b)
                {
                    Console.WriteLine("Неверно!Это число больше!");
                    Console.WriteLine("Введите свой ответ");
                     a = Convert.ToInt32(Console.ReadLine());
                }
                else if (a > b)
                {
                    Console.WriteLine("Неверно!Это число меньше!");
                    Console.WriteLine("Введите свой ответ");
                    a = Convert.ToInt32(Console.ReadLine());
                }
            } while (a != b);
            Console.WriteLine("Вы угадали!");
            Console.ReadLine();
        }
        public static void Twelve()
        {
            Console.WriteLine("Введите число ");
            int N = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i< N; i++)
            {
                int r = i*i;
                 

                Console.WriteLine(r);
            }
            Console.ReadLine();
        }
        public static void Fourteen()
        {

            var rand = new Random();
            int sum = 0;
            for (int i = 1; i < 6; i++)
            {
                


                int N = rand.Next();
                
                Console.WriteLine(N);
                sum = sum + N;
                
            }
            Console.WriteLine("Среднее арифметическое:");
            Console.WriteLine(sum/2);
            Console.ReadLine();
        }
        public static void Thirteen()
        {
          
            int sum = 0;
            for (int i = 1; i < 6; i++)
            {


                Console.WriteLine("Введите число ");
                int N = Convert.ToInt32(Console.ReadLine());

                
                sum = sum + N;

            }
            Console.WriteLine("Среднее арифметическое:");
            Console.WriteLine(sum / 2);
            Console.ReadLine();
        }
        public static void Fifteen()
        {
            int x;
            for(int i = 0; i < 17; i++)
            {
                x = 32 - (i * 2);
                Console.WriteLine("Кролики:{0}",i);
                Console.WriteLine( "Гуси:{0}", x);
            }
            Console.ReadLine();
        }
        public static void Sixteen()
        {
            string b;
            string a = "root";
           
            do
            {
                Console.WriteLine("Введите пароль! ");
                b = Console.ReadLine();
                if (b != a)
                {
                    Console.WriteLine("Вы ввели неверный пароль! ");
                    Console.WriteLine("Введите пароль! ");
                    b = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Вы ввели верный пароль! ");
                }
            } while (b != a);
            
            Console.ReadLine();
        }

            static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста,введите номер задания:");
            int h = Convert.ToInt32(Console.ReadLine());
           
            do
            {
                switch (h)
                {
                    case 1:
                        First();
                        break;
                    case 2:
                        Second();
                        break;
                    case 3:
                        Third();
                        break;
                    case 4:
                        Forth();
                        break;
                    case 5:
                        Fifth();
                        break;
                    case 6:
                       Six();
                        break;
                    case 7:
                        Seven();
                        break;
                    case 8:
                      Eight();
                        break;
                    case 9:
                        Nine();
                        break;
                    case 10:
                        Ten();
                        break;
                    case 11:
                        Eleven();
                        break;
                    case 12:
                        Twelve();
                        break;
                    case 13:
                        Thirteen();
                        break;
                    case 14:
                        Fourteen();
                        break;
                    case 15:
                        Fifteen();
                        break;
                    case 16:
                        Sixteen();
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            } while (h > 0);

        }
    }
}