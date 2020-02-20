using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Ports.Dto
{
    public class Student
    {
        public Guid StudentId { get; set; }
        public string StudentName { get; set; }
        public List<Booking> Bookings { get; set; }
        public List<StudentHold> StudentHolds { get; set; }

    }
}
