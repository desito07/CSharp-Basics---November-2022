using System;

namespace Conditional_Statements_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    quantity *= 2.5;
                }
                else if (fruit == "apple")
                {
                    quantity *= 1.2;
                }
                else if (fruit == "orange")
                {
                    quantity *= 0.85;
                }
                else if (fruit == "grapefruit")
                {
                    quantity *= 1.45;
                }
                else if (fruit == "kiwi")
                {
                    quantity *= 2.7;
                }
                else if (fruit == "pineapple")
                {
                    quantity *= 5.5;
                }
                else if (fruit == "grapes")
                {
                    quantity *= 3.85;
                }

            }
            else if (day == "Saturday" || day == "Sunday")
            {

                if (fruit == "banana")
                {
                    quantity *= 2.7;
                }
                else if (fruit == "apple")
                {
                    quantity *= 1.25;
                }
                else if (fruit == "orange")
                {
                    quantity *= 0.90;
                }
                else if (fruit == "grapefruit")
                {
                    quantity *= 1.60;
                }
                else if (fruit == "kiwi")
                {
                    quantity *= 3.0;
                }
                else if (fruit == "pineapple")
                {
                    quantity *= 5.6;
                }
                else if (fruit == "grapes")
                {
                    quantity *= 4.20;
                }

            }

            if ((day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday" || day == "Sunday") && (fruit == "banana" || fruit == "apple" || fruit == "orange" || fruit == "grapefruit" || fruit == "kiwi" || fruit == "pineapple" || fruit == "grapes"))
            {
                Console.WriteLine($"{quantity:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
