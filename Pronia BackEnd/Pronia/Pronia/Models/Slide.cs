using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia.Models
{
    public class Slide
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Precent { get; set; }
        public string Title { get; set; }
        public string Context { get; set; }
    }
}
