using PetShop.Models;

namespace PetShop.Services
{
    public class DatabaseHandler
    {
        Database _database;
        public DatabaseHandler(Database database)
        {
            _database = database;
            FillDatabase();
        }

        public void FillDatabase()
        {
            _database.AddPerson(new Person { UserName = "tom", Login = "tom1", Password = "12345" });
            _database.AddPerson(new Person { UserName = "max", Login = "max1", Password = "12345" });
            _database.AddPerson(new Person { UserName = "ben", Login = "ben1", Password = "12345" });
        }
    }
}
