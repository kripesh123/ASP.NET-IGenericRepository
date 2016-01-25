using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kripesh.MVC.Application.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Item { get; set; }
        public string Details { get; set; }
        public bool Status { get; set; }
    }
}