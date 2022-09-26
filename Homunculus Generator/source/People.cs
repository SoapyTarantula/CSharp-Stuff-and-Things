using System;

namespace PeopleLibrary
{
    public class People
    {
        public static String GetPerson() 
        {
            string[] nameArray = { "Mokiro Kuzen", "Laced Azalea", "Nia Kohana", "Isabella Esperia", "Ophelia Vexx", "Jessie Zaeora", "Rosaria Shinozaki", "Sai Hamori", "Macaroni Bowl", "Doctor Dubu", "Rustie Yiffany", "Danny Naoko", "Cheap Shot", "Tea Oolong", "Flash Reaper", "Kait Oreal", "Nellie Antoinette", "Seraph Bell", "Zen Rancor", "Myras Gunhilda", "Slumpy Wing" };
            var i = new Random().Next(nameArray.Length);
            return nameArray[i];
        }
    }
}

