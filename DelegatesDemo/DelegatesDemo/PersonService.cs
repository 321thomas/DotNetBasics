namespace DelegatesDemo
{
    public delegate bool StringPredicate(Person p, string s);
    public delegate bool PersonPredicate(Person p);

    public class PersonService
    {

        PersonRepository _personRepository;
        public PersonService()
        {
            _personRepository = new PersonRepository();
        }

        public IEnumerable<Person> GetAllPersons()
        {
            return _personRepository.GetAllPersons();
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
            foreach (var person in _personRepository.GetAllPersons())
            {
                if (person.FirstName.StartsWith(startingWith))
                {
                    yield return person;
                }
            }
        }

        // TODO: implement method, WITHOUT(!) any LINQ statements but using delegate as input parameter
        public IEnumerable<Person> FilterPersonsWithStringPredicate(StringPredicate predicate, string term)
        {
            foreach (var person in _personRepository.GetAllPersons())
            {
                if (predicate(person, term))
                {
                    yield return person;
                }
            }
        }

        public IEnumerable<Person> FilterPersons(PersonPredicate predicate)
        {
            foreach (var person in _personRepository.GetAllPersons())
            {
                if (predicate(person))
                {
                    yield return person;
                }
            }
        }
    }
}
