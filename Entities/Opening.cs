using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Dal.Entities
{
    public class Opening
    {       
        public int Id { get; set; }
        public virtual OpeningDay Monday { get; set; }
        public virtual OpeningDay Tuesday { get; set; }
        public virtual OpeningDay Wednesday { get; set; }
        public virtual OpeningDay Thursday { get; set; }
        public virtual OpeningDay Friday { get; set; }
        public virtual OpeningDay Saturday { get; set; }
        public virtual OpeningDay Sunday { get; set; }        

        public bool SaturdayOpen { get; set; }
        public bool SundayOpen{ get; set; }

        public virtual CompanyUser CompanyUser { get; set; }
    }
}
