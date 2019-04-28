using System.Collections.Generic;

namespace CarService.Dal.Entities
{
    public class ClientUser : User
    {
        public ICollection<Car> Cars { get; set; }
    }
}