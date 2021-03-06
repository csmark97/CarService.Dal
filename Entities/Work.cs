﻿using System;
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
        //public string OwnerDescription { get; set; }
        //public string CompanyDescription { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public int SubTaskId { get; set; }
        public virtual SubTask SubTask { get; set; }
        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }
        public int StateId { get; set; }
        public virtual State State { get; set; }
        public string WorkerUserId { get; set; }
        public virtual WorkerUser WorkerUser { get; set; }
    }
}
