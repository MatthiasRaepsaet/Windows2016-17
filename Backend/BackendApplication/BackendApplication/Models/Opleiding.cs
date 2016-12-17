using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackendApplication.Models
{
    public class Opleiding
    {
        public int Id { get; set; }
        public String naam { get; set; }
        public String omschrijving { get; set; }
        public String ImgUrl { get; set; }
    }
}