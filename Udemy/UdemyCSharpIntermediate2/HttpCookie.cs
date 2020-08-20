using System;
using System.Collections.Generic;

namespace UdemyCSharpIntermediate2
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public void SetItem(string key, string value)
        {
            _dictionary[key] = value;
        }

        public string GetItem(string key)
        {
            return _dictionary[key];
        }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value;  }
        }
    }
}
