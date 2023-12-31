﻿using System;
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
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Title)
                .Select(b => b.Title);

            foreach ( var book in cheapBooks )
            {
                Console.WriteLine(book);
                //Console.WriteLine(book.Title + "" + book.Price);
            }
                Console.ReadLine();
        }
    }
}
