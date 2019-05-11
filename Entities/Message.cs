using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Dal.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public string SenderId { get; set; }
        public virtual User Sender { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
        public int WorkId { get; set; }
        public virtual Work Work { get; set; }
    }
}
