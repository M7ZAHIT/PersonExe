using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Linq;
=======
>>>>>>> eef7c043af812032082089b03383d86c8634fe44

namespace PersonBookExe
{
    class Program
    {
        static List<Person> people = new List<Person>();

        static void Main(string[] args)
        {

            RunProgram();
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

<<<<<<< HEAD
        public static void ListPerson()
=======
         // list of the person in the book
        public static void PersonList()
>>>>>>> eef7c043af812032082089b03383d86c8634fe44
        {
            if (people.Count == 0)
            {
                Console.Write("No person Exist on the book");
            }
            foreach (var selectedPerson in people)
            {
                Console.WriteLine($"Id : {selectedPerson.GetId()}  , Name : {selectedPerson.GetFirstName()} , LastName :{selectedPerson.GetLastName()} ");
            }
            
        }

        //adding person to the book
        public static void AddPerson()
        {
            Console.Write("Please Enter The Person Name : ");
            var newName = Console.ReadLine();
            Console.Write("Please Enter The Person LastName : ");
            var lastName = Console.ReadLine();

            var newId = people.Count + 1;
            var newPerson = new Person(newId, newName, lastName);
            people.Add(newPerson);
        }

        // changing information about a person on the book
        public static void UpdatePerson()
        {
            ListPerson();
            if (people.Count!=0)
            {
                Console.Write("Please Enter The Person ID you want to update : ");
                string input = Console.ReadLine();
                bool isInt = Int32.TryParse(input, out var id);
                if (isInt)
                {
                    Console.WriteLine("Person ID : " + people[id].GetId() + ", Name : " + people[id].GetFirstName() +
                                      ", Lastname : " + people[id].GetLastName());
                    Console.WriteLine("What do you want to update?" +
                                      "\n 1-) Name" +
                                      "\n 2-) LastName");
                    var option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Please Enter The New Name!");
                            var newName = Console.ReadLine();
                            people[id].SetFirstName(newName);
                            break;
                        case 2:
                            Console.WriteLine("Please Enter The New Last Name!");
                            var lastName = Console.ReadLine();
                            people[id].SetLastName(lastName);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid value");
                }
                if (id > people.Count || id < 0 )
                {
                    Console.WriteLine("There is no Person with this  ID");
                }
            }
            else
            {
                Console.WriteLine(" to update! ");
            }
          
        }
    

<<<<<<< HEAD
    public static void RemovePerson()
=======
        // deleting wanted person from the book
        public static void RemovePerson()

>>>>>>> eef7c043af812032082089b03383d86c8634fe44
        {
            ListPerson();
            if (people.Count!=0)
            {
                Console.Write("Please Enter The Person ID you want to remove : ");
                string input = Console.ReadLine();
                bool isInt = Int32.TryParse(input, out var id);
                if (isInt)
                {
                    people.RemoveAt(id);
                }
            }
            else
            {
                Console.Write(" to delete! \n");
            }
        }

<<<<<<< HEAD
        public static void RunProgram()
=======
        // person book program
        public static void PersonBookExe()
>>>>>>> eef7c043af812032082089b03383d86c8634fe44
        {
            PrintMenu();
            var exit = false;
            while (!exit)
            {
                Console.WriteLine("\nPlease Select An Option");
                string input = Console.ReadLine();
                bool isInt = Int32.TryParse(input, out var option);
                if (isInt)
                {
                    switch (option)
                    {
                        case 1:
                            ListPerson();
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
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            }
        }
    }
}

}
