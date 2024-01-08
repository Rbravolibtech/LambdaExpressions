using System;
using System.Collections.Generic;



// Namespace declaration
namespace LambdaExpressions
{
    // Class declaration
    class Program
    {
        // Main method, the entry point of the program
        static void Main(string[] args)
        {
            // Creating an instance of BookRepository and getting a list of books
            var books = new BookRepository().GetBooks();

            // Filtering books based on the IsCheaperThan10Dollars condition using lambda expression
            var cheapBooks = books.FindAll(IsCheaperThan10Dollars);

            // Printing the titles of cheap books
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

            // The following lines are commented out, suggesting you were experimenting with lambda expressions:

            // Lambda expression examples
            // args => expression
            // () => ...
            // x => ...
            // (x, y, z) => ...

            // const int factor = 5;

            // Func<int, int> multipler = n => n * factor;
            // var result = multipler(10);
            // Console.WriteLine(result);

            // Lambda expression for squaring a number
            // number => number * number

            // Calling the square function with the argument 5 and printing the result
            // Console.WriteLine(square(5));
        }

        // Function to check if a book is cheaper than $10
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}
