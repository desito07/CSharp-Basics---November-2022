using System;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersN = int.Parse(Console.ReadLine());
           
            int sum = 0;
            for (int i = 1; i <= numbersN; i++)
            {

                int currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;
            }
            Console.WriteLine(sum);
        }
    }
}