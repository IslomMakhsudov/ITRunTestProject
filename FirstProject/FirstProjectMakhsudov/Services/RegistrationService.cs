namespace PetShop.Services
{
    public class RegistrationService
    {
        public Person PersonRegistration()
        {
            var person = new Person();
            var database = new Database(); 
            
            person.Login = "Login";
            person.Password = "1234";

            person.UserName = "Andrey";
            person.Age = 19;
            person.PhoneNumber = "+1234567890";

            database.AddPerson(person);

            return person;
        }
    }
}
