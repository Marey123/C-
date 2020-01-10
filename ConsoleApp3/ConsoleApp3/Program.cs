using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{


    struct Notebook
    {
        public string model;
        public int cost;
        public string proiz;
        public Notebook(string proiz, int cost, string model)
        {
            this.proiz = proiz;
            this.cost = cost;
            this.model = model;

        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Производитель: {proiz}  Цена: {cost}  Модель:{model}");
        }

    }
    struct Train
    {
        string destination;
        int number;
        DateTime departureTime;

        public Train(string destination, int number, DateTime departureTime)
        {
            this.departureTime = departureTime;
            this.destination = destination;
            this.number = number;
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public DateTime DepartureTime
        {
            get { return departureTime; }
            set { departureTime = value; }
        }
    }
    class MyClass
    {
        public string change;
    }

    struct MyStruct
    {
        public string change;

    }

    struct DR
    {
        public int today;
        public int day;
        public int year;
        public int thisyear;
        public int month;
        public int thismonth;
        public DR(int today, int day, int year, int thisyear, int month, int thismonth)
        {
            this.today = today;
            this.day = day;
            this.year = year;
            this.thisyear = thisyear;
            this.month = month;
            this.thismonth = thismonth;



        }
        public int JP()
        {
            Console.WriteLine("Введите дату своего следующего рождения:");
            Console.WriteLine("Год: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Месяц: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("День: ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сегодняшнюю дату:");
            Console.WriteLine("Год: ");
            thisyear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Месяц: ");
            thismonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("День: ");
            today = Convert.ToInt32(Console.ReadLine());


            int a = (14 - month) / 12;
            int y = year + 4800 - a;
            int m = month + 12 * a - 3;

            int jdn1 = day + (153 * m + 2) / 5 + 365 * y + y / 4 - y / 100 + y / 400 - 32045;


            int a1 = (14 - thismonth) / 12;
            int y1 = thisyear + 4800 - a1;
            int m1 = thismonth + 12 * a1 - 3;

            int jdn2 = today + (153 * m1 + 2) / 5 + 365 * y1 + y1 / 4 - y1 / 100 + y1 / 400 - 32045;

            return jdn1 - jdn2;

        }
      
       
        public void DisplayInfo()
        {
            Console.WriteLine($"До дня рождения { JP()} дней");
        }

    }

    static class Stroka
    {
       
        public enum Color
        {
            White = 1,
            Black,
            Green,
            Yellow,
            Red
        }

        public static void Print(Color k)
        {
            Console.WriteLine("Введите строку:");
         string   stroka = Console.ReadLine();
            Console.WriteLine("White = 1," +
                "Black = 2" +
                " Green = 3" +
                " Yellow = 4" +
                " Red = 5");
            Console.WriteLine("Введите номер цвета:");
          int  color = Convert.ToInt32(Console.ReadLine());


            switch (k)
            {
                case Color.White:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                case Color.Black:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                case Color.Green:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                case Color.Yellow:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                case Color.Red:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                default:
                    break;
            }
        }
    }



    class Accauntant
    {
        public enum Post
        {
            Buhgalter = 1,
            Main_Buhgalter,
            Boss,
            Big_boss
        }

       public bool AskForBonus(Post worker)
        {
            Console.WriteLine("Бугалтер = 1," +
                 "Главный бугалтер = 2" +
                 " Босс = 3" +
                 " Большой босс = 4");
            Console.WriteLine("Выберите рабочего:");
            int workers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите часы работы:");
            int hours = Convert.ToInt32(Console.ReadLine());
         
                switch (worker)
                {
                    case Post.Buhgalter:
                        if (hours > 320)
                        {
                            Console.WriteLine("Выдать премию");
                        }
                        else
                        {
                            Console.WriteLine("Не выдавать премию");
                        }
                        break;

                    case Post.Main_Buhgalter:
                        if (hours > 480)
                        {
                            Console.WriteLine("Выдать премию");
                        }
                        else
                        {
                            Console.WriteLine("Не выдавать премию");
                        }
                        break;
                    case Post.Boss:
                        if (hours > 1000)
                        {
                            Console.WriteLine("Выдать премию");
                        }
                        else
                        {
                            Console.WriteLine("Не выдавать премию");
                        }
                        break;
                    case Post.Big_boss:
                        if (hours > 1200)
                        {
                            Console.WriteLine("Выдать премию");
                        }
                        else
                        {
                            Console.WriteLine("Не выдавать премию");
                        }
                        break;
                    default:

                        break;
                }

            return true;
           
            

        }

    }









    class Program
    {
      
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Notebook notebook = new Notebook("УКР", 1200, "A340");
            notebook.DisplayInfo();
            Console.ReadKey(true);

            Console.WriteLine("Задание 2");

            Train train = new Train("Питер", 547, new DateTime(2011, 7, 25));
            Console.WriteLine("Время отправления: " + train.DepartureTime.ToLongDateString());
            Console.WriteLine("Номер поезда: " + train.Number);
            Console.WriteLine("Пункт назначения: " + train.Destination);
            Console.ReadKey(true);
          

            Console.WriteLine("Задание 3");
            MyClass mainClass = new MyClass();
            MyStruct mainStruct = new MyStruct();

            mainClass.change = "Не изменено";
            mainStruct.change = "Не изменено";

            ClassTaker(mainClass);
            StruktTaker(mainStruct);
           // mainStruct.StruktTaker();
            Console.WriteLine(mainClass.change);
            Console.WriteLine(mainStruct.change);
            Console.ReadKey(true);


            Console.WriteLine("Задание 4");
            DR dr = new DR();
      
            dr.DisplayInfo();
            Console.ReadKey(true);

            Console.WriteLine("Задание 5");
            Stroka.Print(Stroka.Color.White);

            Console.ReadKey(true);

            Console.WriteLine("Задание 6");
            Accauntant acc = new Accauntant();
            acc.AskForBonus(Accauntant.Post.Buhgalter);
            Console.ReadKey(true);
        }
    }
}


