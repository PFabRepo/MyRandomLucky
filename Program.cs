using System;

namespace MyRandomLucky
{
    class Program
    {
        static void Main(string[] args)
        {
            Lotto lotto = new Lotto();

            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine($"Losowanko nr. {i}");
                lotto.RandomDraw();

            }

            //lotto.RandomEuroJack();

            /*   for (int i = 1; i <= 15; i++)
               {
                   Console.WriteLine($"Losowanko nr. {i}");
                   lotto.RandomEuroJack();

               }*/




            //lotto.RandomDrawBonus();
            /* for (int i = 0; i < 10; i++)
             {
             lotto.RandomEuroJack();
                 Console.WriteLine();
                 Console.WriteLine("Nowe Losowanie:");
             }*/

        }
    }
}
