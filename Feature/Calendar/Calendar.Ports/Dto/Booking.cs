using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Ports.Dto
{
    public class Booking
    {
        public Guid BookingId { get; set; }
        public DateTime BookingStartDateTime { get; set; }
        public DateTime BookingEndDateTime { get; set; }
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        public Guid TimeslotId { get; set; }
        public Timeslot Timeslot { get; set; }
    }
}
