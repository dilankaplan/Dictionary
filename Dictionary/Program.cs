using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> yemekler = new MyList<string>();
            yemekler.Add("Hamburger");
            yemekler.Add("Pizza");
            yemekler.Add("Makarna");
            Console.WriteLine(yemekler.Count);

            MyList<string> saglikliYemekler = new MyList<string>();
            saglikliYemekler.Add("Ispanak");
            saglikliYemekler.Add("Kabak");
            saglikliYemekler.Add("Patlican");
            saglikliYemekler.Add("Yogurt");

            Console.WriteLine(saglikliYemekler.Count);

        }
    }
}

class MyList<T>
{
    T[] yemekArray;
    T[] tempArray;
    public MyList()
    {
        yemekArray = new T[0];
    }
    public void Add(T item)
    {
        tempArray = yemekArray;
        yemekArray = new T[yemekArray.Length + 1];
        for (int i = 0; i < tempArray.Length-1; i++)
        {
            yemekArray[i] = tempArray[i];
        }

    }

    public int Count
    {
        get { return yemekArray.Length; }
    }
}