using System;

namespace FoodLibrary
{
    public class Food
    {
        public static String GetFood() 
        {
            string[] dietArray = { "chicken noodle soup.", "toast.", "candy.", "existential dread.", "nectarines.", "fish.", "apples.", "beef.", "french onion soup.", "various meats.", "inedible substances.", "free samples at the department store.", "plants.", "sunshine.", "ramen.", "pho.", "sushi.", "pizza rolls.", "spaghetti.", "Lalafell flesh.", "dirt.", "a cool rock they found.", "nothing but air.", "the lifeforce of others around them.", "macaroni." };
            var i = new Random().Next(dietArray.Length);
            return dietArray[i];
         }
    }
}
