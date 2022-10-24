using PetShop.Models.Dto;

namespace PetShop.Services
{
    public class RegistrationService
    {
        private readonly Database database;
        public RegistrationService(Database database)
        {
            this.database = database;
        }
        public Person PersonRegistration(RegistrationDto registration)
        {
            var person = new Person
            {
                Login = registration.Login,
                Password = registration.Password,
                UserName = registration.UserName,
                Age = registration.Age,
                PhoneNumber = registration.PhoneNumber
            };

            database.AddPerson(person);

            return person;
        }
    }
}
