using System;

namespace PersonBookExe
{
    class Program
    {
        static List<Person> people = new List<Person>();

        static void Main(string[] args)
        {
            var huso = new Person("Huseyin", "Zahit");
            huso.setID(1);
            people.Add(huso);

            PrintMenu();
            PersonBookExe();
        }

         //Menu of the program
        public static void PrintMenu()
        {
            Console.WriteLine("\n*************************** \n" +
                              "* 1) Print Person List    * \n" +
                              "* 2) Add Person           * \n" +
                              "* 3) Update Person        * \n" +
                              "* 4) Remove Person        * \n" +
                              "* 5) Exit                 * \n" +
                              "***************************\n");
        }

         // list of the person in the book
        public static void PersonList()
        {
            if (people.Count == 0)
            {
                Console.WriteLine("No person Exist on the book");

            }
            foreach (var person in people)
            {
                Console.WriteLine("Id : " + person.getId() + " , Name : " + person.getFirstName() + " , LastName : " +
                                  person.getLastName());
            }
        }

        //adding person to the book
        public static void AddPerson()
        {
            Console.Write("Please Enter The Person Name : ");
            var newName = Console.ReadLine();
            Console.Write("Please Enter The Person LastName : ");
            var lastName = Console.ReadLine();

            var newPerson = new Person(newName, lastName);
            var newId = people.Count;

            newPerson.setID(newId + 1);
            people.Add(newPerson);
        }

        // changing information about a person on the book
        public static void UpdatePerson()
        {
            PersonList();
            Console.Write("Please Enter A Person ID : ");
            var newId = Convert.ToInt32(Console.ReadLine());
            foreach (var person in people)
            {
                if (newId == person.getId())
                {
                    Console.WriteLine("Person ID : " + person.getId() + ", Name : " + person.getFirstName() +
                                      ", Lastname : " + person.getLastName());
                    Console.WriteLine("What do you want to update?" +
                                      "\n 1-) Name" +
                                      "\n 2-) LastName");
                    var option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Please Enter The New Name!");
                            var newName = Console.ReadLine();
                            person.setFirstName(newName);
                            break;
                        case 2:
                            Console.WriteLine("Please Enter The New Last Name!");
                            var lastName = Console.ReadLine();
                            person.setLastName(lastName);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("There is no Person with this  ID");
                }
            }
        }

        // deleting wanted person from the book
        public static void RemovePerson()

        {
            Console.Write("Please Enter The Person ID you want to remove : ");
            var Id = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i <= people.Count; i++)
            {
                if (Id == people[i].getId())
                {
                    people.RemoveAt(i);
                }
            }
        }

        // person book program
        public static void PersonBookExe()
        {
            var exit = false;
            while (!exit)
            {

                Console.WriteLine("Please Select An Option");
                var option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        PersonList();
                        break;
                    case 2:
                        AddPerson();
                        break;
                    case 3:
                        UpdatePerson();
                        break;
                    case 4:
                        RemovePerson();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("There is no such option!!!");
                        break;
                }

                PrintMenu();
            }
        }
    }

