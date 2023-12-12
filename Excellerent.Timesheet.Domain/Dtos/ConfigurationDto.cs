﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Timesheet.Domain.Dtos
{
    public class ConfigurationDto
    {
        public List<StartOfWeek> StartOfWeeks { get; set; }
        public List<string> WorkingDays { get; set; }
        public WorkingHours WorkingHours { get; set; }
    }

    public class WorkingHours 
    { 
        public int Min { get; set; }
        public int Max { get; set; }
    }

    public class StartOfWeek 
    {
        public DayOfWeek DayOfWeek { get; set; }
        public DateTime EffectiveDate { get; set; }
    }
}
