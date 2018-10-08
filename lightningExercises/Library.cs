using System;
using System.Collections.Generic;

namespace Library
{
    /*
    Make a Library class that has:
        - Private List of Books (remember casing and naming convention here)
        - Public Method to add a Book to the List of Books
        - Public Address property
        - Public Name property
     */
    public class LibraryOfBooks 
    {
        // constructor has to have the same name as the class its in, and it doesn't have a return type --- this is to add books and a library to go with them
        public LibraryOfBooks(List<Book> initalInventory, string name, string address)
        {
            _bookList = initalInventory;
            Name = name;
            Address = address;
        }
        public string Name { get; set; }
        public string Address { get; set; }
        private List<Book> _bookList = new List<Book>();

        // when you call this you put in a book as an arg to be added to the _bookList you made
        public void AddBookToList(Book book)
        {
            _bookList.Add(book);
        }

        public void Checkout(string isbn, CardHolder cardHolder)
        {
            Book foundBook = new Book();
            foreach(Book book in _bookList)
            {
                if(book.ISBN == isbn && book.IsAvailable)
                {
                    cardHolder.CheckoutBook(book);
                    book.IsAvailable = false;
                }
            }
        }

        public bool IsAvailable(string isbn)
        {
            // this will wait until its done looping to return the false at the bottom
            foreach(Book book in _bookList)
            {
                if(book.ISBN == isbn)
                {
                    return book.IsAvailable;
                }
            }
                return false;
        } 
    }
}
