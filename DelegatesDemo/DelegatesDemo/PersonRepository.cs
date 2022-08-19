using Bogus;

namespace DelegatesDemo
{
    public class PersonRepository
    {
        public IEnumerable<Person> GetAllPersons()
        {
            var persons = new Faker<Person>()
                .CustomInstantiator(f =>
                new Person(
                    f.IndexVariable++,
                    f.Name.FirstName(),
                    f.Name.LastName(),
                    f.Date.PastOffset(60, DateTime.Now.AddYears(-10)).Date
                    )
                )
                .Generate(100);

            return persons;
        }
    }
}
