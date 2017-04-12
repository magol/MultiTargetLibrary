using System;

namespace Foo.Library
{
    public class MyLibrary
    {
        public static string Format(FormattableString formattable) => formattable.ToString();

        public static void PrintLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
