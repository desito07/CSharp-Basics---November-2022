﻿//using System;

//namespace ConditionalStatements
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double tripCosts = double.Parse(Console.ReadLine());
//            int puzzels = int.Parse(Console.ReadLine());
//            int dolls = int.Parse(Console.ReadLine());
//            int bears = int.Parse(Console.ReadLine());
//            int minions = int.Parse(Console.ReadLine());
//            int trucks = int.Parse(Console.ReadLine());

//            double puzzelsPrice = puzzels * 2.60;
//            double dollsPrice = dolls * 3;
//            double bearsPrice = bears * 4.10;
//            double minionsPrice = minions * 8.20;
//            double trucksPrice = trucks * 2;

//            int toys = puzzels + dolls + bears + minions + trucks;
//            double totalPrice = puzzelsPrice + dollsPrice + bearsPrice + minionsPrice + trucksPrice;

//            if (toys >= 50)
//            {
//                totalPrice -= (totalPrice * 25 / 100.00);
//            }

//            double rent = totalPrice * 0.1;
//            double total = totalPrice - rent;
           

//            if (total >= tripCosts)
//            {
//                Console.WriteLine($"Yes! {(total - tripCosts):F2} lv left.");
//            }
//            else
//            {
//                Console.WriteLine($"Not enough money! {(tripCosts - total):F2} lv needed.");
//            }
//        }
//    }

//}