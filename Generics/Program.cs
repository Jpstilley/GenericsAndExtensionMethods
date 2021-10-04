using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace Generics
{
    class Program
    {
        //Generics
        //TODO Create a class called "Storage" that has a generic Type "T". Set a constraint to for the type so that T must conform to IStorable.
        //TODO In your class create a property List called "Bin". Set the list type to "T".
        //TODO Create two more classes. One class called "Boxes". The second class called "Food". Both classes will conform to IStoreable interface.
        //TODO create two instances of type Storage in the Main method. First Instance will hold type "<Boxes>". The second instance will hold "<Food>".
        //TODO create some instanes of type Food and Equipment and Add them the correct storage bins.

        




        static void Main(string[] args)
        {
            var food = new Storage<Food>();
            var boxes = new Storage<Boxes>();

            var lunchMeat = new Food();
            var pizza = new Food();
            var iceCream = new Food();

            var gloves = new Boxes();
            var mopHeads = new Boxes();
            var groceryBags = new Boxes();

            food.Bin.Add(lunchMeat);
            food.Bin.Add(pizza);
            food.Bin.Add(iceCream);

            boxes.Bin.Add(gloves);
            boxes.Bin.Add(mopHeads);
            boxes.Bin.Add(groceryBags);

            var word1 = "Food";
            var word2 = "Treaty";

            Console.WriteLine(word1.Pluralize());
            Console.WriteLine(word2.Pluralize() + "\n");

            int[] array = { 1, 4, 2, 6, 3, 78, 4, 9, 5, 43 };
            array = array.SortArray();

            Array.ForEach(array, value => Console.WriteLine(value));

            Console.ReadKey();
        }
      

        //ExtensionMethods
        //TODO Create a static class called "ExtensionMethods"
        //TODO in your new class create a static extension method called "pluralize" this method should take a string and add an s to the end of it. (***BONUS*** if string ends in y you can replace y with ies to pluralize it)

        //TODO Create an extension method called "SortArray". This method will take an array of type T. Then it will use a LINQ statement to OrderBy.
        //TODO call both extension methods in the Main. Use the method on the numbers Array.


    }
}
