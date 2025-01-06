using System;
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
            foreach (Store store in stores) { if (store._priceLvl == 1) { Console.WriteLine(store._name); }; }
        }
    }
}
