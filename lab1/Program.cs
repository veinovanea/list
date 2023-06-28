using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {   //ArrayList
            Console.WriteLine("Введите размер списков N: "); int N = Convert.ToInt32(Console.ReadLine());
            var G = new Random();
            var arlist = new ArrayList();
            
                    for (int i = 0; i < N; i++)
            {
                Console.WriteLine(arlist.Add(G.Next(0, N)));
            }
            //LinkedList
            LinkedList<int> LDlist = new LinkedList<int>();
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(arlist.Add(G.Next(0, N)));
            }
            // меняем местами первый и последний елемент списка
            // доступ по индексу
            LDlist.AddLast(0);
            LDlist.AddFirst(N-1);
            // вставка в список числа 10
            LDlist.AddAfter(LDlist.Last, 10);
        }
    }
}
