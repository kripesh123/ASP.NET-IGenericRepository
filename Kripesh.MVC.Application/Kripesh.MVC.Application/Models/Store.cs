using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kripesh.MVC.Application.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Capacity { get; set; }
        public int Employee { get; set; }
        public bool Status { get; set; }
    }
}