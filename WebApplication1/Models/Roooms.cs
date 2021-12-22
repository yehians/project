using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Roooms
    {
        public int id { get; set; }
        public int Room_id { get; set; }
        public bool place_in { get; set; }
    }
}