using System;

namespace AddressBookUsingCollection
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Address Book!");
            Console.WriteLine("Enter Address Book Name");
            string addressBookName = Console.ReadLine();
            AddressBookCollection addressBookCollection = new AddressBookCollection();
            AddressBook addressBook = new AddressBook();
            addressBookCollection.addressBookDictionary.Add(addressBookName, addressBook);
            int choice;
            do
            {
                Console.WriteLine("Enter Choice:");
                Console.WriteLine("1 to Display All Contact");
                Console.WriteLine("2 to Add new Contact");
                Console.WriteLine("3 to Edit Contact");
                Console.WriteLine("4 to Delete Contact");
                Console.WriteLine("5 to Add New Address Book");
                Console.WriteLine("6 to List of all Address Book");
                Console.WriteLine("7 to Search Person in City or State");
                Console.WriteLine("8 to View Person by City or State");
                Console.WriteLine("9 to Count Contact by city or state");
                Console.WriteLine("10 to Contact sort by Person Name");
                Console.WriteLine("11 to sort by city state and zip");
                Console.WriteLine("12 to read file");
                Console.WriteLine("13 to write file");
                Console.WriteLine("14 to WriteAddressBookCollectionToCSVFiles");
                Console.WriteLine("15 to ReadAddressBookCollectionToCSVFiles");
                Console.WriteLine("0 to Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addressBookCollection.addressBookDictionary[addressBookName].DisplayNamesInAddresBook();
                        break;
                    case 2:
                        addressBookCollection.addressBookDictionary[addressBookName].AddAddressBookEntry();
                        break;
                    case 3:
                        Console.WriteLine("Enter First Name");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name");
                        string lastName = Console.ReadLine();
                        addressBookCollection.addressBookDictionary[addressBookName].EditContact(firstName, lastName);
                        break;
                    case 4:
                        Console.WriteLine("Enter First Name");
                        firstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name");
                        lastName = Console.ReadLine();
                        addressBookCollection.addressBookDictionary[addressBookName].DeleteContact(firstName, lastName);
                        break;
                    case 5:
                        Console.WriteLine("Enter New Address Book Name");
                        addressBookName = Console.ReadLine();
                        addressBookCollection.addressBookDictionary.Add(addressBookName, new AddressBook());
                        Console.WriteLine("Address Book selected: " + addressBookName);
                        break;
                    case 6:
                        Console.WriteLine("Listing all Address Books");
                        foreach (var addressBookEntry in addressBookCollection.addressBookDictionary)
                        {
                            Console.WriteLine(addressBookEntry.Key);
                        }
                        Console.WriteLine("Select an Address Book");
                        addressBookName = Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("Enter First Name");
                        firstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name");
                        lastName = Console.ReadLine();
                        addressBookCollection.SearchPersonInCityOrState(firstName, lastName);
                        break;
                    case 8:
                        Console.WriteLine("Enter City Name");
                        string cityName = Console.ReadLine();
                        Console.WriteLine("Enter State Name");
                        string stateName = Console.ReadLine();
                        addressBookCollection.ViewPersonByCityOrState(cityName, stateName);
                        break;
                    case 9:
                        Console.WriteLine("Enter City name");
                        cityName = Console.ReadLine();
                        Console.WriteLine("Enter state name");
                        stateName = Console.ReadLine();
                        addressBookCollection.ViewCountByCityOrState(cityName, stateName);
                        break;
                    case 10:
                        addressBook.SortByPersonName();
                        break;
                    case 11:
                        addressBook.SortByCityStateZip();
                        break;
                    case 12:
                        addressBookCollection.ReadAddressBookFromFile();
                        break;
                    case 13:
                        addressBookCollection.WriteAddressBookCollectionToFiles();
                        break;
                    case 14:
                        addressBookCollection.WriteAddressBookCollectionToCSVFiles();
                        break;
                    case 15:
                        addressBookCollection.ReadAddressBookCollectionFromCSVFiles();
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            } while (choice != 0);
        }
    }
}