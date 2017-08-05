using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Movie.Models
{
    [Table("Movie")]
    public class Movie
    {
        
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }

        public decimal  Seats { get; set; }

        public DateTime Date { get; set; }
    }
}