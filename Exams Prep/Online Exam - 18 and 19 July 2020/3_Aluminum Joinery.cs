using System;

namespace Exams_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDograma = int.Parse(Console.ReadLine());
            string nameDograma = Console.ReadLine();
            string deliveryOption = Console.ReadLine();

            double price = 0;
            int delivery = 60;


            if (numDograma > 10)
            {
                if (nameDograma == "90X130")
                {
                    price += numDograma * 110;
                    if (numDograma > 30 && numDograma <= 60)
                    {
                        price -= price * 0.05;
                    }
                    else if (numDograma > 60)
                    {
                        price -= price * 0.08;
                    }
                }
                else if (nameDograma == "100X150")
                {
                    price += numDograma * 140;
                    if (numDograma > 40 && numDograma <= 80)
                    {
                        price -= price * 0.06;
                    }
                    else if (numDograma > 80)
                    {
                        price -= price * 0.1;
                    }
                }
                else if (nameDograma == "130X180")
                {
                    price += numDograma * 190;
                    if (numDograma > 20 && numDograma <= 50)
                    {
                        price -= price * 0.07;
                    }
                    else if (numDograma > 50)
                    {
                        price -= price * 0.12;
                    }
                }
                else if (nameDograma == "200X300")
                {
                    price += numDograma * 250;
                    if (numDograma > 25 && numDograma <= 50)
                    {
                        price -= price * 0.09;
                    }
                    else if (numDograma > 50)
                    {
                        price -= price * 0.14;
                    }
                }



                if (deliveryOption == "With delivery")
                {
                    price += delivery;
                }

                if (numDograma > 99)
                {
                    price -= price * 0.04;
                }
                Console.WriteLine($"{price:f2} BGN");

            }
            else
            {
                Console.WriteLine("Invalid order");
            }
        }
    }
}

