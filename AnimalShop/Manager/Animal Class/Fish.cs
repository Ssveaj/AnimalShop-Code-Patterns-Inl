using System;
using System.Threading;


namespace AnimalShop
{
    public class Fish : IFish
    {
        public Animal Type { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Color Color { get; set; }
        public Fish()
        {
        }
        public Fish(Animal type, string name, Gender gender, Color color)
        {
            Type = type;
            Name = name;
            Gender = gender;
            Color = color;
        }
        public void CleanTheAquarium()
        {
            var animals = AnimalList.GetListOfAnimals();
            foreach (var item in animals)
            {
                if (item.Type == Animal.Fish)
                {
                    Console.WriteLine($"You are cleaning the aquarium. {item.Name} is happy.");
                    Thread.Sleep(2000);
                }
            }
        }
        public void Feed()
        {
            var animals = AnimalList.GetListOfAnimals();
            foreach (var item in animals)
            {
                if (item.Type == Animal.Fish)
                {
                    Console.WriteLine($"You are feeding {item.Name} with worms.");
                    Thread.Sleep(2000);
                }
            }
        }
        public void Play()
        {
            var animals = AnimalList.GetListOfAnimals();
            foreach (var item in animals)
            {
                if (item.Type == Animal.Fish)
                {
                    Console.WriteLine($"You are playing the net with {item.Name}");
                    Thread.Sleep(2000);
                }
            }
        }
    }
}