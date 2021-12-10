using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Library
    {
        public static List<Book> books = new List<Book>();

        public delegate void SortingType();
        public void Sort(SortingType sortingType)
        {
           sortingType();
        }

        public static SortingType byName = SortingByName;
        public static SortingType byAuthor = SortingByAuthor;
        public static SortingType byPublisher = SortingByPiblisher;

        private static void SortingByName()
        {
            var sorted = Library.books.OrderBy(Book => Book.name);
            Console.WriteLine("Sorted by names::");
            foreach (Book book in sorted)
            {
                Console.WriteLine($" {book.name}, {book.author}, {book.publisher}");
            }

        }

        private static void SortingByAuthor()
        {
            
            var sorted = Library.books.OrderBy(Book => Book.author);
            Console.WriteLine("Sorted by authors::");
            foreach (Book book in sorted)
            {
                Console.WriteLine($" {book.name}, {book.author}, {book.publisher}");
            }

        }

        private static void SortingByPiblisher()
        {
            var sorted = Library.books.OrderBy(Book => Book.publisher);
            Console.WriteLine("Sorted by publishers::");
            foreach (Book book in sorted)
            {
                Console.WriteLine($" {book.name}, {book.author}, {book.publisher}");
            }
        }
       
    }
}
