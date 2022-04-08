using System;
using System.Collections;
using System.Collections.Generic;

namespace AddressBookProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Address Book  \n");
            CreateAddressBook createAddressBook = new CreateAddressBook();
            createAddressBook.ReadInput();
            Console.ReadLine();
        }


    }
}

