using System.Collections.Generic;

namespace CarService.Dal.Entities
{
    public class ClientUser : User
    {
        public virtual ICollection<Car> Cars { get; set; }
    }
}