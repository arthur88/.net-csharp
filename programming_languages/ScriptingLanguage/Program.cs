using System;
using System.Collections.Generic;

namespace ScriptingLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var keywords = new Dictionary<string, Action>
            {
                ["hello"] = () =>
                {
                    Console.WriteLine("Hello was invoked");
                },
                ["world"] = () =>
                {
                    Console.WriteLine("|world was invoked");
                }
            };

            string code = "hello world";
            var tokens = code.Split(' ');

            foreach(var token in tokens)
            {
                keywords[token]();
            }
        }
    }
}
