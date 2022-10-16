using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;


class Set
{
    public List<int> members = new List<int>();
    public static int countofsets = 0;
    public int number = 0;
    public Set(List <int> items)
    {
        members = items;
        countofsets++;
        number = countofsets;
    }
    public void AddItemSet(int item)
    {
        int i = 0;
        foreach (var mb in members)
        {       
            if(mb == item)
            {
                i++;        
            }
        }
        if(i>=1)
        {
            Console.WriteLine($"Такой элемент({item}) уже существует в множестве");
        }
        else
        {
            members.Add(item);
        }
        
    }

  

    public void DisplaySpis()
    {
        if(members.Count>0)
        {
            Console.WriteLine("Множество №" + number);
            foreach (var item in members)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Множество №" + number + " пустое");
        }
        

    }


}

namespace LAB3
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> items1 = new List<int>() {5,6};
            List<int> items2 = new List<int>() { 1, 2, 3, 4 };
            Set A = new Set(items1);
            Set B = new Set(items2);
            A.DisplaySpis();
            B.DisplaySpis();
            A.DisplaySpis();
            Console.WriteLine("Количесвто элементов класса(множеств): " + Set.countofsets);
        }
    }
}
