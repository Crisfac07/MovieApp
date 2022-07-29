using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class MovieViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Genre { get; set; }
        public Guid Id { get; set; }
    }
}
