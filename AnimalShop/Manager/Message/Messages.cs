using System;
using System.Threading;


namespace AnimalShop
{
    public class Messages
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to Animal Shop!\n");
        }
        public static void GivingInformation()
        {
            Console.WriteLine("Our animals live here\n");
            AnimalList.PrintAnimals(); // Hämtar listan på djur.        
        }
        public static void CloseTheShop()
        {
            Console.WriteLine("\nWe have to close the shop. Please go to exit door\n");
            Thread.Sleep(3000);
            Console.Clear();
        }
        public static void GoodBye()
        {
            Console.WriteLine("Have a nice day. Good Bye!");
            Console.ReadLine();
        }
    }
}
