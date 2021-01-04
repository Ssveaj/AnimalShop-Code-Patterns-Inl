using System;
using System.Threading;

namespace AnimalShop
{
    public class Activity
    {
        public static void AskUserWhatOfAnimals() 
        {
            Console.WriteLine("What of them do you want to meet? Cat/Fish/Snake");
        }
        public static void UserPicksOneChoice()
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "Cat":
                    Console.WriteLine("You want to meet cat...\n");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                case "Fish":
                    Console.WriteLine("You want to meet fish...\n");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                case "Snake":
                    Console.WriteLine("You want to meet snake...\n");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("We don't have it...\n");
                    break;
            }
            if (input == "Cat")
            {
                Validation.TheUserPicksOneActivityForCat();
            }
            else if (input == "Fish")
            {
                Validation.TheUserPicksOneActivityForFish();
            }
            else if (input == "Snake")
            {
                Validation.TheUserPicksOneActivityForSnake();
            }
            else
            {
                Console.WriteLine("Try again...");
                Thread.Sleep(2000);
                Console.Clear();
                Validation.TheUserPicksOneAnimal();
            }
        }
        public static void AskUserWhatToDoWithTheCat()
        {
            Console.WriteLine("What do you want to do?\n");
            Console.WriteLine("Feed, Play or Brush\n");
        }
        public static void UserPicksWhatToDoWithCat()
        {
            var cat = new Cat();

            string input = Console.ReadLine();
            switch (input)
            {
                case "Feed":
                    Console.WriteLine("You want to feed...\n");
                    Thread.Sleep(2000);
                    break;
                case "Play":
                    Console.WriteLine("You want to play...\n");
                    Thread.Sleep(2000);
                    break;
                case "Brush":
                    Console.WriteLine("You want to brush...\n");
                    Thread.Sleep(2000);
                    break;
                default:
                    Console.WriteLine("You can't do that...\n");
                    break;
            }
            if (input == "Feed")
            {
                cat.Feed();
            }
            else if (input == "Play")
            {
                cat.Play(); // hämtar från cat klassen eller snarare interface.. 
            }
            else if (input == "Brush")
            {
                cat.BrushTheCat();
            }
            else
            {
                Console.WriteLine("Try again...");
                Thread.Sleep(2000);
                Console.Clear();
                Validation.TheUserPicksOneActivityForCat();
            }
        }
        public static void AskUserWhatToDoWithTheFish()
        {
            Console.WriteLine("What do you want to do?\n");
            Console.WriteLine("Feed, Play or Clean\n");
        }
        public static void UserPicksWhatToDoWithFish()
        {
            var fish = new Fish();

            string input = Console.ReadLine();
            switch (input)
            {
                case "Feed":
                    Console.WriteLine("You want to feed...\n");
                    Thread.Sleep(2000);
                    break;
                case "Play":
                    Console.WriteLine("You want to play...\n");
                    Thread.Sleep(2000);
                    break;
                case "Clean":
                    Console.WriteLine("You want to clean...\n");
                    Thread.Sleep(2000);
                    break;
                default:
                    Console.WriteLine("You can't do that...\n");
                    break;
            }
            if (input == "Feed")
            {
                fish.Feed();
            }
            else if (input == "Play")
            {
                fish.Play();
            }
            else if (input == "Clean")
            {
                fish.CleanTheAquarium();
            }
            else
            {
                Console.WriteLine("Try again...");
                Thread.Sleep(2000);
                Console.Clear();
                Validation.TheUserPicksOneActivityForFish();
            }
        }
        public static void AskUserWhatToDoWithTheSnake()
        {
            Console.WriteLine("What do you want to do?\n");
            Console.WriteLine("Feed, Play or Lift\n");
        }
        public static void UserPicksWhatToDoWithSnake()
        {
            var snake = new Snake();

            string input = Console.ReadLine();
            switch (input)
            {
                case "Feed":
                    Console.WriteLine("You want to feed...\n");
                    Thread.Sleep(2000);
                    break;
                case "Play":
                    Console.WriteLine("You want to play...\n");
                    Thread.Sleep(2000);
                    break;
                case "Lift":
                    Console.WriteLine("You want to lift...\n");
                    Thread.Sleep(2000);
                    break;
                default:
                    Console.WriteLine("You can't do that...\n");
                    break;
            }
            if (input == "Feed")
            {
                snake.Feed();
            }
            else if (input == "Play")
            {
                snake.Play();
            }
            else if (input == "Lift")
            {
                snake.HoldingTheSnakeAroundNeck();
            }
            else
            {
                Console.WriteLine("Try again...");
                Thread.Sleep(2000);
                Console.Clear();
                Validation.TheUserPicksOneActivityForSnake();
            }
        }
    }          
}
