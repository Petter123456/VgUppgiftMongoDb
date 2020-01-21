using System;
using System.Collections.Generic;
using System.Text;

namespace VgUppgiftMongoDb
{
    internal class Restaurants
    {
        public string id { get; set; }
        public string name { get; set; }
        public int stars { get; set; }
        public IEnumerable<string> categories { get; set; }
    }
}
