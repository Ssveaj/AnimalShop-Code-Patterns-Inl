
namespace AnimalShop
{
    class Program
    {
        static void Main(string[] args)
        {          
            Messages.Welcome(); 
            Messages.GivingInformation(); 
            Validation.TheUserPicksOneAnimal();
            Messages.CloseTheShop();
            Messages.GoodBye();
        }
    }
}