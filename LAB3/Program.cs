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

    public static Set operator +(Set A, Set B)
    {
        int s = 0;
        foreach(var item in B.members)
        {
            foreach(var item2 in A.members)
            {
                if(item2 == item)
                {
                    s++;
                }
            }
            if(s==0)
            {
                A.members.Add(item);
            }
            s = 0;
        }
        return A;
    }
    public static Set operator ++(Set A)
    {
        Random rand = new Random();
        A.AddItemSet(rand.Next(10,20));
        return A;
    }
    public static bool operator <=(Set A, Set B)
    {
        int s = 0;
        foreach(int item in B.members)
        {
            foreach(int item2 in A.members)
            {
                if(item==item2)
                {
                    s++;
                }
            }
        }
        if(s==A.members.Count())
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public static bool operator >=(Set A, Set B)
    {
        int s = 0;
        foreach (int item in A.members)
        {
            foreach (int item2 in B.members)
            {
                if (item == item2)
                {
                    s++;
                }
            }
        }
        if (s == B.members.Count())
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public static implicit operator int(Set A)
    {
        return A.members.Count();
    }

    public static int operator %(Set A, int  poz)
    {
        return A.members[poz];
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
            A = A + B;
            A++;
            int pow = A;
            Console.WriteLine($"Можность множества №{A.number}: " + pow);
            A.DisplaySpis();
            int el = A % 2;
            Console.WriteLine(el);
            Console.WriteLine(A >= B);
            Console.WriteLine(A <= B);
            Console.WriteLine("Количесвто элементов класса(множеств): " + Set.countofsets);
        }
    }
}
