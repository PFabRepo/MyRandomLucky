using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRandomLucky
{
    class Lotto
    {

        public void RandomDraw()
        {
            var rand = new Random();
            int[] secondtab = new int[6];

            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49};
            // var number2 = default(int);

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
            var rand = new Random();
            var firstNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50};
            var secondNumbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};

            int[] firstTab = new int[5];
            int[] secondTab = new int[2];

            for (int i = 0; i < 5; i++)
            {
                var numberFromFirstArray = firstNumbers[rand.Next(firstNumbers.Count)];
                firstTab[i] = numberFromFirstArray;
                firstNumbers.Remove(numberFromFirstArray);
                Console.WriteLine($"Wylosowane 5 liczb z przedziału od 1 do 50 to: {firstTab[i]}");
            }
            Console.WriteLine();

            for (int j = 0; j < 2; j++)
            {
                var numberFromSecondArray = secondNumbers[rand.Next(secondNumbers.Count)];
                secondTab[j] = numberFromSecondArray;
                secondNumbers.Remove(numberFromSecondArray);
                Console.WriteLine($"Wylosowane 2 liczby z przedziału od 1 do 12 to: {secondTab[j]}");

            }
        
        }

    }
}
