using System;
using System.Collections.Generic;
using POCOnList.Model;

namespace POCOnList.Model
{
    public class PersonManagerClass
    {
        public static void PersonManager()
        {
            List<Person> persons = new List<Person>();
            Console.WriteLine("Welcome to Person Manager App");
            Console.WriteLine(new string('-', 50));

            while (true)
            {
                Console.WriteLine("What do you want to Perform?");
                Console.WriteLine("1. Create new Person");
                Console.WriteLine("2. Display all Persons");
                Console.WriteLine("3. Update Person Details");
                Console.WriteLine("4. Delete a Person");
                Console.WriteLine("5. Exit");

                if (!int.TryParse(Console.ReadLine(), out int userInputForAction))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (userInputForAction)
                {
                    case 1:
                        CreatePerson(persons);
                        break;
                    case 2:
                        PrintPersons(persons);
                        break;
                    case 3:
                        UpdatePerson(persons);
                        break;
                    case 4:
                        DeletePerson(persons);
                        break;
                    case 5:
                        Console.WriteLine("Exiting..");
                        return;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }

        public static void CreatePerson(List<Person> persons)
        {
            Console.WriteLine("Enter Person Id:");
            if (!int.TryParse(Console.ReadLine(), out int personId))
            {
                Console.WriteLine("Invalid Id. Please enter a number.");
                return;
            }

            Console.WriteLine("Enter Person Name:");
            string personName = Console.ReadLine();

            persons.Add(new Person(personId, personName));
            Console.WriteLine("Person added successfully.");
        }

        public static void UpdatePerson(List<Person> persons)
        {
            Console.WriteLine("Enter the Id of the person you want to update the name for:");
            if (!int.TryParse(Console.ReadLine(), out int userInputForPersonUpdate))
            {
                Console.WriteLine("Invalid Id. Please enter a number.");
                return;
            }

            Console.WriteLine("Enter New Name:");
            string newName = Console.ReadLine();

            Person selectedPersonToUpdate = persons.Find(p => p.PersonId == userInputForPersonUpdate);
            if (selectedPersonToUpdate != null)
            {
                selectedPersonToUpdate.PersonName = newName;
                Console.WriteLine("Person updated successfully.");
            }
            else
            {
                Console.WriteLine("Id not found.");
            }
        }

        public static void DeletePerson(List<Person> persons)
        {
            Console.WriteLine("Enter the Id of the person you want to delete:");
            if (!int.TryParse(Console.ReadLine(), out int userInputForPersonDeletion))
            {
                Console.WriteLine("Invalid Id. Please enter a number.");
                return;
            }

            Person personToDelete = persons.Find(p => p.PersonId == userInputForPersonDeletion);
            if (personToDelete != null)
            {
                persons.Remove(personToDelete);
                Console.WriteLine("Person deleted successfully.");
            }
            else
            {
                Console.WriteLine("Id not found.");
            }
        }

        public static void PrintPersons(List<Person> persons)
        {
            if (persons.Count == 0)
            {
                Console.WriteLine("There are no persons to display.");
            }
            else
            {
                foreach (Person person in persons)
                {
                    Console.WriteLine($"Person Id: {person.PersonId} Person Name: {person.PersonName}");
                }
            }
        }
    }
}
