using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rest1.Models
{
    public class product
    {
        public string id { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public int department { get; set; }
        public List<department> departments { get; set; }
    }
}
