using PetShop.Models;

namespace PetShop.Services
{
    public class DatabaseHandler
    {
        Database _database;
        public DatabaseHandler(Database database)
        {
            _database = database;
        }

        public void FillDatabase()
        {
            _database.AddPerson(new Person { UserName = "tom", Login = "tom1", Password = "12345" });
            _database.AddPerson(new Person { UserName = "max", Login = "max1", Password = "12345" });
            _database.AddPerson(new Person { UserName = "ben", Login = "ben1", Password = "12345" });

            _database.AddCity(new City { Name = "Khujand" });
            _database.AddCity(new City { Name = "Dushanbe" });
            _database.AddCity(new City { Name = "Isfara" });
            _database.AddCity(new City { Name = "Konibodom" });
            _database.AddCity(new City { Name = "Mastcho" });
            _database.AddCity(new City { Name = "Zafarobod" });
            _database.AddCity(new City { Name = "Spitamen" });

            _database.AddCountry(new Country { Name = "Tajikistan"});
            _database.AddCountry(new Country { Name = "Russia"});
            _database.AddCountry(new Country { Name = "USA"});
            _database.AddCountry(new Country { Name = "Japan"});
        }
    }
}
