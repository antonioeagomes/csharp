using System;
using CSharp.Generics;
using CSharp.LambdaExpressions;

namespace CSharp.Exec
{
    public class LambdasExec : IExecutable
    {
        public void Execute(){
            var books = new BookRepository().GetBooks();
            /* It will iterate with each book of the List*/
            var cheapBooks =  books.FindAll(IsCheaperThan75Bucks);
            var dearerBooks = books.FindAll(b => b.Price > 70);

            foreach (var item in cheapBooks)
            {
                Console.WriteLine(item.Title);
            }
            Console.WriteLine("================");
            foreach (var item in dearerBooks)
            {
                Console.WriteLine(item.Title);
            }

        }

        /* Predicate - delegate that returns bool */
        static bool IsCheaperThan75Bucks(Book book)
        {
            return book.Price < 75;
        }
    }
}