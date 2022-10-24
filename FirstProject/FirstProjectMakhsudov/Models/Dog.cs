using PetShop.Services;

namespace PetShop.Models
{
    public class Dog : Animal
    {
        public int Id { get; set; } = ++Global.DogId;
    }
}
