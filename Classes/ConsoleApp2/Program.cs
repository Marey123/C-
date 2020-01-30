using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
   class Address
    {
        public string Country;
        public int index;
        public string City;
        public string Street;
        public int House;
        public int Apartment;

        public void SetInfo()
        {
            Country = "Украина";
            City = "Днепр";
            Street = "Казакова";
            House = 23;
            index = 4567;
            Apartment = 3;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Страна: {Country} ");
            Console.WriteLine($"Город: {City}");
            Console.WriteLine($"Улица:{Street} ");
            Console.WriteLine($" Дом:{House} ");
            Console.WriteLine($" Индекс:{index} ");
            Console.WriteLine($" Апартаменты:{Apartment} ");

        }

    }

    class Book
    {
        Title book = new Title();
        Content boook = new Content();
        Author booook = new Author();
        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(book.title);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(boook.content);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(booook.author);
            Console.ResetColor();
        }
        }
    class Title
    {
        public string title { get; set; } = "Гарри Поттер";
    }
    class Content
    {
        public string content { get; set; } = "Сказка";
    }
    class Author
    {
        public string author { get; set; } = "Джоан Роулинг";

    }
    class Rectangle
    {
        public double side1;
        public double side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
           
        }
      
        public double AreaCalculator()
        {
            

            return side1*side2;
         
        }
        public double PerimeterCalculator()
        {
           

            return (side1 + side2)*2;
        }
        public double Area
        {

            get { return AreaCalculator(); }
        }

        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
    }

    class Point
    {
        public string name;
       public int x, y;
        public int X
        {
            get
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Point()
           : this("", 0, 0) { }
        public Point(string name, int x, int y)
        {
            Console.WriteLine("Enter  name of Point:");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter X:");
            this.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y:");
            this.y = int.Parse(Console.ReadLine());
        }
    }
    class Figure
    {
        int number;
        Point[] points;
        public string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void InitializeFigure()
        {
            Console.WriteLine("enter number of verticles of your figure");
            number = int.Parse(Console.ReadLine());
            points = new Point[number];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point();
            }
        }
        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
        public double CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 1; i < points.Length; i++)
            {
                perimeter += this.LengthSide(points[i - 1], points[i]);
            }
            perimeter += this.LengthSide(points[0], points[points.Length - 1]);
            return perimeter;
        }
        public Figure(string name)
        {
            InitializeFigure();
        }
    }

    class User
    {
        public string login;
        public string firstname;
        public string name;
        public int age;
        private int date;
        private string month;
        private int year;

        public string Login
        {
            get { return login; }
        }
        public string Firstname
        {
            get { return firstname; }
        }
        public string Name
        {
            get { return name; }
        }
        public int Age
        {
            get { return age; }
        }
        private int Data
        {
            get { return date; }
        }
        private string Month
        {
            get { return month; }
        }
        private int Year
        {
            get { return year; }
        }
        public User()
        {
            Console.WriteLine("Введите логин:");
            this.login = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            this.firstname = Console.ReadLine();
            Console.WriteLine("Введите имя:");
            this.name = Console.ReadLine();
            Console.WriteLine("Введите возраст:");
            this.age = int.Parse(Console.ReadLine());
            this.date = 12;
            this.month = "April";
            this.year = 2020;

        }
        public void show()
        {
            Console.WriteLine($"Логин:{login}");
            Console.WriteLine($"Фамилия:{firstname}");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст:{ age}");
            Console.WriteLine($"Дата: {date}.{month}.{year}");

        }
    }



    class Converter
    {
        public double usd;
        public double eur;
        public double rub;
        public string name;

        public double Usd
        {
            get { return usd; }
        }
        public double Eur
        {
            get { return eur; }
        }
        public double Rub
        {
            get { return rub; }
        }
        public string Name
        {
            get { return name; }
        }
        public Converter(double usd, double eur, double rub)
        {
            usd = usd;
            eur = eur;
            rub = rub;

        }
        public void dollar()
        {
            Console.WriteLine("Введите единицу доллара: ");
            this.usd = double.Parse(Console.ReadLine());
            Console.WriteLine($"В гривнах это:{usd*24,85} ");
            Console.WriteLine("Введите единицу гривны: ");
            this.usd = double.Parse(Console.ReadLine());
            Console.WriteLine($"В долларах это:{usd / 24,85} ");

        }
        public void evro()
        {
            Console.WriteLine("Введите единицу евро: ");
            this.eur = double.Parse(Console.ReadLine());
            Console.WriteLine($"В гривнах это:{eur * 27,39} ");
            Console.WriteLine("Введите единицу гривны: ");
            this.eur = double.Parse(Console.ReadLine());
            Console.WriteLine($"В евро это:{eur / 27,39} ");

        }
        public void rubl()
        {
            Console.WriteLine("Введите единицу рубля: ");
            this.rub = double.Parse(Console.ReadLine());
            Console.WriteLine($"В гривнах это:{rub * 0,39} ");
            Console.WriteLine("Введите единицу гривны: ");
            this.rub = double.Parse(Console.ReadLine());
            Console.WriteLine($"В рублях это:{rub / 0,39} ");

        }
        public void conver()
        {
            Console.WriteLine("Введите одну из валют:доллар,евро,рубль");
            this.name = Console.ReadLine();
            if (name == "доллар")
            {
                dollar();
            }
            else if (name == "евро")
            {
                evro();
            }
            else if (name == "рубль")
            {
                rubl();
            }
            else
            {
                Console.WriteLine("Вы ввели не то,что нужно! ");
            }

        }



    }

    public class Employee
    {
       string name;
        string surname;
        DateTime dateOfHire;
        double salary;

        public enum Position
        {
            Slave = 10000,
            Warden = 100000,
            Lord = 1000000
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfHire
        {
            get
            {
                return dateOfHire;
            }
            set
            {
                if (dateOfHire.Date < DateTime.Parse("01.01.1995"))
                {
                    dateOfHire = value;
                }
                else
                {
                    Console.WriteLine("Date before times!");
                }

            }
        }

        public Employee(string name, string surname, DateTime dateOfHire)
        {
            Name = name;
            Surname = surname;
            DateOfHire = dateOfHire;
        }

        public double DiscoverGrade(DateTime dateOfHire)
       
        {
            double dateValueForGrade = (DateTime.Now - dateOfHire).TotalDays;

            if (dateValueForGrade >= 1825 && dateValueForGrade < 3650)
                return 1.5;
            else if (dateValueForGrade >= 3650)
                return 1.25;
            else
                return 1.0;
        }

        public double Calculation(Position position)
       
        {
            double grade = DiscoverGrade(dateOfHire);
            switch (position)
            {
                case Position.Slave:
                    salary = 10000 * grade;
                    return salary;
                case Position.Warden:
                    salary = 100000 * grade;
                    return salary;
                case Position.Lord:
                    salary = 1000000 * grade;
                    return salary;
                default:
                    Console.WriteLine("No such position!");
                    break;

            }
            return 0.0;
        }
    }

    class Invoice
    {
        public int account { get; set; }
        public string customer { get; set; }
        public string provider { get; set; }
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        private string article;
        public string Article
        {
            get { return article; }


            set
            {
                Console.WriteLine("Предмет - ");
                this.article = "Духи";

            }
        }

        private int quantity;
        public int Qantity
        {
            get { return quantity; }


            set
            {
                Console.WriteLine("Кол-во - ");
                this.quantity = 5;

            }
        }

        public void NDS()
        {
            Console.WriteLine($" С НДС:{account*quantity - (account*20/100)}");
        }
        public void BNDS()
        {
            Console.WriteLine($"Без  НДС:{account * quantity }");
        }
    }














    class Program
    {
        static void Main(string[] args)
        {
     
            Console.WriteLine("Задание 1");
            Address address = new Address();
          
            address.SetInfo();
            address.GetInfo();

            Console.WriteLine("Задание 2");
            Console.Write($"Введите первую сторону: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Введите первую вторую: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1, side2);
            
            Console.WriteLine("Площадь: {0}, Периметр: {1}", rectangle.Area, rectangle.Perimeter);




            Console.WriteLine("Задание 3");
            Book newbook = new Book();
            newbook.Show();

            Console.WriteLine("Задание 4");
            Figure cube = new Figure("cube");
            Console.WriteLine(cube.CalculatePerimeter());

            Console.WriteLine("Задание 5");
            User one = new User();
            one.show();
            Console.WriteLine("Задание 6");
            Converter on = new Converter(1,1,1);
            on.conver();
            Console.WriteLine("Задание 7");
            Employee rau = new Employee("Anton", "Lupanov", DateTime.Parse("01.02.2000"));
            Console.WriteLine("Name is {0}, surname is {1}. Date of hire: {2}", rau.Name, rau.Surname, rau.DateOfHire);
            double salary = rau.Calculation(Employee.Position.Lord);
            Console.WriteLine("Salary is {0}, tax is {1}, position is {2}.", salary, salary * 0.34, Employee.Position.Lord);
          

            Console.WriteLine("Задание 8");
            Invoice first = new Invoice(1200, "Tom", "Maybe");
            first.NDS();
            first.BNDS();
            Console.Read();
        }
    }
}
