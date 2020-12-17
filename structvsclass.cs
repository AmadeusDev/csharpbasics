using System;
namespace CviceniAP1PA
{
    class Trida
    {
        public int cislo;
        public Trida(int cislo)
        {
            this.cislo = cislo;
        }
    }
    struct Struktura
    {
        public int cislo;
        public Struktura(int cislo)
        {
            this.cislo = cislo;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Trida t1 = new Trida(1); //Třída je referenční typ, alokuje paměť na zásobníku pro referenci proměné t1 a hodnotu 1 uloží na haldu pod referencí na adresu t1.
            Trida t2 = t1; //Vytvoří se v zásobníku další proměná t2, která má stejnou referenční hodnotu na haldě jako t1.
            t2.cislo = 2; //Na haldu se uloží hodnota 2 pod referencí na adresu v zásobníku t2, jelikož t1 a t2 má stejnou referenční adresu na haldě, tak t1.cislo u t2.cislo ukazují na stejnou hodnotu 
            Struktura s1 = new Struktura(1); //Objekt s1 se alokuje přímo na zásobníku a je zde i hodnota 1
            Struktura s2 = s1; //Při přiřazení se zkopíruje objekt s1 do s2 a jsou nezávislé
            s2.cislo = 2; //Do objektu s2 se přířadí hodnota 2 namísto 1 a jelikož jsou objekty nezávislé, tak s1.cislo vypíše 1 a s2.cislo 2
            // Vysvetlete proc je u prakticky stejneho klientskeho kodu vysledek jiny pro strukturu a jiny pro tridu
            Console.WriteLine($"{t1.cislo} {t2.cislo}");
            Console.WriteLine($"{s1.cislo} {s2.cislo}");
        }
    }
}