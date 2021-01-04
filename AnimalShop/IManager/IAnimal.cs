

namespace AnimalShop
{
    public interface IAnimal
    {
       public Animal Type {get;set;} 
       public string Name { get; set; }
       public Gender Gender { get; set; }
       public Color Color { get; set; }

       public void Feed();
       public void Play();
       
    }
}