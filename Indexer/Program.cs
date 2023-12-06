using System;
using System.Collections.Generic;

namespace Indexer
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expire { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        // Define the indexer inside the class.
        public string this[string key]
        {
            get
            {
                return _dictionary[key];
            }
            set
            {
                _dictionary[key] = value;
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Giovanni";

            Console.WriteLine(cookie["name"]);
        }
    }
}
