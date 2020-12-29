using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonBookExe
{
    class Program
    {
        static List<Person> people = new List<Person>();

        static void Main(string[]args)
        {

            RunProgram();
        }

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

        static void ListPerson()
        {
            if (people.Count == 0)
            {
                Console.Write("No person Exist on the book");
            }
            foreach (var selectedPerson in people)
            {
                PrintPerson(selectedPerson.Id);
            }
            
        }

        static void AddPerson()
        {
            Console.Write("Please Enter The Person Name : ");
            var newName = Console.ReadLine();
            Console.Write("Please Enter The Person LastName : ");
            var lastName = Console.ReadLine();

            var newId = people.Count + 1;
            var newPerson = new Person(newId, newName, lastName);
            people.Add(newPerson);
        }

         static void UpdatePerson()
         {
             const int updateNameCase = 1;
             const int updateLastNameCase = 2;
            ListPerson();
            if (people.Count!=0)
            {
                Console.Write("Please Enter The Person ID you want to update : \n");
                var input = Console.ReadLine();
                var isParsed= Int32.TryParse(input, out var id);
                
                if (isParsed && IsPersonExist(id) )
                {
                
                    PrintPerson(id);
                    Console.WriteLine("What do you want to update?" +
                                      "\n 1-) Name" +
                                      "\n 2-) LastName\n");
                    var option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case updateNameCase:
                            Console.WriteLine("Please Enter The New Name!\n");
                            var newName = Console.ReadLine();
                            people[id-1].FirstName=newName;
                            break;
                        case updateLastNameCase:
                            Console.WriteLine("Please Enter The New Last Name!\n");
                            var lastName = Console.ReadLine();
                            people[id-1].SurName=lastName;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid value\n");
                }
            }
            else
            {
                Console.WriteLine(" to update!\n ");
            }
        }
        static void RemovePerson()
        {
            ListPerson();
            if (people.Count!=0)
            {
                Console.Write("Please Enter The Person ID you want to remove : \n");
                var input = Console.ReadLine();
                Console.WriteLine();
                var isParsed = Int32.TryParse(input, out var id);
                var person = people.FirstOrDefault(p => p.Id == id);
                if(person == null){
                    Console.WriteLine("Id is not in the person list!\n");
                    return;
                }

                if (isParsed && IsPersonExist(id))
                {
                    people.Remove(person);    
                }
                
            }
            else
            {
                Console.Write(" to delete! \n");
            }
        }

        static void RunProgram()
        {
            var exit = false;
            while (!exit)
            {
                PrintMenu();
                Console.WriteLine("\nPlease Select An Option\n");
                var input = Console.ReadLine();
                var isInt = Int32.TryParse(input, out var option);
                const int listPerson = 1, addPerson = 2, updatePerson = 3, removePerson = 4, toExit = 5;
                if (isInt)
                {
                    switch (option)
                    {
                        case listPerson:
                            ListPerson(); 
                            break;
                        case addPerson:
                            AddPerson();
                            Console.Clear();
                            break;
                        case updatePerson:
                            UpdatePerson();
                            Console.Clear();
                            break;
                        case removePerson:
                            RemovePerson();
                            Console.Clear();
                            break;
                        case toExit:
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

        static void PrintPerson(int id)
        {
            Console.WriteLine(people[id-1].ToString());
        }

        static bool IsPersonExist(int id)
        {
            var person = people.FirstOrDefault(p => p.Id == id);
            return person != null && person.Id==id;
        }
    }
}

