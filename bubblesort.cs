using System;
namespace Ukol3
{
    class Program
        {
            static void Main(string[] args)
            {
                int[] pole = new int[] { 1, 9, 4, 7, 6, 9, 2 };
            int prvek = 7;
            // najdete a vypiste na konzoli index prvku s hodnotou 7 v poli (reseni: index 3)
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] == prvek)
                {
                    Console.WriteLine($"Prvek pole s indexem {i} ma hodnotu {prvek}");
                    break;
                }
            }
            // seradte hodnoty prvku v poli vzestupne pomoci algoritmu Bubble Sort a vypiste serazene hodnoty na konzoli
            int temp = 0;
            for (int write = 0; write < pole.Length; write++)
            {
                for (int sort = 0; sort < pole.Length - 1; sort++)
                {
                    if (pole[sort] > pole[sort + 1])
                    {
                        temp = pole[sort + 1];
                        pole[sort + 1] = pole[sort];
                        pole[sort] = temp;
                    }
                 }
            }
            for (int i = 0; i < pole.Length; i++)
            { 
                if(i == pole.Length - 1)
                    Console.Write(pole[i]);
                else
                    Console.Write(pole[i] + ",");
            }
        }
    }
}