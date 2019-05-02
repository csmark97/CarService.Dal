using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Dal.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Vin { get; set; }
        public string LicensePlateNumber { get; set; }
        public int YearOfManufacture { get; set; }
        public int Km { get; set; }
        public DateTime TechnicalValidity { get; set; }
        public string Picture { get; set; } //maybe byte
        public string ClientUserId { get; set; }
        public virtual ClientUser ClientUser { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}
