using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class MovieViewModel
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public Guid Id { get; set; }
    }
}
