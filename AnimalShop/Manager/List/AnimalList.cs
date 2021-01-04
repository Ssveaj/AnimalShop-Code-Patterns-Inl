using System;
using System.Collections.Generic;


namespace AnimalShop
{

    public class AnimalList
    {   
        public static List<IAnimal> GetListOfAnimals()
        {
            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(new Cat(Animal.Cat, "Tarzan", Gender.Male, Color.White));
            animals.Add(new Fish(Animal.Fish, "Bumbo", Gender.Female, Color.Red));
            animals.Add(new Snake(Animal.Snake, "Buzzer", Gender.Female, Color.Black));

            return animals;
        }
        public static void PrintAnimals()
        {
            var animals = GetListOfAnimals(); // Hämtar metoden ovanför och loopar genom listan.
            foreach (var item in animals)
            {
                Console.WriteLine(" Type: " + item.Type + ".\n"
                                 + " Name: " + item.Name + ".\n"
                                 + " Gender: " + item.Gender + ".\n"
                                 + " Color: " + item.Color + ".\n"
                                 );
            }
        }
    }
}