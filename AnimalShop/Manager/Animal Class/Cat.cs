using System;
using System.Threading;

namespace AnimalShop
{
    public class Cat : ICat 
    {
        public Animal Type {get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Color Color { get; set; }
        public Cat()
        {
        }
        public Cat(Animal type, string name, Gender gender, Color color)
        {
            Type = type;
            Name = name;
            Gender = gender;
            Color = color;
        }
        public void BrushTheCat()
        {
           var animals = AnimalList.GetListOfAnimals();
           foreach (var item in animals)
           {
               if (item.Type == Animal.Cat)
               {
                   Console.WriteLine($"You are brushing {item.Name}");
                   Thread.Sleep(2000);
               }
           }
        }
        public void Feed()
        {
           var animals = AnimalList.GetListOfAnimals();
           foreach (var item in animals)
           {
               if (item.Type == Animal.Cat)
               {
                   Console.WriteLine($"You are feeding the {item.Type + ", " + item.Name} with Whiskas");
                   Thread.Sleep(2000);
               }
           }
        }
        public void Play()
        {
            var animals = AnimalList.GetListOfAnimals();
            foreach (var item in animals)
            {
                if (item.Type == Animal.Cat)
                {
                    Console.WriteLine($"You are playing {Color.Yellow} rat toy with {item.Name}");
                    Thread.Sleep(2000);
                }
            }
        }
    }
}