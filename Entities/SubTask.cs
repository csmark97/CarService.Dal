﻿using System.Collections.Generic;

namespace CarService.Dal.Entities
{
    public class SubTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EstimatedPrice { get; set; }
        public int EstimtedTime { get; set; }
        public ICollection<Work> Works { get; set; }
        public string Picture { get; set; }
        public string CompanyId { get; set; }
        public CompanyUser Company { get; set; }
    }
}