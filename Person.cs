namespace PersonBookExe
{
    public class Person
    {
        public int Id {get; }
        public string FirstName { get; set; }
        public string SurName { get; set; }

        public Person(int id,string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            SurName = lastName;
        }

        public override string ToString()
        {
            return $"Id : {Id} , Name : {FirstName}, Surname : {SurName}";
        }
    }
}