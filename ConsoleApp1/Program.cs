using Nustache.Core;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var obj = new
            {
                Items = new List<object>
                {
                    new {Name = "hello1", Enabled = false },
                    new {Name = "hello2", Enabled = true }
                },
                Name = "123",
                Description="desc"
            };
            var html = Render.StringToString("{{name}} {{description}} {{#items}} {{#enabled}} {{name}} {{/enabled}} {{/items}}", obj);
            Console.WriteLine(html);
            Console.Read();
        }
    }
}
