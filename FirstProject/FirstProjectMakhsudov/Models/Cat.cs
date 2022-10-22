using PetShop.Services;

namespace PetShop.Models
{
    public class Cat
    {
        public int Id { get; set; } = ++Global.CatId;
        public string Name { get; set; } = string.Empty;
    }
}
