using System;
using PeopleLibrary; // dll reference for names
using FoodLibrary; // dll reference for food types

namespace HomunculusGenerator
{
    public class Person
    {
        readonly static Random rand = new Random();
        public int arms, legs, eyes, hands, feet = 0;
        public float fingers, toes = 0;
        public string name, diet;


        // Blank constructor which grabs a name from PeopleLibrary.dll
        public Person() 
        {
            this.name = People.GetPerson();
            GiveMeBodyParts(this);
        }

        // Constructor with a name string
        public Person(string whatIsMyName)
        {
            this.name = whatIsMyName;
            GiveMeBodyParts(this);
        }

        private void GiveMeBodyParts(Person _person)
        {
            _person.diet = Food.GetFood();
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
