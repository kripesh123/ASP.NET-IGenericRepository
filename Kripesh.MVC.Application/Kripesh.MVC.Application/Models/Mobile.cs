using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kripesh.MVC.Application.Models
{
    public class Mobile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Processor { get; set; }
        public string ScreenSize { get; set; }
        public bool Available { get; set; }
    }
}