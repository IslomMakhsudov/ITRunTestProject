namespace PetShop.Models.Dto
{
    public class RegistrationDto
    {
        public string UserName { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public int Age { get; set; }
    }
}
