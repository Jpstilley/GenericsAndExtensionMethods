using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var food = new Storage<Food>();
            var boxes = new Storage<Boxes>();

            var lunchMeat = new Food("Turkey");
            var pizza = new Food("Supreme Pizza");
            var iceCream = new Food("Chocolate-chip Cookie Dough Ice Cream");
            var foodStorage = new Storage<Food>(lunchMeat, pizza, iceCream);

            var gloves = new Boxes("Nitrile Gloves");
            var mopHeads = new Boxes("Swiffer Mop Heads");
            var groceryBags = new Boxes("Plastic Bags");
            var boxStorage = new Storage<Boxes>(gloves, mopHeads, groceryBags);

            foreach(var foodItem in foodStorage.Bin)
            {
                Console.WriteLine(foodItem.Name);
            }
            Console.WriteLine();

            foreach(var boxItem in boxStorage.Bin)
            {
                Console.WriteLine(boxItem.Name);
            }
            Console.WriteLine();

            var word1 = "Food";
            var word2 = "Treaty";

            Console.WriteLine(word1.Pluralize());
            Console.WriteLine(word2.Pluralize() + "\n");

            int[] array = { 1, 4, 2, 6, 3, 78, 4, 9, 5, 43 };
            array = array.SortArray();

            Array.ForEach(array, value => Console.WriteLine(value));

            Console.ReadKey();
        }
    }
}
