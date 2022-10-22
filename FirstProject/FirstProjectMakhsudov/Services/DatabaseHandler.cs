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

            _database.AddCity(new Dog { Name = "Khujand" });
            _database.AddCity(new Dog { Name = "Dushanbe" });
            _database.AddCity(new Dog { Name = "Isfara" });
            _database.AddCity(new Dog { Name = "Konibodom" });
            _database.AddCity(new Dog { Name = "Mastcho" });
            _database.AddCity(new Dog { Name = "Zafarobod" });
            _database.AddCity(new Dog { Name = "Spitamen" });

            _database.AddCountry(new Cat { Name = "Tajikistan"});
            _database.AddCountry(new Cat { Name = "Russia"});
            _database.AddCountry(new Cat { Name = "USA"});
            _database.AddCountry(new Cat { Name = "Japan"});
        }
    }
}
