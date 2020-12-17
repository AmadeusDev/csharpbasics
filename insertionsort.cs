using System;
using System.Threading;
namespace CviceniAP1PA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole = new int[] { 1, 5, 7, 9, 11, 12, 15, 16 };
            int prvek = 255;
            // mate pole s prvky jiz serazenymy vzestupne
            // vlozte do pole promennou prvek, tak aby bylo pole opet serazeno, nejvyssi prvek po vlozeni z pole odstrante
            // vase reseni musi byt platne pro ruzne dlouhe pole s minimalne jedním prvkem a ruzne hodnoty prvku
            // priklady:
            // pokud vlozite prvek s hodnotou  3, tak vysledne pole bude mit hodnotu  1, 3, 5, 7,  9, 11, 12
            // pokud vlozite prvek s hodnotou 10, tak vysledne pole bude mit hodnotu  1, 5, 7, 9, 10, 11, 12
            // pokud vlozite prvek s hodnotou  1, tak vysledne pole bude mit hodnotu  1, 1, 5, 7,  9, 11, 12
            // zde napiste reseni
            int i = pole.Length - 1;
            while (i > 0 && prvek < pole[i - 1])
            {
                pole[i] = pole[i - 1];
                --i;
            }
            pole[i] = prvek;
            for (int j = 0; j < pole.Length; j++)
            {
                if (j == pole.Length - 1)
                    Console.Write(pole[j]);
                else
                    Console.Write(pole[j] + ",");
            }
        }
    }
}
