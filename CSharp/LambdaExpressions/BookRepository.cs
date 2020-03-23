using System.Collections.Generic;
using CSharp.Generics;

namespace CSharp.LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks(){
            return new List<Book>{
                new Book { Title = "C++", Price=70 },
                new Book { Title = "Java", Price=75.10f },
                new Book { Title = "C#", Price=80.15f },
                new Book { Title = "Javascript", Price=65.70f }
            };
        }
    }
}