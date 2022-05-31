using System;

namespace _1_uslovniy_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string outputText = Console.ReadLine();
            Console.Write("Введите количество повторов: ");
            int numberForRepetitions = Convert.ToInt32(Console.ReadLine());

            for (int i = numberForRepetitions; i > 0; i--)
            {
                Console.WriteLine(outputText);
            }
        }
    }
}
