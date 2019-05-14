using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string ClientUserId { get; set; }
        public virtual ClientUser ClientUser { get; set; }
        public virtual ICollection<Service> Services { get; set; }

        //File properties
        public string Picture { get; set; }

        [Display(Name = "Public Schedule Size (bytes)")]
        [DisplayFormat(DataFormatString = "{0:N1}")]
        public long PictureSize { get; set; }

        [Display(Name = "Uploaded (UTC)")]
        [DisplayFormat(DataFormatString = "{0:F}")]
        public DateTime PictureUploadDT { get; set; }
    }
}
