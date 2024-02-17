using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //LINQ Query operators
            //var cheapBooks = 
            //    from b in books
            //    where b.Price < 10
            //    orderby b.Title
            //    select b.Title;

            // LINQ Extention Methods
            var cheapBooks = books
                .Where(b => b.Price < 7)
                .OrderBy(b => b.Title)
                .Select(b => b.Title);

            foreach ( var book in cheapBooks )
            {
                Console.WriteLine(book);
                //Console.WriteLine($"{book} Price: {book.Price}");
            }

            var book1 = books.Single(b => b.Title == "ASP.NET MVC");
            var book2 = books.FirstOrDefault(b => b.Title == "C# Advanced Topics");
            var book3 = books.LastOrDefault(b => b.Title == "C# Advanced Topics");
            Console.WriteLine();
            Console.WriteLine("\tSingle Books ");
            Console.WriteLine($"{book1.Title}\t\t Price: {book1.Price}");
            Console.WriteLine($"{book2.Title}\t Price: {book2.Price}");
            Console.WriteLine($"{book3.Title}\t Price: {book3.Price}");


            Console.ReadLine();
        }
    }
}
