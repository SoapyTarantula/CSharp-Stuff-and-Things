using System;

namespace ConsoleTestApp
{
    partial class Program
    {
        static void Main()
        {
            var duder = new Person();
            var otherDude = new Person();
            PersonPrinter(duder);
            Console.WriteLine("");
            PersonPrinter(otherDude);
            Console.ReadKey(true);
        }

        public static void PersonPrinter(Person p1)
        {
            // name
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(p1.name);
            Console.ResetColor(); // Resets the color of the text to the default.
            Console.WriteLine(""); // Add some whitespace.
            // diet
            Console.WriteLine(p1.name + " consumes mostly " + p1.diet);
            // eyes
            if (p1.eyes == 0) { Console.WriteLine(p1.name + " has no eyes."); }
            else if (p1.eyes == 1) { Console.WriteLine(p1.name + " has 1 eye."); }
            else { Console.WriteLine(p1.name + " has " + p1.eyes + " eyes."); }
            // arms
            if (p1.arms == 0) { Console.WriteLine(p1.name + " has no arms."); }
            else if (p1.arms == 1) { Console.WriteLine(p1.name + " has 1 arm."); }
            else { Console.WriteLine(p1.name + " has " + p1.arms + " arms."); }
            // hands
            if (p1.hands == 0) { Console.WriteLine(p1.name + " has no hands."); }
            else if (p1.hands == 1) { Console.WriteLine(p1.name + " has 1 hand."); }
            else { Console.WriteLine(p1.name + " has " + p1.hands + " hands."); }
            // fingers
            if (p1.fingers == 0) { Console.WriteLine(p1.name + " has no fingers."); }
            else if (p1.fingers == 1) { Console.WriteLine(p1.name + " has 1 finger."); }
            else { Console.WriteLine(p1.name + " has " + p1.fingers + " fingers."); }
            // legs
            if (p1.legs == 0) { Console.WriteLine(p1.name + " has no legs."); }
            else if (p1.legs == 1) { Console.WriteLine(p1.name + " has 1 leg."); }
            else { Console.WriteLine(p1.name + " has " + p1.legs + " legs."); }
            // feet
            if (p1.feet == 0) { Console.WriteLine(p1.name + " has no feet."); }
            else if (p1.feet == 1) { Console.WriteLine(p1.name + " has 1 foot."); }
            else { Console.WriteLine(p1.name + " has " + p1.feet + " feet."); }
            // toes
            if (p1.toes == 0) { Console.WriteLine(p1.name + " has no toes."); }
            else if (p1.toes == 1) { Console.WriteLine(p1.name + " has 1 toes."); }
            else { Console.WriteLine(p1.name + " has " + p1.toes + " toes."); }
        }
    }
}
