using PetShop.Models;

namespace PetShop.Services
{
    public class Database
    {
        Dictionary<int, Person> people = new();
        Dictionary<int, Cat> cats = new();
        Dictionary<int, Dog> dogs = new();

        public void AddPerson(Person person)
        {
            people.Add(person.Id, person);
        }

        public Person? GetPerson(int id)
        {
            if(people.ContainsKey(id))
                return people[id];
            return null;
        }

        public List<Person> GetAllPersons()
        {
            return people.Values.ToList();
        }

        public void AddCat(Cat country)
        {
            cats.Add(country.Id, country);
        }

        public Cat? GetCat(int id)
        {
            if (cats.ContainsKey(id))
                return cats[id];
            return null;
        }

        public List<Cat> GetCatsByBreed(int id)
        {
            return (List<Cat>)cats.Where(cat => cat.Value.BreedId == id);
        }

        public void AddCDog(Dog city)
        {
            dogs.Add(city.Id, city);
        }

        public Dog? GetDog(int id)
        {
            if( dogs.ContainsKey(id))
                return dogs[id];
            return null;
        }

        public List<Dog> GetDogsByBreed(int id)
        {
            return (List<Dog>)dogs.Where(dog => dog.Value.BreedId == id);
        }
    }
}
