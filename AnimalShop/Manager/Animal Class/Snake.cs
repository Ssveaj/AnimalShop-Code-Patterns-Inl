using System;
using System.Threading;


namespace AnimalShop
{
    public class Snake : ISnake
    {
        public Animal Type { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Color Color { get; set; }
        
        public Snake()
        {
        }
        public Snake(Animal type, string name, Gender gender, Color color)
        {
            Type = type;
            Name = name;
            Gender = gender;
            Color = color;
        }
        public void HoldingTheSnakeAroundNeck()
        {
            var animals = AnimalList.GetListOfAnimals();
            foreach (var item in animals)
            {
                if (item.Type == Animal.Snake)
                {
                    Console.WriteLine($"You are holding {item.Name} around neck\n");
                    Thread.Sleep(3000);
                    Console.WriteLine($"We are going to take a picture of you and {item.Name}");
                    Thread.Sleep(3000);
                    Console.WriteLine("Smile!");
                    Thread.Sleep(2000);
                    Console.WriteLine("***Click***");
                    Thread.Sleep(2000);
                }
            }
        }
        public void Feed()
        {
            var animals = AnimalList.GetListOfAnimals();
            foreach (var item in animals)
            {
                if (item.Type == Animal.Snake)
                {
                    Console.WriteLine($"You are feeding {item.Name} with {Color.White} rats");
                    Thread.Sleep(2000);
                }
            }
        }
        public void Play()
        {
            var animals = AnimalList.GetListOfAnimals();
            foreach (var item in animals)
            {
                if (item.Type == Animal.Snake)
                {
                    Console.WriteLine($"You are playing with {item.Name}");
                    Thread.Sleep(2000);
                }
            }
        }
    }
}