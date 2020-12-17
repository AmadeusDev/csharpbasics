using System;
namespace Ukol2
{
    class Program
        {
            static void Main(string[] args)
            {
                int[] pole = new int[] { 1, 9, 4, 5, 6, 9, 2 };
            // vypiste na konzoli hodnotu prvniho prvku
            Console.WriteLine(pole[0]);
            // vypiste na konzoli hodnotu posledniho prvku
            Console.WriteLine(pole[6]);
            // najdete a vypiste hodnotu nejvyssiho prvku v poli
            int max = pole[0];
            for (int i = 1; i < pole.Length; i++)
                if (pole[i] > max)
                    max = pole[i];
            Console.WriteLine(max);
            // najdete a vypiste sumu prvku v poli
            int suma = 0;
            for (int i = 0; i < pole.Length; i++)
                suma += pole[i];
            Console.WriteLine(suma);
        }
    }
}