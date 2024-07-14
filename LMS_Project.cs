using System;
using System.Collections.Generic;
//calling library for list collection 

namespace MyApp
{

    public class Person
    {
        public string Name;
        public int Age;
        public int PersonID;
    }

    public class Librarian : Person//applying inheritance
    {
        public int Employee_ID; // Assuming you will use this later

        // Assuming you want to pass the library instance to the librarian
        private Library library;//accessing  instance of libraray

        public Librarian(Library library)
        {
            this.library = library;
        }

        public void issue_book(string bookname, string user, int librarianId)
        {
            bool bookIssued = false;

            foreach (Book book in library.Books)
            {
                if (book.Title.Equals(bookname, StringComparison.OrdinalIgnoreCase))
                {
                    // Perform issuing logic here, e.g., marking the book as issued

                    Console.WriteLine($"Book issued to {user} by Librarian ID: {librarianId}:");
                    book.DisplayInfo(); // Display the book information

                    // Add the issued book to the issued books list with Librarian ID
                    library.AddToIssuedBooks(book, librarianId);

                    bookIssued = true;
                    break; // Exit the loop after issuing the book
                }
            }

            if (!bookIssued)
            {
                // If book with given title is not found
                Console.WriteLine($"Book with title '{bookname}' not found in the library.");
            }
        }

        public void return_book(string bookname, string user)
        {
            bool bookReturned = false;

            foreach (Book book in library.IssuedBooks.Keys)
            {
                if (book.Title.Equals(bookname, StringComparison.OrdinalIgnoreCase))
                {
                    // Remove the book from issued books list
                    library.RemoveFromIssuedBooks(book);
                    Console.WriteLine($"Book '{bookname}' returned by {user}.");

                    bookReturned = true;
                    break; // Exit the loop after returning the book
                }
            }

            if (!bookReturned)
            {
                Console.WriteLine($"Book '{bookname}' not found in issued books.");
            }
        }
    }

