namespace PersonBookExe
{
    public class Person
    {
        
        private int _Id = 0;
        private string _firstName;
        private string _surName;

        public Person(int id,string firstName, string lastName)
        {
            this._Id = id;
            this._firstName = firstName;
            this._surName = lastName;
        }

        public int GetId()
        {
            return this._Id;
        }

        public string GetFirstName()
        {
            return this._firstName;
        }

        public string GetLastName()
        {
            return this._surName;
        }


        public void SetFirstName(string newName)
        {
            this._firstName = newName;
        }

        public void SetLastName(string newSurname)
        {
            this._surName = newSurname;
        }
    }
}