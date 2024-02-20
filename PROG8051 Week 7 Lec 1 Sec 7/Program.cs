using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Library
    {
        Book[] books = new Book[10];
        int currentCount = 0;



        public void AddBook(Book book)
        {
            if(currentCount < books.Length)
            {
                books[currentCount++] = book;
                
            }
            else
            {
                Console.WriteLine("LIbrary is full");
            }
           
         }

        public void CheckoutBook(string isbn)
        {
            for (int i = 0; i < currentCount; i++)
            {
                if (books[i].Isbn == isbn && books[i].IsAvailable)
                {
                    books[i].IsAvailable = false;
                    Console.WriteLine($"{books[i].Title} has been check out successfully");
                }
            }
        }

       public void ListAvailableBooks()
        {
            for(int i = 0; i < currentCount; i++)
            {
                if (books[i].IsAvailable)
                {
                    Console.WriteLine($"Title: {books[i].Title}, Author: {books[i].Author}");
                }
            }
        }

    }

    class Book {

        // Fields
        string title;
        string author;
        string isbn;
        bool isavailable = true;


        // Proprerties
        public string Title {get { return title; }}
        public string Author {get { return author; }}
        public string Isbn {get { return isbn; }}
        public bool IsAvailable {
            get {return isavailable;}
            set {isavailable = value;}
        }

        // Constructor
        public Book( string bookTitle, string bookAuthor, string bookISBN) { 
            title = bookTitle;
            author = bookAuthor;
            isbn = bookISBN;
        }

       
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("1984", "George", "1234");
            Book book2 = new Book("19", "MArtin", "545645");

            Library lib = new Library();

            lib.AddBook(book1);
            lib.AddBook(book2);
            lib.CheckoutBook("545645");
        }
    }





   










    /* class Vehicle
     {
         private string transmission = "manual";

         // properties

         public string Transmission
         {
             get { return transmission; }
             set { transmission = value; }
         }

         public void Honk()
         {
             Console.WriteLine("Honk Honk");
         }
     }

     class Car
     {
         // What is OOP
         // Classes and Objects

         // How to create a class
         // fields
         bool engine = true; 
         int tires = 4;
         int seats;
         string color;
         int enginesize;

         // Class Members


         public void Honk()
         {
             Console.WriteLine("Honk Honk");
         }

         public void Break()
         {
             Console.WriteLine("car stops");
         }


         // Access Modifiers

         // public vs private


         // Constructor
         public Car(int carSeats, string carColor, int carEnginesize)
         {
             seats = carSeats;
             enginesize = carEnginesize;
             color = carColor;
         }
         static void Main(string[] args)
         {
             // create an object of the class

             // Classname objectname = new Classname()
             Car lexus = new Car(2,"red",3500);
             Console.WriteLine(lexus.color);


             Car BMW = new Car(4,"blue",4200);


             Vehicle toyota = new Vehicle();
             Console.WriteLine(toyota.Transmission);
             toyota.Transmission = "automatic";
             Console.WriteLine(toyota.Transmission);
         }
     }*/
}