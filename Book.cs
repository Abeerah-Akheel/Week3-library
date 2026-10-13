using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        private string title;
        private string author;
        private string isbn;

        //Title property to allow access to the private Title field
        public string Title
        {
            get { return title; } // get method
            set { title = value; } // set method
        }

        public string Author
        {
            get { return author; }
            set 
            {
                //Check if any character is in the incoming string is a digit
                if (!value.Any(char.IsDigit))
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author name cannot contain numbers.");
                }
            }
        }
        
        public string ISBN
        {
            get { return isbn; }
            set
            {
                //Check if the imcoming string is not blank
                if (value != "")
                {
                    isbn = value;
                }
                else
                {
                    Console.WriteLine("Error: ISBN cannot be blank.");
                }
            }
        }

        // Example of a constructor that allows us to 'construct' a new Book object
        public Book (string bookTitle, string bookAuthor, string bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}