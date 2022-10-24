using PetShop.Models;

namespace PetShop.Services
{
    public class Database
    {
        List<Person> people = new();
        List<Cat> cats = new();
        List<Dog> dogs = new();

        public void AddPerson(Person person)
        {
            people.Add(person);
        }

        public Person? GetPerson(int id)
        {
            if (people.FirstOrDefault(x => x.Id == id) != null)
                return people[id];
            return null;
        }

        public List<Person> GetAllPersons()
        {
            return people;
        }

        public void AddCat(Cat country)
        {
            cats.Add(country);
        }

        public Cat? GetCat(int id)
        {
            if (cats.FirstOrDefault(x => x.Id == id) != null)
                return cats[id];
            return null;
        }

        public List<Cat> GetCatsByBreed(int id)
        {
            return (List<Cat>)cats.Where(cat => cat.BreedId == id);
        }

        public void AddCDog(Dog dog)
        {
            dogs.Add(dog);
        }

        public Dog? GetDog(int id)
        {
            if (dogs.FirstOrDefault(x => x.Id == id) != null)
                return dogs[id];
            return null;
        }

        public List<Dog> GetDogsByBreed(int id)
        {
            return (List<Dog>)dogs.Where(dog => dog.BreedId == id);
        }
    }
}
