namespace DelegatesDemo
{
    public class Person
    {
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime DateOfBirth { get; }

        public Person(int Id, string FirstName, string LastName, DateTime DateOfBirth)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
        }

        public override string ToString()
        {
            return $"{FirstName.PadRight(20)} {LastName.PadRight(20)}\t{Id.ToString().PadLeft(4)}\t{DateOfBirth.ToShortDateString()}";
        }
    }

    //public record Person(int Id, string FirstName, string LastName, DateTime DateOfBirth)
    //{
    //    public override string ToString()
    //    {
    //        return $"{FirstName.PadRight(20)} {LastName.PadRight(20)}\t{Id.ToString().PadLeft(4)}\t{DateOfBirth.ToShortDateString()}";
    //    }
    //}
}
