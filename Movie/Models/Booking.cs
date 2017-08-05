using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Movie.Models
{
    [Table("Booking")]
    public class Booking
    {
        public int Id { get; set; }
        public int SeatId { get; set; }

        public int CustomerId { get; set; }

        public int NumberOfSeats { get; set; }
    }
}