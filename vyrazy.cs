using System;
namespace Ukol1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 20; i += 2)
            {
                Console.WriteLine(i);
            }
            //1. prepsat cyklus for s pomoci cyklu while
            int a = 2;
            while (a < 20)
            {
                Console.WriteLine(a);
                a += 2;
            }
            //2. prepiste cyklus for s pomoci cyklu do-while
            int b = 2;
            do
            {
                Console.WriteLine(b);
                b += 2;
            } while (b < 20);
            int t1 = 0;
            int t2 = 60;
            int t3 = 70;
            if ((t1 > 50 && t2 > 50) || t3 > 50)
            {
                Console.WriteLine("uspel");
            }
            // 3. Prepiste podminku pouze s pouzitim prikazu if a bez && (AND), || (OR) a bez pomocne promenne
            if (t3 > 50)
            {
                Console.WriteLine("uspel");
            }
            else if (t1 > 50)
            {
                if (t2 > 50)
                {
                    Console.WriteLine("uspel");
                }
            }
        }
    }
}