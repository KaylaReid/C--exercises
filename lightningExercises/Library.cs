using System;
using System.Collections.Generic;

namespace Library
{
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
