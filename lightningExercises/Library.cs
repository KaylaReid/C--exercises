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
        public string Name { get; set; }
        public string Address { get; set; }
        private List<Book> _bookList = new List<Book>();
        public void AddBookToList(Book book){
            _bookList.Add(book);
        }

    }
}
