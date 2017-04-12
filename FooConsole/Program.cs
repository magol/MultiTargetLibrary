using System;
using Foo.Library;

namespace FooConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string hello = "Hello";
            const string world = "World";

            string text = MyLibrary.Format($"{hello} {world}!");
            MyLibrary.PrintLine(text);

            Console.ReadKey();
        }
    }
}