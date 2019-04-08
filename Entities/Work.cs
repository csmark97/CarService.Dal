using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Dal.Entities
{
    public class Work
    {
        public int Id { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Price { get; set; }
        public string OwnerDescription { get; set; }
        public string CompanyDescription { get; set; }
        public int TaskId { get; set; }
        public Task Task { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
