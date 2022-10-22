using PetShop.Services;

namespace PetShop.Models
{
    public class Cat
    {
        public int Id { get; set; } = ++Global.CatId;
        public int Age { get; set; }
        public int BreedId { get; set; }
    }
}
