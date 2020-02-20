using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Infrastructure.Mvc.ViewModel
{
    public class Calendar
    {
        public Guid CalendarId { get; set; }
        public string Description { get; set; }
        public List<Timeslot> Timeslots { get; set; }
        public List<Hold> Holds { get; set; }
        public List<TeacherCalendar> TeacherCalendars { get; set; }



    }
}
