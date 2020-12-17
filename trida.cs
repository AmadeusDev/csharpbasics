using System;
namespace CviceniAP1PA
{
    class Pocitadlo
    {
        private int hodnota;
        public Pocitadlo(int hodnota)
        {
            this.hodnota = hodnota;
        }
        public int VratPocet()
        {
            return hodnota;
        }
        public int Zvys()
        {
            return hodnota++;
        }
        public int Vynuluj()
        {
            return hodnota = 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Definujte tridu Pocitadlo, tak aby sli prelozit nasledujici radky a vypis odpovidal poznamkam.
            // Vlastni pocet v pocitadle skryjte pomoci klicoveho slova private, tak aby nesel menit z metody main primo ale jen pomoci metod Zvys a Vynuluj
            Pocitadlo pocitadlo = new Pocitadlo(10);
         
            Console.WriteLine(pocitadlo.VratPocet()); // vypise 10
            pocitadlo.Zvys();
            Console.WriteLine(pocitadlo.VratPocet()); // vypise 11
            pocitadlo.Zvys();
            Console.WriteLine(pocitadlo.VratPocet()); // vypise 12
            pocitadlo.Vynuluj();
            Console.WriteLine(pocitadlo.VratPocet()); // vypise 0
        }
    }
}