using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBookImplementation
{
    internal class Program
    {

        //Main  Method / program Entry Point
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Address Book Progam \n");
            CreateAddressBook createAddressBook = new CreateAddressBook();
            createAddressBook.ReadInput();
            Console.ReadLine();
        }
    }
}