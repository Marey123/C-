using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }
    class XMLHandler: AbstractHandler
    {

        public override void Open()
        {
            Console.WriteLine("Open XML");
        }


        public override void Create()
        {
            Console.WriteLine("Create XML");
        }


        public override void Change()
        {
            Console.WriteLine("Change XML");
        }


        public override void Save()
        {
            Console.WriteLine("Save XML");
        }
    }
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open TXT");
        }


        public override void Create()
        {
            Console.WriteLine("Create TXT");
        }


        public override void Change()
        {
            Console.WriteLine("Change TXT");
        }


        public override void Save()
        {
            Console.WriteLine("Save TXT");
        }
    }
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open DOC");
        }


        public override void Create()
        {
            Console.WriteLine("Create DOC");
        }


        public override void Change()
        {
            Console.WriteLine("Change DOC");
        }


        public override void Save()
        {
            Console.WriteLine("Save DOC");
        }
    }
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }
    class Player: IPlayable, IRecodable
    {
      public  void Play()
        {
            Console.WriteLine("Проигрывает");
        }
        public void Record()
        {
            Console.WriteLine("Записывает");
        }
        public void Pause()
        {
            Console.WriteLine("Пауза");
        }
        public void Stop()
        {
            Console.WriteLine("Останавливает");
        }




    }






    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            string formatDoc;
            Console.WriteLine("Форматы документов:" +
                " DOC " +
                " TXT " +
                " XML :");
            Console.WriteLine("Введите формат документа:");
            formatDoc = Console.ReadLine();
            if (formatDoc == "DOC")
            {
                AbstractHandler doc = new DOCHandler();
                doc.Open();
                doc.Create();
                doc.Change();
                doc.Save();
            }
            else if (formatDoc == "XML")
            {
                AbstractHandler xml = new XMLHandler();
                xml.Open();
                xml.Create();
                xml.Change();
                xml.Save();
            }
            else if (formatDoc == "TXT")
            {
                AbstractHandler txt = new TXTHandler();
                txt.Open();
                txt.Create();
                txt.Change();
                txt.Save();
            }
            else
                Console.WriteLine("Неверно указан формат документа!");
            Console.ReadKey();

            Console.WriteLine("Задание 2");
            Console.WriteLine("Проиграть запись - 1, записать - 2 ");
            int k;
            k = Convert.ToInt32(Console.ReadLine());
            Player song = new Player();
            switch (k)
            {
                case 1:
      
                    ((IPlayable)song).Play();
                    ((IPlayable)song).Pause();
                    ((IPlayable)song).Stop();
                    break;
                case 2:
                     ((IRecodable)song).Record();
                    ((IRecodable)song).Pause();
                    ((IRecodable)song).Stop();
                    break;
                default:
                    break;

            }
            Console.ReadKey();
        }
        }
    }

