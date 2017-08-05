using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Movie.Models
{
    [Table("Seats")]
    public class Seat
    {
       
        public int Id { get; set; }

        public string Category { get; set; }

        public int MovieId { get; set; }

        public int IsBooked { get; set; }

        public int RowId { get; set; }

        public int SeatNumber { get; set; }

    }
}