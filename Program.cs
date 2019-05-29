using System;
using System.Collections.Generic;

namespace books
{

    //Create a new class
    class Book
    {
        //This is a constructor. Think of a constructor as a construction crew.
        //Think of a class as blueprints to a house for that crew to use.
        //Think of an object as the new house after the construction crew builds it using the blueprints you gave them.
        //*****Constructors can have parameters.*****
        public Book(string title)
        {
            // Console.WriteLine("Constructing a new Book!!");
            Title = title;
            SubTitle = "";
            Author = "";
            ReleaseDate = DateTime.Now;
            Price = double.MaxValue;
        }

        //These are properties
        public string Title { get; set; }
        public string SubTitle { get; set; }
        //This property is just getting the value and is not doing any setting.
        public string FullTitle
        {
            get
            {
                return Title + ": " + SubTitle;
            }
        }
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Price { get; set; }

        //You can also store methods in classes.
        public void DisplayDetails()
        {
            //Since this code lives inside of the class there is no need to use dot notation ex. book.FullTitle...
            Console.WriteLine("===========================");
            Console.WriteLine($"Full Title: {FullTitle}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Released: {ReleaseDate}");
            Console.WriteLine($"Price: ${Price}");
        }

        //This is called method overloading.
        //It is an already existing method that is passed an extra parameter by the user.
        //If no extra parameter is passed by the user, the existing method will run.
        public void DisplayDetailsWithHeader(string header)
        {
            Console.WriteLine(header);
            DisplayDetails();
        }

    };
    class Program
    {
        static void Main(string[] args)
        {
            // Create 3 books
            // Each book should have:
            // title,
            // author,
            // release date,
            // and price

            //Create a new book using the class that was declared above.
            Book book1 = new Book("The Book");

            //Give each of the properties for book1 a value.
            book1.Author = "Juanita Voss";
            book1.Title = "Being Awesome isn't so Great";
            book1.SubTitle = "And other depressing things.";
            book1.ReleaseDate = new DateTime(2000, 2, 28);
            book1.Price = 21.17;

            //Create a new book.
            Book book2 = new Book("My Life");
            book2.Author = "Me";
            book2.SubTitle = "Not that great of a read.";
            book2.ReleaseDate = new DateTime(2015, 2, 10);
            book2.Price = 100.29;

            //Another way to create an object using the class that
            Book book3 = new Book("How to Win Friends and Get Their Money.")
            {
                SubTitle = "The art of the steal",
                Author = "Richy Guy",
                ReleaseDate = new DateTime(1980, 7, 24),
                Price = 34.00
            };

            //Create a list of the books
            List<Book> shelf = new List<Book>() {
                book1, book2, book3
            };

            //Initialize a new variable so that math can be done.
            double sum = 0;

            foreach (Book book in shelf)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Subtitle: {book.SubTitle}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"Released: {book.ReleaseDate}");
                Console.WriteLine($"Price: ${book.Price}");
            }

            //This is an example of how to use a method that has been stored inside a class.
            foreach (Book book in shelf)
            {
                book.DisplayDetails();
            };
            //Iterate over the books and add their prices together.
            foreach (Book book in shelf)
            {
                sum += book.Price;
            };

            //Print out the sum of all books added together.
            Console.WriteLine($"The total of all books added together is ${sum}");

            foreach (Book book in shelf)
            {
                book.DisplayDetailsWithHeader("The BOOK Header");
                Console.WriteLine("++++++++++++++++++++++++++++");
            }

            //If you want to create a book using a dictionary this is how you'd do it.
            // Dictionary<string, string> book1 = new Dictionary<string, string> {
            //     {"Title", "The Big Sleep"},
            //     {"Author", "Raymond Chandler"},
            //     {"Release Date", "1939"},
            //     {"Price", "$5.00"},
            // };

            // Dictionary<string, string> book2 = new Dictionary<string, string> {
            //     {"Title", "The Lady in the Lake"},
            //     {"Author", "Raymond Chandler"},
            //     {"Release Date", "1943"},
            //     {"Price", "$15.00"},
            // };

            // Dictionary<string, string> book3 = new Dictionary<string, string> {
            //     {"Title", "C# For Fun and Profit"},
            //     {"Author", "Somebody"},
            //     {"Release Date", "2018"},
            //     {"Price", "$95.00"},
            // };

            // //List all three books
            // List<Dictionary<string, string>> shelf = new List<Dictionary<string, string>>() {
            //     book1, book2,book3
            // };
            // //Run through a loop to print out the price of each book.
            // foreach (Dictionary<string, string> book in shelf)
            // {
                //Console the book price.
            //     Console.WriteLine(
            //         book["Price"]
            //     );
            // }

        }
    }
}