    public abstract class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int BookID { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ID: {BookID}");
        }
    }

    public class FictionBook : Book
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"Fiction Book - Title: {Title}, Author: {Author}, ID: {BookID}");
        }
    }

    public class NonFictionBook : Book
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"Non-Fiction Book - Title: {Title}, Author: {Author}, ID: {BookID}");
        }
    }

    public class Library
    {
        public string LibraryName { get; set; }
        public int LibraryID { get; set; }
        public List<Book> Books { get; set; }
        public Dictionary<Book, int> IssuedBooks { get; set; } // Dictionary to store issued books with Librarian ID

        public Library()
        {
            Books = new List<Book>(); // Initialize the list in the constructor
            IssuedBooks = new Dictionary<Book, int>(); // Initialize the dictionary for issued books
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RemoveBook(int ID)
        {
            int removedCount = Books.RemoveAll(book => book.BookID == ID);

            if (removedCount > 0)
            {
                Console.WriteLine($"Removed {removedCount} book(s) with the ID {ID}.");
            }
            else
            {
                Console.WriteLine($"No book found with the ID {ID} to remove.");
            }
        }

        public void ViewBooks()
        {
            if (Books.Count == 0)
            {
                Console.WriteLine("No books in the library.");
            }
            else
            {
                Console.WriteLine("Books in the library:");
                foreach (Book book in Books)
                {
                    book.DisplayInfo();
                }
            }
        }

        public void SearchBook(string title)
        {
            bool found = false;
            foreach (Book book in Books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    book.DisplayInfo();
                    found = true;
                    break; // Exit the loop once found
                }
            }

            if (!found)
            {
                Console.WriteLine("No book found with the title.");
            }
        }

        public void AddToIssuedBooks(Book book, int librarianId)
        {
            IssuedBooks.Add(book, librarianId);
        }

        public void RemoveFromIssuedBooks(Book book)
        {
            IssuedBooks.Remove(book);
        }

        public void ListIssuedBooks()
        {
            if (IssuedBooks.Count == 0)
            {
                Console.WriteLine("No books have been issued.");
            }
            else
            {
                Console.WriteLine("Issued books:");
                foreach (var entry in IssuedBooks)
                {
                    Console.WriteLine($"Title: {entry.Key.Title}, Author: {entry.Key.Author}, ID: {entry.Key.BookID}, Issued by Librarian ID: {entry.Value}");
                }
            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("---------------------WELCOME To Library Management System------------------------");

                Library library = new Library();
                Librarian librarian = new Librarian(library);

                int library_option;

                do
                {
                    Console.WriteLine("1- Add Book ");
                    Console.WriteLine("2- Remove Book ");
                    Console.WriteLine("3- View Books");
                    Console.WriteLine("4- Search Books");
                    Console.WriteLine("5- Issue Book");
                    Console.WriteLine("6- Return Book");
                    Console.WriteLine("7- List Issued Books");
                    Console.WriteLine("8- Exit");
                    Console.Write("Enter your choice: ");
                    library_option = Convert.ToInt32(Console.ReadLine());

                    switch (library_option)
                    {
                        case 1:
                            Console.WriteLine("---------------------Library---------------------");
                            Console.WriteLine("How many books do you want to add ?  ");
                            Console.Write("Please enter in numbers:");

                            int numBooks = Convert.ToInt32(Console.ReadLine());

                            for (int i = 0; i < numBooks; i++)
                            {
                                Console.Write($"Enter book {i + 1} title: ");
                                string title = Console.ReadLine();

                                Console.Write($"Enter book {i + 1} author: ");
                                string author = Console.ReadLine();

                                Console.Write($"Enter book {i + 1} ID: ");
                                int bookID = Convert.ToInt32(Console.ReadLine());

                                Console.Write($"Enter book {i + 1} type (Fiction or NonFiction): ");
                                string type = Console.ReadLine();

                                Book book;
                                if (type.Equals("Fiction", StringComparison.OrdinalIgnoreCase))
                                {
                                    book = new FictionBook();
                                    FictionBook fb = new FictionBook();
                                    fb.Title = title;
                                    fb.Author = author;
                                    fb.BookID = bookID;
                                    book = fb;
                                }
                                else if (type.Equals("NonFiction", StringComparison.OrdinalIgnoreCase))
                                {
                                    book = new NonFictionBook();
                                    NonFictionBook NFB = new NonFictionBook();
                                    NFB.Title = title;
                                    NFB.Author = author;
                                    NFB.BookID = bookID;
                                    book = NFB;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid book type. Defaulting to Book.");
                                    // You cannot directly instantiate an abstract class 'Book'
                                    // Instead, you should decide what to do here, possibly skip adding the book or handle it differently.
                                    continue;
                                }



                                library.AddBook(book); // Add the book to the library
                            }
                            break;
                        case 2:
                            Console.Write("Enter book ID to remove: ");
                            int bookIDToRemove = Convert.ToInt32(Console.ReadLine());
                            library.RemoveBook(bookIDToRemove);
                            break;
                        case 3:
                            library.ViewBooks();
                            break;
                        case 4:
                            Console.Write("Please enter the Title of a book: ");
                            string search_Title = Console.ReadLine();
                            library.SearchBook(search_Title);
                            break;
                        case 5:
                            Console.Write("Enter the Book title to issue: ");
                            string bookNameToIssue = Console.ReadLine();

                            Console.Write("Enter User's Name: ");
                            string user = Console.ReadLine();

                            Console.Write("Enter Librarian ID: ");
                            int librarianId = Convert.ToInt32(Console.ReadLine());

                            librarian.issue_book(bookNameToIssue, user, librarianId);
                            break;
                        case 6:
                            Console.Write("Enter the Book title to return: ");
                            string bookNameToReturn = Console.ReadLine();

                            Console.Write("Enter User's Name: ");
                            string userReturn = Console.ReadLine();

                            librarian.return_book(bookNameToReturn, userReturn);
                            break;
                        case 7:
                            library.ListIssuedBooks();
                            break;
                        case 8:
                            Console.WriteLine("Exiting Library Management System.");
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please select a valid option.");
                            break;
                    }
                } while (library_option != 8);
            }
        }
    }
}