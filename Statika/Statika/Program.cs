using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;






namespace Statika
{
     static class Calculator
    {
        public static double a { get; set; }
        public static double b { get; set; }
      
        public static double Pluss (){
            return a + b;

            }
        public static double Minus()
        {
            return a - b;

        }
        public static double Proizv()
        {
            return a * b;

        }
        public static double Delenie()
        {
            return a / b;

        }



    }


    static class Array
    {


        public static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
        public static int[] BubbleSort(int[] array)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
        }
    }
        public class String
        {
        static public string text { get; set; }
       static public string Substring()
            {
                int i = 1;
                string itog = "";
                foreach (char a in text)
                {
                    if (i <= 10)
                    {
                        itog += a;
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
                return itog;
            }
        static public string Replace()
        {
            var theString = "ABCDEFGHIJ";
            var aStringBuilder = new StringBuilder(theString);
            aStringBuilder.Remove(4, 2);
            aStringBuilder.Insert(3, "FGHT");
            theString = aStringBuilder.ToString();
            return theString;
        }
        


    }
    

    












    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Calculator.a = 12;
            Calculator.b = 2;
            Console.WriteLine("Выберите действие: 1 - сложение, 2 - вычитание, 3 - умножение, 4 - деление");
            int k = Convert.ToInt32(Console.ReadLine());
            switch (k)
            {
                case 1:

                    Console.WriteLine("Cумма = {0}" , Calculator.Pluss());
                    break;
                case 2:
                    Console.WriteLine("Разность =  {0} ", Calculator.Minus());
                    break;
                case 3:
                    Console.WriteLine("Произведение =  {0} ", Calculator.Proizv());
                    break;
                case 4:
                    Console.WriteLine("Частное =  {0}", Calculator.Delenie());
                    break;
                default:
                    break;

            }
           
            Console.WriteLine("Задание 2");


            Console.WriteLine("Сортировка пузырьком");
            Console.Write("Введите элементы массива: ");
            var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            var array = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                array[i] = Convert.ToInt32(parts[i]);
            }

            Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", Array.BubbleSort(array)));


            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите строку:");
            String.text = Console.ReadLine();
            Console.Write("Substring\n");
            Console.Write(String.Substring()+"\n");
         
            Console.Write("Replace\n");
            Console.Write(String.Replace() + "\n");




            Console.ReadKey();
        }
    }
}
