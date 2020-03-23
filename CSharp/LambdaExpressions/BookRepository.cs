using System.Collections.Generic;
using CSharp.Generics;

namespace CSharp.LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>{
                new Book { Title = "C++", Price = 70 },
                new Book { Title = "Java", Price = 75.10f },
                new Book { Title = "C#", Price = 80.15f },
                new Book { Title = "Javascript", Price = 65.70f },
                new Book { Title = "Python", Price = 120.18f },
                new Book { Title = "Visual Basic", Price = 5.50f },
                new Book { Title = "Delphi", Price = 18.15f },
                new Book { Title = "Ruby on Rails", Price = 6.70f }
            };
        }
    }
}