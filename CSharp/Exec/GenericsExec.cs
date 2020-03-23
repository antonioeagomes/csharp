using System;
using CSharp.Generics;

namespace CSharp.Exec
{
    public class GenericsExec : IExecutable
    {
        public void Execute()
        {
            var book = new Book { ISBN = "123", Title = "C#", Price = 50.29f };
            var books = new GenericList<Book>();
            books.Add(book);
            books.Add(new Book());
            var dictionary  = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());

            var number = new Generics.Nullable<int>();
            Console.WriteLine($"Has value ? {number.HasValue}");
            Console.WriteLine($"Value: {number.GetValueOrDefault()}");

        }
    }
}