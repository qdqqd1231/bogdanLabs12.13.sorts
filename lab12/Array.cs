using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Array<Book>
    {
        private Book[] data;
        private int size;

        public int Size { get => size; }

        public Array()
        {
            data = new Book[] { };
            size = 0;
        }

        public Array(params Book[] data)
        {
            this.data = data;
            size += data.Length;
        }

        

        public void Add(Book book)
        {
            Book[] newData = new Book[Size + 1];
            data.CopyTo(newData, 0);
            newData[size] = book;
            size++;
            data = new Book[size];
            newData.CopyTo(data, 0);
        }

        public delegate void SortingType();

        public static SortingType byName = SortingByName;
        public static SortingType byAuthor = SortingByAuthor;
        public static SortingType byPublisher = SortingByPiblisher;

        private static void SortingByName()
        {
            Console.WriteLine("Сортировка по имени");


        }

        private static void SortingByAuthor()
        {
            Console.WriteLine("Сортировка по автору");
        }

        private static void SortingByPiblisher()
        {
            Console.WriteLine("Сортировка по издательству");
        }

        public void Sort(SortingType sort)
        {
            sort();
        }
    }
}
