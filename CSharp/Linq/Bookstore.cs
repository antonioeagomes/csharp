using System.Collections.Generic;
using System.Linq;
using CSharp.Generics;
using CSharp.LambdaExpressions;

namespace CSharp.Linq
{
    public class Bookstore
    {
        public List<Book> GetCheapBooks() {
            var books = new BookRepository().GetBooks();
            /* Not using Linq */
            var cheaps = new List<Book>();

            foreach (var book in books)
            {
                if (book.Price < 20)
                {
                    cheaps.Add(book);    
                }                
            }

            /* using Linq extension methods */

            var cheapBooks = books.Where(b => b.Price < 20).OrderBy(b => b.Title); //.Select(b => b.Title);

            return cheapBooks.ToList();
        }
    }
}