using System;

namespace FoodLibrary
{
    public class Food
    {
        readonly private static Random randomNum = new Random();
        public static String GetFood() 
        {
            string[] dietArray = { "chicken noodle soup.", "toast.", "candy.", "existential dread.", "nectarines.", "fish.", "apples.", "beef.", "french onion soup.", "various meats.", "inedible substances.", "free samples at the department store.", "plants.", "sunshine.", "ramen.", "pho.", "sushi.", "pizza rolls.", "spaghetti.", "Lalafell flesh.", "dirt.", "a cool rock they found." };
            var i = randomNum.Next(0, dietArray.Length);
            return dietArray[i];
         }
    }
}
