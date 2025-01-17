﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPmedHenrikogKim
{
    internal class Main
    {
        List<Store> stores = new List<Store>()
        {
            new("Kiwi", "Food", 1),
            new("Meny", "Food", 3),
            new("Mega", "Food", 2),
            new("ExtraLeker", "Toys", 1),
            new("Yes!", "Toys", 3),
            new("Toys'r us", "Toys", 2),
            new("Lindex", "Clothes", 2),
            new("H&M", "Clothes", 1),
            new("LV", "Clothes", 3)
        };

        public Main()
        {
            MainMenu();
        }

        public void MainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Welcome to storeApp what do you wanna do?");
                Console.WriteLine("1: Search for stores based on price class");
                Console.WriteLine("2: Search for stores based on type");
                Console.WriteLine("3: Search for stores based on type AND price");
                Console.WriteLine("4: Add store to list");
                Console.WriteLine("5: Print all stores");
                Console.WriteLine("Q: Quit");
                string input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "1":
                        SearchByPriceClass();
                        Console.ReadKey();
                        break;
                    case "2":
                        SearchByType();
                        Console.ReadKey();
                        break;
                    case "3":
                        SearchNameAndType();
                        Console.ReadKey();
                        break;
                    case "4":
                        AddStore();
                        Console.ReadKey();
                        break;
                    case "5":
                        PrintAllStores();
                        Console.ReadKey();
                        break;
                    case "q":
                         return;
                    default:
                        MainMenu();
                        break;

                }
            }
        }


        void SearchByPriceClass()
        {
            Console.WriteLine("Price Level:");
            var input = Console.ReadLine();
            int i = Convert.ToInt32(input);
            foreach (Store store in stores)
            {
                if (i == store._priceLvl)
                { Console.WriteLine($" Name: {store._name} Type: {store._type} PriceLevel: {store._priceLvl}"); }
            };
        }
        void SearchByType()
        {
            Console.WriteLine("Store Type:");
            string input = Console.ReadLine();
            foreach (Store store in stores)
            {
                if (input == store._type) { Console.WriteLine($" Name: {store._name} Type: {store._type} PriceLevel: {store._priceLvl}"); }

            }
        }
        void SearchNameAndType()
        {
            Console.WriteLine("Store Type:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Price Level:");
            string input2 = Console.ReadLine();
            int int2 = Convert.ToInt32(input2);
            foreach (Store store in stores)
            {
                if (input1 == store._type && int2 == store._priceLvl)
                { Console.WriteLine($" Name: {store._name} Type: {store._type} PriceLevel: {store._priceLvl}"); }
            }
        }
        void AddStore()
        {
            Console.WriteLine("Name of store:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Store type:");
            string input2 = Console.ReadLine();
            Console.WriteLine("Store price level:");
            string input3 = Console.ReadLine();
            int int3 = Convert.ToInt32(input3);
            Store store = new Store(input1, input2, int3);
            stores.Add(store);
            Console.WriteLine(stores.Last()._name);
        }
        void PrintAllStores()
        {
            foreach (Store store in stores)
            {
                Console.WriteLine($" Name: {store._name} Type: {store._type} PriceLevel: {store._priceLvl}");
            }
        }

        // alternative Search function:

        /* void Search() 
         {
             Console.WriteLine("Store Type:");
             string input1 = Console.ReadLine();
             Console.WriteLine("Price Level:");
             string input2 = Console.ReadLine();
             int int2 = Convert.ToInt32(input2);
             foreach (Store store in stores)
             {
                 if (input1 == store._type && int2 == store._priceLvl)
                 { Console.WriteLine($" Name: {store._name} Type: {store._type} PriceLevel: {store._priceLvl}"); }
                 else if (input1 == store._type && int2 == null)
                 {
                     Console.WriteLine($" Name: {store._name} Type: {store._type} PriceLevel: {store._priceLvl}");
                 }
                 else if (input1 == "" || input2 == null && int2 != null)
                 {
                     if (int2 == store._priceLvl) {
                         Console.WriteLine($" Name: {store._name} Type: {store._type} PriceLevel: {store._priceLvl}");
                     }
                 }
             }
         }*/
    }
}
