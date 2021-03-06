﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Infrastructure.Mvc.ViewModel
{
    public class Hold
    {
        public Guid HoldId { get; set; }
        public string HoldName { get; set; }

        public List<StudentHold> StudentHolds { get; set; }

        public Guid CalendarId { get; set; }
        public Calendar Calendar { get; set; }
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }

    }
}
