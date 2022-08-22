using System;

namespace MyRandomLucky
{
    class Program
    {
        static void Main(string[] args)
        {
            Lotto lotto = new Lotto();
            lotto.RandomDraw();
          
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
