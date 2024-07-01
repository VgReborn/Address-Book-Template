using System;
using System.Runtime.CompilerServices;
using ABook;

class Main_Program
{
    static void Main(string[] arg)
    {
        Initializer._INIT(); //Can be deleted or commented out

        AddressBook.GetFile("Example.json");
        AddressBook.Show();


        //AddressBook.Show(); // if needed, it can show your current information
        Console.ReadKey();
    }
}