using PetShop.Services;

namespace PetShop.Models
{
    public class Cat : Animal
    {
        public int Id { get; set; } = ++Global.CatId;

    }
}
