

namespace AnimalShop
{
    public class Validation
    {
        public static void TheUserPicksOneAnimal() 
        {
            Activity.AskUserWhatOfAnimals(); 
            Activity.UserPicksOneChoice();      
        }      
        public static void TheUserPicksOneActivityForCat() 
        {          
            Activity.AskUserWhatToDoWithTheCat(); 
            Activity.UserPicksWhatToDoWithCat(); 
        } 
        public static void TheUserPicksOneActivityForFish()
        {
            Activity.AskUserWhatToDoWithTheFish();
            Activity.UserPicksWhatToDoWithFish();
        } 
        public static void TheUserPicksOneActivityForSnake()
        {
            Activity.AskUserWhatToDoWithTheSnake();
            Activity.UserPicksWhatToDoWithSnake();
        } 
    }
}
