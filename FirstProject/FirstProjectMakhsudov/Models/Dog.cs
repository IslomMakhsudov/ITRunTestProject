using PetShop.Services;

namespace PetShop.Models
{
    public class Dog
    {
        public int Id { get; set; } = ++Global.DogId;
        public string Name { get; set; } = string.Empty;
        public int BreedId { get; set; }

    }
}
