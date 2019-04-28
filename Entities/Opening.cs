using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Dal.Entities
{
    public class Opening
    {
        private Opening opening;

        public Opening()
        {
        }

        public Opening(Opening opening)
        {
            this.opening = opening;
        }

        public int Id { get; set; }
        public DateTime StartMonday { get; set; }
        public DateTime StartTuesday { get; set; }
        public DateTime StartWednesday { get; set; }
        public DateTime StartThursday { get; set; }
        public DateTime StartFriday { get; set; }
        public DateTime? StartSaturday { get; set; }
        public DateTime? StartSunday { get; set; }

        public DateTime EndMonday { get; set; }
        public DateTime EndTuesday { get; set; }
        public DateTime EndWednesday { get; set; }
        public DateTime EndThursday { get; set; }
        public DateTime EndFriday { get; set; }
        public DateTime? EndSaturday { get; set; }
        public DateTime? EndSunday { get; set; }

        public bool SaturdayOpen { get; set; }
        public bool SundayOpen{ get; set; }

        public CompanyUser CompanyUser { get; set; }
    }
}
