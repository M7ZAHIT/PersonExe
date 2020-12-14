namespace PersonBookExe
{
    public class Person
    {
        
        private int _Id = 0;
        private string _firstName;
        private string _surName;

        public Person(string firstName, string lastName)
        {

            this._firstName = firstName;
            this._surName = lastName;
        }

        public int getId()
        {
            return this._Id;
        }

        public string getFirstName()
        {
            return this._firstName;
        }

        public string getLastName()
        {
            return this._surName;
        }

        public void setID(int id)
        {
            this._Id = id;
        }

        public void setFirstName(string newName)
        {
            this._firstName = newName;
        }

        public void setLastName(string newSurname)
        {
            this._surName = newSurname;
        }
    }
}