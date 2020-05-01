using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Obobshenie

{
  

    //Задание 1
    public class MyFactory<T> where T : new()
    {
        public static T FacrotyMethod()
        {
            return new T();
        }
    }

    //Задание 2
   public class MyList<T>
    {
         ArrayList myList;
       
        public  T this[int index]
        {
            get { return (T)myList[index]; }
            set { myList[index] = value; }
        }

        public MyList()
        {
            this.myList = new ArrayList();
        }

        public MyList(int count)
        {
            this.myList = new ArrayList(count);
        }

        public void Add(T item)
        {
            myList.Add(item);
        }

        public int Capacity
        {
            get { return myList.Capacity; }
            set
            {

                if (value < myList.Count)
                    throw new ArgumentOutOfRangeException();

                myList.Capacity = value;
            }
        }

        public int Count
        {
            get { return myList.Count; }
        }

       
    }

    //Задание 3
      class MyDictionary<Tkey, Tval>
        {
            private int counter = 0;
            private Tkey[] keysArray = null;
            private Tval[] valsArray = null;

            public int Counter
            {
                get { return this.counter; }
            }

            public void Add(Tkey key, Tval val)
            {
                this.counter++;

                Array.Resize(ref keysArray, counter);
                keysArray[counter - 1] = key;


                Array.Resize(ref valsArray, counter);
                valsArray[counter - 1] = val;
            }

            public Tval this[Tkey key]
            {
                get
                {
                    int ind = 0;
                    for (int i = 0; i < keysArray.Length; i++)
                    {
                        if (key.Equals(keysArray[i]))
                            ind = i;
                    }
                    return valsArray[ind];
                }
            }
        

       
    }
    }

//Задание 4

    public static class MList
{
    
    public static T[] GetArray<T>(this MyList<T> myList)
    {

        return myList;
    }
}
    




//Задание 5

interface ICar
    {
        string Name { get; set; }
        int Year { get; set; }
    }

    class CarCollection<T> where T : ICar, new()
    {
        List<T> Cars = new List<T>();

        public void Add(string Name, int Year)
        {
            Cars.Add(new T() { Name = Name, Year = Year });
        }

        public T this[int Index]
        {
            get { return Cars[Index]; }
            set { Cars[Index] = value; }
        }

        public int Count
        {
            get { return Cars.Count; }
        }
        public void Clear()
        {
            Cars.Clear();
        }
    }

    class CarA : ICar
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return System.String.Format(Name, Year);

        }
    }

    class CarB : ICar
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return System.String.Format(Name, Year);

        }
    }



//Задание 6
class Dictionary<Tkey, Tval>
{
    private int counter = 0;
    private Tkey[] keysArray = null;
    private Tval[] valsArray = null;

    public int Counter
    {
        get { return this.counter; }
    }

    public void Add(Tkey key, Tval val)
    {
        this.counter++;
        Tkey[] keysArray2 =  new Tkey[counter - 1];
        for (int i = 0; i < counter-1; i++)
            keysArray2[i] = keysArray[i];
        keysArray = keysArray2;
       keysArray[counter - 1] = key;




       
    }

    public Tval this[Tkey key]
    {
        get
        {
            int ind = 0;
            for (int i = 0; i < keysArray.Length; i++)
            {
                if (key.Equals(keysArray[i]))
                    ind = i;
            }
            return valsArray[ind];
        }
    }



}
    













//Задание 7
public class MyArrayList<T>
{
    private  int INIT_SIZE = 20;
    private  int CUT_RATE = 5;
    private Object[] array = new Object[16];
    private int pointer = 0;

    
    public void add(T item)
    {
        if (pointer == array.Length - 1)
           Array.Resize(ref array,array.Length * 2); 
        array[pointer++] = item;
    }

    
    public T get(int index)
    {
        return (T)array[index];
    }

   
    public void remove(int index)
    {
        for (int i = index; i < pointer; i++)
            array[i] = array[i + 1];
        array[pointer] = null;
        pointer--;
        if (array.Length > INIT_SIZE && pointer < array.Length / CUT_RATE)
        {
            Array.Resize(ref array, array.Length / 2);
        }
                                     
    }
    
}
    class Program
    {
        
        static void Main(string[] args)
        {
           
            
        }
    }

