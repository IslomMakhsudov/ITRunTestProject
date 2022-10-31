namespace PetShop.Services
{
    public class LoginService
    {
        private readonly Database database;
        public LoginService(Database database)
        {
            this.database = database;
        }
        public bool PersonLogin(string password, string login)
        {
            var person = database.GetAllPersons().FirstOrDefault(x => x.Login == login && x.Password == password);
            if (person is null)
                return false;
            return true;
        }
    }
}
