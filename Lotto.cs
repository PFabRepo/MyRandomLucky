using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRandomLucky
{
    class Lotto
    {
        Random rand = new Random();

        public void RandomDraw()
        {
            int[] arrayNumbers = new int[7];

            var numbers = Enumerable.Range(1, 49).ToList();
            RandomNumbersFromList(numbers, 6, arrayNumbers, 49);
            Console.WriteLine();
        }

        public void RandomDrawBonus()
        {
            Console.WriteLine("Extra Bonus!");
            RandomDraw();
        }

        public void RandomEuroJack()
        {

            var firstNumbers = Enumerable.Range(1, 50).ToList();
            var secondNumbers = Enumerable.Range(1, 12).ToList();

            int[] firstArray = new int[6];
            int[] secondArray = new int[3];

            RandomNumbersFromList(firstNumbers, 5, firstArray, 50);
            Console.WriteLine();
            RandomNumbersFromList(secondNumbers, 2, secondArray, 12);
            Console.WriteLine();

        }

        private void RandomNumbersFromList(List<int> list, int counter, int[] tab, int lastNumber)
        {
            for (int i = 1; i <= counter; i++)
            {
                var numbersFromList = list[rand.Next(list.Count)];
                tab[i] = numbersFromList;
                list.Remove(numbersFromList);
                Console.WriteLine($"Wylosowane liczby: {i} ({counter} wybranych) z przedziału od 1 do {lastNumber} to: {tab[i]}");
               
            }

        }




    }
}
