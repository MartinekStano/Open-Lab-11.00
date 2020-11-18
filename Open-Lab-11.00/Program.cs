using System;
using System.Collections.Generic;

namespace Open_Lab_11._00
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> studentsList = new List<string>() { "John", "Paul"};
            
            string category = Book.CategoryList[2];
            
            Book chemia = new Book("Chemia", 120,category, "Marián Schwarz",2018);
            Book matematika = new Book("Matematika", 150, category, "Zuzana a Peter Bero", 2018);
            
            Library schoolLibrary = new Library(2, 2, new List<string>() { "John", "Paul" }, new List<Book>() { chemia, matematika});
            
            schoolLibrary.DiscribeLibrary();

            Console.ReadKey();
        }
    }
}

