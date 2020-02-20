using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Ports.Dto
{
    public class Teacher
    {
        public Guid TeacherId { get; set; }
        public string TeacherName { get; set; }
        public List<Timeslot> Timeslots { get; set; }
        public List<TeacherCalendar> TeacherCalendars { get; set; }
        public List<Hold> Holds { get; set; }


    }
}
