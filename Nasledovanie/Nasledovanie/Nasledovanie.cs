using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie
{

    class Printer
    {
      public string value1;
        public string Smt
        {
            get { return value1; }
            set { value1 = value; }
        }

        public void Print()
        {
            Console.WriteLine(value1);
        }
    }
    
    class Smth : Printer
    {

    }
    class ClassRoom
    {
        public string Pupil { get; set; }
        public ClassRoom(string pupil, string pupil1, string pupil2)
        {
            Pupil = pupil;
            Pupil = pupil1;
            Pupil = pupil2;
            
        }
        public virtual void Display()
        {
            Console.WriteLine(Pupil);
        }

    }
    class Pupil
    {
       
        public virtual void Study()
        {

        }
        public virtual void Read()
        {

        }
        public virtual void Write()
        {

        }
        public virtual void Relax()
        {

        }

    }
    class ExcelentPupil : Pupil
    {
      
       
        public override void Study()
        {
            Console.WriteLine("Study excelent!");
        }
        public override void Read()
        {
            Console.WriteLine("Read excelent!");
        }
        public override void Write()
        {
            Console.WriteLine("Write excelent!");
        }
        public override void Relax()
        {
            Console.WriteLine("Doesn't relax!");
        }

    }
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Study good!");
        }
        public override void Read()
        {
            Console.WriteLine("Read good!");
        }
        public override void Write()
        {
            Console.WriteLine("Write good!");
        }
        public override void Relax()
        {
            Console.WriteLine("Relax!");
        }
    }
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Study bad!");
        }
        public override void Read()
        {
            Console.WriteLine("Read bad!");
        }
        public override void Write()
        {
            Console.WriteLine("Write bad!");
        }
        public override void Relax()
        {
            Console.WriteLine("Relax excelent!");
        }
    }


    internal class Vehicle
    {
        private double coordinateX, coordinateY;
        private double price, speed, year;


        public double CoordinateX 
        {
            get { return coordinateX; }
            set { coordinateX = value; }
        }

        public double CoordinateY 
        {
            get { return coordinateY; }
            set { coordinateY = value; }
        }

        public double Price 
        {
            get { return price; }
            set { price = value; }
        }

        public double Speed 
        {
            get { return speed; }
            set { speed = value; }
        }

        public double Year 
        {
            get { return year; }
            set { year = value; }
        }


     
        public void Coordinate(double CoordinateX, double CoordinateY)
        {
            this.CoordinateX = CoordinateX;
            this.coordinateY = CoordinateY;
        }

       
        public Vehicle(double Speed)
        {

            this.Speed = Speed;
        }
    }
    class Plane : Vehicle 
    {
        public double Height { get; set; } 
        public double Passengers { get; set; } 
       
        public Plane(double Speed)
            : base(Speed)
        {
            Height = 300;
            Passengers = 100;
        }
    }

    class Ship : Vehicle 
    {
        public double Passengers { get; set; } 
        public string Port { get; set; } 
      
        public Ship(double Speed)
            : base(Speed)
        {
            Passengers = 500;
            Port = "порт 1";
        }
    }

    class Car : Vehicle 
    {
       
        public Car(double Speed)
            : base(Speed)
        {

        }
    }


    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
















    class Program
    {

        private const string PRO_LICENSE = "112";
        private const string EXP_LICENSE = "232";
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Printer p = new Printer { Smt = "Найгарніша квітка" };
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            p.Print();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Black;
            p = new Smth { Smt = "Найпоганіша звичка" };
            p.Print();
            Console.ResetColor();
      

            Console.WriteLine("Задание 2");

            ClassRoom A = new ClassRoom("Tom", "Mary", "Kate");
            A.Display();
            GoodPupil pupil = new GoodPupil();

            pupil.Read();
            pupil.Study();
            pupil.Write();
            pupil.Relax();
            A.Display();
            ExcelentPupil pupil1 = new ExcelentPupil();
            pupil1.Read();
            pupil1.Study();
            pupil1.Write();
            pupil1.Relax();
            A.Display();
            BadPupil pupil2 = new BadPupil();
            pupil2.Read();
            pupil2.Study();
            pupil2.Write();
            pupil2.Relax();
            Console.Read();
            Console.WriteLine("Задание 3");

            Console.WriteLine("Характеристики самолёта");
            var plane = new Plane(200) { Year = 2004, Price = 230000, Height = 5000, Passengers = 40, Speed = 700 };
            Console.WriteLine("Год выпуска: {0}", plane.Year.ToString());
            Console.WriteLine("Стоимость  {0}:", plane.Price.ToString());
            Console.WriteLine("Высота полёта {0}:", plane.Height.ToString());
            Console.WriteLine("Число пассажиров {0}:", plane.Passengers.ToString());
            Console.WriteLine("Скорость {0}:", plane.Speed.ToString());


            Console.WriteLine("Характеристики машины");
            var car = new Car(60) { Price = 55678, Year = 1987, Speed = 450 };
            car.Coordinate(40000, 30000);
            Console.WriteLine("Стоимость  {0}:", car.Price.ToString());
            Console.WriteLine("Координаты  X:{0},Y: {1}", car.CoordinateX.ToString(), car.CoordinateY.ToString());
            Console.WriteLine("Год выпуска: {0}", car.Year.ToString());
            Console.WriteLine("Стоимость {0}:", car.Price.ToString());
            Console.WriteLine("Скорость {0}:", car.Speed.ToString());
            var ship = new Ship(20) { Price = 8000000, Year = 1900, Speed = 90, Port = "Порт Еквар" };


            Console.WriteLine("Характеристики корабля");
            Console.WriteLine("Стоимость  {0}:", ship.Price.ToString());
            Console.WriteLine("Координаты  X:{0},Y: {1}", ship.CoordinateX.ToString(), car.CoordinateY.ToString());
            Console.WriteLine("Год выпуска: {0}", ship.Year.ToString());
            Console.WriteLine("Стоимость  {0}:", ship.Price.ToString());
            Console.WriteLine("Скорость {0}:", ship.Speed.ToString());
            Console.WriteLine("Порт приписки {0}:", ship.Port.ToString());


            Console.WriteLine("Задание 4");

            Console.WriteLine("Enter license key:");
            var license = Console.ReadLine();

       
            DocumentWorker worker;
            switch (license)
            {
                case PRO_LICENSE: worker = new ProDocumentWorker(); break;
                case EXP_LICENSE: worker = new ExpertDocumentWorker(); break;
                default: worker = new DocumentWorker(); break;
            }

            
            while (true)
            {
                Console.WriteLine("Выберите команду:o,e,s,q: ");
                switch (Console.ReadLine())
                {
                    case "o": worker.OpenDocument();
                        break;
                    case "e": worker.EditDocument();
                        break;
                    case "s": worker.SaveDocument();
                        break;
                    case "q": return;
                }
            }
            Console.Read();
        }
    
     
        
    }
}
