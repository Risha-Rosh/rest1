using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rest1.Models
{
    public class department
    {
        public int id { get; set; }
        public string name { get; set; }
        public string curator { get; set; }
        public List<product> products { get; set; }
    }
}
