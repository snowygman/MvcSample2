using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcSample2.Models
{
    public class Music
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Artist { get; set; }
        public decimal Size { get; set; }
    }
}