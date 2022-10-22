using PetShop.Models;

namespace PetShop.Services
{
    public class Database
    {
        Dictionary<int, Person> _people = new();
        Dictionary<int, Cat> _countries = new();
        Dictionary<int, Dog> _cities = new();

        public void AddPerson(Person person)
        {
            _people.Add(person.Id, person);
        }

        public Person? GetPerson(int id)
        {
            if(_people.ContainsKey(id))
                return _people[id];
            return null;
        }

        public List<Person> GetAllPersons()
        {
            return _people.Values.ToList();
        }

        public void AddCountry(Cat country)
        {
            _countries.Add(country.Id, country);
        }

        public Cat? GetCountry(int id)
        {
            if (_countries.ContainsKey(id))
                return _countries[id];
            return null;
        }

        public void AddCity(Dog city)
        {
            _cities.Add(city.Id, city);
        }

        public Dog? GetCity(int id)
        {
            if( _cities.ContainsKey(id))
                return _cities[id];
            return null;
        }
    }
}
