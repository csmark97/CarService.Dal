using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Dal.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime EndTime { get; set; }
        public int TotalPrice { get; set; }
        public string Invoice { get; set; }
        public int CarId { get; set; }
        public virtual Car Car { get; set; }
        public virtual ICollection<Work> Works { get; set; }
    }
}
