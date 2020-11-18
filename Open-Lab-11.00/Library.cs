using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_11._00
{
    class Library : Book
    {
        public int NumberOfBooks { get; set; }
        public int NumberOfStudents { get; set; }
        public List<string> StudentsList { get; set; }
        public List<Book> BookList { get; set; }

        public Library(int numberOfBooks, int numberOfStudents, List<string> studentsList, List<Book> bookList)
        {
            NumberOfBooks = numberOfBooks;
            NumberOfStudents = numberOfStudents;
            StudentsList = studentsList;
            BookList = bookList;
            
        }
        public Library()
        {
            Book book = new Book();
            NumberOfBooks = -1;
            NumberOfStudents = -1;
            StudentsList = new List<string>();
            BookList = new List<Book>();
        }

            

        public override string ToString()
        {
            return $"{NumberOfBooks}\n{NumberOfStudents}\n{StudentsList}\n{BookList}";
        }

        public void DiscribeLibrary()
        {
            Console.WriteLine($"Pocet knih:{NumberOfBooks}\tPocet studentov{NumberOfStudents}");
            
            int i = 1;
            
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Vypis ziakov: ");
            
            foreach(string pupil in StudentsList)
            {
                Console.WriteLine($"{i}. {pupil}");
                i += 1;
            }
            
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Vypis knih: ");

            foreach (Book book in BookList) 
            {
                book.DiscribeBook();
            }
            
        }



    }
}
