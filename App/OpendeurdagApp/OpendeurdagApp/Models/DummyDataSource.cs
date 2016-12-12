using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpendeurdagApp.Models
{
    public static class DummyDataSource
    {
        public static List<News> News { get; set; } = new List<News>()
        {
            new News() {Title="Aankoop Hololens",Description="Er is eindelijk beslist om een hololens aan te kopen."}
            
    };
}
}
