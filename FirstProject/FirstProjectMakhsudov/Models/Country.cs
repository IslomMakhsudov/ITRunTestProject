using PetShop.Services;

namespace PetShop.Models
{
    public class Country
    {
        public int Id { get; set; } = ++Global.CountryId;
        public string Name { get; set; } = string.Empty;
    }
}
