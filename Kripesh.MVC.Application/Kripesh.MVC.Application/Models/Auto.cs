using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kripesh.MVC.Application.Models
{
    public class Auto
    {
        public int Id { get; set; }
        public string AutoName { get; set; }
        public string ModelNumber { get; set; }
        public string Price { get; set; }
        public bool Status { get; set; }
    }
}