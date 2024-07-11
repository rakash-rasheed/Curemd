using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyApp
{
    internal class Program
    {
        class Book
        {
            String title, Author;
            int BookId;
            void Display_info()
            {

            }
        }

        class Person
        {
            String Name;
            int age, PersonID;
        }
        class Library
        {
            String LibraryName;
            int Library_ID;
            List<Library> LibraryList;

            void add_book(Book book) { }
            void add_book(Book book_id) { }
            void view_book() { }

        }
        static void Main(string[] args)
        {
            Book b1=new Book();
                Library l2= new Library();
            Person p1 = new Person();
            
        }
    }
}
