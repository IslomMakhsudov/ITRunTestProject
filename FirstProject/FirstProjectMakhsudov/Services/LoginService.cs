namespace PetShop.Services
{
    public class LoginService
    {
        private readonly Database database;
        public LoginService(Database database)
        {
            this.database = database;
        }
        public string PersonLogin(HttpRequest httpRequest)
        {
            var person = database.GetAllPersons().FirstOrDefault(x => x.Login == httpRequest.Query["Login"] && x.Password == httpRequest.Query["Password"]);
            if (person is null)
                return "/Values/registration";

            return "/Values";
        }
    }
}
