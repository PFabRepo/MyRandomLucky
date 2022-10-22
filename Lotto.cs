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
            int[] secondtab = new int[6];

            var numbers = Enumerable.Range(1, 49).ToList();

            for (int i = 0; i < 6; i++)
            {
                var number1 = numbers[rand.Next(numbers.Count)];
                secondtab[i] = number1;
                numbers.Remove(number1);
                Console.WriteLine($"Wylosowane liczby to: " + secondtab[i]);

            }
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
            var secondNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            int[] firstTab = new int[6];
            int[] secondTab = new int[3];

            RandomNumbersFromList(firstNumbers, 5, firstTab, 50);
            Console.WriteLine();
            RandomNumbersFromList(secondNumbers, 2, secondTab, 12);
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
