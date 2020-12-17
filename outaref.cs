using System;
/*REF se požívá k předání/vracení reference hodnot 
 do nebo z metod, jakákoliv změna hodnoty předávána
referencí bude reflektována
OUT se používá k předání argumentu do metod jako
 referenční typ
Ani jeden z parametrů nepředává property*/
class RefOut
{
    static public void Main()
    {
        //Deklarace proměné X bez přiřazení hodnoty
        int X;
       //Předání hodnoty X metodě Sum pomocí klíčového slova out
        Sum(out X);
        //Zobrazení hodnoty X
        Console.WriteLine("Soucet hodnot je: {0}", X);
        //Přiřazení hodnoty stringu(nutno u ref)
        string str = "Pes";
        //Zobrazení stringu
        Console.WriteLine(str);
        //Předání stringu jako referenční parametr
        SetValue(ref str);
        //Zobrazení stringu po předání nové hodnoty
        Console.WriteLine(str);
    }
    //Metoda kde je patametr out předáván a vrací se jeho hodnota
    public static void Sum(out int X)
    {
        X = 60;
        X += X;
    }
    static void SetValue(ref string str1)
    {
        //Kontrola hodnoty stringu
        if (str1 == "Pes")
        {
            Console.WriteLine("Haf");
        }
        //Přirazení nové hodnoty parametru
        str1 = "Pošťák";
    }
}