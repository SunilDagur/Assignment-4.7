using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__4._7
{
    using System;
    using System.Collections.Generic;

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

    class Bookshelf
    {
        private List<Book> books = new List<Book>();

        
        public Book this[string title]
        {
            get
            {
                return books.Find(book => book.Title == title);
            }
            set
            {
                var existingBook = books.Find(book => book.Title == title);
                if (existingBook != null)
                {
                   
                    existingBook.Title = value.Title;
                    existingBook.Author = value.Author;
                }
                else
                {
                   
                    books.Add(value);
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            var bookshelf = new Bookshelf();

          
            bookshelf["Book1"] = new Book { Title = "Book1", Author = "Author1" };
            bookshelf["Book2"] = new Book { Title = "Book2", Author = "Author2" };

            
            var book1 = bookshelf["Book1"];
            var book2 = bookshelf["Book2"];

            Console.WriteLine("Book1: " + book1.Title + " by " + book1.Author);
            Console.WriteLine("Book2: " + book2.Title + " by " + book2.Author);

            bookshelf["Book1"] = new Book { Title = "New Book1", Author = "New Author1" };
            var updatedBook1 = bookshelf["New Book1"];
            Console.WriteLine("Updated Book1: " + updatedBook1.Title + " by " + updatedBook1.Author);

            Console.ReadKey();
        }
    }

}
