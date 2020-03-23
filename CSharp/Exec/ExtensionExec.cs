using System;
using CSharp.ExtensionMethods;

namespace CSharp.Exec
{
    public class ExtensionExec : IExecutable
    {
        public void Execute()
        {
            var post = new Post();
            post.CreatePost("A post long and extense with lot of words, verbs, phrases and no punctuation!");
            Console.WriteLine(post.GetPost());
            Console.WriteLine(post.ShowPostResume());
        }
    }
}