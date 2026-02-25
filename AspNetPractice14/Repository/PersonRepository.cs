using AspNetPractice14.Models;
using System.Reflection.Metadata.Ecma335;

namespace AspNetPractice14.Repository
{
    public class PersonRepository
    {
        private readonly List<Person> _persons = new List<Person>
        {
            new Person("person1@gmail.com", "12345"),
            new Person("person2@gmail.com", "12345")
        };

        public IEnumerable<Person> GetAll() => _persons;
    }
}
