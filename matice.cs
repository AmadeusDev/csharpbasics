using System;
namespace CviceniAP1PA
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            char[,] matice = new char[n, n];
            // naplnte matici znaky tak aby nad vedlejsi diagonalou byly znaky '1' a ostatni znaky byly '0'
            // Reseni musi byt platne pro libovolne hodnoty n > 0
            /* 
             * znaky matice potom vypiste na konzoli, tak aby vysup byl nasledujici:
             * 
       
            1111111110
            1111111100
            1111111000
            1111110000
            1111100000
            1111000000
            1110000000
            1100000000
            1000000000
            0000000000
            */
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < n - j - 1)
                        matice[i, j] = '1';
                    else
                        matice[i, j] = '0';
                }
            }
            for (int i = 0; i < matice.GetLength(0); i++)
            {
                for (int j = 0; j < matice.GetLength(1); j++)
                {
                    Console.Write(matice[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}