using System;

namespace ConsoleTestApp
{
    public class Person
    {
        readonly static Random rand = new Random();
        public int arms, legs, eyes, hands, feet = 0;
        public float fingers, toes = 0;
        public string name, diet;
        public string[] dietArray = { "soup.", "toast.", "candy.", "nectarines.", "fish.", "apples.", "beef.", "various meats.", "inedible substances.", "free samples at the department store.", "plants.", "sunshine.", "ramen.", "pho.", "sushi.", "pizza rolls.", "spagheti." };
        public string[] nameArray = {"Mokiro Kuzen", "Laced Azalea", "Nia Kohana", "Isabella Esperia", "Ophelia Vexx", "Jessie Zaeora", "Rosaria Shinozaki", "Sai Hamori", "Macaroni Bowl", "Doctor Dubu", "Rustie Yiffany", "Danny Naoko", "Cheap Shot", "Tea Oolong", "Flash Reaper", "Kait Oreal"};

        public Person() 
        {
            int indexOfNames = rand.Next(nameArray.Length);
            this.name = nameArray[indexOfNames];
            GiveMeBodyParts(this);
        }

        public Person(string whatIsMyName)
        {
            this.name = whatIsMyName;
            GiveMeBodyParts(this);
        }

        private void GiveMeBodyParts(Person _person)
        {
            int indexOfDiet = rand.Next(dietArray.Length);
            _person.diet = dietArray[indexOfDiet];
            _person.arms = rand.Next(0, 4);
            _person.legs = rand.Next(0, 4);
            _person.eyes = rand.Next(0, 4);
            _person.hands = rand.Next(0, 4);
            _person.feet = rand.Next(0, 4);
            _person.fingers = rand.Next(0, 16);
            _person.toes = rand.Next(0, 20);
        }
    }
}
