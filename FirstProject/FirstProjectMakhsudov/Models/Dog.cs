using PetShop.Services;

namespace PetShop.Models
{
    public class Dog
    {
        public int Id { get; set; } = ++Global.DogId;
        public int Age { get; set; }
        public int BreedId { get; set; }

    }
}
