using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day23_AddressBook
{
    internal class AddressBook1

    {
        List<Contacts> personDetails = new List<Contacts>();

        public void AddPerson()
        {
            Contacts person = new Contacts();
            //
            Console.WriteLine("enter first name");
            person.FirstName = Console.ReadLine();
            Console.WriteLine("enter last name");
            person.LastName = Console.ReadLine();
            Console.WriteLine("enter Address");
            person.Address = Console.ReadLine();
            Console.WriteLine("enter city name");
            person.City = Console.ReadLine();
            Console.WriteLine("enter state name");
            person.state = Console.ReadLine();
            Console.WriteLine("enter Zip Code");
            person.ZipCode = Console.ReadLine();
            Console.WriteLine("enter Phone number");
            person.PhNo = Console.ReadLine();
            Console.WriteLine("enter Email");
            person.Email = Console.ReadLine();
            personDetails.Add(person);
            Console.WriteLine("Details Added successfully");
            Console.ReadLine();


        }
        public void Add_Multiple_Person()
        {
            AddPerson();
            Console.WriteLine("Do you want to add one more person detail(Y/N) : ");
            string choice = Console.ReadLine();
            while (choice == "y" || choice == "Y")
            {
                AddPerson();
                Console.WriteLine("Do you want to add one more person detail(Y/N) : ");
                choice = Console.ReadLine();
            }


        }
        public void EditPersonDetails()
        {
            if (personDetails.Count != 0)
            {
                Console.WriteLine("Enter contact to modify:");
                string edit = Console.ReadLine();
                foreach (var person in personDetails)
                {
                    //ToUpper used to convert to uppercase 
                    if (person.FirstName.ToUpper() == edit.ToUpper())
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter the option to modify the property: ");
                            Console.WriteLine("Enter 1 to Change First name ");
                            Console.WriteLine("Enter 2 to Change Last name ");
                            Console.WriteLine("Enter 3 to Change Phone Number ");
                            Console.WriteLine("Enter 4 to Change Address ");
                            Console.WriteLine("Enter 5 to Change City ");
                            Console.WriteLine("Enter 6 to Change State ");
                            Console.WriteLine("Enter 7 to Change Pincode ");
                            Console.WriteLine("Enter 8 to Exit ");
                            int Option = Convert.ToInt32(Console.ReadLine());
                            //Switch case statement taken to choose desired operation
                            switch (Option)
                            {
                                case 1:
                                    Console.WriteLine("Enter the New First Name: ");
                                    person.FirstName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the New Last Name: ");
                                    person.LastName = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter the New Phone Number: ");
                                    person.PhNo = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine("Enter the New Address: ");
                                    person.Address = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter the New City: ");
                                    person.City = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.WriteLine("Enter the New State: ");
                                    person.state = Console.ReadLine();
                                    break;
                                case 7:
                                    Console.WriteLine("Enter the New Pin Code: ");
                                    person.ZipCode = Console.ReadLine();
                                    break;
                                case 8:
                                    return;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Contact does not exist");
                    }
                }
            }
            else
            {
                Console.WriteLine("Your address book is empty");
            }
        }
        public void Delete_Person_UsingName()
        {
            AddPerson();
            Console.WriteLine("enter the first name to delete that person");
            string delete = Console.ReadLine();

            foreach (Contacts person in personDetails)
            {
                if (person.FirstName.ToLower() == delete.ToLower())
                {
                    Console.WriteLine("Are you sure you want to delete this contact?(Y/N)");
                    var n = Console.ReadKey().Key;
                    if (n == ConsoleKey.Y)
                    {
                        personDetails.Remove(person);
                        Console.WriteLine("\nContact is deleted");
                    }
                    Console.WriteLine("\n\nContact Deleted from the List !");
                    return;
                }
                else
                {
                    Console.WriteLine("Contact not found");
                }
            }
        }

    }
}
