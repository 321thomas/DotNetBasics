namespace DelegatesDemo
{
    public delegate bool StringPredicate(Person p, string s);

    public class PersonService
    {

        PersonRepository _personRepository;
        public PersonService()
        {
            _personRepository = new PersonRepository();
        }

        public IEnumerable<Person> GetPersonsByMinAge(int age)
        {
            var currentYear = DateTime.Now.Year;
            foreach (var person in _personRepository.GetAllPersons())
            {
                if (currentYear - person.DateOfBirth.Year >= age)
                {
                    yield return person;
                }
            }
        }

        public IEnumerable<Person> GetPersonsWithLastNameStartingWith(string startingWith)
        {
            foreach (var person in _personRepository.GetAllPersons())
            {
                if (person.LastName.StartsWith(startingWith))
                {
                    yield return person;
                }
            }
        }

        // TODO: implement a method that returns all Persons with FirstName starting with parameter of method
        public IEnumerable<Person> GetPersonsWithFirstNameStartingWith(string startingWith)
        {
            throw new NotImplementedException();
        }

        // TODO: implement method, WITHOUT(!) any LINQ statements but using delegate as input parameter
        public IEnumerable<Person> FilterPersons()
        {
            throw new NotImplementedException();
        }
    }
}
