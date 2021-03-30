using System;
using System.Collections.Generic;
using System.Text;
namespace OOAD_17
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new TextAppender();
            text.Append("Asif").Append("Abdullah");
            var str = text.GetFullText();
            Console.WriteLine(str);
        }
    }
}
