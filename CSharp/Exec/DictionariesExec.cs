using System;
using CSharp.Classes;

namespace CSharp.Exec
{
    public class DictionariesExec: IExecutable
    {
        public void Execute()
        {
            var cookie = new HttpCookies();
            cookie["name"] = "Mosh";

            Console.WriteLine(cookie["name"]);
            
        }
        
    }
}