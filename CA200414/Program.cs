using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA200414
{
    class Program
    {
        static void Main()
        {
            var lista = new List<int>() { 77, 100 };

            lista.Add(20);
            lista.Add(42);
            lista.Add(33);

            foreach (var e in lista)
            {
                Console.WriteLine($"{lista.IndexOf(e)}: {e}");
            }

            Console.Write("\n");
            lista[1] = 2020;

            foreach (var e in lista) Console.Write($"{e} ");

            Console.Write("\n\n");

            for (int i = 0; i < lista.Count; i++)
                Console.WriteLine($"lista[{i}]: {lista[i]}");

            Console.Write('\n');

            lista.RemoveAt(index: 0);

            for (int i = 0; i < lista.Count; i++)
                Console.WriteLine($"lista[{i}]: {lista[i]}");

            lista.AddRange(new int[] { 32, 31, 40 });

            Console.Write('\n');

            for (int i = 0; i < lista.Count; i++)
                Console.WriteLine($"lista[{i}]: {lista[i]}");

            lista.AddRange(new List<int> { 50, 60 });

            Console.ReadKey();
        }
    }
}
