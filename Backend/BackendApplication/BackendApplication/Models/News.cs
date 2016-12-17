using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackendApplication.Models
{
    public class News
    {
        public int Id { get; set; }
        public String Titel { get; set; }
        public String description { get; set; }
        public String stad { get; set; }
    }
}