using System;
namespace method_exercises
{
    public class Method
    {
        public static void MadLib()
        {
            Console.Write("Welcome to Exercise 1\nLet's write a funny story!\nEnter a name: ");
            var name = Console.ReadLine();

            Console.Write("Enter a verb: ");
            var verb = Console.ReadLine();

            Console.Write("Enter an animal: ");
            var animal = Console.ReadLine();

            Console.Write("Enter a food: ");
            var food = Console.ReadLine();

            Console.Write("Enter an adjective: ");
            var adjective = Console.ReadLine();

            string story = $"\n{name} went to the pet store to purchase a pet {animal}.\nAfter leaving the pet store, {name} assumed the {animal} was hungry because it was {adjective}, so {name} offered the {animal} some {food}.\nAfter eating all of the {food}, {name} and {animal} walked home to meet the rest of the family.";
            Console.Write(story);
        }
    }
}

