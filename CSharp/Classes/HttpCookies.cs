using System;
using System.Collections.Generic;

namespace CSharp.Classes
{
    public class HttpCookies
    {
        /* Has key-value*/
        private readonly Dictionary<string, string> _dict;
        public DateTime Expiry { get; set; }

        public HttpCookies()
        {
            _dict = new Dictionary<string, string>();
        }
        /* Indexers */
        public string this[string key]
        {
            get { return _dict[key]; }

            set { _dict[key] = value; }
        }

        /* A verbosis way of doing the same */
        public void SetItem(string key, string value) {
            _dict[key] = value;
        }

        public string GetItem(string key) {
            return _dict[key];
        }
    }
}