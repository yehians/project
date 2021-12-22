using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Table
    {
        public int id { get; set; }
        public string Table_name { get; set; }
        public int Char_number { get; set; }
        public bool Avilibality { get; set; }
        public virtual Roooms Roooms { get; set; }


    }
}