using System.Collections.Generic;

namespace CarService.Dal.Entities
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Work> Works { get; set; }
    }
}