using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManager
{
    // Task 1: Encapsulation - Properties ko restrict kiya
    public class Book
    {
        public string Title { get; private set; } // Bahar se Title change nahi ho sakta
        public string Author { get; private set; }
        public bool IsAvailable { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            IsAvailable = true;
        }
    }

    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book) => books.Add(book);

        public void ShowAvailableBooks()
        {
            Console.WriteLine("\n--- Available Books ---");
            foreach (var book in books.Where(b => b.IsAvailable))
            {
                Console.WriteLine($"- {book.Title} by {book.Author}");
            }
        }

        // Late Afternoon Task 2 & 3: Validation aur Error Handling
        public void BorrowBook(string title)
        {
            // Task: Add data validation
            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("\n⚠️ Error: Please enter a valid book title.");
                return;
            }

            // Task: Handle system exceptions (Logic handling)
            var book = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (book == null)
            {
                Console.WriteLine($"\n❌ Not Found: '{title}' library mein nahi hai.");
            }
            else if (!book.IsAvailable)
            {
                Console.WriteLine($"\n❌ Unavailable: '{book.Title}' pehle hi borrow ho chuki hai.");
            }
            else
            {
                book.IsAvailable = false;
                Console.WriteLine($"\n✅ Success: Aapne '{book.Title}' borrow kar li hai.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Library myLibrary = new Library();
            myLibrary.AddBook(new Book("C# Programming", "Microsoft"));
            myLibrary.AddBook(new Book("Clean Code", "Robert Martin"));
            myLibrary.AddBook(new Book("OOP Basics", "Gunjan"));

            myLibrary.ShowAvailableBooks();

            Console.Write("\nBorrow karne ke liye book ka naam likhein: ");
            string choice = Console.ReadLine() ?? "";
            
            myLibrary.BorrowBook(choice);

            myLibrary.ShowAvailableBooks();
        }
    }
}