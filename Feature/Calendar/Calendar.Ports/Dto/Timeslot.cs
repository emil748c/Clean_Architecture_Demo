using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Ports.Dto
{
    public class Timeslot
    {
        public Guid TimeslotId { get; set; }
        public DateTime TimeslotStartDateTime { get; set; }
        public DateTime TimeslotEndDateTime { get; set; }
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public Guid CalendarId { get; set; }
        public Calendar Calendar { get; set; }
        public List<Booking> Bookings { get; set; }

    }
}
