using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_11._00
{
    class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public int ReleaseDate { get; set; }
        public static List<string> CategoryList = new List<string>() { "detské", "romantické", "náučné", "sci-fi", "dobrodružné" };

        public Book(string title, int pages, string categoty, string author, int releasedate)
        {
            Title = title;
            Pages = pages;
            Category = categoty;
            Author = author;
            ReleaseDate = releasedate;

        }

        public Book()
        {
            Title = "-1";
            Pages = -1;
            Category = "-1";
            Author = "-1";
            ReleaseDate = -1;
        }
        public Book(string title, int pages)
        {
            Title = title;
            Pages = pages;
            Category = "-1";
            Author = "-1";
            ReleaseDate = -1;

        }
        public override string ToString()
        {
            return $"{Title}\n{Pages}\n{Category}\n{Author}\n{ReleaseDate}";
        }
        public void DiscribeBook()
        {
            Console.WriteLine($"\t\t{Title} {Pages} {Category} {Author} {ReleaseDate}");
        }
        public static string ChooseAGenre()
        {
            int i = 1;
            foreach (string genre in Book.CategoryList)
            {

                Console.WriteLine("{0} {1}", i, genre);
                i += 1;
            }
            Console.WriteLine("Tvoj vyber: ");
            string category = Book.CategoryList[int.Parse(Console.ReadLine()) - 1];
            return category;
        }
    }
}
