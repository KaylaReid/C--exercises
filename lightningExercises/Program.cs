using System;

namespace Library
{
    public class Library 

    /*
    Create a few (4 or so) instances of Book and use the method on your Library class to add them to the list of books in an instance of Library 
    */
    {
        static void Main(string[] args)
        {
            // one way to make it 
            Book AfraidOfTheDark = new Book(){
                Title = "Afraid of the Dark",
                Author = "Trevor Noah",
                ISBN = "M27007s"
            };

            // AfraidOfTheDark.Title = "Afraid of the Dark";
            // AfraidOfTheDark.Author = "Trevor Noah";
            // AfraidOfTheDark.ISBN = "M27007s";


            // second way to make it
            Book TheChamberOfSecrets = new Book();
            TheChamberOfSecrets.Title = "The Chamber of Secrets";
            TheChamberOfSecrets.Author = "J.K. Rowling";
            TheChamberOfSecrets.ISBN = "2098fn88sdf";

            Book TheHalfBloodPrince = new Book();
            TheHalfBloodPrince.Title = "The Half Blood Prince";
            TheHalfBloodPrince.Author = "J.K. Rowling";
            TheHalfBloodPrince.ISBN = "k999ndufgsd873";
            
            Book FantasticBeasts = new Book();
            FantasticBeasts.Title = "Fantastic Beats and where to Find Them ";
            FantasticBeasts.Author = "J.K. Rowling";
            FantasticBeasts.ISBN = "kdi983g8hf";

            LibraryOfBooks library = new LibraryOfBooks() {
                Name = "Downtown Library",
                Address = "Main St."
            };

            library.AddBookToList(AfraidOfTheDark);
            library.AddBookToList(TheChamberOfSecrets);
            library.AddBookToList(TheHalfBloodPrince);
            library.AddBookToList(FantasticBeasts);
        }
    }
}
