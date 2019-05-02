using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Dal.Entities
{
    public class OpeningDay
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public OpeningDay(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }
    }
}
