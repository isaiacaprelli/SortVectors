using System;

namespace SortVectors
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] vett = new int[10] { 4, -1, 100, -85, 4, 6, 77, -35, 2, 0 };
            Ordina(vett);
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(vett[i]);
            }
            Console.ReadKey();
        }

        static void Ordina(int[] v)
        {
            Array.Sort(v);
        }
    }

}
